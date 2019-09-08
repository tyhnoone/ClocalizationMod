using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityTheDevourerofGods : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmicWorm"))
				{
					item.SetNameOverride("宇宙之虫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBar"))
				{
					item.SetNameOverride("宇宙锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DevourerofGodsBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NebulousCore"))
				{
					item.SetNameOverride("星云之核");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmicWorm"))
					{
						if (tooltipLine.text == "Summons the Devourer of Gods")
						{
							tooltipLine.text = "召唤神明吞噬者";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmiliteBar"))
					{
						if (tooltipLine.text == "A chunk of highly-resistant cosmic steel")
						{
							tooltipLine.text = "一团高硬度的宇宙金属";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NebulousCore"))
					{
						if (tooltipLine.text == "12% increased damage")
						{
							tooltipLine.text = "增加12%伤害";
						}
						if (tooltipLine.text == "Summons floating nebula stars to protect you")
						{
							tooltipLine.text = "召唤漂浮的小星云保护你";
						}
						if (tooltipLine.text == "You have a 10% chance to survive an attack that would have killed you")
						{
							tooltipLine.text = "受到致死伤害时有10%的几率闪避";
						}
						if (tooltipLine.text == "If this effect activates you will be healed by 100 HPu")
						{
							tooltipLine.text = "如果此效果被激发，你会瞬间回复100血";
						}
					}
				}
			}
		}
	}
}
