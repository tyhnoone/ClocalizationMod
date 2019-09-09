using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityPotions : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralInjection"))
				{
					item.SetNameOverride("幻星注射剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BoundingPotion"))
				{
					item.SetNameOverride("弹跳药水");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CadencePotion"))
				{
					item.SetNameOverride("尾音药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitasBrew"))
				{
					item.SetNameOverride("灾厄茶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalciumPotion"))
				{
					item.SetNameOverride("补钙药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CeaselessHungerPotion"))
				{
					item.SetNameOverride("无尽之饥药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrumblingPotion"))
				{
					item.SetNameOverride("崩碎药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraconicElixir"))
				{
					item.SetNameOverride("龙之仙品");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GravityNormalizerPotion"))
				{
					item.SetNameOverride("重力恢复药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HolyWrathPotion"))
				{
					item.SetNameOverride("神圣之怒药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaHealingPotion"))
				{
					item.SetNameOverride("终极血瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PenumbraPotion"))
				{
					item.SetNameOverride("半影药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PhotosynthesisPotion"))
				{
					item.SetNameOverride("光合药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PotionofOmniscience"))
				{
					item.SetNameOverride("全知药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedRagePotion"))
				{
					item.SetNameOverride("渎神之怒药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PurifiedJam"))
				{
					item.SetNameOverride("净神果酱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RevivifyPotion"))
				{
					item.SetNameOverride("再生药水");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShatteringPotion"))
				{
					item.SetNameOverride("斩裂药水");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SoaringPotion"))
				{
					item.SetNameOverride("腾飞药水");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SupremeHealingPotion"))
				{
					item.SetNameOverride("至尊血瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SupremeManaPotion"))
				{
					item.SetNameOverride("至尊蓝瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TitanScalePotion"))
				{
					item.SetNameOverride("泰坦之鳞药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TriumphPotion"))
				{
					item.SetNameOverride("胜利药剂");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralInjection"))
					{
						if (tooltipLine.text == "Gives mana sickness and hurts you when used, but you regenerate mana extremely quickly even while moving or casting spells")
						{
							tooltipLine.text = "注射后受到伤害和魔力病的影响，但是在移动和施法时魔法恢复速度极速提升";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BoundingPotion"))
					{
						if (tooltipLine.text == "Increases jump height, jump speed, and fall damage resistance")
						{
							tooltipLine.text = "增加跳跃高度，跳跃速度，降低摔落伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CadencePotion"))
					{
						if (tooltipLine.text == "Gives the cadence buff which reduces shop prices and enemy aggro")
						{
							tooltipLine.text = "获得尾音buff，降低商店商品价格和敌人仇恨值";
						}
						if (tooltipLine.text == "Increases life regen and increases max life by 25%")
						{
							tooltipLine.text = "增加生命恢复速度和25%生命上限";
						}
						if (tooltipLine.text == "Increases heart pickup range")
						{
							tooltipLine.text = "增加红心捡取范围";
						}
						if (tooltipLine.text == "While this potion's buff is active, Regeneration Potion and Lifeforce Potion buffs are disabled")
						{
							tooltipLine.text = "当此药剂的buff激活时，再生药剂和生命力药剂的buff被禁用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitasBrew"))
					{
						if (tooltipLine.text == "Adds abyssal flames to your melee projectiles and melee attacks")
						{
							tooltipLine.text = "近战武器弹幕施加深渊之火buff";
						}
						if (tooltipLine.text == "Increases your movement speed by 15%")
						{
							tooltipLine.text = "增加15%移动速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalciumPotion"))
					{
						if (tooltipLine.text == "Grants immunity to fall damage")
						{
							tooltipLine.text = "免疫摔落伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CeaselessHungerPotion"))
					{
						if (tooltipLine.text == "Causes you to suck up all items in the world")
						{
							tooltipLine.text = "令你吸附全世界的物品";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrumblingPotion"))
					{
						if (tooltipLine.text == "Increases melee and rogue critical strike chance by 5%")
						{
							tooltipLine.text = "增加5%近战和盗贼暴击率";
						}
						if (tooltipLine.text == "Melee and rogue attacks break enemy armor")
						{
							tooltipLine.text = "近战和盗贼攻击会降低敌人护甲";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraconicElixir"))
					{
						if (tooltipLine.text == "Greatly increases wing flight time and speed and increases defense by 16")
						{
							tooltipLine.text = "大幅增加飞行时间，飞行速度，增加16防御";
						}
						if (tooltipLine.text == "God slayer revival heals you to full HP instead of 150 HP when triggered")
						{
							tooltipLine.text = "弑神者套的复活效果直接复活至满生命";
						}
						if (tooltipLine.text == "Silva invincibility heals you to full HP when triggered")
						{
							tooltipLine.text = "始源林海套的无敌特效直接治疗至满生命";
						}
						if (tooltipLine.text == "If you trigger the above heals you cannot drink this potion again for 30 seconds")
						{
							tooltipLine.text = "如果上述效果已经触发，你无法饮此仙品，持续30秒";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GravityNormalizerPotion"))
					{
						if (tooltipLine.text == "Disables the low gravity of space and grants immunity to the distorted debuff")
						{
							tooltipLine.text = "太空中的低重力状态无效，免疫扭曲debuff";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HolyWrathPotion"))
					{
						if (tooltipLine.text == "Increases damage by 12% and increases movement and horizontal flight speed by 5%")
						{
							tooltipLine.text = "增加12%伤害，增加5%水平飞行速度和移动速度";
						}
						if (tooltipLine.text == "Attacks inflict holy fire")
						{
							tooltipLine.text = "攻击附着神圣之火效果";
						}
						if (tooltipLine.text == "While this potion's buff is active the Wrath Potion's buff is disabled")
						{
							tooltipLine.text = "当此药剂的buff激活时，怒气药剂的buff被禁用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PenumbraPotion"))
					{
						if (tooltipLine.text == "Rogue stealth regenerates 10% faster, 20% faster at night and 30% faster during an eclipse")
						{
							tooltipLine.text = "盗贼潜行再生加快10%，夜间快20%，在月蚀时快30%";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PhotosynthesisPotion"))
					{
						if (tooltipLine.text == "You regen life quickly while not moving, this effect is five times as strong during daytime")
						{
							tooltipLine.text = "站立不动时大幅增加生命恢复速度，此增益在白天效果是原本的5倍";
						}
						if (tooltipLine.text == "Dropped hearts heal more HP")
						{
							tooltipLine.text = "掉落的红心恢复更多血量";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PotionofOmniscience"))
					{
						if (tooltipLine.text == "Gives creature, danger, and treasure detection")
						{
							tooltipLine.text = "获得探查到生命，矿石，宝物和危险的能力";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PotionofOmniscience"))
					{
						if (tooltipLine.text == "Increases critical strike chance by 12% and increases movement and horizontal flight speed by 5%")
						{
							tooltipLine.text = "增加12%暴击率，增加5%移动速度和水平飞行速度";
						}
						if (tooltipLine.text == "In Revengeance Mode you gain more rage when damaged")
						{
							tooltipLine.text = "复仇模式中，受伤时额外增加怒气值";
						}
						if (tooltipLine.text == "While this potion's buff is active the Rage Potion's buff is disabled")
						{
							tooltipLine.text = "当此药剂的buff激活时，暴怒药剂的buff被禁用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PurifiedJam"))
					{
						if (tooltipLine.text == "Makes you immune to all damage and most debuffs for 10 seconds (5 seconds in Death Mode)")
						{
							tooltipLine.text = "让你在10秒钟内免疫所有伤害和绝大多数debuff(死亡模式5秒)";
						}
						if (tooltipLine.text == "Causes potion sickness when consumed")
						{
							tooltipLine.text = "使用后导致药水病";
						}
						if (tooltipLine.text == "Cannot be consumed while potion sickness is active")
						{
							tooltipLine.text = "药水病期间无法使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RevivifyPotion"))
					{
						if (tooltipLine.text == "Causes enemy attacks to heal you for a fraction of their damage for 15 seconds")
						{
							tooltipLine.text = "让敌人在攻击你时治疗你，治疗量为伤害值的一部分，持续15秒";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShatteringPotion"))
					{
						if (tooltipLine.text == "Increases melee and rogue damage and critical strike chance by 8%")
						{
							tooltipLine.text = "增加8%近战和盗贼伤害及暴击率";
						}
						if (tooltipLine.text == "Melee and rogue attacks break enemy armor")
						{
							tooltipLine.text = "近战和盗贼攻击会降低敌人的防御";
						}
						if (tooltipLine.text == "While this potion's buff is active the Crumbling Potion's buff is disabled")
						{
							tooltipLine.text = "当此药剂的buff激活时，崩碎药剂的buff被禁用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SoaringPotion"))
					{
						if (tooltipLine.text == "Increases flight time and horizontal flight speed by 10%")
						{
							tooltipLine.text = "增加10%飞行时间和水平飞行速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TitanScalePotion"))
					{
						if (tooltipLine.text == "Increases knockback, defense by 5, and damage reduction by 5%")
						{
							tooltipLine.text = "增加击退，5防御和5%伤害减免";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TriumphPotion"))
					{
						if (tooltipLine.text == "Enemy contact damage is reduced, the lower their health the more it is reduced")
						{
							tooltipLine.text = "敌人的接触伤害降低，敌人的血量越低，降低幅度越大";
						}
					}
				}
			}
		}
	}
}
