using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityYharon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChickenEgg"))
				{
					item.SetNameOverride("丛林龙蛋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HellcasterFragment"))
				{
					item.SetNameOverride("犽戎碎魂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharimsGift"))
				{
					item.SetNameOverride("犽戾武之赠礼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharonBag"))
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
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChickenEgg"))
					{
						if (tooltipLine.text == "Summons the loyal guardian of the tyrant king")
						{
							tooltipLine.text = "召唤暴君的守卫者";
						}
						if (tooltipLine.text == "It yearns for the jungle")
						{
							tooltipLine.text = "它渴望丛林";
						}
						if (tooltipLine.text == "Not consumable")
						{
							tooltipLine.text = "无消耗";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HellcasterFragment"))
					{
						if (tooltipLine.text == "A shard of a godly soul")
						{
							tooltipLine.text = "神明灵魂的一片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharimsGift"))
					{
						if (tooltipLine.text == "The power of a god pulses from within this artifact")
						{
							tooltipLine.text = "神之力在此物中涌动";
						}
						if (tooltipLine.text == "Flaming meteors rain down while invincibility is active")
						{
							tooltipLine.text = "受伤后无敌时间内降下燃火流星";
						}
						if (tooltipLine.text == "Exploding dragon dust is left behind as you move")
						{
							tooltipLine.text = "移动时身后留下爆裂龙尘";
						}
						if (tooltipLine.text == "Defense increased by 30 and damage increased by 15%")
						{
							tooltipLine.text = "增加30防御和15%所有伤害";
						}
					}
				}
			}
		}
	}
}
