using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x0200002F RID: 47
	public class CalamityPlaceableFurnitureOccult : GlobalItem
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000CC98 File Offset: 0x0000AE98
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultBathtub"))
				{
					item.SetNameOverride("异界浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultBed"))
				{
					item.SetNameOverride("异界床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultBookcase"))
				{
					item.SetNameOverride("异界书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultCandelabra"))
				{
					item.SetNameOverride("异界烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultCandle"))
				{
					item.SetNameOverride("异界蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultChair"))
				{
					item.SetNameOverride("异界椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultChandelier"))
				{
					item.SetNameOverride("异界吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultChest"))
				{
					item.SetNameOverride("异界宝箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultClock"))
				{
					item.SetNameOverride("异界钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultDoor"))
				{
					item.SetNameOverride("异界门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultDresser"))
				{
					item.SetNameOverride("异界梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultLamp"))
				{
					item.SetNameOverride("异界灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultLantern"))
				{
					item.SetNameOverride("异界灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultPiano"))
				{
					item.SetNameOverride("异界钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultPlatform"))
				{
					item.SetNameOverride("异界平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultSink"))
				{
					item.SetNameOverride("异界水池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultSofa"))
				{
					item.SetNameOverride("异界沙发");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultWorkBench"))
				{
					item.SetNameOverride("异界工作台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultStone"))
				{
					item.SetNameOverride("异界石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultStoneWall"))
				{
					item.SetNameOverride("异界石墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultTable"))
				{
					item.SetNameOverride("异界桌");
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && item.type == ModLoader.GetMod("CalamityMod").ItemType("OccultSink"))
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
