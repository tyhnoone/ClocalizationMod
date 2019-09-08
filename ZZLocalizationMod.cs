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
using ZZLocalizationMod.Interface;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Events;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameInput;
using Terraria.ModLoader.Audio;
using Terraria.ModLoader.Default;
using Terraria.ModLoader.Exceptions;
using Terraria.ModLoader.IO;
using Terraria.ModLoader.UI;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Utilities;
using Terraria.World.Generation;

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
		}

		public static Mod Instance;
		internal static ZZLocalizationMod instance;

		internal static ModConfiguration modConfiguration;
		internal static UserInterface ZZPlayerInterfaceUserInfo;
		internal ZZPlayerInfo ZZPlayerInfoUI;
		internal static UserInterface ZZRecipeInterfaceUserInfo;
		//internal ZZRicipeInfo ZZRecipeInfoUI;

		internal static UserInterface ZZBuffInterfaceUserInfo;
		internal ZZBuffInfo ZZBuffInfoUI;

			
			
		public override void Load()
		{
			Instance = this;
			ZZPlayerInfoOK = RegisterHotKey("人物信息菜单", "P");

			

			//ZZRecipeInfoOK = RegisterHotKey("物品合成菜单", "O");

			/*ZZRecipeInfoUI = new ZZRicipeInfo();
			ZZRecipeInfoUI.Activate();
			ZZRecipeInterfaceUserInfo = new UserInterface();
			ZZRecipeInterfaceUserInfo.SetState(ZZRecipeInfoUI);
			*/
			ZZBuffInfoOK = RegisterHotKey("免疫buff信息", "O");

			


			if (!Main.dedServ)
			{	
				ZZBuffInfoUI = new ZZBuffInfo();
				ZZBuffInfoUI.Activate();
				ZZBuffInterfaceUserInfo = new UserInterface();
				ZZBuffInterfaceUserInfo.SetState(ZZBuffInfoUI);

				ZZPlayerInfoUI = new ZZPlayerInfo();
				ZZPlayerInfoUI.Activate();
				ZZPlayerInterfaceUserInfo = new UserInterface();
				ZZPlayerInterfaceUserInfo.SetState(ZZPlayerInfoUI);
			}
			instance = this;
			
			if(ModLoader.GetMod("CalamityMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				Mod mod = ModLoader.GetMod("CalamityMod");
				CalamitySupport.CalamityAddLocalizations();
			}
			if(ModLoader.GetMod("ThoriumMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				Mod mod = ModLoader.GetMod("ThoriumMod");
				ThoriumSupport.AddLocalizations();
			}
			
			
		}

		public override void Unload() 
		{
			Instance = null;
			instance = null;
			LootCache.instance = null;
			modConfiguration = null;

			ZZPlayerInfoOK = null;
			//ZZRecipeInfoOK = null;
			ZZBuffInfoOK = null;
		}

		public override void PostAddRecipes()
		{
			if (!Main.dedServ)
			{
				LootCacheManager.Setup(this);
			}
		}

		public override void PostSetupContent()
		{
			CalamitySupport.Setup();
		}

		public static ModHotKey ZZPlayerInfoOK;
		public static ModHotKey ZZRecipeInfoOK;
		public static ModHotKey ZZBuffInfoOK;

		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers) 
		{
			
			if(ModLoader.GetMod("CalamityMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				CalamitySupport.CalamityNPCChat();
			}
			if(ModLoader.GetMod("ThoriumMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				ThoriumSupport.ThoriumBardClass();
			}
			if(ModLoader.GetMod("Redemption") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				ModRedemption.ModRedemptionCombat();
				ModRedemption.ModRedemptionChat();
			}

			Player player = Main.player[Main.myPlayer];
			ZZLocalizationMod.instance.ZZPlayerInfoUI.UpdateValue(player);
			ZZLocalizationMod.instance.ZZBuffInfoUI.UpdateValue(player);


			
			int inventoryIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Info Accessories Bar"));
			if (inventoryIndex != -1) {
				layers.Insert(inventoryIndex, new LegacyGameInterfaceLayer(
					"ZZLocalizationMod: Info Accessories Bar2",
					delegate {
						DrawInterfaceInfoAccs();
						return true;
					},
					InterfaceScaleType.UI)
				);
			}

			int MouseTextIndexP = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
			if (MouseTextIndexP != -1)
			{
				layers.Insert(MouseTextIndexP, new LegacyGameInterfaceLayer(
					"ZZLocalizationMod: PlayerInfo",
					delegate
					{
						if (ZZPlayerInfo.visible)
						{
							ZZPlayerInfoUI.Draw(Main.spriteBatch);
						}
						return true;
					},
					InterfaceScaleType.UI)
				);
			}

			int MouseTextIndexB = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
			if (MouseTextIndexB != -1)
			{
				layers.Insert(MouseTextIndexB, new LegacyGameInterfaceLayer(
					"ZZLocalizationMod: PlayerInfo",
					delegate
					{
						if (ZZBuffInfo.visible)
						{
							ZZBuffInfoUI.Draw(Main.spriteBatch);
						}
						return true;
					},
					InterfaceScaleType.UI)
				);
			}

			/* int MouseTextIndexP2 = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Info Accessories Bar"));
			if (MouseTextIndexP2 != -1)
			{
				layers.Insert(MouseTextIndexP2, new LegacyGameInterfaceLayer(
					"ZZLocalizationMod: RecipeInfo",
					delegate
					{
						if (ZZRicipeInfo.visible)
						{
							ZZRecipeInfoUI.Draw(Main.spriteBatch);
						}
						return true;
					},
					InterfaceScaleType.UI)
				);
			}
			*/
			
		}

		public static string zoneString(Player player) 
		{
			string zone="所处环境: ";
			int num22 = (int)((double)((Main.player[Main.myPlayer].position.Y + (float)Main.player[Main.myPlayer].height) * 2f / 16f) - Main.worldSurface * 2.0);
			
			
			if(Main.player[Main.myPlayer].ZoneTowerSolar) zone += "\n日耀柱";
			if(Main.player[Main.myPlayer].ZoneTowerNebula) zone += "\n星云柱";
			if(Main.player[Main.myPlayer].ZoneTowerVortex) zone += "\n星璇柱";
			if(Main.player[Main.myPlayer].ZoneTowerStardust) zone += "\n星尘柱";
			if(Main.player[Main.myPlayer].ZoneSnow) zone += "\n苔原";
			if(Main.player[Main.myPlayer].ZoneJungle) zone += "\n丛林";
			if(Main.player[Main.myPlayer].ZoneCrimson) zone += "\n血腥之地";
			if(Main.player[Main.myPlayer].ZoneDesert) zone += "\n沙漠";
			if(Main.player[Main.myPlayer].ZoneRain) zone += "\n雨天";
			if(Main.player[Main.myPlayer].ZoneSandstorm) zone += "\n沙尘暴";
			if(Main.player[Main.myPlayer].ZoneBeach) zone += "\n海洋";
			if(Main.player[Main.myPlayer].ZoneGlowshroom) zone += "\n荧光蘑菇地";
			if(Main.player[Main.myPlayer].ZoneCorrupt) zone += "\n腐化之地";
			if(Main.player[Main.myPlayer].ZoneDungeon) zone += "\n地牢";
			if(Main.player[Main.myPlayer].ZoneHoly) zone += "\n神圣之地";
			if(Main.player[Main.myPlayer].ZoneMeteor) zone += "\n陨石";
			if(Main.player[Main.myPlayer].ZoneSkyHeight) zone += "\n太空";
			
			bool zoneMarble = false;
			bool zoneGranite = false;
			int num26 = (int)Main.player[Main.myPlayer].Center.X / 16;
			int num27 = (int)(Main.player[Main.myPlayer].Bottom.Y + 8f) / 16;
			if (Main.tile[num26, num27].type == 367)
			{
				zoneMarble = true;
			}
			if (Main.tile[num26, num27].type == 368)
			{
				zoneGranite = true;
			}
			if(zoneMarble) zone += "\n大理石穴";
			if(zoneGranite) zone += "\n花岗岩穴";

			bool spiderCave = false;
			int num39 = (int)Main.player[Main.myPlayer].position.X / 16;
			int num40 = (int)Main.player[Main.myPlayer].position.Y / 16;
			if (Main.tile[num39, num40].wall == 62)
			{
				spiderCave = true;
			}
			if(spiderCave) zone += "\n蜘蛛洞";

			bool lihzahrd = false;
			int num7 = (int)(Main.player[Main.myPlayer].position.X + (float)(Main.player[Main.myPlayer].width / 2)) / 16;
			int num8 = (int)(Main.player[Main.myPlayer].position.Y + (float)(Main.player[Main.myPlayer].height / 2)) / 16;
			if (Main.tile[num7, num8].wall == 87)
			{
				lihzahrd = true;
			}
			if(lihzahrd) zone += "\n蜥蜴神庙";

			if(ModLoader.GetMod("AAMod") != null) zone += AASupport.AAZone(player);
			if(ModLoader.GetMod("CalamityMod") != null) zone += CalamitySupport.CalamityZone(player);
			if(ModLoader.GetMod("ThoriumMod") != null) zone += ThoriumSupport.ThoriumZone(player);
			if(ModLoader.GetMod("SacredTools") != null) zone += SacredtoolsSupport.SacredToolsZone(player);
			if(ModLoader.GetMod("Redemption") != null) zone += ModRedemption.ModRedemptionZone(player);
			
			
			if(zone == "所处环境: ") 
			{
				if(Main.player[Main.myPlayer].position.Y > (float)((Main.maxTilesY - 204) * 16)) zone += "\n地狱";
				else if((double)Main.player[Main.myPlayer].position.Y > Main.rockLayer * 16.0 + (double)(1200 / 2) + 16.0) zone += "\n洞穴";
				else if(num22 > 0) zone += "\n地下";
				else if((float)((double)((Main.screenPosition.Y + (float)(Main.screenHeight / 2)) / 16f - (65f + 10f * (float)(Main.maxTilesX / 4200))) / (Main.worldSurface / 5.0)) >= 1f ) zone += "\n森林";
				else zone = "";
			};
			
			return zone;
		}
		public Texture2D[] infoIconTexture = new Texture2D[14];
		
		private void DrawInterfaceInfoAccs()
		{

				bool flaghitlife = false;
				int num = -1;
				int num2 = -10;
				int num3 = 0;
				string text = "";
				float num4 = 215f;
				int num5 = 0;
				Player player = Main.player[Main.myPlayer];
				
				for (int i = 0; i < 14; i++)
				{
					string text2 = "";
					string text3 = "";
					if ((Main.npcChatText == null || Main.npcChatText == "") && Main.player[Main.myPlayer].sign < 0 && ZZLocalizationMod.modConfiguration.uitext)
					{
						if(i== (Main.playerInventory? 0:-1) && !ZZPlayerInfo.visible)
						{
							
							text2 = "每秒" + player.lifeRegen + "生命再生";
							text3 = "生命再生速度";
							
						}
						if(i== (Main.playerInventory? 1:-1) && !ZZPlayerInfo.visible)
						{
							
							text2 = "每秒" + player.manaRegen + "魔力再生";
							text3 = "魔力再生速度";
							
						}
						if(i== (Main.playerInventory? 2:-1) && !ZZPlayerInfo.visible)
						{
							
							text2 = player.wingTimeMax + "最大飞行时间";
							text3 = "飞行时间";
							
						}
						if(i== (Main.playerInventory? 3:-1) && !ZZPlayerInfo.visible)
						{
							
							text2 = "获得" + player.endurance*100 + "%伤害减免";
							text3 = "伤害减免";
						}
						if(i== (Main.playerInventory? 4:-1) && !ZZPlayerInfo.visible)
						{
							
							text2 = "召唤物栏已用/上限："+ player.slotsMinions + " / " + player.maxMinions;
							text3 = "召唤栏";
						}
						if(i== (Main.playerInventory? 5:-1) && !ZZPlayerInfo.visible)
						{
							
							text2 = "哨兵炮塔上限：" + player.maxTurrets;
							text3 = "炮塔栏";
						}
						
						if(i== (Main.playerInventory? 6:-1)  && !ZZPlayerInfo.visible && ModLoader.GetMod("ThoriumMod") != null)
						{
							ModPlayer playerthorium = Main.player[Main.myPlayer].GetModPlayer(ModLoader.GetMod("ThoriumMod"), "ThoriumPlayer");
							text2 = "瑟银乐师灵感: " + ModLoader.GetMod("ThoriumMod").GetPlayer("ThoriumPlayer").GetType().GetField("bardResource").GetValue(playerthorium)+"灵感";
							text3 = "瑟银乐师灵感";
						}
						
						if(i== (Main.playerInventory? 8:0) && !flaghitlife)
						{
							int num15 = 2500;
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
											if (((npcaround.Center - Main.player[Main.myPlayer].Center).Length() - distance > (float)num16) && ((npcaround.Center - Main.player[Main.myPlayer].Center).Length() < 800))
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
								text2 = npcaround.GivenOrTypeName + ": " + npcaround.life + " / "+ npcaround.lifeMax;
							}
							if (npcaround2 != null)
							{
								text2 += "\n" + npcaround2.GivenOrTypeName + ": " + npcaround2.life + " / "+ npcaround2.lifeMax;
							}
							if (npcaround3 != null)
							{
								text2 += "\n" + npcaround3.GivenOrTypeName + ": " + npcaround3.life + " / "+ npcaround3.lifeMax;
							}
							flaghitlife = true ;
						}
						
						if(i== (Main.playerInventory? 13:6) && ZZLocalizationMod.modConfiguration.zonetext && !ZZPlayerInfo.visible)
						{
							
							text2 = zoneString(player);
							text3 = "所处环境";
							
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
								int num28 = (int)(74f * Main.inventoryScale);
								num26 = Main.screenWidth - 520;
								/* num26 = 697 - num28 * 4 + Main.screenWidth - 800 + 20 * (num3 % 2);*/
								num27 = 114 + num28 * 7 + num28 / 2 + 20 * (num3 / 2) + 8 * (num3 / 4) - 340;
								if (Main.EquipPage == 2)
								{
									/*num26 += num28 + num28 / 2;*/
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
		public override void UpdateUI(GameTime gameTime)
		{
			if (ZZPlayerInterfaceUserInfo != null)
			{
				ZZPlayerInterfaceUserInfo.Update(gameTime);
			}
			if (ZZRecipeInterfaceUserInfo != null)
			{
				ZZRecipeInterfaceUserInfo.Update(gameTime);
			}
			if (ZZBuffInterfaceUserInfo != null)
			{
				ZZBuffInterfaceUserInfo.Update(gameTime);
			}
		}

	}
}