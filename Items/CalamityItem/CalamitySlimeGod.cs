using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamitySlimeGod : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ManaOverloader"))
				{
					item.SetNameOverride("魔力超载仪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OverloadedSludge"))
				{
					item.SetNameOverride("过载淤泥");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PurifiedGel"))
				{
					item.SetNameOverride("纯净凝胶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SlimeGodBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ManaOverloader"))
					{
						if (tooltipLine.text == "Increases max mana by 50 and magic damage by 6%")
						{
							tooltipLine.text = "+50魔力上限，增加6%魔法伤害";
						}
						if (tooltipLine.text == "Life regen lowered by 3 if mana is above 50% of its maximum")
						{
							tooltipLine.text = "如果魔力值超过最大值的50%，生命回复值降低3";
						}
						if (tooltipLine.text == "Spectre healing if mana is below 10% of its maximum")
						{
							tooltipLine.text = "低于10%魔力时，你的魔法攻击可以汲取生命";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OverloadedSludge"))
					{
						if (tooltipLine.text == "It looks corrupted")
						{
							tooltipLine.text = "看起来被腐化了";
						}
						if (tooltipLine.text == "Summons the Slime God")
						{
							tooltipLine.text = "召唤史莱姆之神";
						}
					}
				}
			}
		}
	}
}
