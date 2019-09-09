using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityPolterghast : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Affliction"))
				{
					item.SetNameOverride("苦难");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NecroplasmicBeacon"))
				{
					item.SetNameOverride("幽花灵火");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PolterghastBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RuinousSoul"))
				{
					item.SetNameOverride("毁灭之灵");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Affliction"))
					{
						if (tooltipLine.text == "Gives you and all other players on your team +1 life regen,")
						{
							tooltipLine.text = "令你和你的队友增加1生命恢复";
						}
						if (tooltipLine.text == "+5% max life, 5% damage reduction, 15 defense, and 10% increased damage")
						{
							tooltipLine.text = "+5%生命上限，增加5%伤害减免，15防御，以及10%伤害";
						}
						if (tooltipLine.text == "These effects are stronger on revengeance mode")
						{
							tooltipLine.text = "复仇模式里这些效果加强";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NecroplasmicBeacon"))
					{
						if (tooltipLine.text == "It's spooky")
						{
							tooltipLine.text = "毛骨悚然";
						}
						if (tooltipLine.text == "Summons Polterghast")
						{
							tooltipLine.text = "召唤噬魂幽花";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RuinousSoul"))
					{
						if (tooltipLine.text == "A shard of the distant past")
						{
							tooltipLine.text = "来自遥远过去的碎片";
						}
					}
				}
			}
		}
	}
}
