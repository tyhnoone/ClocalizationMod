using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityCalamitas : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlightedEyeball"))
				{
					item.SetNameOverride("荒芜之眼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitasBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamityDust"))
				{
					item.SetNameOverride("灾厄尘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamityRing"))
				{
					item.SetNameOverride("灾劫虚空");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaosStone"))
				{
					item.SetNameOverride("混乱石");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlightedEyeball"))
					{
						if (tooltipLine.text == "Tonight is going to be a horrific night...")
						{
							tooltipLine.text = "这将会是一个恐怖的夜晚...";
						}
						if (tooltipLine.text == "Summons Calamitas")
						{
							tooltipLine.text = "召唤灾厄之影";
						}
						if (tooltipLine.text == "Not consumable")
						{
							tooltipLine.text = "不消耗";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamityRing"))
					{
						if (tooltipLine.text == "Cursed?")
						{
							tooltipLine.text = "受到诅咒?";
						}
						if (tooltipLine.text == "15% increase to all damage")
						{
							tooltipLine.text = "增加15%所有伤害";
						}
						if (tooltipLine.text == "Brimstone fire rains down while invincibility is active")
						{
							tooltipLine.text = "被攻击后的无敌时间内会降下硫磺火雨";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaosStone"))
					{
						if (tooltipLine.text == "One of the ancient relics")
						{
							tooltipLine.text = "远古遗物之一";
						}
						if (tooltipLine.text == "Increases max mana by 50, all damage by 3%, and reduces mana usage by 5%")
						{
							tooltipLine.text = "增加50魔力上限，3%所有伤害并减少5%的魔法消耗";
						}
					}
				}
			}
		}
	}
}
