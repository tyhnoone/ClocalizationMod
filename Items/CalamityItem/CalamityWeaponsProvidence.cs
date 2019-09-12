using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsProvidence : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlissfulBombardier"))
				{
					item.SetNameOverride("极乐升天炮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HolyCollider"))
				{
					item.SetNameOverride("圣火之刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PurgeGuzzler"))
				{
					item.SetNameOverride("净化激光炮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SolarFlare"))
				{
					item.SetNameOverride("炽日耀斑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TelluricGlare"))
				{
					item.SetNameOverride("大地耀光");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlissfulBombardier"))
					{
						if (tooltipLine.text == "Fires flare rockets")
						{
							tooltipLine.text = "发射闪耀火箭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HolyCollider"))
					{
						if (tooltipLine.text == "Striking enemies will cause them to explode into holy fire")
						{
							tooltipLine.text = "打击敌人会让他们被圣火点燃爆炸";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PurgeGuzzler"))
					{
						if (tooltipLine.text == "Fires three beams of holy energy")
						{
							tooltipLine.text = "发射三束圣火射线";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SolarFlare"))
					{
						if (tooltipLine.text == "Emits large holy explosions on enemy hits")
						{
							tooltipLine.text = "爆发出大量神圣火焰";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TelluricGlare"))
					{
						if (tooltipLine.text == "Shoots an extremely fast energy arrow")
						{
							tooltipLine.text = "射出一支极快的能量箭";
						}
					}
				}
			}
		}
	}
}
