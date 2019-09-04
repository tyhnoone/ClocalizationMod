using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityDevourerMunsters : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ArmoredShell"))
				{
					item.SetNameOverride("装甲外壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DarkPlasma"))
				{
					item.SetNameOverride("暗质离子气");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RuneofCos"))
				{
					item.SetNameOverride("宇宙符文");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TwistingNether"))
				{
					item.SetNameOverride("扭曲虚空");
				}
			}
			
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RuneofCos"))
					{
						if (tooltipLine.text == "A relic of the profaned flame")
						{
							tooltipLine.text = "亵渎圣焰的遗物";
						}
						if (tooltipLine.text == "Contains the power hunted relentlessly by the sentinels of the cosmic devourer")
						{
							tooltipLine.text = "含有神明吞噬者的部下无情猎寻的能量";
						}
						if (tooltipLine.text == "When used in certain areas of the world it will unleash them")
						{
							tooltipLine.text = "在世界上合适的地方使用就可以释放它们(注: 太空、地狱、地牢)";
						}
						if (tooltipLine.text == "Not consumable")
						{
							tooltipLine.text = "无消耗";
						}
					}
					
				}
			}
		}
	}
}
