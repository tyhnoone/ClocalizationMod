using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000029 RID: 41
	public class CalamityPlaceableFurnitureAbyss : GlobalItem
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000B1C4 File Offset: 0x000093C4
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssBath"))
				{
					item.SetNameOverride("深渊浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssBed"))
				{
					item.SetNameOverride("深渊床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssBookcase"))
				{
					item.SetNameOverride("深渊书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssCandelabra"))
				{
					item.SetNameOverride("深渊烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssCandle"))
				{
					item.SetNameOverride("深渊蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssChair"))
				{
					item.SetNameOverride("深渊椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssChandelier"))
				{
					item.SetNameOverride("深渊吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssChest"))
				{
					item.SetNameOverride("深渊箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssClock"))
				{
					item.SetNameOverride("深渊钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssDoor"))
				{
					item.SetNameOverride("深渊门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssDresser"))
				{
					item.SetNameOverride("深渊梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssLamp"))
				{
					item.SetNameOverride("深渊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssLantern"))
				{
					item.SetNameOverride("深渊灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssPiano"))
				{
					item.SetNameOverride("深渊钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssSink"))
				{
					item.SetNameOverride("深渊水池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssSofa"))
				{
					item.SetNameOverride("深渊沙发");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssTable"))
				{
					item.SetNameOverride("深渊桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssTorch"))
				{
					item.SetNameOverride("深渊火把");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssWorkbench"))
				{
					item.SetNameOverride("深渊工作台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SmoothAbyssGravel"))
				{
					item.SetNameOverride("光滑深渊砾石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SmoothAbyssGravelPlatform"))
				{
					item.SetNameOverride("光滑深渊砾石平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SmoothAbyssGravelWall"))
				{
					item.SetNameOverride("光滑深渊砾石墙");
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000B550 File Offset: 0x00009750
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssSink"))
				{
					foreach (TooltipLine tooltip in tooltips)
					{
						if (tooltip.Name == "Tooltip0")
						{
							tooltip.text = "算作水源";
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssTorch"))
				{
					foreach (TooltipLine tooltip2 in tooltips)
					{
						if (tooltip2.Name == "Tooltip0")
						{
							tooltip2.text = "可放入水中";
						}
					}
				}
			}
		}
	}
}
