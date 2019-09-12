using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsRavager : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Hematemesis"))
				{
					item.SetNameOverride("呕血");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RealmRavager"))
				{
					item.SetNameOverride("灭域者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SpikecragStaff"))
				{
					item.SetNameOverride("地刺王法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UltimusCleaver"))
				{
					item.SetNameOverride("终结屠刀");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Hematemesis"))
					{
						if (tooltipLine.text == "Casts a barrage of blood geysers from below you")
						{
							tooltipLine.text = "从你下面射出一道血泉";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RealmRavager"))
					{
						if (tooltipLine.text == "Shoots a burst of explosive bullets")
						{
							tooltipLine.text = "发射一团爆炸弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SpikecragStaff"))
					{
						if (tooltipLine.text == "Summons a spikecrag to protect you")
						{
							tooltipLine.text = "召唤地刺王保护你";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SpikecragStaff"))
					{
						if (tooltipLine.text == "Launches damaging sparks when the player walks on the ground with this weapon out")
						{
							tooltipLine.text = "举起武器行走时，释放火花";
						}
					}
				}
			}
		}
	}
}
