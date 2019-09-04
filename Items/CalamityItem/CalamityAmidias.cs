using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAmidias : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UrchinFlail"))
				{
					item.SetNameOverride("海胆链球");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmidiasTrident"))
				{
					item.SetNameOverride("海王三叉戟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoralCannon"))
				{
					item.SetNameOverride("珊瑚炮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MagicalConch"))
				{
					item.SetNameOverride("魔法海螺");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Shellshooter"))
				{
					item.SetNameOverride("贝壳刃弓");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Waywasher"))
				{
					item.SetNameOverride("清道夫");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UrchinFlail"))
					{
						if (tooltipLine.text == "Launch an urchin ball, which shoots a spike on contact with an enemy")
						{
							tooltipLine.text = "掷出海胆链球，接触敌人时会发射针刺";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmidiasTrident"))
					{
						if (tooltipLine.text == "Shoots homing whirlpools")
						{
							tooltipLine.text = "发出追踪漩涡";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoralCannon"))
					{
						if (tooltipLine.text == "Has a chance to shoot a big coral that stuns enemies")
						{
							tooltipLine.text = "有几率发射一枚更大的珊瑚炮弹并晕眩敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MagicalConch"))
					{
						if (tooltipLine.text == "Summons a hermit crab to fight for you")
						{
							tooltipLine.text = "召唤寄居蟹为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Shellshooter"))
					{
						if (tooltipLine.text == "Shoots slow, powerful shells")
						{
							tooltipLine.text = "射出缓慢而强劲的贝壳";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Waywasher"))
					{
						if (tooltipLine.text == "Casts inaccurate water bolts")
						{
							tooltipLine.text = "施放并不精准的水矢";
						}
					}
				}
			}
		}
	}
}
