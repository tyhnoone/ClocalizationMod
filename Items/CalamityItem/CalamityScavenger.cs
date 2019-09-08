using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityScavenger : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientMedallion"))
				{
					item.SetNameOverride("远古徽章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodPact"))
				{
					item.SetNameOverride("血契");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FleshTotem"))
				{
					item.SetNameOverride("血肉图腾");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RavagerBag"))
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
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientMedallion"))
					{
						if (tooltipLine.text == "A very old temple medallion")
						{
							tooltipLine.text = "很古老的神庙纹章";
						}
						if (tooltipLine.text == "Summons the Ravager")
						{
							tooltipLine.text = "召唤毁灭魔像";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodPact"))
					{
						if (tooltipLine.text == "Doubles your max HP")
						{
							tooltipLine.text = "血量加倍";
						}
						if (tooltipLine.text == "Allows you to be critically hit 25% of the time")
						{
							tooltipLine.text = "同时你也有25%的几率受到暴击伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FleshTotem"))
					{
						if (tooltipLine.text == "Halves enemy contact damage")
						{
							tooltipLine.text = "减半敌人的碰触伤害";
						}
						if (tooltipLine.text == "When you take contact damage this effect has a 20 second cooldown")
						{
							tooltipLine.text = "受到一次接触攻击后，这个效果会有20秒的CD才能再次触发";
						}
					}
				}
			}
		}
	}
}
