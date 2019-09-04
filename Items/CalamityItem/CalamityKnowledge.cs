using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityKnowledge : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge"))
				{
					item.SetNameOverride("荒漠灾虫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge2"))
				{
					item.SetNameOverride("猪鲨公爵");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge"))
					{
						if (tooltipLine.text == "The great sea worm appears to have survived the extreme heat and has even adapted to it.")
						{
							tooltipLine.text = "庞大的海虫似乎从极度的炎热之中存活下来了，甚至完全适应了此处";
						}
						if (tooltipLine.text == "What used to be a majestic beast swimming through the water has now become a dried-up and")
						{
							tooltipLine.text = "曾于水中畅游的巨兽现如今变得干燥而贪食";
						}
						if (tooltipLine.text == "gluttonous husk, constantly on a voracious search for its next meal.")
						{
							tooltipLine.text = "他不断地寻找着下一顿美餐";
						}
						if (tooltipLine.text == "Place in your inventory for an increase to defense while in the desert or sunken sea.")
						{
							tooltipLine.text = "在沙漠或沉沦之海中增加防御，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge2"))
					{
						if (tooltipLine.text == "The mutant terror of the sea was once the trusted companion of an old king; he tamed it using its favorite treat.")
						{
							tooltipLine.text = "这个来自大海的象征着恐惧的畸变生物是曾经某位旧主的可靠伙伴；他用它最喜爱的食物驯养着它";
						}
						if (tooltipLine.text == "Long ago, the creature flew in desperation from the raging bloody inferno consuming its home, ultimately finding its way to the ocean.")
						{
							tooltipLine.text = "很久以前，这只生物绝望的飞离了被硫磺火蒸腾的大海。那是它曾经的家乡，而他不得不另寻住处";
						}
						if (tooltipLine.text == "Place in your inventory for an increase to all damage, crit, and movement speed while submerged in liquid.")
						{
							tooltipLine.text = "在水中增加所有伤害，暴击率和移速，放在背包中会生效";
						}
					}
				}
			}
		}
	}
}
