using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityPerforator : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodSample"))
				{
					item.SetNameOverride("血液样本");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyWormFood"))
				{
					item.SetNameOverride("血蠕虫诱饵");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyWormTooth"))
				{
					item.SetNameOverride("血蠕虫之牙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerforatorBag"))
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
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyWormFood"))
					{
						if (tooltipLine.text == "Summons the Perforator Hive")
						{
							tooltipLine.text = "召唤血肉宿主";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyWormTooth"))
					{
						if (tooltipLine.text == "5% increased damage reduction and increased melee stats")
						{
							tooltipLine.text = "增加5%伤害减免，增强你的近战属性";
						}
						if (tooltipLine.text == "10% increased damage reduction and melee stats when below 50% life")
						{
							tooltipLine.text = "低于50%生命时增加10%伤害减免";
						}
					}
				}
			}
		}
	}
}
