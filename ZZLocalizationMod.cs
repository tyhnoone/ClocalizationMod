using Microsoft.Xna.Framework;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;
using Terraria.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using ZZLocalizationMod.Items;

namespace ZZLocalizationMod
{
	public class ZZLocalizationMod : Mod
	{
		public ZZLocalizationMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
			};	
			instance = this;
		}

		public static Mod Instance;
		internal static ZZLocalizationMod instance;

		internal static ModConfiguration modConfiguration;

		public override void Unload() {
			LootCache.instance = null;
			modConfiguration = null;
		}

		public override void PostAddRecipes()
		{
			if (!Main.dedServ)
			{
				LootCacheManager.Setup(this);
			}
		}

		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers) 
		{

			int inventoryIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Info Accessories Bar"));
			if (inventoryIndex != -1) {
				layers.Insert(inventoryIndex, new LegacyGameInterfaceLayer(
					"ZZLocalizationMod: Info Accessories Bar2",
					delegate {
						// If the current UIState of the UserInterface is null, nothing will draw. We don't need to track a separate .visible value.
						DrawInterfaceInfoAccs();
						return true;
					},
					InterfaceScaleType.UI)
				);
			}
			
		}
		public Texture2D[] infoIconTexture = new Texture2D[14];

		private void DrawInterfaceInfoAccs()
		{
				bool flag7 = false;
				int num = -1;
				int num2 = -10;
				int num3 = 0;
				string text = "";
				float num4 = 215f;
				int num5 = 0;
				Player player = Main.player[Main.myPlayer];
				for (int i = 0; i < 8; i++)
				{
					string text2 = "";
					string text3 = "";
					if ((Main.npcChatText == null || Main.npcChatText == "") && Main.player[Main.myPlayer].sign < 0 && ZZLocalizationMod.modConfiguration.uitext)
					{
						if(i== (Main.playerInventory? 0:-1))
						{
							
							text2 = "每秒" + player.lifeRegen + "生命再生";
							text3 = "生命再生速度";
							
						}
						if(i== (Main.playerInventory? 1:-1))
						{
							
							text2 = "每秒" + player.manaRegen + "魔力再生";
							text3 = "魔力再生速度";
							
						}
						if(i== (Main.playerInventory? 2:-1))
						{
							
							text2 = player.wingTimeMax + "飞行时间";
							text3 = "飞行时间";
							
						}
						if(i== (Main.playerInventory? 3:-1))
						{
							
							text2 = "获得" + player.endurance*100 + "%伤害减免";
							text3 = "伤害减免";
						}
						if(i== (Main.playerInventory? 4:-1))
						{
							
							text2 = "召唤物栏已用/上限："+ player.slotsMinions + " / " + player.maxMinions;
							text3 = "召唤栏";
						}
						if(i== (Main.playerInventory? 5:-1))
						{
							
							text2 = "哨兵炮塔上限：" + player.maxTurrets;
							text3 = "炮塔栏";
						}
						if(i== (Main.playerInventory? 7:0) && !flag7)
						{
							int num15 = 4000;
							int num16 = 300;
							NPC npcaround = null;
							NPC npcaround2 = null;
							NPC npcaround3 = null;
							text3 = "敌人生命显示";
							for (int l = 0; l < 200; l++)
							{
								if (Main.npc[l].active && !Main.npc[l].townNPC && Main.npc[l].life < Main.npc[l].lifeMax)
								{
									NPC type = Main.npc[l];
									float distance = (Main.npc[l].Center - Main.player[Main.myPlayer].Center).Length();
									if (distance < (float)num15)
									{
										Player player3 = Main.player[Main.myPlayer];
										Player player4 = player3;
										
										if(npcaround != null)
										{
											if ((npcaround.Center - Main.player[Main.myPlayer].Center).Length() - distance > (float)num16)
											{
												npcaround = type;
											}
										}
										else
										{
											npcaround = type;
										}

										if (npcaround2 == null)
										{
											npcaround2 = type;
											npcaround3 = null;
										}
										else
										{
											npcaround3 = type;
										}

										if (npcaround == type)
										{
											npcaround2 = null;
										}
									}
								}
							}

							if (npcaround == null)
							{
							text2 = "";
							}
							else
							{
								text2 = npcaround.GivenOrTypeName + ": "+ npcaround.life + " / "+ npcaround.lifeMax;
							}
							if (npcaround2 != null)
							{
								text2 += "\n" + npcaround2.GivenOrTypeName + ": "+ npcaround2.life + " / "+ npcaround2.lifeMax;
							}
							if (npcaround3 != null)
							{
								text2 += "\n" + npcaround3.GivenOrTypeName + ": "+ npcaround3.life + " / "+ npcaround3.lifeMax;
							}
							flag7 = true ;
						}
						
					}
					if (text2 != "")
					{
						int num26;
						int num27;
						if (!Main.playerInventory)
						{
							num26 = Main.screenWidth - 520;
							num27 = -80;
						}
						else
						{
							bool shouldDrawInfoIconsHorizontally = Main.ShouldDrawInfoIconsHorizontally;
							if (shouldDrawInfoIconsHorizontally)
							{
								num26 = Main.screenWidth - 520 + 20 * num3 - 10;
								num27 = -80;
							}
							else
							{
								int num28 = (int)(52f * Main.inventoryScale);
								num26 = 697 - num28 * 4 + Main.screenWidth - 800 + 20 * (num3 % 2);
								num27 = 114 + num28 * 7 + num28 / 2 + 20 * (num3 / 2) + 8 * (num3 / 4) - 320;
								if (Main.EquipPage == 2)
								{
									num26 += num28 + num28 / 2;
									num27 -= num28;
								}
							}
						}
						num26 += num5;
						if (num >= 0)
						{
							num3++;
							int num29 = 22;
							if (Main.screenHeight < 650)
							{
								num29 = 20;
							}
							Vector2 vector = new Vector2((float)num26, (float)(num27 + 74 + num29 * i + 52) + 300);
							int num30 = num;
							if (num30 == 8)
							{
								num30 = 7;
							}
							Microsoft.Xna.Framework.Color white = Microsoft.Xna.Framework.Color.White;
							bool flag14 = false;
							if (!Main.playerInventory)
							{
								vector = new Vector2((float)num26, (float)num27);
								if ((float)Main.mouseX >= vector.X && (float)Main.mouseY >= vector.Y && (float)Main.mouseX <= vector.X + (float)this.infoIconTexture[num].Width && (float)Main.mouseY <= vector.Y + (float)this.infoIconTexture[num].Height)
								{
									flag14 = true;
									Main.player[Main.myPlayer].mouseInterface = true;
									if (Main.mouseLeft && Main.mouseLeftRelease)
									{
										Main.PlaySound(12, -1, -1, 1, 1f, 0f);
										Main.mouseLeftRelease = false;
										Main.player[Main.myPlayer].hideInfo[num30] = !Main.player[Main.myPlayer].hideInfo[num30];
									}
									if (!Main.mouseText)
									{
										text = text3;
										Main.mouseText = true;
									}
								}
								if (Main.player[Main.myPlayer].hideInfo[num30])
								{
									white = new Microsoft.Xna.Framework.Color(80, 80, 80, 70);
								}
							}
							else if ((float)Main.mouseX >= vector.X && (float)Main.mouseY >= vector.Y && (float)Main.mouseX <= vector.X + (float)this.infoIconTexture[num].Width && (float)Main.mouseY <= vector.Y + (float)this.infoIconTexture[num].Height && !Main.mouseText)
							{
								num2 = i;
								text = text3;
								Main.mouseText = true;
							}
							UILinkPointNavigator.SetPosition(1558 + num3 - 1, vector);
							Main.spriteBatch.Draw(this.infoIconTexture[num], vector, new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(0, 0, this.infoIconTexture[num].Width, this.infoIconTexture[num].Height)), white, 0f, default(Vector2), 1f, SpriteEffects.None, 0f);
							if (flag14)
							{
								Main.spriteBatch.Draw(this.infoIconTexture[13], vector - Vector2.One * 2f, null, Main.OurFavoriteColor, 0f, default(Vector2), 1f, SpriteEffects.None, 0f);
							}
							num26 += 20;
						}
						UILinkPointNavigator.Shortcuts.INFOACCCOUNT = num3;
						if (Main.playerInventory)
						{
							Vector2 vector2 = new Vector2(1f);
							Vector2 vector3 = Main.fontMouseText.MeasureString(text2);
							if (vector3.X > num4)
							{
								vector2.X = num4 / vector3.X;
							}
							if (vector2.X < 0.58f)
							{
								vector2.Y = 1f - vector2.X / 3f;
							}
							for (int num31 = 0; num31 < 5; num31++)
							{
								int num32 = 0;
								int num33 = 0;
								Microsoft.Xna.Framework.Color black = Microsoft.Xna.Framework.Color.Black;
								if (num31 == 0)
								{
									num32 = -2;
								}
								if (num31 == 1)
								{
									num32 = 2;
								}
								if (num31 == 2)
								{
									num33 = -2;
								}
								if (num31 == 3)
								{
									num33 = 2;
								}
								if (num31 == 4)
								{
									black = new Microsoft.Xna.Framework.Color((int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor);
								}
								if (i > num2 && i < num2 + 2)
								{
									black = new Microsoft.Xna.Framework.Color((int)(black.R / 3), (int)(black.G / 3), (int)(black.B / 3), (int)(black.A / 3));
								}
								int num34 = 22;
								if (Main.screenHeight < 650)
								{
									num34 = 20;
								}
								DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, text2, new Vector2((float)(num26 + num32), (float)(num27 + 74 + num34 * i + num33) + 100), black, 0f, default(Vector2), vector2, SpriteEffects.None, 0f);
							}
						}
						if (!Main.playerInventory)
						{
							Vector2 vector2 = new Vector2(1f);
							Vector2 vector3 = Main.fontMouseText.MeasureString(text2);
							if (vector3.X > num4)
							{
								vector2.X = num4 / vector3.X;
							}
							if (vector2.X < 0.58f)
							{
								vector2.Y = 1f - vector2.X / 3f;
							}
							for (int num31 = 0; num31 < 5; num31++)
							{
								int num32 = 0;
								int num33 = 0;
								Microsoft.Xna.Framework.Color black = Microsoft.Xna.Framework.Color.Black;
								if (num31 == 0)
								{
									num32 = -2;
								}
								if (num31 == 1)
								{
									num32 = 2;
								}
								if (num31 == 2)
								{
									num33 = -2;
								}
								if (num31 == 3)
								{
									num33 = 2;
								}
								if (num31 == 4)
								{
									black = new Microsoft.Xna.Framework.Color((int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor, (int)Main.mouseTextColor);
								}
								if (i > num2 && i < num2 + 2)
								{
									black = new Microsoft.Xna.Framework.Color((int)(black.R / 3), (int)(black.G / 3), (int)(black.B / 3), (int)(black.A / 3));
								}
								int num34 = 22;
								if (Main.screenHeight < 650)
								{
									num34 = 20;
								}
								DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, text2, new Vector2((float)(num26 + num32), (float)(num27 + 74 + num34 * i + num33) + 100), black, 0f, default(Vector2), vector2, SpriteEffects.None, 0f);
							}
						}
					}
				}
				
		}

	}
}