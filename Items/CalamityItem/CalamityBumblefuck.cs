using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityBumblefuck : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BirbPheromones"))
				{
					item.SetNameOverride("飞禽激素");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BumblebirbBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EffulgentFeather"))
				{
					item.SetNameOverride("闪耀金羽");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BirbPheromones"))
					{
						if (tooltipLine.text == "Attracts the bumbling birb")
						{
							tooltipLine.text = "吸引嗡嗡蜂鸟";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EffulgentFeather"))
					{
						if (tooltipLine.text == "It vibrates with fluffy golden energy")
						{
							tooltipLine.text = "流动着蓬松的金色能量";
						}
					}
				}
			}
		}
	}
}
