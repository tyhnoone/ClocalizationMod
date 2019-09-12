using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityweaponAquaticScourge : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Barinautical"))
				{
					item.SetNameOverride("闪电箭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeepseaStaff"))
				{
					item.SetNameOverride("渊海权杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Downpour"))
				{
					item.SetNameOverride("倾盆暴雨");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SubmarineShocker"))
				{
					item.SetNameOverride("潜渊震荡者");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Barinautical"))
					{
						if (tooltipLine.text == "Shoots a string of electric bolt arrows that explode")
						{
							tooltipLine.text = "射出一串串爆炸的电子箭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeepseaStaff"))
					{
						if (tooltipLine.text == "Summons an aquatic star to fight for you")
						{
							tooltipLine.text = "召唤渊海海星为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Downpour"))
					{
						if (tooltipLine.text == "Fires a spray of water that drips extra trails of water")
						{
							tooltipLine.text = "发射会额外溅射的水柱";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SubmarineShocker"))
					{
						if (tooltipLine.text == "Enemies release electric sparks on hit")
						{
							tooltipLine.text = "敌人受到攻击时散发电火花";
						}
					}
				}
			}
		}
	}
}
