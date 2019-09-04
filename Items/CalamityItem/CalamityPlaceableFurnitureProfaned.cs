using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000031 RID: 49
	public class CalamityPlaceableFurnitureProfaned : GlobalItem
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000D588 File Offset: 0x0000B788
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedBasin"))
				{
					item.SetNameOverride("渎神坩埚");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedBath"))
				{
					item.SetNameOverride("渎神浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedBed"))
				{
					item.SetNameOverride("渎神床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedBench"))
				{
					item.SetNameOverride("渎神凳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedBookcase"))
				{
					item.SetNameOverride("渎神书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCandelabra"))
				{
					item.SetNameOverride("渎神烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCandle"))
				{
					item.SetNameOverride("渎神蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedChair"))
				{
					item.SetNameOverride("渎神椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedChandelier"))
				{
					item.SetNameOverride("渎神吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedChest"))
				{
					item.SetNameOverride("渎神宝箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedClock"))
				{
					item.SetNameOverride("渎神钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCrystal"))
				{
					item.SetNameOverride("渎神圣晶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCrystalWall"))
				{
					item.SetNameOverride("渎神圣晶墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedDoor"))
				{
					item.SetNameOverride("渎神门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedDresser"))
				{
					item.SetNameOverride("渎神梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedLamp"))
				{
					item.SetNameOverride("渎神灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedLantern"))
				{
					item.SetNameOverride("渎神灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedPiano"))
				{
					item.SetNameOverride("渎神钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedPlatform"))
				{
					item.SetNameOverride("渎神平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedRock"))
				{
					item.SetNameOverride("亵渎天石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedRockWall"))
				{
					item.SetNameOverride("亵渎天墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedSink"))
				{
					item.SetNameOverride("渎神熔岩池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedSlab"))
				{
					item.SetNameOverride("渎神石板");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedSlabWall"))
				{
					item.SetNameOverride("渎神石板墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedTable"))
				{
					item.SetNameOverride("渎神桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedWorkbench"))
				{
					item.SetNameOverride("渎神工作台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RunicProfanedBrick"))
				{
					item.SetNameOverride("亵渎符砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RunicProfanedBrickWall"))
				{
					item.SetNameOverride("亵渎符砖墙");
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000D9FC File Offset: 0x0000BBFC
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedBasin"))
				{
					foreach (TooltipLine tooltip in tooltips)
					{
						if (tooltip.Name == "Tooltip0")
						{
							tooltip.text = "用于打造特定家具";
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedSink"))
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
