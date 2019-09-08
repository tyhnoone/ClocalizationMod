using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityProfanedShard : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedShard"))
				{
					item.SetNameOverride("亵渎碎片");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedShard"))
					{
						if (tooltipLine.text == "A shard of the unholy flame")
						{
							tooltipLine.text = "自亵渎之火衍生出的碎片";
						}
						if (tooltipLine.text == "Summons the Profaned Guardians")
						{
							tooltipLine.text = "召唤亵渎守卫";
						}
						if (tooltipLine.text == "Can only be used during daytime")
						{
							tooltipLine.text = "只能在白天使用";
						}
					}
				}
			}
		}
	}
}
