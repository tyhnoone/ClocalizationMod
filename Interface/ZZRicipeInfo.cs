/* 
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
using ZZLocalizationMod.UIElements;


namespace ZZLocalizationMod.Interface
{
	class ZZRicipeInfo : UIState
	{
		public UIPanel ZZRicipeInfoUI;

		public static bool visible = false;

		
		public UIRecipeInfoDisplay ItemRecipeInfo;
		public UIItemInfo ItemInfo;

		public float longth = 0;

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			
		}
		public override void OnInitialize()
		{
			ZZRicipeInfoUI = new UIPanel();
			ZZRicipeInfoUI.SetPadding(10);
			ZZRicipeInfoUI.Left.Set(325f, 0f);
			ZZRicipeInfoUI.Top.Set(275f, 0f);
			ZZRicipeInfoUI.Width.Set(30f + longth, 0f);
			ZZRicipeInfoUI.Height.Set(380f, 0f);
			ZZRicipeInfoUI.BackgroundColor = new Color(73, 94, 171, 200);

			ZZRicipeInfoUI.OnMouseDown += new UIElement.MouseEvent(DragStart);
			ZZRicipeInfoUI.OnMouseUp += new UIElement.MouseEvent(DragEnd);

			ItemInfo = new UIItemInfo();
			ItemInfo.Left.Set(25, 0f);
			ItemInfo.Top.Set(25, 0f);
			ItemInfo.Width.Set(500f, 0f);
			ItemInfo.Height.Set(250f, 0f);
			ZZRicipeInfoUI.Append(ItemInfo);

			ItemRecipeInfo = new UIRecipeInfoDisplay();
			ItemInfo.Left.Set(25, 0f);
			ItemInfo.Top.Set(25, 0f);
			ItemInfo.Width.Set(500f, 0f);
			ItemInfo.Height.Set(250f, 0f);
			ZZRicipeInfoUI.Append(ItemRecipeInfo);

			Mod mod = ZZLocalizationMod.Instance;

			Texture2D buttonDeleteTexture = ModContent.GetTexture("Terraria/UI/ButtonDelete");
			UIImageButton closeButton = new UIImageButton(buttonDeleteTexture);
			closeButton.Left.Set(950, 0f);
			closeButton.Top.Set(10, 0f);
			closeButton.Width.Set(22, 0f);
			closeButton.Height.Set(22, 0f);
			closeButton.OnClick += new MouseEvent(CloseButtonClicked);
			ZZRicipeInfoUI.Append(closeButton);

			
			base.Append(ZZRicipeInfoUI);
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
			offset = new Vector2(evt.MousePosition.X - ZZRicipeInfoUI.Left.Pixels, evt.MousePosition.Y - ZZRicipeInfoUI.Top.Pixels);
			dragging = true;
		}

		private void DragEnd(UIMouseEvent evt, UIElement listeningElement)
		{
			Vector2 end = evt.MousePosition;
			dragging = false;

			ZZRicipeInfoUI.Left.Set(end.X - offset.X, 0f);
			ZZRicipeInfoUI.Top.Set(end.Y - offset.Y, 0f);

			Recalculate();
		}
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			Vector2 MousePosition = new Vector2((float)Main.mouseX, (float)Main.mouseY);
			if (ZZRicipeInfoUI.ContainsPoint(MousePosition))
			{
				Main.LocalPlayer.mouseInterface = true;
			}
			if (dragging)
			{
				ZZRicipeInfoUI.Left.Set(MousePosition.X - offset.X, 0f);
				ZZRicipeInfoUI.Top.Set(MousePosition.Y - offset.Y, 0f);
				Recalculate();
			}
		}
		public void UpdateValue(Item item, Player player) 
		{
			ItemRecipeInfo.item = item;
			ItemRecipeInfo.player = player;
			
			ItemInfo.item2 = item;
			ItemInfo.player = player;
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

		internal static void OnScrollWheel_FixHotbarScroll(UIScrollWheelEvent evt, UIElement listeningElement)
		{
			Main.LocalPlayer.ScrollHotbar(Terraria.GameInput.PlayerInput.ScrollWheelDelta / 120);
		}

	}

		public class UIRecipeInfoDisplay : UIElement
		{
			public Item item = new Item();
			public Player player = new Player();
			public int longth = 0;

			public String text4 = "";

			public TextSnippet[] textSnippets;
			public UIRecipeInfoDisplay() 
			{
				Width.Set(100, 0f);
				Height.Set(40, 0f);
			}

			public UIPanel ZZRicipeInfoUI;

			public static Texture2D defaultBackgroundTexture = Main.inventoryBack9Texture;
			public Texture2D backgroundTexture = defaultBackgroundTexture;
			internal float scale = 1f;
			public int itemType;
			public bool hideSlot = false;

			public List<Item> Need = new List<Item>();

			public static Dictionary<Item,int> FindRecipe(Item item)
			{
				Recipe recipe = new Recipe();
				for(int i=0; i < Recipe.numRecipes ; i++)
				{
					if(Main.recipe[i].createItem.type == 0)
					{
						break;
					}
					if(item.type == Main.recipe[i].createItem.type)
					{
						recipe = Main.recipe[i];
					}
				}
				Dictionary<Item,int> itemdictionary = new Dictionary<Item,int>();
				for (int i = 0; i < Recipe.maxRequirements; i++)
				{
					itemdictionary.Add(recipe.requiredItem[i], recipe.requiredItem[i].stack);
				}
				return itemdictionary;
			}

			public void  DrawText(int a, int b, String text)
			{
				Rectangle hitbox = GetInnerDimensions().ToRectangle();

				int hoveredSnippet = -1;

				TextSnippet[] textSnippets = ChatManager.ParseMessage(text, Color.White).ToArray();
				ChatManager.ConvertNormalSnippets(textSnippets);

				for (int i = 0; i < ChatManager.ShadowDirections.Length; i++)
				{
					ChatManager.DrawColorCodedStringShadow(Main.spriteBatch, Main.fontMouseText, textSnippets, new Vector2(2+a, 15 + 3 +b) + hitbox.TopLeft() + ChatManager.ShadowDirections[i] * 1, 
					Color.Black, 0f, Vector2.Zero, new Vector2(1f, 1f), hitbox.Width - (7 * 2), 1);
				}

				Vector2 size = ChatManager.DrawColorCodedString(Main.spriteBatch, Main.fontMouseText, textSnippets,
				new Vector2(2 + a, 15 + 3 +b) + hitbox.TopLeft(), Color.White, 0f, Vector2.Zero, new Vector2(1f, 1f), out hoveredSnippet, hitbox.Width - (7 * 2), false);

				if (hoveredSnippet > -1)
				{
					ZZLocalizationMod.instance.ZZRecipeInfoUI.hoveredTextSnippet = textSnippets[hoveredSnippet];
				}
			}

			public Dictionary<String,int> ItemRecipe()
			{
				String text4="";
				Dictionary<String,int> a = new Dictionary<String,int>();
				Dictionary<Item,int> itemdictionary = new Dictionary<Item,int>();
				int Count = 0;
				
				foreach(Item item in Need)
				{
					
					bool Q = true;
					text4 = $"[i:{item.type}]";
					itemdictionary = UIRecipeInfoDisplay.FindRecipe(item);
					Count ++;
					foreach(Item item2 in itemdictionary.Keys)
					{
						int itemstack;
						itemdictionary.TryGetValue(item2, out itemstack);				
						if(itemstack == 0) {break;}
						text4 += " + ";
						if(Q) {text4=text4.Replace(" + "," = ");Q = false;}
						text4 += $"[i:{item2.type}]";

						string text3 = "[c/FF0000:"+" 0/"+itemstack +"]";
						for(int i=0; i<58 ; i++)
						{
							if(player.whoAmI.inventory[i].type==item2.type)
							{
								if(Main.player [Main.myPlayer].inventory[i].stack >= itemstack)
								{text3 = text3.Replace(text3,"[c/00FF00: "+ player.whoAmI.inventory[i].stack+"/"+itemstack +"]");}
								else{text3 = text3.Replace(text3,"[c/FF0000: "+ player.whoAmI.inventory[i].stack+"/"+itemstack +"]");}
								
								break;
							}
						}
						text4 += text3;
					}
					if(text4 == $"[i:{item.type}]") continue;

					a.Add(text4, Count);
				}

				return a;	
			}

			protected override void DrawSelf(SpriteBatch spriteBatch) 
			{
				
				CalculatedStyle innerDimensions = GetInnerDimensions();	
				float shopx = innerDimensions.X;
				float shopy = innerDimensions.Y;

				String text = $"{item.Name}";
				
				Dictionary<Item,int> itemdictionary = UIRecipeInfoDisplay.FindRecipe(item);

				

				//spriteBatch.Draw(texture, new Vector2(shopx + 70,shopy + 50), null, Color.White, 0, texture.Size(), 35/(texture.Size().Y), SpriteEffects.None, 0f);
				//DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, text, new Vector2(shopx+90, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);

				
				String text2 = "";

				int a =0;
				int b =0;
				bool F = true;

				foreach(Item item in itemdictionary.Keys)
				{
					int itemstack;
					itemdictionary.TryGetValue(item, out itemstack);				
					if(itemstack == 0) {if(text2 == "") text2= "[c/FF0000:未找到合成]"; break;}
					text2 += " + ";
					if(F) {text2=text2.Replace(" + ","= ");F = false;}
					text2 += $"[i:{item.type}]";
					
					bool No =false;
					string text3 = "[c/FF0000:"+" 0/"+itemstack +"]";
					for(int i=0; i<58 ; i++)
					{
						if(player.inventory[i].type==item.type)
						{
							if(player.inventory[i].stack >= itemstack)
							{text3 = text3.Replace(text3,"[c/00FF00: "+ player.inventory[i].stack+"/"+itemstack +"]");No = true;}
							else{text3 = text3.Replace(text3,"[c/FF0000: "+ player.inventory[i].stack+"/"+itemstack +"]");}
							
							break;
						}
					}
					if(!No) Need.Add(item);
					text2 += text3;
				}

				ZZLocalizationMod.instance.ZZRecipeInfoUI.longth = text2.Length;
				

				DrawText(a,b+50,text2);

				text4 = $"[i:{item.type}]";
				foreach(Item item in Need)
				{
					bool Q = true;

					itemdictionary = UIRecipeInfoDisplay.FindRecipe(item);

					foreach(Item item2 in itemdictionary.Keys)
					{
						int itemstack;
						itemdictionary.TryGetValue(item2, out itemstack);				
						if(itemstack == 0) {break;}
						text4 += " + ";
						if(Q) {text4=text4.Replace(" + "," = ");Q = false;}
						text4 += $"[i:{item2.type}]";

						string text3 = "[c/FF0000:"+" 0/"+itemstack +"]";
						for(int i=0; i<58 ; i++)
						{
							if(player.inventory[i].type==item2.type)
							{
								if(player.inventory[i].stack >= itemstack)
								{text3 = text3.Replace(text3,"[c/00FF00: "+ player.inventory[i].stack+"/"+itemstack +"]");}
								else{text3 = text3.Replace(text3,"[c/FF0000: "+ player.inventory[i].stack+"/"+itemstack +"]");}
								
								break;
							}
						}
						text4 += text3;
					}
					if(text4 == $"[i:{item.type}]") continue;

					text2 += text4;
				}
			}
		}

		public class UIItemInfo : UIElement
		{
			public List<Item> Need = new List<Item>();
			public Item item2 = new Item();
			public Player player = new Player();
			public int longth = 0;

			public TextSnippet[] textSnippets;
			public UIItemInfo() 
			{
				Width.Set(100, 0f);
				Height.Set(40, 0f);
			}

			public static Texture2D defaultBackgroundTexture = Main.inventoryBack9Texture;
			public Texture2D backgroundTexture = defaultBackgroundTexture;
			internal float scale = 1f;
			public int itemType;
			public bool hideSlot = false;

			public void  DrawText(int a, int b, String text)
			{
				Rectangle hitbox = GetInnerDimensions().ToRectangle();

				int hoveredSnippet = -1;

				TextSnippet[] textSnippets = ChatManager.ParseMessage(text, Color.White).ToArray();
				ChatManager.ConvertNormalSnippets(textSnippets);

				for (int i = 0; i < ChatManager.ShadowDirections.Length; i++)
				{
					ChatManager.DrawColorCodedStringShadow(Main.spriteBatch, Main.fontMouseText, textSnippets, new Vector2(2+a, 15 + 3 +b) + hitbox.TopLeft() + ChatManager.ShadowDirections[i] * 1, 
					Color.Black, 0f, Vector2.Zero, new Vector2(1f, 1f), hitbox.Width - (7 * 2), 1);
				}

				Vector2 size = ChatManager.DrawColorCodedString(Main.spriteBatch, Main.fontMouseText, textSnippets,
				new Vector2(2 + a, 15 + 3 +b) + hitbox.TopLeft(), Color.White, 0f, Vector2.Zero, new Vector2(1f, 1f), out hoveredSnippet, hitbox.Width - (7 * 2), false);

				if (hoveredSnippet > -1)
				{
					ZZLocalizationMod.instance.ZZRecipeInfoUI.hoveredTextSnippet = textSnippets[hoveredSnippet];
				}
			}


			protected override void DrawSelf(SpriteBatch spriteBatch) 
			{
				
				if (item2 != null)
				{
					CalculatedStyle dimensions = base.GetInnerDimensions();
					Rectangle rectangle = dimensions.ToRectangle();
					if (!hideSlot)
					{
						spriteBatch.Draw(backgroundTexture, dimensions.Position(), null, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
						DrawAdditionalOverlays(spriteBatch, dimensions.Position(), scale);
					}
					if (!item2.IsAir)
					{
						Texture2D itemTexture = Main.itemTexture[item2.type];
						Rectangle rectangle2;
						if (Main.itemAnimations[item2.type] != null)
						{
							rectangle2 = Main.itemAnimations[item2.type].GetFrame(itemTexture);
						}
						else
						{
							rectangle2 = itemTexture.Frame(1, 1, 0, 0);
						}
						Color newColor = Color.White;
						float pulseScale = 1f;
						ItemSlot.GetItemLight(ref newColor, ref pulseScale, item2, false);
						int height = rectangle2.Height;
						int width = rectangle2.Width;
						float drawScale = 1f;
						float availableWidth = (float)defaultBackgroundTexture.Width * scale;
						if (width > availableWidth || height > availableWidth)
						{
							if (width > height)
							{
								drawScale = availableWidth / width;
							}
							else
							{
								drawScale = availableWidth / height;
							}
						}
						drawScale *= scale;
						Vector2 vector = backgroundTexture.Size() * scale;
						Vector2 position2 = dimensions.Position() + vector / 2f - rectangle2.Size() * drawScale / 2f;
						Vector2 origin = rectangle2.Size() * (pulseScale / 2f - 0.5f);
						//Vector2 drawPosition = dimensions.Position();
						//drawPosition.X += defaultBackgroundTexture.Width * scale / 2f - (float)width * drawScale / 2f;
						//drawPosition.Y += defaultBackgroundTexture.Height * scale / 2f - (float)height * drawScale / 2f;

						if (ItemLoader.PreDrawInInventory(item2, spriteBatch, position2, rectangle2, item2.GetAlpha(newColor),
							item2.GetColor(Color.White), origin, drawScale * pulseScale))
						{
							spriteBatch.Draw(itemTexture, position2, new Rectangle?(rectangle2), item2.GetAlpha(newColor), 0f, origin, drawScale * pulseScale, SpriteEffects.None, 0f);
							if (item2.color != Color.Transparent)
							{
								spriteBatch.Draw(itemTexture, position2, new Rectangle?(rectangle2), item2.GetColor(Color.White), 0f, origin, drawScale * pulseScale, SpriteEffects.None, 0f);
							}
						}
						ItemLoader.PostDrawInInventory(item2, spriteBatch, position2, rectangle2, item2.GetAlpha(newColor),
							item2.GetColor(Color.White), origin, drawScale * pulseScale);
						if (ItemID.Sets.TrapSigned[item2.type])
						{
							spriteBatch.Draw(Main.wireTexture, dimensions.Position() + new Vector2(40f, 40f) * scale, new Rectangle?(new Rectangle(4, 58, 8, 8)), Color.White, 0f, new Vector2(4f), 1f, SpriteEffects.None, 0f);
						}
						DrawAdditionalBadges(spriteBatch, dimensions.Position(), scale);
					}
				}
				Rectangle hitbox = GetInnerDimensions().ToRectangle();
				TextSnippet[] textSnippets = ChatManager.ParseMessage($"{item2.Name}", Color.White).ToArray();
				int hoveredSnippet = -1;
				ChatManager.ConvertNormalSnippets(textSnippets);
				for (int i = 0; i < ChatManager.ShadowDirections.Length; i++)
				{
					ChatManager.DrawColorCodedStringShadow(Main.spriteBatch, Main.fontMouseText, textSnippets, new Vector2(2+55, 15 + 3 +13) + hitbox.TopLeft() + ChatManager.ShadowDirections[i] * 1, 
					Color.Black, 0f, Vector2.Zero, new Vector2(1f, 1f), hitbox.Width - (7 * 2), 1);
				}
				Vector2 size = ChatManager.DrawColorCodedString(Main.spriteBatch, Main.fontMouseText, textSnippets,
				new Vector2(2 + 55, 15 + 3 +13) + hitbox.TopLeft(), Color.White, 0f, Vector2.Zero, new Vector2(1f, 1f), out hoveredSnippet, hitbox.Width - (7 * 2), false);
			
				//Dictionary<Item,int> itemdictionary = UIRecipeInfoDisplay.FindRecipe(item2);
				//String text2 = "";

				//int a =0;
				//int b =0;
				//bool F = true;

				//foreach(Item item in itemdictionary.Keys)
				//{
				//	int itemstack;
				//	itemdictionary.TryGetValue(item, out itemstack);				
				//	if(itemstack == 0) {if(text2 == "") text2= "[c/FF0000:未找到合成]"; break;}
				//	text2 += " + ";
				//	if(F) {text2=text2.Replace(" + ","= ");F = false;}
				//	text2 += $"[i:{item.type}]";
					
				//	bool No =false;
				//	string text3 = "[c/FF0000:"+" 0/"+itemstack +"]";
				//	for(int i=0; i<58 ; i++)
				//	{
				//		if(player.inventory[i].type==item.type)
				//		{
				//			if(player.inventory[i].stack >= itemstack)
				//			{text3 = text3.Replace(text3,"[c/00FF00: "+ player.inventory[i].stack+"/"+itemstack +"]");No = true;}
				//			else{text3 = text3.Replace(text3,"[c/FF0000: "+ player.inventory[i].stack+"/"+itemstack +"]");}
				//			
				//			break;
				//		}
				//	}
				//	if(!No) Need.Add(item);
				//	text2 += text3;
				//}
			}
			
			internal virtual void DrawAdditionalOverlays(SpriteBatch spriteBatch, Vector2 vector2, float scale)
			{
			}

			internal virtual void DrawAdditionalBadges(SpriteBatch spriteBatch, Vector2 vector2, float scale)
			{
			}

			public void GetNeed(List<Item> need)
			{
				this.Need = need;
			}

			public Dictionary<String,int> ItemRecipe()
			{
				String text4="";
				Dictionary<String,int> a = new Dictionary<String,int>();
				Dictionary<Item,int> itemdictionary = new Dictionary<Item,int>();
				int Count = 0;
				
				foreach(Item item in Need)
				{
					
					bool Q = true;
					text4 = $"[i:{item.type}]";
					itemdictionary = UIRecipeInfoDisplay.FindRecipe(item);
					Count ++;
					foreach(Item item2 in itemdictionary.Keys)
					{
						int itemstack;
						itemdictionary.TryGetValue(item2, out itemstack);				
						if(itemstack == 0) {break;}
						text4 += " + ";
						if(Q) {text4=text4.Replace(" + "," = ");Q = false;}
						text4 += $"[i:{item2.type}]";

						string text3 = "[c/FF0000:"+" 0/"+itemstack +"]";
						for(int i=0; i<58 ; i++)
						{
							if(player.whoAmI.inventory[i].type==item2.type)
							{
								if(player.whoAmI.inventory[i].stack >= itemstack)
								{text3 = text3.Replace(text3,"[c/00FF00: "+ player.whoAmI.inventory[i].stack+"/"+itemstack +"]");}
								else{text3 = text3.Replace(text3,"[c/FF0000: "+ player.whoAmI.inventory[i].stack+"/"+itemstack +"]");}
								
								break;
							}
						}
						text4 += text3;
					}
					if(text4 == $"[i:{item.type}]") continue;

					a.Add(text4, Count);
				}

				return a;	
			}
		}
	internal class HoveredTextSnippetTooltipHack : GlobalItem
	{
		const int paddingForBox = 10;
		public override bool PreDrawTooltip(Item item, ReadOnlyCollection<TooltipLine> lines, ref int x, ref int y)
		{
			if(ZZLocalizationMod.instance.ZZRecipeInfoUI.hoveredTextSnippet != null)
			{
				var texts = lines.Select(z => z.text);
				string longestText = texts.ToList().OrderByDescending(z => z.Length).First();
				int widthForBox = (int)Main.fontMouseText.MeasureString(longestText).X ;
				int heightForBox = (int)texts.ToList().Sum(z => Main.fontMouseText.MeasureString(z).Y);

				Vector2 drawPosForBox = new Vector2(x - paddingForBox, y - paddingForBox);
				Rectangle drawRectForBox = new Rectangle(x, y, widthForBox, heightForBox);
				drawRectForBox.Inflate(paddingForBox, paddingForBox);
				
			}
			return base.PreDrawTooltip(item, lines, ref x, ref y);
		}
	}
}
 */
		