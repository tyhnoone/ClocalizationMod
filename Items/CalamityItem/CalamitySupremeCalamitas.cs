using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamitySupremeCalamitas : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EyeofExtinction"))
				{
					item.SetNameOverride("灭世之眼");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EyeofExtinction"))
					{
						if (tooltipLine.text == "Death")
						{
							tooltipLine.text = "死亡";
						}
						if (tooltipLine.text == "Summons Supreme Calamitas")
						{
							tooltipLine.text = "召唤至尊灾厄之影";
						}
						if (tooltipLine.text == "Creates a large square arena of blocks around your player")
						{
							tooltipLine.text = "在玩家周围创造一个大型方型场地";
						}
						if (tooltipLine.text == "Your player is the CENTER of the arena so be sure to use this item in a good location")
						{
							tooltipLine.text = "玩家所处的位置会作为战斗场地的 中.心 ，请确定在合适的位置使用";
						}
					}
				}
			}
		}
	}
}
