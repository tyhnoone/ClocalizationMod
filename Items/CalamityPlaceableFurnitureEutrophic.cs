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
    public class CalamityPlaceableFurnitureEutrophic : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicBathtub")))
                {
                    item.SetNameOverride("富养渊浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicBed")))
                {
                    item.SetNameOverride("富养渊床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicBench")))
                {
                    item.SetNameOverride("富养渊凳");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicBookcase")))
                {
                    item.SetNameOverride("富养渊书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicCandelabra")))
                {
                    item.SetNameOverride("富养渊烛台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicCandle")))
                {
                    item.SetNameOverride("富养渊蜡烛");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicChair")))
                {
                    item.SetNameOverride("富养渊椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicChandelier")))
                {
                    item.SetNameOverride("富养渊吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicChest")))
                {
                    item.SetNameOverride("富养渊宝箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicClock")))
                {
                    item.SetNameOverride("富养渊钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicDoor")))
                {
                    item.SetNameOverride("富养渊门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicDresser")))
                {
                    item.SetNameOverride("富养渊梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicLamp")))
                {
                    item.SetNameOverride("富养渊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicLantern")))
                {
                    item.SetNameOverride("富养渊灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicPiano")))
                {
                    item.SetNameOverride("富养渊钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicCrafting")))
                {
                    item.SetNameOverride("富养渊制作台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicPlatform")))
                {
                    item.SetNameOverride("富养渊平台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicSink")))
                {
                    item.SetNameOverride("富养渊水池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicTable")))
                {
                    item.SetNameOverride("富养渊桌");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicWorkBench")))
                {
                    item.SetNameOverride("富养渊工作台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothNavystone")))
                {
                    item.SetNameOverride("光滑沉沦渊石");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothNavystoneWall")))
                {
                    item.SetNameOverride("光滑沉沦渊石墙");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicCrafting")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "用于打造特定家具";
					        }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicSink")))
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