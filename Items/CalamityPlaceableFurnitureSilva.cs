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
    public class CalamityPlaceableFurnitureSilva : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaBasin")))
                {
                    item.SetNameOverride("闪耀金羽操作机");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaBathtub")))
                {
                    item.SetNameOverride("圣金源浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaBed")))
                {
                    item.SetNameOverride("圣金源床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaBench")))
                {
                    item.SetNameOverride("圣金源凳");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaBookcase")))
                {
                    item.SetNameOverride("圣金源书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaCandelabra")))
                {
                    item.SetNameOverride("圣金源烛台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaCandle")))
                {
                    item.SetNameOverride("圣金源蜡烛");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaChair")))
                {
                    item.SetNameOverride("圣金源椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaChandelier")))
                {
                    item.SetNameOverride("圣金源吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaChest")))
                {
                    item.SetNameOverride("圣金源宝箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaClock")))
                {
                    item.SetNameOverride("圣金源钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaCrystal")))
                {
                    item.SetNameOverride("圣金源晶");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaDoor")))
                {
                    item.SetNameOverride("圣金源门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaDresser")))
                {
                    item.SetNameOverride("圣金源梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaLamp")))
                {
                    item.SetNameOverride("圣金源灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaLantern")))
                {
                    item.SetNameOverride("圣金源灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaPiano")))
                {
                    item.SetNameOverride("圣金源钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaPlatform")))
                {
                    item.SetNameOverride("圣金源平台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaSink")))
                {
                    item.SetNameOverride("圣金源水池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaTable")))
                {
                    item.SetNameOverride("圣金源桌");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaWall")))
                {
                    item.SetNameOverride("圣金源墙");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaWorkBench")))
                {
                    item.SetNameOverride("圣金源工作台");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaBasin")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "用于打造特定家具";
					        }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SilvaSink")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "视作水源";
					        }
				        }
			        }
                }
            }
        } 
	}
}