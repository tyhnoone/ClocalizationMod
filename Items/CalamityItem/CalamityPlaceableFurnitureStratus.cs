﻿using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000034 RID: 52
	public class CalamityPlaceableFurnitureStratus : GlobalItem
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000E450 File Offset: 0x0000C650
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusBathtub"))
				{
					item.SetNameOverride("幻流明浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusBed"))
				{
					item.SetNameOverride("幻流明床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusBookcase"))
				{
					item.SetNameOverride("幻流明书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusBricks"))
				{
					item.SetNameOverride("幻流明块");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusCandelabra"))
				{
					item.SetNameOverride("幻流明烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusCandle"))
				{
					item.SetNameOverride("幻流明蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusChair"))
				{
					item.SetNameOverride("幻流明椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusChandelier"))
				{
					item.SetNameOverride("幻流明吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusChest"))
				{
					item.SetNameOverride("幻流明宝箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusClock"))
				{
					item.SetNameOverride("幻流明钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusDoor"))
				{
					item.SetNameOverride("幻流明门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusDresser"))
				{
					item.SetNameOverride("幻流明梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusLamp"))
				{
					item.SetNameOverride("幻流明灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusLantern"))
				{
					item.SetNameOverride("幻流明灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusPiano"))
				{
					item.SetNameOverride("幻流明钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusPlatform"))
				{
					item.SetNameOverride("幻流明平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusSink"))
				{
					item.SetNameOverride("幻流明水池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusSofa"))
				{
					item.SetNameOverride("幻流明沙发");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusTable"))
				{
					item.SetNameOverride("幻流明桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusWall"))
				{
					item.SetNameOverride("幻流明墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusWorkbench"))
				{
					item.SetNameOverride("幻流明工作台");
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && item.type == ModLoader.GetMod("CalamityMod").ItemType("StratusSink"))
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
