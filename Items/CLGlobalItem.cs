using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using System.Reflection;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000037 RID: 55
	public class CLGlobalItem : GlobalItem
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00010650 File Offset: 0x0000E850
		public void splitValue(int totalCopper, out int plat, out int gold, out int silver, out int copper)
		{
			plat = totalCopper / 1000000;
			totalCopper %= 1000000;
			gold = totalCopper / 10000;
			totalCopper %= 10000;
			silver = totalCopper / 100;
			totalCopper %= 100;
			copper = totalCopper;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00010688 File Offset: 0x0000E888
		public string valueAsString(int plat, int gold, int silver, int copper)
		{
			string line = "";
			if (plat > 0)
			{
				line = line + plat + " 铂金";
			}
			if (gold > 0)
			{
				line = line + gold + " 金";
			}
			if (silver > 0)
			{
				line = line + silver + " 银";
			}
			if (plat == 0 && copper > 0)
			{
				line = line + copper + " 铜";
			}
			return line;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000106FC File Offset: 0x0000E8FC
		public void sellPriceTooltip(Item item, TooltipLine line)
		{
			int totalValue = (int)((float)(item.GetStoreValue() * item.stack) / 5f);
			if (item.type == 71 || item.type == 72 || item.type == 73 || item.type == 74 || totalValue == 0)
			{
				line.text = "";
				return;
			}
			line.text = "出售价格 ";
			int plat;
			int gold;
			int silver;
			int copper;
			this.splitValue(totalValue, out plat, out gold, out silver, out copper);
			line.text += this.valueAsString(plat, gold, silver, copper);
			if (plat > 0)
			{
				line.overrideColor = new Color?(new Color(220, 220, 198));
				return;
			}
			if (gold > 0)
			{
				line.overrideColor = new Color?(new Color(221, 199, 91));
				return;
			}
			if (silver > 0)
			{
				line.overrideColor = new Color?(new Color(181, 192, 193));
				return;
			}
			line.overrideColor = new Color?(new Color(246, 138, 96));
		}

		public void itemdrop(Item item, TooltipLine linedrop)
		{
			Player player = Main.player[Main.myPlayer];
			string line= "";
				var jsonitem = new JSONItem(item.modItem?.mod.Name ?? "Terraria",
					item.modItem?.Name ?? Lang.GetItemNameValue(item.type),
					item.modItem != null ? 0 : item.type);
				List<JSONNPC> npcsdropme = LootInfo.npcsthatdropme;
				int k=0;
				if (LootCache.instance.lootInfos.TryGetValue(jsonitem, out npcsdropme))
				{
					string[] lastname = new string[npcsdropme.Count];
					foreach (var dropper in npcsdropme)
					{
						bool OK= true;
						int id = dropper.GetID();
						NPC npc = new NPC();
						npc.SetDefaults(id);
						int i = 0;
						while(i<k)
						{
							if (npc.GivenOrTypeName == lastname[i])
							{
								OK= false;
							}
							i++;
						}
						if(OK) line = line + npc.GivenOrTypeName + "\n";
						lastname[k] = npc.GivenOrTypeName;
						k++;
						string r = line.Replace("\n", "");
						int num = (line.Length - r.Length);
						if(num >= ZZLocalizationMod.modConfiguration.droptext) 
						{
							line += "......";
							break;
						}
					}
				}
			linedrop.text = line;
			linedrop.overrideColor = Color.LimeGreen;
		}

		public void itembuy(Item item, TooltipLine linebuy)
		{
			FieldInfo shopToNPCField = typeof(NPCLoader).GetField("shopToNPC", BindingFlags.Static | BindingFlags.NonPublic);
			int[] shopToNPC = (int[])shopToNPCField.GetValue(null);
			for (int k = 0; k < 200; k++)
			{
				if (Main.npc[k].active && NPCLoader.CanChat(Main.npc[k]))
				{
					int type = Main.npc[k].type;
					int shop = Array.IndexOf(shopToNPC, type);
					if (shop == -1)
						shop = Main.MaxShopIDs - 1;

					Main.instance.shop[shop].SetupShop(shop == Main.MaxShopIDs - 1 ? type : shop);

					foreach (var itemcan in Main.instance.shop[shop].item)
					{
						if (item.type == itemcan.type)
						{
							linebuy.text += Main.npc[k].TypeName + "\n";
						}
					}
				}
			}
			linebuy.overrideColor = Color.DeepSkyBlue;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00010814 File Offset: 0x0000EA14
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if(item.melee)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "melee", "-战士职业-")
				{
					overrideColor = new Color?(Color.OrangeRed)
				});
			}
			if(item.magic)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "magic", "-法师职业-")
				{
					overrideColor = new Color?(Color.HotPink)
				});
			}
			if(item.thrown && ModLoader.GetMod("ThoriumMod") == null && ModLoader.GetMod("CalamityMod") == null)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "thrown", "-投手职业-")
				{
					overrideColor = new Color?(Color.SaddleBrown)
				});
			}
			if(item.summon)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "summon", "-召唤职业-")
				{
					overrideColor = new Color?(Color.MediumBlue)
				});
			}
			if (item.type == 2331 || item.type == 2312 || item.type == 2312)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 熔岩钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 2314 || item.type == 2451)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 蜂蜜钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type >= 2337 && item.type <= 2339)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 钓鱼垃圾")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 2429)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 困难模式下腐化/猩红/神圣的雪地海洋环境钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 3210)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 困难模式腐化钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 3203 || item.type == 2330 || item.type == 2454 || item.type == 2485 || item.type == 2457 || item.type == 2318)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 腐化钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 3211)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 困难模式血腥钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 3204 || item.type == 2477 || item.type == 2463 || item.type == 2319 || item.type == 2305)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 血腥钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 2467 || item.type == 2470 || item.type == 2484 || item.type == 2466 || item.type == 3197 || item.type == 2306 || item.type == 2299 || item.type == 2309)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 雪地钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 2452 || item.type == 2483 || item.type == 2488 || item.type == 2486 || item.type == 2311 || item.type == 2313 || item.type == 2302 || item.type == 3208)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 丛林钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 3211)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 地牢钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 3209)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 困难模式神圣钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 2317 || item.type == 3207 || item.type == 2317 || item.type == 2465 || item.type == 2468 || item.type == 2310 || item.type == 2471 || item.type == 2307)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 神圣钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 2336 || item.type == 3206 || item.type == 2335 || item.type == 2334 || item.type == 2423 || item.type == 3225 || item.type == 2420 || item.type == 3196)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 任意地点钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 3211)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 地牢钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			if (item.type == 2475)
			{
				tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 蘑菇地钓鱼")
				{
					overrideColor = new Color?(Color.BlueViolet)
				});
			}
			foreach (int type in Main.anglerQuestItemNetIDs)
			{
				if (item.type == type)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "任务鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
			}
			bool isTool = false;
			bool firesProjectile = false;
			if (item.pick > 0 || item.axe > 0 || item.hammer > 0)
			{
				isTool = true;
			}
			if (item.melee && item.shoot > 0 && item.useAnimation <= item.useTime)
			{
				firesProjectile = true;
			}
			int speed;
			if (firesProjectile || isTool)
			{
				speed = item.useAnimation;
			}
			else if (item.useAnimation > 0 && item.useAnimation < 100)
			{
				speed = item.useAnimation;
			}
			else
			{
				speed = item.useTime;
			}
			float realSpeed = (float)speed;
			float attacksPerSecond = 60f / ((realSpeed > 0f) ? realSpeed : 1f);
			Item ammoItem = null;
			if (item.ranged && item.useAmmo != 0)
			{
				for (int i = 54; i < 58; i++)
				{
					Item pItem = Main.LocalPlayer.inventory[i];
					if (pItem.ammo > 0 && pItem.ammo == item.useAmmo && pItem.Name != "")
					{
						ammoItem = pItem;
						break;
					}
				}
				if (ammoItem == null)
				{
					for (int j = 0; j < Main.LocalPlayer.inventory.Length; j++)
					{
						Item pItem2 = Main.LocalPlayer.inventory[j];
						if (pItem2.ammo > 0 && pItem2.ammo == item.useAmmo && pItem2.Name != "")
						{
							ammoItem = pItem2;
							break;
						}
					}
				}
			}
			float ammoDamage = 0f;
			if (ammoItem != null)
			{
				ammoDamage = (float)ammoItem.damage;
			}
			for (int k = 0; k < tooltips.Count; k++)
			{
				TooltipLine line = tooltips[k];
				if (line.Name == "Speed" && line.text.Length >= 3)
				{
					line.text = (attacksPerSecond.ToString("0.#") ?? "") + "次攻击每秒";
				}
				else if (line.Name == "Knockback" && line.text.Length >= 3)
				{
					if (item.knockBack > 0f)
					{
						line.text = (item.knockBack.ToString("0.#") ?? "") + "击退";
					}
					if (item.useAmmo > 0)
					{
						TooltipLine UseAmmoType = new TooltipLine(base.mod, "UseAmmoType", "");
						UseAmmoType.text = "弹药类型: [i:" + item.useAmmo + "]";
						if (k < tooltips.Count - 1)
						{
							tooltips.Insert(k + 1, UseAmmoType);
						}
						else
						{
							tooltips.Add(UseAmmoType);
						}
					}
					if (item.ammo > 0)
					{
						TooltipLine AmmoType = new TooltipLine(base.mod, "AmmoType", "");
						AmmoType.text = "弹药类型: [i:" + item.ammo + "]";
						if (k < tooltips.Count - 1)
						{
							tooltips.Insert(k + 1, AmmoType);
						}
						else
						{
							tooltips.Add(AmmoType);
						}
					}
					if (ammoDamage > 0f)
					{
						TooltipLine l = new TooltipLine(base.mod, "Ammo", "");
						l.text = "目前弹药: [i:" + ammoItem.type + "]";
						if (k < tooltips.Count - 1)
						{
							tooltips.Insert(k + 1, l);
						}
						else
						{
							tooltips.Add(l);
						}
					}
				}
			}
			if (Main.npcShop <= 0)
			{
				TooltipLine line2 = new TooltipLine(base.mod, "Sell", "");
				this.sellPriceTooltip(item, line2);
				if (line2.text != "")
				{
					tooltips.Add(line2);
				}
			}
			if(ZZLocalizationMod.modConfiguration.buytext)
			{
				
				TooltipLine line5 = new TooltipLine(base.mod, "buy", "");
				TooltipLine line5ok = new TooltipLine(base.mod, "buy2", "");
				this.itembuy(item, line5ok);
				if (line5ok.text != ""&&line5.text != "\n")
				{
					line5.text = "\n可购买自：";
					line5.overrideColor = Color.CadetBlue;
					tooltips.Add(line5);
					tooltips.Add(line5ok);
				}
			}
			if(ZZLocalizationMod.modConfiguration.droptext != 0)
			{
				TooltipLine line3 = new TooltipLine(base.mod, "dropNPC", "");
				TooltipLine line4 = new TooltipLine(base.mod, "dropNPC2", "");
				this.itemdrop(item, line4);
				if (line4.text != ""&&line4.text != "\n")
				{
					line3.text = "\n可掉落自：";
					line3.overrideColor = Color.OrangeRed;
					tooltips.Add(line3);
					tooltips.Add(line4);
				}
			}
		}	
	}
}
