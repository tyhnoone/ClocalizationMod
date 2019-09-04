using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityCrabulon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrabulonBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DecapoditaSprout"))
				{
					item.SetNameOverride("节支动物芽孢");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FungalClump"))
				{
					item.SetNameOverride("真菌块");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DecapoditaSprout"))
					{
						if (tooltipLine.text == "Summons Crabulon")
						{
							tooltipLine.text = "召唤蘑菇蟹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FungalClump"))
					{
						if (tooltipLine.text == "Summons a fungal clump to fight for you")
						{
							tooltipLine.text = "召唤一块真菌球为你而战";
						}
						if (tooltipLine.text == "The clump latches onto enemies and steals their life for you")
						{
							tooltipLine.text = "这球附着在敌人上并汲取生命治疗你";
						}
					}
				}
			}
		}
	}
}
