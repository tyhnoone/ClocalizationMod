using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAstrageldon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstrageldonBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralChunk"))
				{
					item.SetNameOverride("星辉凝块");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralJelly"))
				{
					item.SetNameOverride("星辉胶核");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralChunk"))
					{
						if (tooltipLine.text == "Summons Astrum Aureus")
						{
							tooltipLine.text = "召唤白金之星";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralJelly"))
					{
						if (tooltipLine.text == "Gives mana regeneration and magic power for 6 minutes")
						{
							tooltipLine.text = "提升魔法恢复速度和魔法力量，持续6分钟";
						}
					}
				}
			}
		}
	}
}
