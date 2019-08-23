using CLocalizationMod;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Localization;

namespace CLocalizationMod.Items
{
    public class CLGlobalItem : GlobalItem
    {
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

        public string valueAsString(int plat, int gold, int silver, int copper)
        {
            string line = "";

            if (plat > 0)
            {
                line += plat + " 铂金";
            }

            if (gold > 0)
            {
                line += gold + " 金";
            }

            if (silver > 0)
            {
                line += silver + " 银";
            }

            //don't bother with copper if we have plat, makes the line too long and no one cares
            if (plat == 0 && copper > 0)
            {
                line += copper + " 铜";
            }

            return line;
        }
		public void reforgePriceTooltip(Item item, TooltipLine line)
        {
            int totalValue = (int)(item.GetStoreValue() / 3.0f);

            if (item.maxStack > 1 || item.vanity || totalValue == 0 || !NPC.savedGoblin ||
			(!item.accessory && item.defense > 0))
            {
                line.text = "";
                return;
            }
            else
            {
                line.text = "重铸花费 ";
                line.overrideColor = new Color(80, 140, 80);
            }

            int plat, gold, silver, copper;
            splitValue(totalValue, out plat, out gold, out silver, out copper);
            line.text += valueAsString(plat, gold, silver, copper);
        }

        public void sellPriceTooltip(Item item, TooltipLine line)
        {
            int totalValue = (int)((item.GetStoreValue() * item.stack) / 5.0f);

            if (item.type == ItemID.CopperCoin ||
                item.type == ItemID.SilverCoin ||
                item.type == ItemID.GoldCoin ||
                item.type == ItemID.PlatinumCoin ||
                totalValue == 0)
            {
                line.text = "";
                return;
            }
            else
            {
                line.text = "出售价格 ";
            }

            int plat, gold, silver, copper;
            splitValue(totalValue, out plat, out gold, out silver, out copper);
            line.text += valueAsString(plat, gold, silver, copper);

            if (plat > 0)
            {
                line.overrideColor = new Color(220, 220, 198);
            }
            else if (gold > 0)
            {
                line.overrideColor = new Color(221, 199, 91);
            }
            else if (silver > 0)
            {
                line.overrideColor = new Color(181, 192, 193);
            }
            else
            {
                line.overrideColor = new Color(246, 138, 96);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
			const bool useColour = false;
			const string startColour = useColour ? "[c/ffc055:" : "";
            const string endColour = useColour ? "]" : "";

			int speed;

			bool isTool = false;
            bool firesProjectile = false;

            if (item.pick > 0 ||
                item.axe > 0 ||
                item.hammer > 0)
            {
                isTool = true;
            }

            if (item.melee &&
                item.shoot > 0 &&
                item.useAnimation <= item.useTime)
            {
                firesProjectile = true;
            }

            if (firesProjectile ||
                isTool)
            {
                speed = item.useAnimation;
           }
            else if (item.useAnimation > 0 &&
                item.useAnimation < 100)
            {
                speed = item.useAnimation;
            }
            else
            {
                speed = item.useTime;
            }
			
			float realSpeed = speed;
			float attacksPerSecond = 60.0f / (realSpeed > 0 ? realSpeed : 1);

			Item ammoItem = null;

            if (item.ranged && item.useAmmo != 0)
            {
                for (int i = 54; i < 58; ++i)
                {
                    Item pItem = Main.LocalPlayer.inventory[i];
                    if (pItem.ammo > 0)
                    {
                        if (pItem.ammo == item.useAmmo && pItem.Name != "")
                        {
                            ammoItem = pItem;
                            break;
                        }
                    }
                }
                if (ammoItem == null)
                {
                    for (int i = 0; i < Main.LocalPlayer.inventory.Length; ++i)
                    {
                        Item pItem = Main.LocalPlayer.inventory[i];
                        if (pItem.ammo > 0)
                        {
                            if (pItem.ammo == item.useAmmo && pItem.Name != "")
                            {
                                ammoItem = pItem;
                                break;
                            }
                        }
                    }
                }
            }

			float ammoDamage = 0;

            if (ammoItem != null)
            {
                ammoDamage = ammoItem.damage;
            }

            for (int i = 0; i < tooltips.Count; ++i)
            {
                TooltipLine line = tooltips[i];
				if (line.Name == "Speed" && line.text.Length >= 3)
                {
                    //todo: come up with my own names rather than use vanilla, faster and more accurate
                    line.text = startColour + attacksPerSecond.ToString("0.#") + endColour + "次攻击每秒";
				}
				else if (line.Name == "Knockback" && line.text.Length >= 3)
                {
                    if (item.knockBack > 0)
                    {
                        line.text = startColour + item.knockBack.ToString("0.#") + endColour + "击退"; //10 = 9 characters in knockback + space
                    }

                    if (item.useAmmo > 0)
                    {
                        TooltipLine UseAmmoType = new TooltipLine(mod, "UseAmmoType", "");
                        UseAmmoType.text = "弹药类型: " + "[i:" + item.useAmmo + "]";
                        if (i < tooltips.Count - 1)
                        {
                            tooltips.Insert(i + 1, UseAmmoType);
                        }
                        else
                        {
                            tooltips.Add(UseAmmoType);
                        }
                    }

                    if (item.ammo > 0)
                    {
                        TooltipLine AmmoType = new TooltipLine(mod, "AmmoType", "");
                        AmmoType.text = "弹药类型: " + "[i:" + item.ammo + "]";
                        if (i < tooltips.Count - 1)
                        {
                            tooltips.Insert(i + 1, AmmoType);
                        }
                        else
                        {
                            tooltips.Add(AmmoType);
                        }
                    }

                    if (ammoDamage > 0)
                    {
                        TooltipLine l = new TooltipLine(mod, "Ammo", "");
                        l.text = "目前弹药: " + ammoItem.Name;
                        if (i < tooltips.Count - 1)
                        {
                            tooltips.Insert(i + 1, l);
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
                TooltipLine line = new TooltipLine(mod, "Reforge", "");
                reforgePriceTooltip(item, line);

                if (line.text != "")
                {
                    tooltips.Add(line);
                }

                TooltipLine line2 = new TooltipLine(mod, "Sell", "");
                sellPriceTooltip(item, line2);
                
                if (line2.text != "")
                {
                    tooltips.Add(line2);
                }
            }
				
					
			
        }
    }
}