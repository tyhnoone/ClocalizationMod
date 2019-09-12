using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsCalamitas : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlightedEyeStaff"))
				{
					item.SetNameOverride("混乱守夜者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneFlameblaster"))
				{
					item.SetNameOverride("硫磺火焰喷射器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneFlamesprayer"))
				{
					item.SetNameOverride("浩劫之息");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitasInferno"))
				{
					item.SetNameOverride("混乱火鞭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheEyeofCalamitas"))
				{
					item.SetNameOverride("被遗忘者");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlightedEyeStaff"))
					{
						if (tooltipLine.text == "Summons Calamitas and her brothers to protect you")
						{
							tooltipLine.text = "召唤灾厄以及她的兄弟为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneFlameblaster"))
					{
						if (tooltipLine.text == "Fires bouncing brimstone fireballs")
						{
							tooltipLine.text = "发射弹跳硫磺火球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitasInferno"))
					{
						if (tooltipLine.text == "Watch the world burn...")
						{
							tooltipLine.text = "静看着整个世界的燃烧...";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheEyeofCalamitas"))
					{
						if (tooltipLine.text == "Fires brimstone lasers when enemies are near")
						{
							tooltipLine.text = "当敌人靠近时发射硫磺火激光";
						}
					}
				}
			}
		}
	}
}
