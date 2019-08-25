using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

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
				string lastname = "";
				if (LootCache.instance.lootInfos.TryGetValue(jsonitem, out npcsdropme))
				{
					foreach (var dropper in npcsdropme)
					{
						int id = dropper.GetID();
						if (id == 0) continue;
						/*int id = dropper.id;
						if (id == 0)
						{
							//it's a
							Mod m = ModLoader.GetMod(dropper.mod);
							if (m == null) continue;
							id = m.NPCType(dropper.name);
						}*/
						NPC npc = new NPC();
						npc.SetDefaults(id);
						if(npc.GivenOrTypeName != lastname)
						{
							line += npc.GivenOrTypeName + "\n";
						}
						lastname = npc.GivenOrTypeName;
					}
				}
			linedrop.text = line;
			linedrop.overrideColor = Color.LimeGreen;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00010814 File Offset: 0x0000EA14
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
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
						l.text = "目前弹药: " + ammoItem.Name;
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
			if (ZZLocalizationMod.modConfiguration.droptext)
			{
				TooltipLine line3 = new TooltipLine(base.mod, "dropNPC", "");
				TooltipLine line4 = new TooltipLine(base.mod, "dropNPC2", "");
				this.itemdrop(item, line4);
				if (line4.text != "")
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
