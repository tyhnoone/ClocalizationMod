using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityCalamityCustomThrowingDamagePatreon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorpusAvertor"))
				{
					item.SetNameOverride("血魔匕首");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeepSeaDumbbell"))
				{
					item.SetNameOverride("深海哑铃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("KelvinCatalyst"))
				{
					item.SetNameOverride("开尔文诱变刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Plaguenade"))
				{
					item.SetNameOverride("瘟疫蜂雷");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TimeBolt"))
				{
					item.SetNameOverride("时之匕");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorpusAvertor"))
					{
						if (tooltipLine.text == "Seems like it has worn down over time")
						{
							tooltipLine.text = "似乎它已经磨损了一段时间了";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeepSeaDumbbell"))
					{
						if (tooltipLine.text == "Throws a dumbbell that bounces and flings weights with each bounce")
						{
							tooltipLine.text = "投掷一个反弹的哑铃，每次反弹时都会投出重物";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("KelvinCatalyst"))
					{
						if (tooltipLine.text == "Throws an icy blade that splits into multiple ice stars on enemy hits")
						{
							tooltipLine.text = "投掷一个冰刃，在命中敌人时分裂成多个冰星";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Plaguenade"))
					{
						if (tooltipLine.text == "Releases a swarm of angry plague bees")
						{
							tooltipLine.text = "释放大量愤怒的瘟疫蜂";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TimeBolt"))
					{
						if (tooltipLine.text == "There should be no boundary to human endeavor.")
						{
							tooltipLine.text = "人类的努力是无垠的（译注：出自电影《万物理论》的一句台词）";
						}
					}
				}
			}
		}
	}
}
