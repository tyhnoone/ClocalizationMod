
using ReLogic.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
using System;
using Terraria.ID;
using System.Linq;
using Terraria.UI.Chat;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.GameInput;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework.Audio;
using Newtonsoft.Json;
using Steamworks;
using Terraria.GameContent.UI;
using Terraria.ModLoader.Audio;
using Terraria.ModLoader.Default;
using Terraria.ModLoader.Exceptions;
using Terraria.ModLoader.IO;
using Terraria.ModLoader.UI;
using ZZLocalizationMod.Interface;
using ZZLocalizationMod.NPCs;


namespace ZZLocalizationMod.Interface
{
	class ZZBuffInfo : UIState
	{
		public UIPanel ZZBuffInfoUI;

		public UIBuffnfoDisplay BuffInfo;

		public static bool visible = false;

		public override void OnInitialize()
		{
			ZZBuffInfoUI = new UIPanel();
			ZZBuffInfoUI.SetPadding(0);
			ZZBuffInfoUI.Left.Set(345f, 0f);
			ZZBuffInfoUI.Top.Set(335f, 0f);
			ZZBuffInfoUI.Width.Set(260f, 0f);
			ZZBuffInfoUI.Height.Set(440f, 0f);
			ZZBuffInfoUI.BackgroundColor = new Color(73, 94, 171, 200);

			ZZBuffInfoUI.OnMouseDown += new UIElement.MouseEvent(DragStart);
			ZZBuffInfoUI.OnMouseUp += new UIElement.MouseEvent(DragEnd);

			BuffInfo = new UIBuffnfoDisplay();
			BuffInfo.Left.Set(20, 0f);
			BuffInfo.Top.Set(45, 0f);
			BuffInfo.Width.Set(200f, 0f);
			BuffInfo.Height.Set(22, 0f);
			ZZBuffInfoUI.Append(BuffInfo);

			Mod mod = ZZLocalizationMod.Instance;
			Texture2D buttonPlayTexture = ModContent.GetTexture("Terraria/UI/ButtonPlay");			
			Texture2D buttonBackTexture = mod.GetTexture("Interface/ButtonBack");

			UIImageButton playButton = new UIImageButton(buttonPlayTexture);
			playButton.Left.Set(220, 0f);
			playButton.Top.Set(410, 0f);
			playButton.Width.Set(22, 0f);
			playButton.Height.Set(22, 0f);
			playButton.OnClick += new MouseEvent(PlayButtonClicked1);
			ZZBuffInfoUI.Append(playButton);

			UIImageButton playButton2 = new UIImageButton(buttonBackTexture);
			playButton2.Left.Set(190, 0f);
			playButton2.Top.Set(410, 0f);
			playButton2.Width.Set(22, 0f);
			playButton2.Height.Set(22, 0f);
			playButton2.OnClick += new MouseEvent(PlayButtonClicked2);
			ZZBuffInfoUI.Append(playButton2);
			
			Texture2D buttonDeleteTexture = ModContent.GetTexture("Terraria/UI/ButtonDelete");
			UIImageButton closeButton = new UIImageButton(buttonDeleteTexture);
			closeButton.Left.Set(220, 0f);
			closeButton.Top.Set(10, 0f);
			closeButton.Width.Set(22, 0f);
			closeButton.Height.Set(22, 0f);
			closeButton.OnClick += new MouseEvent(CloseButtonClicked);
			ZZBuffInfoUI.Append(closeButton);

			base.Append(ZZBuffInfoUI);
		}
		private void PlayButtonClicked1(UIMouseEvent evt, UIElement listeningElement)
		{
			BuffInfo.k ++;
		}

		private void PlayButtonClicked2(UIMouseEvent evt, UIElement listeningElement)
		{
			BuffInfo.k --;
		}

		private void CloseButtonClicked(UIMouseEvent evt, UIElement listeningElement)
		{
			Main.PlaySound(SoundID.MenuOpen);
			visible = false;
		}

		Vector2 offset;
		public bool dragging = false;
		private void DragStart(UIMouseEvent evt, UIElement listeningElement)
		{
			offset = new Vector2(evt.MousePosition.X - ZZBuffInfoUI.Left.Pixels, evt.MousePosition.Y - ZZBuffInfoUI.Top.Pixels);
			dragging = true;
		}

		private void DragEnd(UIMouseEvent evt, UIElement listeningElement)
		{
			Vector2 end = evt.MousePosition;
			dragging = false;

			ZZBuffInfoUI.Left.Set(end.X - offset.X, 0f);
			ZZBuffInfoUI.Top.Set(end.Y - offset.Y, 0f);

			Recalculate();
		}

		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			Vector2 MousePosition = new Vector2((float)Main.mouseX, (float)Main.mouseY);
			if (ZZBuffInfoUI.ContainsPoint(MousePosition))
			{
				Main.LocalPlayer.mouseInterface = true;
			}
			if (dragging)
			{
				ZZBuffInfoUI.Left.Set(MousePosition.X - offset.X, 0f);
				ZZBuffInfoUI.Top.Set(MousePosition.Y - offset.Y, 0f);
				Recalculate();
			}
			
		}
		public TextSnippet hoveredTextSnippet;
		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);

			// now we can draw after all other drawing.
			if (hoveredTextSnippet != null)
			{
				hoveredTextSnippet.OnHover();
				if (Main.mouseLeft && Main.mouseLeftRelease)
				{
					hoveredTextSnippet.OnClick();
				}
				hoveredTextSnippet = null;
			}
		}

		public void UpdateValue(Player player) 
		{
			BuffInfo.player = player;
		}
		
	}
		public class UIBuffnfoDisplay : UIElement
		{
			public int k = 1;
			public int R;
			public Player player = new Player();
			public UIBuffnfoDisplay() 
			{
				Width.Set(100, 0f);
				Height.Set(40, 0f);
			}

			private void MouseText_DrawBuffString(ref int X, ref int Y, int buffNameHeight)
			{
				Microsoft.Xna.Framework.Point p = new Microsoft.Xna.Framework.Point(X, Y);
				int num = 220;
				int num2 = -1;
				float num3 = 1f / Main.UIScale;
				List<Vector2> list = new List<Vector2>();
				Vector2 vector = Main.fontMouseText.MeasureString(Main.buffString);
				list.Add(vector);
				int num4 = (int)((float)(Main.screenHeight - 250) * num3) / 20;
				if (num4 < 1)
				{
					num4 = 1;
				}
				if (Main.bannerMouseOver)
				{
					int num5 = 0;
					for (int i = 0; i < NPCLoader.NPCCount; i++)
					{
						if (Item.BannerToNPC(i) != 0 && Main.player[Main.myPlayer].NPCBannerBuff[i])
						{
							num5++;
							string npcnameValue = Lang.GetNPCNameValue(Item.BannerToNPC(i));
							Vector2 vector2 = Main.fontMouseText.MeasureString(npcnameValue);
							int num6 = X;
							int num7 = Y + (int)vector2.Y + num5 * 20 + 10;
							int num8 = 0;
							int num9 = (num5 - 1) / num4;
							for (int j = 0; j < num9; j++)
							{
								num8++;
								num6 += num;
								num7 -= num4 * 20;
							}
							if ((float)num6 + vector2.X > (float)Main.screenWidth * num3 && num2 == -1)
							{
								num2 = num5;
							}
							list.Add(new Vector2((float)(num6 - num * num8), (float)num7) + vector2 - p.ToVector2());
						}
					}
				}
				BuffLoader.CustomBuffTipSize(Main.buffString, list);
				Vector2 zero = Vector2.Zero;
				foreach (Vector2 vector3 in list)
				{
					if (zero.X < vector3.X)
					{
						zero.X = vector3.X;
					}
					if (zero.Y < vector3.Y)
					{
						zero.Y = vector3.Y;
					}
				}
				if ((float)X + zero.X + 24f > (float)Main.screenWidth * num3)
				{
					X = (int)((float)Main.screenWidth * num3 - zero.X - 24f);
				}
				if ((float)Y + zero.Y + 4f > (float)Main.screenHeight * num3)
				{
					Y = (int)((float)Main.screenHeight * num3 - zero.Y - 4f);
				}
				if (num2 != -1)
				{
					num2--;
				}
				for (int k = 0; k < 5; k++)
				{
					int num10 = X;
					int num11 = Y + buffNameHeight;
					Microsoft.Xna.Framework.Color black = Microsoft.Xna.Framework.Color.Black;
					if (k == 0)
					{
						num10 -= 2;
					}
					else if (k == 1)
					{
						num10 += 2;
					}
					else if (k == 2)
					{
						num11 -= 2;
					}
					else if (k == 3)
					{
						num11 += 2;
					}
					else
					{
						black = new Microsoft.Xna.Framework.Color((int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor);
					}
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, Main.buffString, new Vector2((float)num10, (float)num11), black, 0f, default(Vector2), 1f, SpriteEffects.None, 0f);
				}
				if (Main.bannerMouseOver)
				{
					int num12 = 0;
					for (int l = 0; l < NPCLoader.NPCCount; l++)
					{
						if (Item.BannerToNPC(l) != 0 && Main.player[Main.myPlayer].NPCBannerBuff[l])
						{
							num12++;
							bool flag = false;
							for (int m = 0; m < 5; m++)
							{
								int num13 = X;
								int num14 = Y + (int)vector.Y + num12 * 20 + 10;
								int num15 = (num12 - 1) / num4;
								num13 += num * num15;
								num14 -= num4 * 20 * num15;
								string text = Lang.GetNPCNameValue(Item.BannerToNPC(l));
								if (num2 == num12)
								{
									text = Language.GetTextValue("UI.Ellipsis");
									flag = true;
								}
								Microsoft.Xna.Framework.Color black2 = Microsoft.Xna.Framework.Color.Black;
								if (m == 0)
								{
									num13 -= 2;
								}
								else if (m == 1)
								{
									num13 += 2;
								}
								else if (m == 2)
								{
									num14 -= 2;
								}
								else if (m == 3)
								{
									num14 += 2;
								}
								else
								{
									float num16 = (float)Main.mouseTextColor / 255f;
									black2 = new Microsoft.Xna.Framework.Color((int)((byte)(80f * num16)), (int)((byte)(255f * num16)), (int)((byte)(120f * num16)), (int)Main.mouseTextColor);
								}
								DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, text, new Vector2((float)num13, (float)num14), black2, 0f, default(Vector2), 1f, SpriteEffects.None, 0f);
							}
							if (flag)
							{
								return;
							}
						}
					}
				}
				BuffLoader.DrawCustomBuffTip(Main.buffString, Main.spriteBatch, X, Y + (int)Main.fontMouseText.MeasureString(Main.buffString).Y);
			}

			public void MouseText(string cursorText, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1)
			{
				if (cursorText == null)
				{
					return;
				}
				int num = Main.mouseX + 10;
				int num2 = Main.mouseY + 10;
				if (hackedMouseX != -1 && hackedMouseY != -1)
				{
					num = hackedMouseX + 10;
					num2 = hackedMouseY + 10;
				}
				if (Main.ThickMouse)
				{
					num += 6;
					num2 += 6;
				}
				new Microsoft.Xna.Framework.Color((int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor);
				Vector2 vector = Main.fontMouseText.MeasureString(cursorText);
				if (Main.buffString != "" && Main.buffString != null)
				{
					this.MouseText_DrawBuffString(ref num, ref num2, (int)vector.Y);
				}
				if (hackedScreenHeight != -1 && hackedScreenWidth != -1)
				{
					if ((float)num + vector.X + 4f > (float)hackedScreenWidth)
					{
						num = (int)((float)hackedScreenWidth - vector.X - 4f);
					}
					if ((float)num2 + vector.Y + 4f > (float)hackedScreenHeight)
					{
						num2 = (int)((float)hackedScreenHeight - vector.Y - 4f);
					}
				}
				else
				{
					if ((float)num + vector.X + 4f > (float)Main.screenWidth)
					{
						num = (int)((float)Main.screenWidth - vector.X - 4f);
					}
					if ((float)num2 + vector.Y + 4f > (float)Main.screenHeight)
					{
						num2 = (int)((float)Main.screenHeight - vector.Y - 4f);
					}
				}
				float num3 = (float)Main.mouseTextColor / 255f;
				Microsoft.Xna.Framework.Color baseColor = new Microsoft.Xna.Framework.Color((int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor);
				if (rare == -11)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(255f * num3)), (int)((byte)(175f * num3)), (int)((byte)(0f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == -10)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(65f * num3)), (int)((byte)(255f * num3)), (int)((byte)(110f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == -1)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(130f * num3)), (int)((byte)(130f * num3)), (int)((byte)(130f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 1)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(150f * num3)), (int)((byte)(150f * num3)), (int)((byte)(255f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 2)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(150f * num3)), (int)((byte)(255f * num3)), (int)((byte)(150f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 3)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(255f * num3)), (int)((byte)(200f * num3)), (int)((byte)(150f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 4)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(255f * num3)), (int)((byte)(150f * num3)), (int)((byte)(150f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 5)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(255f * num3)), (int)((byte)(150f * num3)), (int)((byte)(255f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 6)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(210f * num3)), (int)((byte)(160f * num3)), (int)((byte)(255f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 7)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(150f * num3)), (int)((byte)(255f * num3)), (int)((byte)(10f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 8)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(255f * num3)), (int)((byte)(255f * num3)), (int)((byte)(10f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 9)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(5f * num3)), (int)((byte)(200f * num3)), (int)((byte)(255f * num3)), (int)Main.mouseTextColor);
				}
				if (rare == 10)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(255f * num3)), (int)((byte)(40f * num3)), (int)((byte)(100f * num3)), (int)Main.mouseTextColor);
				}
				if (rare >= 11)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)(180f * num3)), (int)((byte)(40f * num3)), (int)((byte)(255f * num3)), (int)Main.mouseTextColor);
				}
				if (Main.HoverItem.expert || rare == -12)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)((float)Main.DiscoR * num3)), (int)((byte)((float)Main.DiscoG * num3)), (int)((byte)((float)Main.DiscoB * num3)), (int)Main.mouseTextColor);
				}
				if (diff == 1)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)((float)Main.mcColor.R * num3)), (int)((byte)((float)Main.mcColor.G * num3)), (int)((byte)((float)Main.mcColor.B * num3)), (int)Main.mouseTextColor);
				}
				if (diff == 2)
				{
					baseColor = new Microsoft.Xna.Framework.Color((int)((byte)((float)Main.hcColor.R * num3)), (int)((byte)((float)Main.hcColor.G * num3)), (int)((byte)((float)Main.hcColor.B * num3)), (int)Main.mouseTextColor);
				}
				ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, Main.fontMouseText, cursorText, new Vector2((float)num, (float)num2), baseColor, 0f, Vector2.Zero, Vector2.One, -1f, 2f);
			}

			public void MouseTextHackZoom(string text, int itemRarity, byte diff = 0)
			{
				Main.spriteBatch.End();
				Main.spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, Main.UIScaleMatrix);
				PlayerInput.SetZoom_UI();
				int hackedScreenWidth = Main.screenWidth;
				int hackedScreenHeight = Main.screenHeight;
				int hackedMouseX = Main.mouseX;
				int hackedMouseY = Main.mouseY;
				PlayerInput.SetZoom_UI();
				PlayerInput.SetZoom_Test();
				this.MouseText(text, itemRarity, 0, hackedMouseX, hackedMouseY, hackedScreenWidth, hackedScreenHeight);
			}

			private static Matrix _uiScaleMatrix;


			protected override void DrawSelf(SpriteBatch spriteBatch) 
			{
				CalculatedStyle innerDimensions = GetInnerDimensions();	
			//Vector2 drawPos = new Vector2(innerDimensions.X + 5f, innerDimensions.Y + 30f);

				float shopx = innerDimensions.X;
				float shopy = innerDimensions.Y;

				int count = 0;
				
				string text = "你当前免疫：";
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, text, new Vector2(shopx , shopy - 30), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);

				List<int> bufftype = new List<int>();

				int q = 0;
				
				for(int i=0 ; i < Main.debuff.Length ; i++)
				{
					if(player.buffImmune[i])
					{
						if(count < k*10 && count >= (k-1)*10)
						{
							spriteBatch.Draw(Main.buffTexture[i], new Vector2(shopx, shopy + q*35), new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(0, 0, Main.buffTexture[i].Width, Main.buffTexture[i].Height)), Color.White, 0f, default(Vector2), 1f, SpriteEffects.None, 0f);
							DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, Lang.GetBuffName(i), new Vector2(shopx + 35 , shopy + 5 + q*35), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
							bufftype.Add(i);
							q++;
						}
						count ++;
					}
				}

				if(player.noKnockback && count < k*10 && count >= (k-1)*10)
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "击退", new Vector2(shopx , shopy + 10 + q*35), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					q++;
					count ++;
				}
				if(player.noFallDmg && count < k*10 && count >= (k-1)*10)
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "坠落伤害", new Vector2(shopx , shopy + 10 + q*35), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					q++;
					count ++;
				}
				if(player.fireWalk && count < k*10 && count >= (k-1)*10)
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "火块烫伤", new Vector2(shopx , shopy + 10 + q*35), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					q++;
					count ++;
				}
				if(player.lavaImmune && count < k*10 && count >= (k-1)*10)
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "岩浆灼伤", new Vector2(shopx , shopy + 10 + q*35), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					q++;
					count ++;
				}

				
				R = (count)/10 + 1;

				if(k>R) k = 1;
				if(k<1) k = R;
					

				int p = 0;
				foreach(int type in bufftype)
				{
					if(type == 0) 
					{
						break;
					}
					if (Main.mouseX < (shopx + Main.buffTexture[type].Width) && Main.mouseY < (shopy + p*35 + Main.buffTexture[type].Height) && Main.mouseX > shopx && Main.mouseY > shopy + p*35)
					{
						int itemRarity = 0;
						Main.buffString = Lang.GetBuffDescription(type);
						this.MouseTextHackZoom(Lang.GetBuffName(type), itemRarity, 0);
					}
					p++;
				}
				
			}
				
		}
}

		