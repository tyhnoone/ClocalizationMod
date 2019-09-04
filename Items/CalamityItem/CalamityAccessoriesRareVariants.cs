using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAccessoriesRareVariants : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeepDiver"))
				{
					item.SetNameOverride("深潜者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FabledTortoiseShell"))
				{
					item.SetNameOverride("寓言龟壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HideofAstrumDeus"))
				{
					item.SetNameOverride("星神游龙外壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Regenator"))
				{
					item.SetNameOverride("再生器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SamuraiBadge"))
				{
					item.SetNameOverride("武士勋章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheBee"))
				{
					item.SetNameOverride("蜜蜂之祝福");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheEvolution"))
				{
					item.SetNameOverride("进化之石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheTransformer"))
				{
					item.SetNameOverride("变压器");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeepDiver"))
					{
						if (tooltipLine.text == "15% increased damage, defense, and movement speed when underwater")
						{
							tooltipLine.text = "在水下增加15%伤害，防御及移速";
						}
						if (tooltipLine.text == "While underwater you gain the ability to dash great distances")
						{
							tooltipLine.text = "在水下时获得冲刺的能力";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FabledTortoiseShell"))
					{
						if (tooltipLine.text == "50% reduced movement speed")
						{
							tooltipLine.text = "减少50%移速";
						}
						if (tooltipLine.text == "Enemies take damage when they hit you")
						{
							tooltipLine.text = "敌人攻击你时会受到伤害";
						}
						if (tooltipLine.text == "You move quickly for a short time if you take damage")
						{
							tooltipLine.text = "受到伤害时，移速会暂时增强";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HideofAstrumDeus"))
					{
						if (tooltipLine.text == "Taking damage drops an immense amount of astral stars from the sky and boosts true melee damage by 200% for a time")
						{
							tooltipLine.text = "受到伤害会从天上召唤彗星下落，短时间内真实近战伤害（武器本体伤害）翻倍";
						}
						if (tooltipLine.text == "Boost duration is based on the amount of damage you took, the higher the damage the longer the boost")
						{
							tooltipLine.text = "增幅的时长取决于你受到的伤害量，受到的伤害越高，增幅时间越长";
						}
						if (tooltipLine.text == "Provides immunity to the astral infection, cursed inferno, on fire, and frostburn debuffs")
						{
							tooltipLine.text = "免疫星体感染，诅咒之炎，着火和霜火debuff";
						}
						if (tooltipLine.text == "Enemies take damage when they hit you and are inflicted with the astral infection debuff")
						{
							tooltipLine.text = "敌人攻击你时会受到伤害，并受到星体感染Debuff";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Regenator"))
					{
						if (tooltipLine.text == "Reduces max HP by 50% but greatly improves life regeneration")
						{
							tooltipLine.text = "最大生命值减半，但大幅增加生命恢复速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SamuraiBadge"))
					{
						if (tooltipLine.text == "20% increased melee damage and speed")
						{
							tooltipLine.text = "增加20%近战伤害和攻速";
						}
						if (tooltipLine.text == "Reduces max life by 25%")
						{
							tooltipLine.text = "减少25%最大生命值";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheBee"))
					{
						if (tooltipLine.text == "Causes stars to fall and releases bees when injured")
						{
							tooltipLine.text = "受伤时会有彗星坠落并释放蜜蜂";
						}
						if (tooltipLine.text == "All projectiles gain bonus damage if you are at full HP")
						{
							tooltipLine.text = "满血时，所有弹幕获得额外伤害";
						}
						if (tooltipLine.text == "The amount of bonus damage is based on your weapon's damage and fire rate")
						{
							tooltipLine.text = "额外伤害的数量取决于你的武器面板伤害和攻击速度";
						}
						if (tooltipLine.text == "Does not work with summons or sentries")
						{
							tooltipLine.text = "此效果对召唤物或炮台无效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheEvolution"))
					{
						if (tooltipLine.text == "You have a 50% chance to reflect projectiles when they hit you back at the enemy for 1000% their original damage")
						{
							tooltipLine.text = "你有50%几率反弹弹幕，反弹伤害为原弹幕伤害的十倍";
						}
						if (tooltipLine.text == "If this effect triggers you get a health regeneration boost for a short time")
						{
							tooltipLine.text = "如果此能力生效，短时间内增加生命恢复速度";
						}
						if (tooltipLine.text == "If the same enemy projectile type hits you again you will resist its damage by 15%")
						{
							tooltipLine.text = "如果同样的弹幕再次击中你，此敌人弹幕伤害减少15%";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheTransformer"))
					{
						if (tooltipLine.text == "Taking damage releases a blast of sparks")
						{
							tooltipLine.text = "受到伤害后会释放电火花爆炸";
						}
						if (tooltipLine.text == "Sparks do extra damage in Hardmode")
						{
							tooltipLine.text = "困难模式下(肉后)电火花造成伤害更高";
						}
						if (tooltipLine.text == "Immunity to Electrified and you resist all elctrical projectile and enemy damage")
						{
							tooltipLine.text = "免疫电击debuff并对所有具有电击属性的弹幕和敌人伤害增加抗性";
						}
						if (tooltipLine.text == "Enemy bullets do half damage to you and are reflected back at the enemy for 800% their original damage")
						{
							tooltipLine.text = "敌人的子弹只对你造成一半的伤害，反弹8倍的原伤害";
						}
					}
				}
			}
		}
	}
}
