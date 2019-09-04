using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityHiveMind : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HiveMindBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RottenBrain"))
				{
					item.SetNameOverride("腐烂之脑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Teratoma"))
				{
					item.SetNameOverride("畸形肿瘤");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrueShadowScale"))
				{
					item.SetNameOverride("真·暗影鳞片");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RottenBrain"))
					{
						if (tooltipLine.text == "10% increased damage when below 75% life")
						{
							tooltipLine.text = "低于75%生命值时增加10%伤害";
						}
						if (tooltipLine.text == "5% decreased movement speed when below 50% life")
						{
							tooltipLine.text = "低于50%生命时减少5%移速";
						}
						if (tooltipLine.text == "Shade rains down when you are hit")
						{
							tooltipLine.text = "受到伤害时降落暗影雨";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Teratoma"))
					{
						if (tooltipLine.text == "Summons the Hive Mind")
						{
							tooltipLine.text = "召唤腐巢意志";
						}
					}
				}
			}
		}
	}
}
