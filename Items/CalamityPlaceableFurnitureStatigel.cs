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
    public class CalamityPlaceableFurnitureStatigel : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StaticRefiner")))
                {
                    item.SetNameOverride("静态凝胶精炼机");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelBath")))
                {
                    item.SetNameOverride("斯塔提斯浴缸");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelBed")))
                {
                    item.SetNameOverride("斯塔提斯床");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelBlock")))
                {
                    item.SetNameOverride("斯塔提斯凝胶块");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelBookcase")))
                {
                    item.SetNameOverride("斯塔提斯书架");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelCandelabra")))
                {
                    item.SetNameOverride("斯塔提斯烛台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelCandle")))
                {
                    item.SetNameOverride("斯塔提斯蜡烛");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelChair")))
                {
                    item.SetNameOverride("斯塔提斯椅");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelChandelier")))
                {
                    item.SetNameOverride("斯塔提斯吊灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelChest")))
                {
                    item.SetNameOverride("斯塔提斯宝箱");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelClock")))
                {
                    item.SetNameOverride("斯塔提斯钟");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelDoor")))
                {
                    item.SetNameOverride("斯塔提斯门");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelDresser")))
                {
                    item.SetNameOverride("斯塔提斯梳妆台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelLamp")))
                {
                    item.SetNameOverride("斯塔提斯灯");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelLantern")))
                {
                    item.SetNameOverride("斯塔提斯灯笼");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelPiano")))
                {
                    item.SetNameOverride("斯塔提斯钢琴");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelPlatform")))
                {
                    item.SetNameOverride("斯塔提斯平台");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelSink")))
                {
                    item.SetNameOverride("斯塔提斯水池");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelTable")))
                {
                    item.SetNameOverride("斯塔提斯桌");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelSofa")))
                {
                    item.SetNameOverride("斯塔提斯沙发");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelWall")))
                {
                    item.SetNameOverride("斯塔提斯凝胶墙");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelWorkbench")))
                {
                    item.SetNameOverride("斯塔提斯工作台");
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StaticRefiner")))
			        {
				        foreach (TooltipLine tooltip in tooltips)
				        {
					        if (tooltip.Name == "Tooltip0")
					        {
						        tooltip.text = "用于打造特定家具";
					        }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StatigelSink")))
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