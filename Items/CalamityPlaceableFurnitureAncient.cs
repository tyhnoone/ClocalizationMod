using ZZLocalizationMod;
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

namespace ZZLocalizationMod.Items
{
    public class CalamityPlaceableFurnitureAncient : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientAltar")))
                {
                    item.SetNameOverride("硫古铸祭台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientBasin")))
                {
                    item.SetNameOverride("硫古盆");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientBath")))
                {
                    item.SetNameOverride("硫古浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientBed")))
                {
                    item.SetNameOverride("硫古床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientBookcase")))
                {
                    item.SetNameOverride("硫古书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientChair")))
                {
                    item.SetNameOverride("硫古椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientChandelier")))
                {
                    item.SetNameOverride("硫古吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientDoor")))
                {
                    item.SetNameOverride("硫古门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientDresser")))
                {
                    item.SetNameOverride("硫古梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientLamp")))
                {
                    item.SetNameOverride("硫古灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientLantern")))
                {
                    item.SetNameOverride("硫古灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientMonolith")))
                {
                    item.SetNameOverride("硫古巨柱钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientPiano")))
                {
                    item.SetNameOverride("硫古钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientSink")))
                {
                    item.SetNameOverride("硫古熔岩池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientSofa")))
                {
                    item.SetNameOverride("硫古沙发");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientTable")))
                {
                    item.SetNameOverride("硫古桌");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientWorkbench")))
                {
                    item.SetNameOverride("硫古工作台");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientAltar")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "用于打造特定家具";
					        }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AncientSink")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "视作岩浆源";
					        }
				        }
			        }
                }
            }
        } 
	}
}