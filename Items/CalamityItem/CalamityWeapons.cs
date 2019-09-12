using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeapons : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssBlade"))
				{
					item.SetNameOverride("深渊之刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AccelerationBullet"))
				{
					item.SetNameOverride("加速弹");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AccretionDiskMelee"))
				{
					item.SetNameOverride("元素飞盘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AcidBullet"))
				{
					item.SetNameOverride("酸液弹");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AegisBlade"))
				{
					item.SetNameOverride("庇护之刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Aeries"))
				{
					item.SetNameOverride("白羊座");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssBlade"))
					{
						if (tooltipLine.text == "Hitting enemies will cause the crush depth debuff")
						{
							tooltipLine.text = "击中敌人会造成深渊重创debuff";
						}
						if (tooltipLine.text == "The lower the enemies' defense the more damage they take from this debuff")
						{
							tooltipLine.text = "敌人的防御越低，此debuff造成的伤害越高";
						}
						if (tooltipLine.text == "Fires short-range water orbs")
						{
							tooltipLine.text = "发射短距离水珠";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AccelerationBullet"))
					{
						if (tooltipLine.text == "Gains speed over time")
						{
							tooltipLine.text = "速度随时间加快";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AccretionDiskMelee"))
					{
						if (tooltipLine.text == "Throws a disk that has a chance to generate several disks if enemies are near it")
						{
							tooltipLine.text = "抛出一个有机会在敌人靠近时生成多个飞盘的飞盘";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AcidBullet"))
					{
						if (tooltipLine.text == "Explodes into acid that inflicts the plague")
						{
							tooltipLine.text = "爆裂出给敌人带来瘟疫的酸液";
						}
						if (tooltipLine.text == "Does more damage the higher the target's defense")
						{
							tooltipLine.text = "敌人的防御越高，造成的伤害越多";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AegisBlade"))
					{
						if (tooltipLine.text == "Striking an enemy with the blade causes an earthen eruption")
						{
							tooltipLine.text = "用剑击打敌人时，庇护之光会爆发出火焰";
						}
						if (tooltipLine.text == "Right click to fire an aegis bolt that costs 4 mana")
						{
							tooltipLine.text = "右键发射庇护之火，消耗4魔法";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Aeries"))
					{
						if (tooltipLine.text == "Fires shockblast rounds that can steal enemy life")
						{
							tooltipLine.text = "发射可以窃取敌人生命的冲击波子弹";
						}
					}
				}
			}
		}
	}
}
