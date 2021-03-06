﻿using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x0200002D RID: 45
	public class CalamityPlaceableFurnitureCosmilite : GlobalItem
	{
		// Token: 0x06000060 RID: 96 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBath"))
				{
					item.SetNameOverride("寰宇浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBed"))
				{
					item.SetNameOverride("寰宇床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBookcase"))
				{
					item.SetNameOverride("寰宇书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBrick"))
				{
					item.SetNameOverride("寰宇砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBrickWall"))
				{
					item.SetNameOverride("寰宇砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteCandelabra"))
				{
					item.SetNameOverride("寰宇烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteCandle"))
				{
					item.SetNameOverride("寰宇蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteChair"))
				{
					item.SetNameOverride("寰宇椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteChandelier"))
				{
					item.SetNameOverride("寰宇吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteChest"))
				{
					item.SetNameOverride("寰宇宝箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteClock"))
				{
					item.SetNameOverride("寰宇钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteDoor"))
				{
					item.SetNameOverride("寰宇门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteDresser"))
				{
					item.SetNameOverride("寰宇梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteLamp"))
				{
					item.SetNameOverride("寰宇灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteLantern"))
				{
					item.SetNameOverride("寰宇灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmilitePiano"))
				{
					item.SetNameOverride("寰宇钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmilitePlatform"))
				{
					item.SetNameOverride("寰宇平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteSconce"))
				{
					item.SetNameOverride("寰宇壁灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteSink"))
				{
					item.SetNameOverride("寰宇水池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteSofa"))
				{
					item.SetNameOverride("寰宇沙发");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteTable"))
				{
					item.SetNameOverride("寰宇桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteWorkbench"))
				{
					item.SetNameOverride("寰宇工作台");
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000C758 File Offset: 0x0000A958
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteSink"))
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
