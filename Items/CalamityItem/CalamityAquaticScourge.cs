using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAquaticScourge : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquaticEmblem"))
				{
					item.SetNameOverride("海波纹章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquaticScourgeBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Seafood"))
				{
					item.SetNameOverride("海鲜饵料");
				}
			}
			
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquaticEmblem"))
					{
						if (tooltipLine.text == "Moderately reduces breath loss in the abyss")
						{
							tooltipLine.text = "在深渊适度降低呼吸槽消耗率";
						}
						if (tooltipLine.text == "Most ocean enemies become friendly and provides waterbreathing")
						{
							tooltipLine.text = "多数海洋生物变得友好，并提供水下呼吸";
						}
						if (tooltipLine.text == "Being underwater slowly boosts your defense over time but also slows movement speed")
						{
							tooltipLine.text = "在水下随着时间缓慢增加你的防御并降低移速";
						}
						if (tooltipLine.text == "The defense boost and movement speed reduction slowly vanish while outside of water")
						{
							tooltipLine.text = "防御增加和移速降低效果在离开水面后缓慢消失";
						}
						if (tooltipLine.text == "Maximum defense boost is 30, maximum movement speed reduction is 5%")
						{
							tooltipLine.text = "最多增加30点防御，最多降低5%移速";
						}
						if (tooltipLine.text == "Provides a small amount of light in the abyss")
						{
							tooltipLine.text = "在深渊里提供微弱的光照";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Seafood"))
					{
						if (tooltipLine.text == "The sulphuric sand stirs...")
						{
							tooltipLine.text = "混着一堆硫磺沙粒...";
						}
						if (tooltipLine.text == "Summons the Aquatic Scourge")
						{
							tooltipLine.text = "召唤渊海灾虫";
						}
					}
				}
			}
		}
	}
}
