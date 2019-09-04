using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAmmo : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralSolution"))
				{
					item.SetNameOverride("星炫溶剂");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralSolution"))
					{
						if (tooltipLine.text == "Used by the Clentaminator.")
						{
							tooltipLine.text = "用于环境改造枪";
						}
						if (tooltipLine.text == "Spreads the Astral.")
						{
							tooltipLine.text = "扩散彗星地";
						}
					}
				}
			}
		}
	}
}
