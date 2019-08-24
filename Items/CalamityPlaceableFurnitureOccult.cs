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
    public class CalamityPlaceableFurnitureOccult : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultBathtub")))
                {
                    item.SetNameOverride("异界浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultBed")))
                {
                    item.SetNameOverride("异界床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultBookcase")))
                {
                    item.SetNameOverride("异界书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultCandelabra")))
                {
                    item.SetNameOverride("异界烛台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultCandle")))
                {
                    item.SetNameOverride("异界蜡烛");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultChair")))
                {
                    item.SetNameOverride("异界椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultChandelier")))
                {
                    item.SetNameOverride("异界吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultChest")))
                {
                    item.SetNameOverride("异界宝箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultClock")))
                {
                    item.SetNameOverride("异界钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultDoor")))
                {
                    item.SetNameOverride("异界门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultDresser")))
                {
                    item.SetNameOverride("异界梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultLamp")))
                {
                    item.SetNameOverride("异界灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultLantern")))
                {
                    item.SetNameOverride("异界灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultPiano")))
                {
                    item.SetNameOverride("异界钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultPlatform")))
                {
                    item.SetNameOverride("异界平台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultSink")))
                {
                    item.SetNameOverride("异界水池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultSofa")))
                {
                    item.SetNameOverride("异界沙发");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultWorkBench")))
                {
                    item.SetNameOverride("异界工作台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultStone")))
                {
                    item.SetNameOverride("异界石");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultStoneWall")))
                {
                    item.SetNameOverride("异界石墙");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultTable")))
                {
                    item.SetNameOverride("异界桌");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OccultSink")))
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