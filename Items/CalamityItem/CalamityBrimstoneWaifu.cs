using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityBrimstoneWaifu : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Abaddon"))
				{
					item.SetNameOverride("亚伯顿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneWaifuBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CharredIdol"))
				{
					item.SetNameOverride("焦炭玩偶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Gehenna"))
				{
					item.SetNameOverride("焦热地狱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RoseStone"))
				{
					item.SetNameOverride("玫瑰石");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Abaddon"))
					{
						if (tooltipLine.text == "Makes you immune to Brimstone Flames")
						{
							tooltipLine.text = "免疫硫磺火";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CharredIdol"))
					{
						if (tooltipLine.text == "Use in the Brimstone Crag at your own risk")
						{
							tooltipLine.text = "在硫磺火之崖使用";
						}
						if (tooltipLine.text == "Summons the Brimstone Elemental")
						{
							tooltipLine.text = "召唤硫磺火元素";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Gehenna"))
					{
						if (tooltipLine.text == "Drops brimstone fireballs from the sky occasionally")
						{
							tooltipLine.text = "时不时降下硫磺火球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RoseStone"))
					{
						if (tooltipLine.text == "One of the ancient relics")
						{
							tooltipLine.text = "远古遗物之一";
						}
						if (tooltipLine.text == "Increases max life by 20, life regen by 1, and all damage by 3%")
						{
							tooltipLine.text = "增加20血量，1生命恢复速度以及3%伤害";
						}
						if (tooltipLine.text == "Summons a brimstone elemental to fight for you")
						{
							tooltipLine.text = "召唤一个硫磺火元素为你而战";
						}
					}
				}
			}
		}
	}
}
