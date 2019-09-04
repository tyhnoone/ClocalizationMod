using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAstrumDeus : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstrumDeusBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Starcore"))
				{
					item.SetNameOverride("星核");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Starcore"))
					{
						if (tooltipLine.text == "May the stars guide your way")
						{
							tooltipLine.text = "愿群星指引你的前路";
						}
						if (tooltipLine.text == "Summons Astrum Deus")
						{
							tooltipLine.text = "召唤星神游龙";
						}
						if (tooltipLine.text == "Not consumable")
						{
							tooltipLine.text = "不消耗";
						}
					}
				}
			}
		}
	}
}
