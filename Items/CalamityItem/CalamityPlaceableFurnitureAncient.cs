using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x0200002A RID: 42
	public class CalamityPlaceableFurnitureAncient : GlobalItem
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000B664 File Offset: 0x00009864
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientAltar"))
				{
					item.SetNameOverride("硫古铸祭台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientBasin"))
				{
					item.SetNameOverride("硫古盆");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientBath"))
				{
					item.SetNameOverride("硫古浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientBed"))
				{
					item.SetNameOverride("硫古床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientBookcase"))
				{
					item.SetNameOverride("硫古书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientChair"))
				{
					item.SetNameOverride("硫古椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientChandelier"))
				{
					item.SetNameOverride("硫古吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientDoor"))
				{
					item.SetNameOverride("硫古门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientDresser"))
				{
					item.SetNameOverride("硫古梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientLamp"))
				{
					item.SetNameOverride("硫古灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientLantern"))
				{
					item.SetNameOverride("硫古灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientMonolith"))
				{
					item.SetNameOverride("硫古巨柱钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientPiano"))
				{
					item.SetNameOverride("硫古钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientSink"))
				{
					item.SetNameOverride("硫古熔岩池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientSofa"))
				{
					item.SetNameOverride("硫古沙发");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientTable"))
				{
					item.SetNameOverride("硫古桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientWorkbench"))
				{
					item.SetNameOverride("硫古工作台");
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000B92C File Offset: 0x00009B2C
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientAltar"))
				{
					foreach (TooltipLine tooltip in tooltips)
					{
						if (tooltip.Name == "Tooltip0")
						{
							tooltip.text = "用于打造特定家具";
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientSink"))
				{
					foreach (TooltipLine tooltip2 in tooltips)
					{
						if (tooltip2.Name == "Tooltip0")
						{
							tooltip2.text = "视作岩浆源";
						}
					}
				}
			}
		}
	}
}
