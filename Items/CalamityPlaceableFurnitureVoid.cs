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
    public class CalamityPlaceableFurnitureVoid : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothVoidstone")))
                {
                    item.SetNameOverride("光滑寂渊石");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothVoidstonePlatform")))
                {
                    item.SetNameOverride("光滑寂渊平台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothVoidstoneWall")))
                {
                    item.SetNameOverride("光滑寂渊墙");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidBath")))
                {
                    item.SetNameOverride("寂渊浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidBed")))
                {
                    item.SetNameOverride("寂渊床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidBench")))
                {
                    item.SetNameOverride("寂渊凳");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidBookcase")))
                {
                    item.SetNameOverride("寂渊书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidCandelabra")))
                {
                    item.SetNameOverride("寂渊烛台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidCandle")))
                {
                    item.SetNameOverride("寂渊蜡烛");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidChair")))
                {
                    item.SetNameOverride("寂渊椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidChandelier")))
                {
                    item.SetNameOverride("寂渊吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidChest")))
                {
                    item.SetNameOverride("寂渊宝箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidClock")))
                {
                    item.SetNameOverride("寂渊钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidCondenser")))
                {
                    item.SetNameOverride("寂渊冷凝机");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidDoor")))
                {
                    item.SetNameOverride("寂渊门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidDresser")))
                {
                    item.SetNameOverride("寂渊梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidLamp")))
                {
                    item.SetNameOverride("寂渊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidLantern")))
                {
                    item.SetNameOverride("寂渊灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidPiano")))
                {
                    item.SetNameOverride("寂渊钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidSink")))
                {
                    item.SetNameOverride("寂渊水池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidSofa")))
                {
                    item.SetNameOverride("寂渊沙发");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidstoneSlab")))
                {
                    item.SetNameOverride("寂渊石板");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidstoneSlabWall")))
                {
                    item.SetNameOverride("寂渊石板墙");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidTable")))
                {
                    item.SetNameOverride("寂渊桌");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidWorkbench")))
                {
                    item.SetNameOverride("寂渊工作台");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidCondenser")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "用于打造特定家具";
					        }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VoidSink")))
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