using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x0200002C RID: 44
	public class CalamityPlaceableFurnitureBotanic : GlobalItem
	{
		// Token: 0x0600005D RID: 93 RVA: 0x0000BF7C File Offset: 0x0000A17C
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicBathtub"))
				{
					item.SetNameOverride("蒿蔓浴缸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicBed"))
				{
					item.SetNameOverride("蒿蔓床");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicBench"))
				{
					item.SetNameOverride("蒿蔓凳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicBookcase"))
				{
					item.SetNameOverride("蒿蔓书架");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicCandelabra"))
				{
					item.SetNameOverride("蒿蔓烛台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicCandle"))
				{
					item.SetNameOverride("蒿蔓蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicChair"))
				{
					item.SetNameOverride("蒿蔓椅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicChandelier"))
				{
					item.SetNameOverride("蒿蔓吊灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicChest"))
				{
					item.SetNameOverride("蒿蔓宝箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicClock"))
				{
					item.SetNameOverride("蒿蔓钟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicDoor"))
				{
					item.SetNameOverride("蒿蔓门");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicDresser"))
				{
					item.SetNameOverride("蒿蔓梳妆台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicLamp"))
				{
					item.SetNameOverride("蒿蔓灯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicLantern"))
				{
					item.SetNameOverride("蒿蔓灯笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicPiano"))
				{
					item.SetNameOverride("蒿蔓钢琴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicPlanter"))
				{
					item.SetNameOverride("蒿蔓培植基");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicPlatform"))
				{
					item.SetNameOverride("蒿蔓平台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicSink"))
				{
					item.SetNameOverride("蒿蔓蜂蜜池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicTable"))
				{
					item.SetNameOverride("蒿蔓桌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicWorkBench"))
				{
					item.SetNameOverride("蒿蔓工作台");
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicPlanter"))
				{
					foreach (TooltipLine tooltip in tooltips)
					{
						if (tooltip.Name == "Tooltip0")
						{
							tooltip.text = "用于打造特定家具";
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BotanicSink"))
				{
					foreach (TooltipLine tooltip2 in tooltips)
					{
						if (tooltip2.Name == "Tooltip0")
						{
							tooltip2.text = "视作蜂蜜源";
						}
					}
				}
			}
		}
	}
}
