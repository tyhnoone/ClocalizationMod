using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityweaponsDesertScourge : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquaticDischarge"))
				{
					item.SetNameOverride("水电剑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Barinade"))
				{
					item.SetNameOverride("巴淋内德");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeaboundStaff"))
				{
					item.SetNameOverride("海星召唤杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StormSpray"))
				{
					item.SetNameOverride("水流喷射");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquaticDischarge"))
					{
						if (tooltipLine.text == "Enemies release electric sparks on death")
						{
							tooltipLine.text = "敌人死亡时散发电火花";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Barinade"))
					{
						if (tooltipLine.text == "Shoots electric bolt arrows that explode")
						{
							tooltipLine.text = "射出由闪电凝结成的弓箭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeaboundStaff"))
					{
						if (tooltipLine.text == "Summons a brittle star to fight for you")
						{
							tooltipLine.text = "召唤海星为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StormSpray"))
					{
						if (tooltipLine.text == "Fires a spray of water that drips extra trails of water")
						{
							tooltipLine.text = "发射一个会额外溅射的水柱";
						}
					}
				}
			}
		}
	}
}
