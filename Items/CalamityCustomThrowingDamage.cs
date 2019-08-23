using CLocalizationMod;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Localization;

namespace CLocalizationMod.Items
{
    public class CalamityCustomThrowingDamage : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AccretionDisk")))
                {
                    item.SetNameOverride("元素飞盘");
                }
            }
			}
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
                if(ModLoader.GetMod("CalamityMod") != null)
                {
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AccretionDisk")))
			        {
                        
				        foreach (TooltipLine tooltipLine in tooltips)
				        {
                            if (tooltipLine.Name == "Damage")
                            {
                                string[] source = tooltipLine.text.Split(new char[] { ' ' });
                                string str = source.First<string>();
                                string str2 = source.Last<string>();
                                tooltipLine.text = str + " 盗贼" + str2;
                            }
                            if (tooltipLine.Name == "Tooltip0")
					        {
						        tooltipLine.text = "切裂真实!";
					        }
				        }
			        }
                }
            }
        }
	}
}