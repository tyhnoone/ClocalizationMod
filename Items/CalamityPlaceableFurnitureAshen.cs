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
    public class CalamityPlaceableFurnitureAshen : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenAltar")))
                {
                    item.SetNameOverride("余烬铸祭台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenBasin")))
                {
                    item.SetNameOverride("余烬盆");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenBath")))
                {
                    item.SetNameOverride("余烬浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenBed")))
                {
                    item.SetNameOverride("余烬床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenBookcase")))
                {
                    item.SetNameOverride("余烬书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenCandelabra")))
                {
                    item.SetNameOverride("余烬烛台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenCandle")))
                {
                    item.SetNameOverride("余烬蜡烛");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenChair")))
                {
                    item.SetNameOverride("余烬椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenChandelier")))
                {
                    item.SetNameOverride("余烬吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenChest")))
                {
                    item.SetNameOverride("余烬宝箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenDoor")))
                {
                    item.SetNameOverride("余烬门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenDresser")))
                {
                    item.SetNameOverride("余烬梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenLamp")))
                {
                    item.SetNameOverride("余烬灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenLantern")))
                {
                    item.SetNameOverride("余烬灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenMonolith")))
                {
                    item.SetNameOverride("余烬巨柱钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenPiano")))
                {
                    item.SetNameOverride("余烬钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenPlatform")))
                {
                    item.SetNameOverride("余烬平台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenSink")))
                {
                    item.SetNameOverride("余烬熔岩池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenSlab")))
                {
                    item.SetNameOverride("余烬厚板");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenSlabWall")))
                {
                    item.SetNameOverride("余烬厚板墙");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenSofa")))
                {
                    item.SetNameOverride("余烬沙发");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenTable")))
                {
                    item.SetNameOverride("余烬桌");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenWorkbench")))
                {
                    item.SetNameOverride("余烬工作台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("LockedAshenChest")))
                {
                    item.SetNameOverride("上锁余烬宝箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothBrimstoneSlag")))
                {
                    item.SetNameOverride("光滑硫磺火石板");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmoothBrimstoneSlagWall")))
                {
                    item.SetNameOverride("光滑硫磺火石板墙");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenAltar")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "用于打造特定家具";
					        }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AshenSink")))
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