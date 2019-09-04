using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x0200002E RID: 46
	public class CalamityPlaceableFurnitureEutrophic : GlobalItem
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicBathtub"))
				{
					item.SetNameOverride("富养渊浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicBed"))
				{
					item.SetNameOverride("富养渊床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicBench"))
				{
					item.SetNameOverride("富养渊凳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicBookcase"))
				{
					item.SetNameOverride("富养渊书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicCandelabra"))
				{
					item.SetNameOverride("富养渊烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicCandle"))
				{
					item.SetNameOverride("富养渊蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicChair"))
				{
					item.SetNameOverride("富养渊椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicChandelier"))
				{
					item.SetNameOverride("富养渊吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicChest"))
				{
					item.SetNameOverride("富养渊宝箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicClock"))
				{
					item.SetNameOverride("富养渊钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicDoor"))
				{
					item.SetNameOverride("富养渊门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicDresser"))
				{
					item.SetNameOverride("富养渊梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicLamp"))
				{
					item.SetNameOverride("富养渊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicLantern"))
				{
					item.SetNameOverride("富养渊灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicPiano"))
				{
					item.SetNameOverride("富养渊钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicCrafting"))
				{
					item.SetNameOverride("富养渊制作台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicPlatform"))
				{
					item.SetNameOverride("富养渊平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicSink"))
				{
					item.SetNameOverride("富养渊水池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicTable"))
				{
					item.SetNameOverride("富养渊桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicWorkBench"))
				{
					item.SetNameOverride("富养渊工作台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SmoothNavystone"))
				{
					item.SetNameOverride("光滑沉沦渊石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SmoothNavystoneWall"))
				{
					item.SetNameOverride("光滑沉沦渊石墙");
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000CB84 File Offset: 0x0000AD84
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicCrafting"))
				{
					foreach (TooltipLine tooltip in tooltips)
					{
						if (tooltip.Name == "Tooltip0")
						{
							tooltip.text = "用于打造特定家具";
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicSink"))
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
