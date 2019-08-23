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
    public class CalamityPlaceableFurnitureAbyss : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssBath")))
                {
                    item.SetNameOverride("深渊浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssBed")))
                {
                    item.SetNameOverride("深渊床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssBookcase")))
                {
                    item.SetNameOverride("深渊书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssCandelabra")))
                {
                    item.SetNameOverride("深渊烛台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssCandle")))
                {
                    item.SetNameOverride("深渊蜡烛");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssChair")))
                {
                    item.SetNameOverride("深渊椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssChandelier")))
                {
                    item.SetNameOverride("深渊吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssChest")))
                {
                    item.SetNameOverride("深渊箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssClock")))
                {
                    item.SetNameOverride("深渊钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssDoor")))
                {
                    item.SetNameOverride("深渊门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssDresser")))
                {
                    item.SetNameOverride("深渊梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssLamp")))
                {
                    item.SetNameOverride("深渊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssLantern")))
                {
                    item.SetNameOverride("深渊灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssPiano")))
                {
                    item.SetNameOverride("深渊钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssSink")))
                {
                    item.SetNameOverride("深渊水池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssSofa")))
                {
                    item.SetNameOverride("深渊沙发");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssTable")))
                {
                    item.SetNameOverride("深渊桌");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssTorch")))
                {
                    item.SetNameOverride("深渊火把");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssWorkbench")))
                {
                    item.SetNameOverride("深渊工作台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothAbyssGravel")))
                {
                    item.SetNameOverride("光滑深渊砾石");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothAbyssGravelPlatform")))
                {
                    item.SetNameOverride("光滑深渊砾石平台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothAbyssGravelWall")))
                {
                    item.SetNameOverride("光滑深渊砾石墙");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssSink")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "算作水源";
					        }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AbyssTorch")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "可放入水中";
					        }
				        }
			        }
                }
            }
        } 
	}
}