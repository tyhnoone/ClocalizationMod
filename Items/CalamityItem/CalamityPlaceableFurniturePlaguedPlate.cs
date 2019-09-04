using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000030 RID: 48
	public class CalamityPlaceableFurniturePlaguedPlate : GlobalItem
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000D09C File Offset: 0x0000B29C
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlate"))
				{
					item.SetNameOverride("瘟疫镀层");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateBasin"))
				{
					item.SetNameOverride("瘟疫盆");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateBathtub"))
				{
					item.SetNameOverride("瘟疫浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateBed"))
				{
					item.SetNameOverride("瘟疫床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateBookcase"))
				{
					item.SetNameOverride("瘟疫书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateCandelabra"))
				{
					item.SetNameOverride("瘟疫烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateCandle"))
				{
					item.SetNameOverride("瘟疫蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateChair"))
				{
					item.SetNameOverride("瘟疫椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateChandelier"))
				{
					item.SetNameOverride("瘟疫吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateChest"))
				{
					item.SetNameOverride("瘟疫宝箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateClock"))
				{
					item.SetNameOverride("瘟疫钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateDoor"))
				{
					item.SetNameOverride("瘟疫门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateDresser"))
				{
					item.SetNameOverride("瘟疫梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateLamp"))
				{
					item.SetNameOverride("瘟疫灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateLantern"))
				{
					item.SetNameOverride("瘟疫灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlatePiano"))
				{
					item.SetNameOverride("瘟疫钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlagueInfuser"))
				{
					item.SetNameOverride("瘟疫注射机");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlatePlatform"))
				{
					item.SetNameOverride("瘟疫平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateSink"))
				{
					item.SetNameOverride("瘟疫水池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateSofa"))
				{
					item.SetNameOverride("瘟疫沙发");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateTable"))
				{
					item.SetNameOverride("瘟疫桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateWall"))
				{
					item.SetNameOverride("瘟疫镀墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateWorkbench"))
				{
					item.SetNameOverride("瘟疫工作台");
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000D474 File Offset: 0x0000B674
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlagueInfuser"))
				{
					foreach (TooltipLine tooltip in tooltips)
					{
						if (tooltip.Name == "Tooltip0")
						{
							tooltip.text = "用于打造特定家具";
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguedPlateSink"))
				{
					foreach (TooltipLine tooltip2 in tooltips)
					{
						if (tooltip2.Name == "Tooltip0")
						{
							tooltip2.text = "视作水源";
						}
					}
				}
			}
		}
	}
}
