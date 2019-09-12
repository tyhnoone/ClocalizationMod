using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAccessories : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AlchemicalFlask"))
				{
					item.SetNameOverride("炼金师烧瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmalgamatedBrain"))
				{
					item.SetNameOverride("联合之脑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmbrosialAmpoule"))
				{
					item.SetNameOverride("百草天香瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmidiasSpark"))
				{
					item.SetNameOverride("阿米迪亚斯电花石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientFossil"))
				{
					item.SetNameOverride("远古化石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AngelTreads"))
				{
					item.SetNameOverride("天使之靴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ArcanumoftheVoid"))
				{
					item.SetNameOverride("虚空秘术");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ArchaicPowder"))
				{
					item.SetNameOverride("古元粉末");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AsgardianAegis"))
				{
					item.SetNameOverride("阿斯加德之庇护");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AsgardsValor"))
				{
					item.SetNameOverride("阿斯加德之英勇");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralArcanum"))
				{
					item.SetNameOverride("星陨幻空石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBulwark"))
				{
					item.SetNameOverride("幻星秘盾");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BadgeofBravery"))
				{
					item.SetNameOverride("勇气勋章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareCore"))
				{
					item.SetNameOverride("血炎晶核");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyWormScarf"))
				{
					item.SetNameOverride("血蠕虫围巾");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BurdenBreaker"))
				{
					item.SetNameOverride("突破樊笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CelestialJewel"))
				{
					item.SetNameOverride("天魔星石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaosAmulet"))
				{
					item.SetNameOverride("混乱护符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoreOfTheBloodGod"))
				{
					item.SetNameOverride("血神核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorruptFlask"))
				{
					item.SetNameOverride("腐化烧瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CounterScarf"))
				{
					item.SetNameOverride("反击围巾");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrawCarapace"))
				{
					item.SetNameOverride("蟹爪壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrimsonFlask"))
				{
					item.SetNameOverride("猩红烧瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrownJewel"))
				{
					item.SetNameOverride("王冠宝石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusEmblem"))
				{
					item.SetNameOverride("代达罗斯纹章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DarkSunRing"))
				{
					item.SetNameOverride("蚀日尊戒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeificAmulet"))
				{
					item.SetNameOverride("神化护符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonsHeart"))
				{
					item.SetNameOverride("嘉登之心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElementalGauntlet"))
				{
					item.SetNameOverride("元素之握");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElementalQuiver"))
				{
					item.SetNameOverride("元素箭袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EtherealTalisman"))
				{
					item.SetNameOverride("空灵护符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EyeoftheStorm"))
				{
					item.SetNameOverride("暴风眼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrigidBulwark"))
				{
					item.SetNameOverride("寒霜壁垒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostBarrier"))
				{
					item.SetNameOverride("寒冰屏障");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostFlare"))
				{
					item.SetNameOverride("霜冻之炎");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FungalCarapace"))
				{
					item.SetNameOverride("真菌壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GiantShell"))
				{
					item.SetNameOverride("巨甲壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GiantTortoiseShell"))
				{
					item.SetNameOverride("巨龟壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GoldBurdenBreaker"))
				{
					item.SetNameOverride("解脱樊笼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrandGelatin"))
				{
					item.SetNameOverride("绚彩凝胶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HarpyRing"))
				{
					item.SetNameOverride("妖鸟指环");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HeartofDarkness"))
				{
					item.SetNameOverride("黑暗之心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HeartoftheElements"))
				{
					item.SetNameOverride("元灵归心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HoneyDew"))
				{
					item.SetNameOverride("蜂蜜露珠");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Laudanum"))
				{
					item.SetNameOverride("鸦片酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeadCore"))
				{
					item.SetNameOverride("铅核");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LifeJelly"))
				{
					item.SetNameOverride("生命凝胶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LivingDew"))
				{
					item.SetNameOverride("生命露珠");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ManaJelly"))
				{
					item.SetNameOverride("魔力凝胶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Nanotech"))
				{
					item.SetNameOverride("纳米科技");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NecklaceofVexation"))
				{
					item.SetNameOverride("恼怒项链");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OrnateShield"))
				{
					item.SetNameOverride("宝光盾");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlagueHive"))
				{
					item.SetNameOverride("瘟疫蜂巢");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PsychoticAmulet"))
				{
					item.SetNameOverride("神经元护符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RadiantOoze"))
				{
					item.SetNameOverride("光泥");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RaidersTalisman"))
				{
					item.SetNameOverride("掠夺者护符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RampartofDeities"))
				{
					item.SetNameOverride("神之壁垒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RogueEmblem"))
				{
					item.SetNameOverride("盗贼纹章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeaShell"))
				{
					item.SetNameOverride("海螺壳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShieldoftheOcean"))
				{
					item.SetNameOverride("海洋盾");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SigilofCalamitas"))
				{
					item.SetNameOverride("灾厄符章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SpiritGenerator"))
				{
					item.SetNameOverride("灵魂浮雕");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Sponge"))
				{
					item.SetNameOverride("化绵留香石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisBeltOfCurses"))
				{
					item.SetNameOverride("斯塔提斯的诅咒系带");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisBlessing"))
				{
					item.SetNameOverride("斯塔提斯的祝福");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisCurse"))
				{
					item.SetNameOverride("斯塔提斯的诅咒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisNinjaBelt"))
				{
					item.SetNameOverride("斯塔提斯忍者系带");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StressPills"))
				{
					item.SetNameOverride("压力药丸");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SupremeBaitTackleBoxFishingStation"))
				{
					item.SetNameOverride("万圣钓鱼台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheAbsorber"))
				{
					item.SetNameOverride("阴阳吸星石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheAmalgam"))
				{
					item.SetNameOverride("聚合之脑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheCommunity"))
				{
					item.SetNameOverride("归一心元石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheFirstShadowflame"))
				{
					item.SetNameOverride("始源暗影炎");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VitalJelly"))
				{
					item.SetNameOverride("活力凝胶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VoidofExtinction"))
				{
					item.SetNameOverride("终结虚空");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WifeinaBottle"))
				{
					item.SetNameOverride("元素瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WifeinaBottlewithBoobs"))
				{
					item.SetNameOverride("稀有元素瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharimsInsignia"))
				{
					item.SetNameOverride("犽戾武之证章");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CheatTestThing"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "lul", "开发者物品\n玩家名字是Fabsol或者Totalbiscuit时装备有奇效\n否则你等着被舔吧")
					{
						overrideColor = new Color?(Color.DarkRed)
					});
				}
				
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (tooltipLine.text == "Revengeance drop")
					{
						tooltipLine.text = "复仇模式物品";
					}
					if (tooltipLine.text == "Legendary Accessory")
					{
						tooltipLine.text = "传说饰品";
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AlchemicalFlask"))
					{
						if (tooltipLine.text == "All attacks inflict the plague")
						{
							tooltipLine.text = "所有攻击附着瘟疫";
						}
						if (tooltipLine.text == "Makes you immune to the plague")
						{
							tooltipLine.text = "使你免疫瘟疫";
						}
						if (tooltipLine.text == "Projectiles spawn plague seekers on enemy hits")
						{
							tooltipLine.text = "弹幕击中敌人后会生成瘟疫搜寻者";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmalgamatedBrain"))
					{
						if (tooltipLine.text == "12% increased damage")
						{
							tooltipLine.text = "增加12%所有伤害";
						}
						if (tooltipLine.text == "Shade rains down when you are hit")
						{
							tooltipLine.text = "被击中后天降阴影之雨";
						}
						if (tooltipLine.text == "You will confuse nearby enemies when you are struck")
						{
							tooltipLine.text = "受到攻击会使你周围的敌人混乱";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmbrosialAmpoule"))
					{
						if (tooltipLine.text == "25% increased mining speed")
						{
							tooltipLine.text = "增加25%挖掘速度";
						}
						if (tooltipLine.text == "You emit light")
						{
							tooltipLine.text = "你会发光";
						}
						if (tooltipLine.text == "5% increased damage reduction and increased life regen")
						{
							tooltipLine.text = "增加5%伤害减免和生命再生速度";
						}
						if (tooltipLine.text == "Poison, Freeze, Chill, Frostburn, and Venom immunity")
						{
							tooltipLine.text = "免疫中毒，剧毒，冻结，冷冻和霜火";
						}
						if (tooltipLine.text == "Honey-like life regen with no speed penalty")
						{
							tooltipLine.text = "受到蜂蜜增益的生命再生时不再降低移动";
						}
						if (tooltipLine.text == "Most bee/hornet enemies and projectiles do 75% damage to you")
						{
							tooltipLine.text = "绝大多数蜂类敌人及其毒针伤害减少75%";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmidiasSpark"))
					{
						if (tooltipLine.text == "Taking damage releases a blast of sparks")
						{
							tooltipLine.text = "受到伤害后会释放电火花爆炸";
						}
						if (tooltipLine.text == "Sparks do extra damage in Hardmode")
						{
							tooltipLine.text = "困难模式，电火花造成伤害更高";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientFossil"))
					{
						if (tooltipLine.text == "Increases pick speed by 15% while underground")
						{
							tooltipLine.text = "处于地下时增加15%挖掘速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AngelTreads"))
					{
						if (tooltipLine.text == "Extreme speed!")
						{
							tooltipLine.text = "极致的速度！";
						}
						if (tooltipLine.text == "Greater mobility on ice")
						{
							tooltipLine.text = "在冰上大幅增加自由移动能力";
						}
						if (tooltipLine.text == "Water and lava walking")
						{
							tooltipLine.text = "能在水和岩浆上行走";
						}
						if (tooltipLine.text == "Temporary immunity to lava")
						{
							tooltipLine.text = "提供暂时的岩浆免疫";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ArcanumoftheVoid"))
					{
						if (tooltipLine.text == "You have a 5% chance to reflect projectiles when they hit you")
						{
							tooltipLine.text = "当弹幕碰到你时，你有5%几率反弹";
						}
						if (tooltipLine.text == "If this effect triggers you get healed for the projectile's damage")
						{
							tooltipLine.text = "如果此能力生效，你会根据弹幕伤害回复生命";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ArchaicPowder"))
					{
						if (tooltipLine.text == "20% increased mining speed, 7% damage reduction, and +3 defense while underground or in the underworld")
						{
							tooltipLine.text = "处于地下或者地狱时, 增加20%挖掘速度, 7%伤害减免，3防御";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AsgardianAegis"))
					{
						if (tooltipLine.text == "Grants immunity to fire blocks and knockback")
						{
							tooltipLine.text = "免疫灼烧砖块和击退";
						}
						if (tooltipLine.text == "Immune to most debuffs")
						{
							tooltipLine.text = "免疫大多数debuff";
						}
						if (tooltipLine.text == "+40 max life")
						{
							tooltipLine.text = "+40生命上限";
						}
						if (tooltipLine.text == "Grants a supreme holy flame dash")
						{
							tooltipLine.text = "获得究极圣火冲刺";
						}
						if (tooltipLine.text == "Can be used to ram enemies")
						{
							tooltipLine.text = "可以冲撞敌人";
						}
						if (tooltipLine.text == "Press N to activate buffs to all damage, crit chance, and defense")
						{
							tooltipLine.text = "按N以激活增加所有伤害，暴击率和防御的buff";
						}
						if (tooltipLine.text == "Activating this buff will reduce your movement speed and increase enemy aggro")
						{
							tooltipLine.text = "激活buff会让你移速下降并增加敌人的攻击性";
						}
						if (tooltipLine.text == "10% damage reduction while submerged in liquid")
						{
							tooltipLine.text = "完全处于液体中时获得10%伤害减免";
						}
						if (tooltipLine.text == "Toggle visibility of this accessory to enable/disable the dash")
						{
							tooltipLine.text = "开关饰品的可见性可开关冲刺功能";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AsgardsValor"))
					{
						if (tooltipLine.text == "Grants immunity to fire blocks and knockback")
						{
							tooltipLine.text = "免疫灼烧砖块和击退";
						}
						if (tooltipLine.text == "Immune to most debuffs including Brimstone Flames, Holy Flames, and Glacial State")
						{
							tooltipLine.text = "免疫包括硫磺火，神圣之火和冰河时代在内的大部分debuff";
						}
						if (tooltipLine.text == "+20 max life")
						{
							tooltipLine.text = "+20生命上限";
						}
						if (tooltipLine.text == "Grants an improved holy dash")
						{
							tooltipLine.text = "获得强化神圣冲刺";
						}
						if (tooltipLine.text == "Can be used to ram enemies")
						{
							tooltipLine.text = "可以冲撞敌人";
						}
						if (tooltipLine.text == "10% damage reduction while submerged in liquid")
						{
							tooltipLine.text = "完全处于液体中时获得10%伤害减免";
						}
						if (tooltipLine.text == "Toggle visibility of this accessory to enable/disable the dash")
						{
							tooltipLine.text = "开关饰品的可见性可开关冲刺功能";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralArcanum"))
					{
						if (tooltipLine.text == "Taking damage drops astral stars from the sky")
						{
							tooltipLine.text = "受到伤害会从天上召唤彗星下落";
						}
						if (tooltipLine.text == "Provides immunity to the astral infection debuff")
						{
							tooltipLine.text = "免疫星体感染";
						}
						if (tooltipLine.text == "You have a 5% chance to reflect projectiles when they hit you")
						{
							tooltipLine.text = "当弹幕碰到你时，你有5%几率反弹";
						}
						if (tooltipLine.text == "If this effect triggers you get healed for the projectile's damage")
						{
							tooltipLine.text = "如果此能力生效，你会根据弹幕伤害回复生命";
						}
						if (tooltipLine.text == "Boosts life regen even while under the effects of a damaging debuff")
						{
							tooltipLine.text = "增加生命恢复速度，并且不受到持续掉血类debuff影响";
						}
						if (tooltipLine.text == "While under the effects of a damaging debuff you will gain 20 defense")
						{
							tooltipLine.text = "处于持续掉血类debuff下增加20点防御";
						}
						if (tooltipLine.text == "Press O to toggle teleportation UI")
						{
							tooltipLine.text = "按O键以打开传送面板";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBulwark"))
					{
						if (tooltipLine.text == "Taking damage drops astral stars from the sky")
						{
							tooltipLine.text = "受到伤害会从天上召唤彗星下落";
						}
						if (tooltipLine.text == "Provides immunity to the astral infection debuff")
						{
							tooltipLine.text = "免疫星体感染";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BadgeofBravery"))
					{
						if (tooltipLine.text == "15% increased melee speed")
						{
							tooltipLine.text = "增加15%近战攻速";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareCore"))
					{
						if (tooltipLine.text == "When below 50% life you gain 5% increased damage reduction and 10% increased damage")
						{
							tooltipLine.text = "低于50%生命时获得5%伤害减免，增加10%伤害";
						}
						if (tooltipLine.text == "When below 15% life you gain 10% increased damage reduction and 20% increased damage")
						{
							tooltipLine.text = "低于15%生命时获得10%伤害减免，增加20%伤害";
						}
						if (tooltipLine.text == "When below 100 defense you gain 15% increased damage")
						{
							tooltipLine.text = "低于100防御时增加15%伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyWormScarf"))
					{
						if (tooltipLine.text == "10% increased damage reduction and increased melee stats")
						{
							tooltipLine.text = "增加10%伤害减免并提升近战属性";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BurdenBreaker"))
					{
						if (tooltipLine.text == "The bad time")
						{
							tooltipLine.text = "痛苦的时光";
						}
						if (tooltipLine.text == "Removes immunity frames")
						{
							tooltipLine.text = "失去无敌帧";
						}
						if (tooltipLine.text == "If you want a crazy challenge, equip this")
						{
							tooltipLine.text = "作死就装备它，怕个鸡儿";
						}
						if (tooltipLine.text == "Touching lava kills you instantly")
						{
							tooltipLine.text = "触碰岩浆立即死亡";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CelestialJewel"))
					{
						if (tooltipLine.text == "Boosts life regen even while under the effects of a damaging debuff")
						{
							tooltipLine.text = "增加生命恢复速度，并且不受到持续掉血类debuff影响";
						}
						if (tooltipLine.text == "While under the effects of a damaging debuff you will gain 20 defense")
						{
							tooltipLine.text = "处于持续掉血类debuff下增加20点防御";
						}
						if (tooltipLine.text == "Press P to teleport to a random location")
						{
							tooltipLine.text = "按P以传送至随机位置";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaosAmulet"))
					{
						if (tooltipLine.text == "Spelunker effect and increased life regen")
						{
							tooltipLine.text = "具有探矿药剂效果，增加生命回复";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoreOfTheBloodGod"))
					{
						if (tooltipLine.text == "5% increased damage reduction")
						{
							tooltipLine.text = "增加5%伤害减免";
						}
						if (tooltipLine.text == "7% increased damage")
						{
							tooltipLine.text = "增加7%伤害";
						}
						if (tooltipLine.text == "When below 100 defense you gain 15% increased damage")
						{
							tooltipLine.text = "防御低于100点时增加15%伤害";
						}
						if (tooltipLine.text == "Halves enemy contact damage")
						{
							tooltipLine.text = "敌人的接触伤害减半";
						}
						if (tooltipLine.text == "When you take contact damage this effect has a 20 second cooldown")
						{
							tooltipLine.text = "当你受到接触伤害后这个效果会有20秒冷却时间";
						}
						if (tooltipLine.text == "Boosts your max HP by 10%")
						{
							tooltipLine.text = "增加10%生命上限";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorruptFlask"))
					{
						if (tooltipLine.text == "7% increased damage reduction and +3 defense while in the corruption")
						{
							tooltipLine.text = "在腐化之地增加7%伤害减免，3防御";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CounterScarf"))
					{
						if (tooltipLine.text == "Melee weapons that don't fire projectiles are granted 20% more damage")
						{
							tooltipLine.text = "没有弹幕的近战武器获得20%额外伤害";
						}
						if (tooltipLine.text == "Grants the ability to dash; dashing into an attack will cause you to dodge it")
						{
							tooltipLine.text = "获得冲刺能力，冲刺中受到攻击时会闪避";
						}
						if (tooltipLine.text == "After a dodge you will be granted a buff to all damage, melee speed, and all crit chance for a short time")
						{
							tooltipLine.text = "闪避之后你会短时间内获得一个增加所有伤害，近战速度以及所有暴击率的buff";
						}
						if (tooltipLine.text == "After a successful dodge you must wait 15 seconds before you can dodge again")
						{
							tooltipLine.text = "一次成功的闪避之后你必须等15秒方可进行下一次闪避";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrawCarapace"))
					{
						if (tooltipLine.text == "5% increased damage reduction")
						{
							tooltipLine.text = "增加5%伤害减免";
						}
						if (tooltipLine.text == "Enemies take damage when they touch you")
						{
							tooltipLine.text = "敌人碰到你就会受到伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrimsonFlask"))
					{
						if (tooltipLine.text == "7% increased damage reduction and +3 defense while in the crimson")
						{
							tooltipLine.text = "在血腥之地增加7%伤害减免，3防御";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrownJewel"))
					{
						if (tooltipLine.text == "Boosts life regen even while under the effects of a damaging debuff")
						{
							tooltipLine.text = "增加生命恢复速度，并且不受到持续掉血类debuff影响";
						}
						if (tooltipLine.text == "While under the effects of a damaging debuff you will gain 10 defense")
						{
							tooltipLine.text = "处于持续掉血类debuff下增加10点防御";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusEmblem"))
					{
						if (tooltipLine.text == "10% increased ranged damage, 5% increased ranged critical strike chance, and 20% reduced ammo usage")
						{
							tooltipLine.text = "增加10%远程伤害和5%远程暴击，减少20%弹药消耗";
						}
						if (tooltipLine.text == "Increases life regen, minion knockback, defense, and pick speed")
						{
							tooltipLine.text = "增加生命恢复速度，召唤物击退，防御和挖掘速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DarkSunRing"))
					{
						if (tooltipLine.text == "12% increase to damage, minion knockback, and melee speed")
						{
							tooltipLine.text = "增加12%伤害，近战攻速和召唤物击退";
						}
						if (tooltipLine.text == "+1 life regen, 15% increased pick speed, and +2 max minions")
						{
							tooltipLine.text = "增加1生命恢复速度，15%挖掘速度，2召唤栏";
						}
						if (tooltipLine.text == "During the day the player has +3 life regen")
						{
							tooltipLine.text = "白天增加玩家3生命恢复速度";
						}
						if (tooltipLine.text == "During the night the player has +30 defense")
						{
							tooltipLine.text = "夜晚增加玩家30防御";
						}
						if (tooltipLine.text == "Contains the power of the dark sun")
						{
							tooltipLine.text = "蕴含着日蚀之阴的可怕力量";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeificAmulet"))
					{
						if (tooltipLine.text == "Taking damage makes you move very fast for a short time")
						{
							tooltipLine.text = "受到伤害会大幅增加移速";
						}
						if (tooltipLine.text == "Increases armor penetration by 25 and immune time after being struck")
						{
							tooltipLine.text = "增加25点护甲穿透，增加受伤后无敌时间";
						}
						if (tooltipLine.text == "Provides light underwater and causes stars to fall when damaged")
						{
							tooltipLine.text = "水下提供照明，受到伤害时召唤落星";
						}
						if (tooltipLine.text == "Reduces the cooldown of healing potions")
						{
							tooltipLine.text = "减少药水病时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonsHeart"))
					{
						if (tooltipLine.text == "Gives 10% increased damage while you have the heart attack debuff")
						{
							tooltipLine.text = "心力衰竭时增加10%伤害";
						}
						if (tooltipLine.text == "Increases your chance of getting the heart attack debuff")
						{
							tooltipLine.text = "增加获得心力衰竭buff的几率";
						}
						if (tooltipLine.text == "Boosts your damage by 10% and max movement speed and acceleration by 5%")
						{
							tooltipLine.text = "增加10%伤害，5%最大移速和加速度";
						}
						if (tooltipLine.text == "Rage mode does more damage")
						{
							tooltipLine.text = "怒气状态造成更多伤害";
						}
						if (tooltipLine.text == "You gain rage over time")
						{
							tooltipLine.text = "随着时间的增长获得怒气值";
						}
						if (tooltipLine.text == "Gives immunity to the horror debuff")
						{
							tooltipLine.text = "免疫恐惧debuff";
						}
						if (tooltipLine.text == "Standing still regenerates your life quickly and boosts your defense by 25")
						{
							tooltipLine.text = "站立不动让你快速恢复生命并增加25防御";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElementalGauntlet"))
					{
						if (tooltipLine.text == "Melee attacks and projectiles inflict most debuffs")
						{
							tooltipLine.text = "近战攻击和弹幕会附着大多数debuff";
						}
						if (tooltipLine.text == "15% increased melee speed, damage, and 5% increased melee critical strike chance")
						{
							tooltipLine.text = "增加15%近战攻速、伤害和5%暴击率";
						}
						if (tooltipLine.text == "Increased invincibility after taking damage")
						{
							tooltipLine.text = "增加受伤之后的无敌帧";
						}
						if (tooltipLine.text == "Temporary immunity to lava")
						{
							tooltipLine.text = "暂时免疫岩浆伤害";
						}
						if (tooltipLine.text == "Increased melee knockback")
						{
							tooltipLine.text = "增加近战击退";
						}
						if (tooltipLine.text == "Melee attacks have a chance to instantly kill normal enemies")
						{
							tooltipLine.text = "近战攻击有几率直接击杀普通敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElementalGauntlet"))
					{
						if (tooltipLine.text == "Ranged projectiles have a chance to split")
						{
							tooltipLine.text = "远程弹道有几率分裂";
						}
						if (tooltipLine.text == "Ranged weapons have a chance to instantly kill normal enemies")
						{
							tooltipLine.text = "远程攻击有几率直接击杀普通敌人";
						}
						if (tooltipLine.text == "10% increased ranged damage and 5% increased ranged critical strike chance")
						{
							tooltipLine.text = "增加10%远程伤害和5%远程暴击率";
						}
						if (tooltipLine.text == "Temporary immunity to lava")
						{
							tooltipLine.text = "暂时免疫岩浆伤害";
						}
						if (tooltipLine.text == "Increased melee knockback")
						{
							tooltipLine.text = "增加近战击退";
						}
						if (tooltipLine.text == "20% reduced ammo usage and increased life regen, minion knockback, defense, and pick speed")
						{
							tooltipLine.text = "减少20%的弹药消耗，增加生命回复、召唤物击退、防御和挖掘速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EtherealTalisman"))
					{
						if (tooltipLine.text == "15% increased magic damage, 5% increased magic critical strike chance, and 10% decreased mana usage")
						{
							tooltipLine.text = "魔法伤害增加15%，魔法暴击率增加5%，魔力消耗减少10%";
						}
						if (tooltipLine.text == "+150 max mana and reveals treasure locations")
						{
							tooltipLine.text = "+150魔力上限，显示宝藏位置";
						}
						if (tooltipLine.text == "Increases pickup range for mana stars and you restore mana when damaged")
						{
							tooltipLine.text = "增加魔力星的拾取范围，并在受到伤害时恢复魔力";
						}
						if (tooltipLine.text == "You automatically use mana potions when needed if visibility is on")
						{
							tooltipLine.text = "如果打开饰品可见，则在需要时自动使用魔力药剂";
						}
						if (tooltipLine.text == "Magic attacks have a chance to instantly kill normal enemies")
						{
							tooltipLine.text = "魔法攻击有几率直接击杀普通敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EyeoftheStorm"))
					{
						if (tooltipLine.text == "Summons a cloud elemental to fight for you")
						{
							tooltipLine.text = "召唤雨云元素为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrigidBulwark"))
					{
						if (tooltipLine.text == "Absorbs 25% of damage done to players on your team")
						{
							tooltipLine.text = "为同队的玩家吸收25%伤害";
						}
						if (tooltipLine.text == "Only active above 25% life")
						{
							tooltipLine.text = "生命值高于25%生效";
						}
						if (tooltipLine.text == "Grants immunity to knockback")
						{
							tooltipLine.text = "免疫击退";
						}
						if (tooltipLine.text == "Puts a shell around the owner when below 50% life that reduces damage")
						{
							tooltipLine.text = "生命值低于50%时生成护盾减少伤害";
						}
						if (tooltipLine.text == "The shell becomes more powerful when below 15% life and reduces damage even further")
						{
							tooltipLine.text = "生命值低于15%时护盾变得更强，减伤更多";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostBarrier"))
					{
						if (tooltipLine.text == "You will freeze enemies near you when you are struck")
						{
							tooltipLine.text = "受到攻击后冻结周围的敌人";
						}
						if (tooltipLine.text == "You are immune to the chilled debuff")
						{
							tooltipLine.text = "免疫冷冻debuff";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostFlare"))
					{
						if (tooltipLine.text == "All melee attacks and projectiles inflict frostburn")
						{
							tooltipLine.text = "近战附着霜火debuff";
						}
						if (tooltipLine.text == "Immunity to frostburn, chilled, and frozen")
						{
							tooltipLine.text = "免疫霜火，冻结和冰冻debuff";
						}
						if (tooltipLine.text == "Resistant to cold attacks and +1 life regen")
						{
							tooltipLine.text = "提供冰系伤害抗性，增加1生命恢复速度";
						}
						if (tooltipLine.text == "Being above 75% life grants the player 10% increased damage")
						{
							tooltipLine.text = "高于75%生命值时增加10%伤害";
						}
						if (tooltipLine.text == "Being below 25% life grants the player 10 defense and 15% increased max movement speed and acceleration")
						{
							tooltipLine.text = "低于25%生命值时增加10防御，15%最大移动速度以及加速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FungalCarapace"))
					{
						if (tooltipLine.text == "You emit a mushroom spore explosion when you are hit")
						{
							tooltipLine.text = "受到伤害时释放爆炸孢子";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GiantShell"))
					{
						if (tooltipLine.text == "15% reduced movement speed")
						{
							tooltipLine.text = "减少15%移速";
						}
						if (tooltipLine.text == "Taking a hit will make you move very fast for a short time")
						{
							tooltipLine.text = "受到伤害时会让你暂时增加大量移速";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GiantTortoiseShell"))
					{
						if (tooltipLine.text == "10% reduced movement speed")
						{
							tooltipLine.text = "减少10%移速";
						}
						if (tooltipLine.text == "Enemies take damage when they hit you")
						{
							tooltipLine.text = "敌人击中你时受到伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GoldBurdenBreaker"))
					{
						if (tooltipLine.text == "The good time")
						{
							tooltipLine.text = "欢乐时光";
						}
						if (tooltipLine.text == "Go fast")
						{
							tooltipLine.text = "走得更快";
						}
						if (tooltipLine.text == "WARNING: May have disastrous results")
						{
							tooltipLine.text = "警 告：可能有不可预计的后果";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GoldBurdenBreaker"))
					{
						if (tooltipLine.text == "10% increased movement speed")
						{
							tooltipLine.text = "增加10%移速";
						}
						if (tooltipLine.text == "200% increased jump speed")
						{
							tooltipLine.text = "增加200%跳跃速度";
						}
						if (tooltipLine.text == "+20 max life and mana")
						{
							tooltipLine.text = "+20生命上限和魔力上限";
						}
						if (tooltipLine.text == "Standing still boosts life and mana regen")
						{
							tooltipLine.text = "站立不动时增加生命及魔法再生速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HarpyRing"))
					{
						if (tooltipLine.text == "Increased movement speed")
						{
							tooltipLine.text = "增加移动速度";
						}
						if (tooltipLine.text == "Boosts your maximum flight time by 25%")
						{
							tooltipLine.text = "增加25%飞行时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HeartofDarkness"))
					{
						if (tooltipLine.text == "Gives 10% increased damage while you have the heart attack debuff")
						{
							tooltipLine.text = "心力衰竭时增加10%伤害";
						}
						if (tooltipLine.text == "Increases your chance of getting the heart attack debuff")
						{
							tooltipLine.text = "增加获得心力衰竭buff的几率";
						}
						if (tooltipLine.text == "Rage mode does more damage")
						{
							tooltipLine.text = "怒气状态造成更多伤害";
						}
						if (tooltipLine.text == "You gain rage over time")
						{
							tooltipLine.text = "随着时间的增长获得怒气值";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HeartoftheElements"))
					{
						if (tooltipLine.text == "The heart of the world")
						{
							tooltipLine.text = "世界之心";
						}
						if (tooltipLine.text == "Increases max life by 20, life regen by 1, and all damage by 8%")
						{
							tooltipLine.text = "+20生命上限，增加1生命再生，增加8%所有伤害";
						}
						if (tooltipLine.text == "Increases movement speed by 10% and jump speed by 100%")
						{
							tooltipLine.text = "增加10%移动速度，100%跳跃速度";
						}
						if (tooltipLine.text == "Increases damage reduction by 5%")
						{
							tooltipLine.text = "增加5%伤害减免";
						}
						if (tooltipLine.text == "Increases max mana by 50 and reduces mana usage by 5%")
						{
							tooltipLine.text = "+50魔力上限，减少5%魔力消耗";
						}
						if (tooltipLine.text == "You grow flowers on the grass beneath you, chance to grow very random dye plants on grassless dirt")
						{
							tooltipLine.text = "你走过的草地会百花齐放，并几率让无草的土块上随机生长颜料植物";
						}
						if (tooltipLine.text == "Summons all elementals to protect you")
						{
							tooltipLine.text = "召唤所有元素之灵保护你";
						}
						if (tooltipLine.text == "Toggling the visibility of this accessory also toggles the elementals on and off")
						{
							tooltipLine.text = "开关饰品的可见性以调整元素之灵是否出现";
						}
						if (tooltipLine.text == "Stat increases are slightly higher if the elementals are turned off")
						{
							tooltipLine.text = "如果关闭，人物属性会略微提升";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HoneyDew"))
					{
						if (tooltipLine.text == "5% increased damage reduction, +5 defense, and increased life regen while in the Jungle")
						{
							tooltipLine.text = "在丛林环境时增加5%伤害减免，5防御，提升生命再生";
						}
						if (tooltipLine.text == "Poison and Venom immunity")
						{
							tooltipLine.text = "免疫中毒和剧毒";
						}
						if (tooltipLine.text == "Honey-like life regen with no speed penalty")
						{
							tooltipLine.text = "受到蜂蜜增益的生命再生时不再降低移动";
						}
						if (tooltipLine.text == "Most bee/hornet enemies and projectiles do 75% damage to you")
						{
							tooltipLine.text = "绝大多数蜂类敌人及其毒针伤害减少75%";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Laudanum"))
					{
						if (tooltipLine.text == "Boosts your damage by 6%,")
						{
							tooltipLine.text = "增加6%伤害";
						}
						if (tooltipLine.text == "defense by 6, and max movement speed and acceleration by 5%")
						{
							tooltipLine.text = "增加6防御，5%的移动速度和加速度";
						}
						if (tooltipLine.text == "Honey-like life regen with no speed penalty")
						{
							tooltipLine.text = "受到蜂蜜增益的生命再生时不再降低移动";
						}
						if (tooltipLine.text == "Makes you immune to The Horror debuff")
						{
							tooltipLine.text = "免疫恐惧debuff";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeadCore"))
					{
						if (tooltipLine.text == "Grants immunity to the acid rain debuff")
						{
							tooltipLine.text = "免疫酸雨debuff";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LifeJelly"))
					{
						if (tooltipLine.text == "+20 max life")
						{
							tooltipLine.text = "+20生命上限";
						}
						if (tooltipLine.text == "Standing still boosts life regen")
						{
							tooltipLine.text = "站立不动时增加生命再生速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LifeJelly"))
					{
						if (tooltipLine.text == "5% increased damage reduction, +5 defense, and increased life regen while in the Jungle")
						{
							tooltipLine.text = "在丛林环境时增加5%伤害减免，5防御，提升生命再生";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ManaJelly"))
					{
						if (tooltipLine.text == "+20 max mana")
						{
							tooltipLine.text = "+20魔力上限";
						}
						if (tooltipLine.text == "Standing still boosts mana regen")
						{
							tooltipLine.text = "站立不动时增加魔法恢复速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Nanotech"))
					{
						if (tooltipLine.text == "Rogue projectiles create nanoblades as they travel")
						{
							tooltipLine.text = "盗贼投掷物在飞行时产生纳米叶片";
						}
						if (tooltipLine.text == "Rogue weapons have a chance to instantly kill normal enemies")
						{
							tooltipLine.text = "盗贼攻击有几率直接击杀普通敌人";
						}
						if (tooltipLine.text == "10% increased rogue damage, 5% increased rogue crit chance, and 15% increased rogue velocity")
						{
							tooltipLine.text = "盗贼伤害增加10%，盗贼暴击率增加5%，盗贼速度增加15%";
						}
						if (tooltipLine.text == "Whenever you crit an enemy with a rogue weapon your rogue damage increases")
						{
							tooltipLine.text = "每当的盗贼武器产生暴击时，你的盗贼伤害会叠加";
						}
						if (tooltipLine.text == "This effect can stack up to 250 times")
						{
							tooltipLine.text = "此效果最多可叠加250次";
						}
						if (tooltipLine.text == "Max rogue damage boost is 25%")
						{
							tooltipLine.text = "最高提升25%盗贼伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NecklaceofVexation"))
					{
						if (tooltipLine.text == "Revenge")
						{
							tooltipLine.text = "复仇";
						}
						if (tooltipLine.text == "15% increased damage when under 50% life")
						{
							tooltipLine.text = "生命值低于50%时伤害增加15%";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlagueHive"))
					{
						if (tooltipLine.text == "Summons a damaging plague aura around the player to destroy nearby enemies")
						{
							tooltipLine.text = "在玩家周身召唤一个持续折磨周围敌人的瘟疫光环";
						}
						if (tooltipLine.text == "Releases bees when damaged")
						{
							tooltipLine.text = "受到伤害后释放蜜蜂";
						}
						if (tooltipLine.text == "Friendly bees inflict the plague")
						{
							tooltipLine.text = "友方蜜蜂的攻击会造成瘟疫";
						}
						if (tooltipLine.text == "All of your attacks inflict the plague")
						{
							tooltipLine.text = "你的所有攻击附着瘟疫";
						}
						if (tooltipLine.text == "Makes you immune to the plague")
						{
							tooltipLine.text = "你免疫瘟疫";
						}
						if (tooltipLine.text == "Projectiles spawn plague seekers on enemy hits")
						{
							tooltipLine.text = "弹幕在击中敌人后会释放瘟疫搜寻者";
						}
						if (tooltipLine.text == "The power of your bees and wasps will rival the Moon Lord himself")
						{
							tooltipLine.text = "你所召唤的蜜蜂与黄蜂的力量能与月球领主匹敌";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PsychoticAmulet"))
					{
						if (tooltipLine.text == "Boosts rogue and ranged damage and critical strike chance by 5%")
						{
							tooltipLine.text = "增加5%盗贼和远程伤害及暴击率";
						}
						if (tooltipLine.text == "Grants a massive boost to these stats if you aren't moving")
						{
							tooltipLine.text = "站立不动时这些属性增幅更大";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RadiantOoze"))
					{
						if (tooltipLine.text == "You emit light and regen life more quickly at night")
						{
							tooltipLine.text = "你会散发光芒，夜晚生命再生速度增加";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RaidersTalisman"))
					{
						if (tooltipLine.text == "Whenever you crit an enemy with a rogue weapon your rogue damage increases")
						{
							tooltipLine.text = "每当的盗贼武器产生暴击时，你的盗贼伤害会叠加";
						}
						if (tooltipLine.text == "This effect can stack up to 250 times")
						{
							tooltipLine.text = "此效果最多可叠加250次";
						}
						if (tooltipLine.text == "Max rogue damage boost is 25%")
						{
							tooltipLine.text = "最高提升25%盗贼伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RampartofDeities"))
					{
						if (tooltipLine.text == "Taking damage makes you move very fast for a short time")
						{
							tooltipLine.text = "受到伤害会短时间内极大增幅你的移速";
						}
						if (tooltipLine.text == "Increases armor penetration by 50 and immune time after being struck")
						{
							tooltipLine.text = "增加50点护甲穿透和被击中后的无敌时间";
						}
						if (tooltipLine.text == "Provides light underwater and causes stars to fall when damaged")
						{
							tooltipLine.text = "在水下提供照明，并在受到伤害时会使星星坠落";
						}
						if (tooltipLine.text == "Absorbs 25% of damage done to players on your team")
						{
							tooltipLine.text = "为同队的玩家吸收25%伤害";
						}
						if (tooltipLine.text == "Only active above 25% life")
						{
							tooltipLine.text = "生命值高于25%生效";
						}
						if (tooltipLine.text == "Grants immunity to knockback and reduces the cooldown of healing potions")
						{
							tooltipLine.text = "免疫击退并减少药水病的时间";
						}
						if (tooltipLine.text == "Puts a shell around the owner when below 50% life that reduces damage")
						{
							tooltipLine.text = "生命值低于50%时生成护盾减少伤害";
						}
						if (tooltipLine.text == "The shell becomes more powerful when below 15% life and reduces damage even further")
						{
							tooltipLine.text = "生命值低于15%时护盾变得更强，减伤更多";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RogueEmblem"))
					{
						if (tooltipLine.text == "15% increased rogue damage")
						{
							tooltipLine.text = "增加15%盗贼伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeaShell"))
					{
						if (tooltipLine.text == "Increased defense and damage reduction when submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加防御和伤害减免";
						}
						if (tooltipLine.text == "Increased movement speed when submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加移动速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShieldoftheOcean"))
					{
						if (tooltipLine.text == "Increased defense by 5 when submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加5点防御";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SigilofCalamitas"))
					{
						if (tooltipLine.text == "10% increased magic damage and 10% decreased mana usage")
						{
							tooltipLine.text = "增加10%魔法伤害，减少10%魔力消耗";
						}
						if (tooltipLine.text == "Increases pickup range for mana stars and you restore mana when damaged")
						{
							tooltipLine.text = "增加魔力星的拾取范围，并在受到伤害时恢复魔力";
						}
						if (tooltipLine.text == "+100 max mana and reveals treasure locations")
						{
							tooltipLine.text = "+100魔力上限，显示宝藏位置";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SpiritGenerator"))
					{
						if (tooltipLine.text == "Whenever your minions hit an enemy you will gain a random buff")
						{
							tooltipLine.text = "你的召唤物攻击敌人时会给你一个随机buff";
						}
						if (tooltipLine.text == "These buffs will either boost your defense, summon damage, or life regen for a while")
						{
							tooltipLine.text = "这些buff在增加防御、召唤伤害和生命再生速度中随机选择并持续一段时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Sponge"))
					{
						if (tooltipLine.text == "50% increased mining speed and you emit light")
						{
							tooltipLine.text = "增加50%挖掘速度，你会发光";
						}
						if (tooltipLine.text == "10% increased damage reduction and increased life regen")
						{
							tooltipLine.text = "增加10%伤害减免，增加生命再生速度";
						}
						if (tooltipLine.text == "Poison, Freeze, Chill, Frostburn, and Venom immunity")
						{
							tooltipLine.text = "免疫中毒，冻结，冷冻，霜火和剧毒";
						}
						if (tooltipLine.text == "Honey-like life regen with no speed penalty, +20 max life and mana")
						{
							tooltipLine.text = "受到蜂蜜增益的生命再生时不再降低移动, +20生命上限和魔力上限";
						}
						if (tooltipLine.text == "Most bee/hornet enemies and projectiles do 75% damage to you")
						{
							tooltipLine.text = "绝大多数蜂类敌人及其毒针伤害减少75%";
						}
						if (tooltipLine.text == "120% increased jump speed and 12% increased movement speed")
						{
							tooltipLine.text = "增加12%移动速度，增加120%跳跃速度";
						}
						if (tooltipLine.text == "Standing still boosts life and mana regen")
						{
							tooltipLine.text = "站立不动时增加生命及魔法再生速度";
						}
						if (tooltipLine.text == "Increased defense and damage reduction when submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加防御和伤害减免";
						}
						if (tooltipLine.text == "Increased movement speed when submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加移动速度";
						}
						if (tooltipLine.text == "Enemies take damage when they hit you")
						{
							tooltipLine.text = "敌人击中你时受到伤害";
						}
						if (tooltipLine.text == "Taking a hit will make you move very fast for a short time")
						{
							tooltipLine.text = "受到伤害时会让你暂时增加大量移速";
						}
						if (tooltipLine.text == "You emit a mushroom spore and spark explosion when you are hit")
						{
							tooltipLine.text = "受到伤害会释放爆炸孢子";
						}
						if (tooltipLine.text == "Enemy attacks will have part of their damage absorbed and used to heal you")
						{
							tooltipLine.text = "你会吸收敌人的一部分伤害并治疗自己";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisBeltOfCurses"))
					{
						if (tooltipLine.text == "Increases jump speed and allows constant jumping")
						{
							tooltipLine.text = "让你能多段跳并增加跳跃速度";
						}
						if (tooltipLine.text == "Can climb walls, dash, and dodge attacks")
						{
							tooltipLine.text = "可以攀爬, 冲刺并且闪避";
						}
						if (tooltipLine.text == "10% increased rogue damage and velocity")
						{
							tooltipLine.text = "增加10%盗贼伤害和盗贼投掷速度";
						}
						if (tooltipLine.text == "5% increased rogue crit chance")
						{
							tooltipLine.text = "增加5%盗贼暴击率";
						}
						if (tooltipLine.text == "Increased max minions by 3 and 10% increased minion damage")
						{
							tooltipLine.text = "增加3召唤栏和10%召唤伤害";
						}
						if (tooltipLine.text == "Increased minion knockback")
						{
							tooltipLine.text = "增加召唤物击退";
						}
						if (tooltipLine.text == "Grants shadowflame powers to all minions")
						{
							tooltipLine.text = "召唤物获得暗影炎之力";
						}
						if (tooltipLine.text == "Minions make enemies cry on hit")
						{
							tooltipLine.text = "召唤物能打哭敌人";
						}
						if (tooltipLine.text == "Minion attacks have a chance to instantly kill normal enemies")
						{
							tooltipLine.text = "召唤物攻击有几率直接击杀普通敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisBlessing"))
					{
						if (tooltipLine.text == "Increased max minions by 3 and 10% increased minion damage")
						{
							tooltipLine.text = "增加3召唤栏和10%召唤伤害";
						}
						if (tooltipLine.text == "Increased minion knockback")
						{
							tooltipLine.text = "增加召唤物击退";
						}
						if (tooltipLine.text == "Minions make enemies cry on hit")
						{
							tooltipLine.text = "召唤物能打哭敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisCurse"))
					{
						if (tooltipLine.text == "Increased max minions by 3 and 10% increased minion damage")
						{
							tooltipLine.text = "增加3召唤栏和10%召唤伤害";
						}
						if (tooltipLine.text == "Increased minion knockback")
						{
							tooltipLine.text = "增加召唤物击退";
						}
						if (tooltipLine.text == "Minions make enemies cry on hit")
						{
							tooltipLine.text = "召唤物能打哭敌人";
						}
						if (tooltipLine.text == "Grants shadowflame powers to all minions")
						{
							tooltipLine.text = "召唤物获得暗影炎之力";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatisNinjaBelt"))
					{
						if (tooltipLine.text == "Increases jump speed and allows constant jumping")
						{
							tooltipLine.text = "让你能多段跳并增加跳跃速度";
						}
						if (tooltipLine.text == "Can climb walls, dash, and dodge attacks")
						{
							tooltipLine.text = "可以攀爬, 冲刺并且闪避";
						}
						if (tooltipLine.text == "5% increased rogue damage and velocity")
						{
							tooltipLine.text = "增加5%盗贼伤害和盗贼投掷速度";
						}
						if (tooltipLine.text == "5% increased rogue crit chance")
						{
							tooltipLine.text = "增加5%盗贼暴击率";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StressPills"))
					{
						if (tooltipLine.text == "Boosts your damage by 8%,")
						{
							tooltipLine.text = "增加8%伤害";
						}
						if (tooltipLine.text == "defense by 8, and max movement speed and acceleration by 5%")
						{
							tooltipLine.text = "增加8防御以及5%最大移动速度和加速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SupremeBaitTackleBoxFishingStation"))
					{
						if (tooltipLine.text == "The ultimate fishing accessory")
						{
							tooltipLine.text = "终极钓鱼饰品";
						}
						if (tooltipLine.text == "Increases fishing skill by 100")
						{
							tooltipLine.text = "增加100钓力";
						}
						if (tooltipLine.text == "Fishing line will never break and decreases chance of bait consumption")
						{
							tooltipLine.text = "鱼线绝不会断鱼饵消耗率降低";
						}
						if (tooltipLine.text == "Crate potion effect, does not stack with crate potions")
						{
							tooltipLine.text = "板条箱药剂效果，不与板条箱药剂重叠";
						}
						if (tooltipLine.text == "Sonar potion effect")
						{
							tooltipLine.text = "声呐药剂效果";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheAbsorber"))
					{
						if (tooltipLine.text == "12% increased movement speed")
						{
							tooltipLine.text = "增加12%移动速度";
						}
						if (tooltipLine.text == "120% increased jump speed")
						{
							tooltipLine.text = "增加120跳跃速度";
						}
						if (tooltipLine.text == "+20 max life and mana")
						{
							tooltipLine.text = "+20生命上限和魔力上限";
						}
						if (tooltipLine.text == "Standing still boosts life and mana regen")
						{
							tooltipLine.text = "站立不动时增加生命及魔法再生速度";
						}
						if (tooltipLine.text == "Increased defense and damage reduction when submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加防御和伤害减免";
						}
						if (tooltipLine.text == "Increased movement speed when submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加移动速度";
						}
						if (tooltipLine.text == "Enemies take damage when they hit you")
						{
							tooltipLine.text = "敌人击中你时受到伤害";
						}
						if (tooltipLine.text == "Taking a hit will make you move very fast for a short time")
						{
							tooltipLine.text = "受到伤害时会让你暂时增加大量移速";
						}
						if (tooltipLine.text == "You emit a mushroom spore and spark explosion when you are hit")
						{
							tooltipLine.text = "受到伤害会释放爆炸孢子";
						}
						if (tooltipLine.text == "Enemy attacks will have part of their damage absorbed and used to heal you")
						{
							tooltipLine.text = "你会吸收敌人的一部分伤害并治疗自己";
						}
						if (tooltipLine.text == "5% increased damage reduction")
						{
							tooltipLine.text = "增加5%伤害减免";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheAmalgam"))
					{
						if (tooltipLine.text == "15% increased damage")
						{
							tooltipLine.text = "增加15%伤害";
						}
						if (tooltipLine.text == "Shade rains down when you are hit")
						{
							tooltipLine.text = "被击中后天降阴影之雨";
						}
						if (tooltipLine.text == "You will confuse nearby enemies when you are struck")
						{
							tooltipLine.text = "受到攻击会使你周围的敌人混乱";
						}
						if (tooltipLine.text == "Drops brimstone fireballs from the sky occasionally")
						{
							tooltipLine.text = "时不时会有硫磺火球从天而降";
						}
						if (tooltipLine.text == "Brimstone fire rains down while invincibility is active")
						{
							tooltipLine.text = "处于无敌帧时硫磺火雨会从天而降";
						}
						if (tooltipLine.text == "Temporary immunity to lava, greatly reduces lava burn damage, and 15% increased damage while in lava")
						{
							tooltipLine.text = "暂时免疫岩浆伤害，大幅削弱岩浆灼烧伤害，处于岩浆中时增加15%的伤害";
						}
						if (tooltipLine.text == "Summons a fungal clump to fight for you")
						{
							tooltipLine.text = "召唤一块真菌球为你而战";
						}
						if (tooltipLine.text == "You leave behind poisonous seawater as you move")
						{
							tooltipLine.text = "在水中移动时身后留下剧毒海水";
						}
						if (tooltipLine.text == "75% increased movement speed, 10% increase to all damage, and plus 40 defense while submerged in liquid")
						{
							tooltipLine.text = "完全处于水中增加75%移动速度，10%所有伤害和40防御";
						}
						if (tooltipLine.text == "If you are damaged while submerged in liquid you will gain a damaging aura for a short time")
						{
							tooltipLine.text = "如果完全处于水中时受到伤害，你会短暂获得能造成伤害的光环";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheCommunity"))
					{
						if (tooltipLine.text == "The heart of (most of) the Terraria community")
						{
							tooltipLine.text = "广大泰拉玩家的精神结晶";
						}
						if (tooltipLine.text == "Starts off with weak buffs to all of your stats")
						{
							tooltipLine.text = "早期你会获得增强所有属性的弱buff";
						}
						if (tooltipLine.text == "The stat buffs become more powerful as you progress")
						{
							tooltipLine.text = "随着游戏属性buff将不断强化";
						}
						if (tooltipLine.text == "Reduces the DoT effects of harmful debuffs inflicted on you")
						{
							tooltipLine.text = "减弱持续性伤害debuff对你的影响";
						}
						if (tooltipLine.text == "Boosts your maximum flight time by 15%")
						{
							tooltipLine.text = "增加15%最大飞行时间";
						}
						if (tooltipLine.text == "Thank you to all of my supporters that made this mod a reality")
						{
							tooltipLine.text = "感谢众多支持者的努力，让这一mod成为现实";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheFirstShadowflame"))
					{
						if (tooltipLine.text == "It is said that in the past, Prometheus descended from the heavens to grant man fire.")
						{
							tooltipLine.text = "据说，远古时代，普罗米修斯离开天界，走入人间，并赐予人类源初的火种";
						}
						if (tooltipLine.text == "If that were true, then it is surely the demons of hell that would have risen from below to do the same.")
						{
							tooltipLine.text = "如果那是真的，那么，恶魔们离开地狱做同样的事也就不稀奇了";
						}
						if (tooltipLine.text == "Minions inflict shadowflame on enemy hits.")
						{
							tooltipLine.text = "召唤物附着暗影炎debuff";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VitalJelly"))
					{
						if (tooltipLine.text == "10% increased movement speed")
						{
							tooltipLine.text = "增加10%移动速度";
						}
						if (tooltipLine.text == "200% increased jump speed")
						{
							tooltipLine.text = "增加200%跳跃速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VoidofExtinction"))
					{
						if (tooltipLine.text == "No longer cursed")
						{
							tooltipLine.text = "不再受到诅咒";
						}
						if (tooltipLine.text == "Drops brimstone fireballs from the sky occasionally")
						{
							tooltipLine.text = "时不时会有硫磺火球从天而降";
						}
						if (tooltipLine.text == "15% increase to all damage")
						{
							tooltipLine.text = "增加15%所有伤害";
						}
						if (tooltipLine.text == "Brimstone fire rains down while invincibility is active")
						{
							tooltipLine.text = "处于无敌帧时硫磺火雨会从天而降";
						}
						if (tooltipLine.text == "Temporary immunity to lava, greatly reduces lava burn damage, and 25% increased damage while in lava")
						{
							tooltipLine.text = "暂时免疫岩浆伤害，大幅削弱岩浆灼烧伤害，处于岩浆中时增加25%的伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WifeinaBottle"))
					{
						if (tooltipLine.text == "Summons a sand elemental to fight for you")
						{
							tooltipLine.text = "召唤一个沙暴元素为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WifeinaBottlewithBoobs"))
					{
						if (tooltipLine.text == "Summons a sand elemental to heal you")
						{
							tooltipLine.text = "召唤一个沙暴元素治疗你";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharimsInsignia"))
					{
						if (tooltipLine.text == "10% increased damage when under 50% life")
						{
							tooltipLine.text = "低于50%生命值时增加10%伤害";
						}
						if (tooltipLine.text == "10% increased melee speed")
						{
							tooltipLine.text = "增加10%近战速度";
						}
						if (tooltipLine.text == "5% increased melee damage")
						{
							tooltipLine.text = "增加5%近战伤害";
						}
						if (tooltipLine.text == "Melee attacks and melee projectiles inflict holy fire")
						{
							tooltipLine.text = "近战攻击和弹幕造成神圣之火";
						}
						if (tooltipLine.text == "Increased invincibility after taking damage")
						{
							tooltipLine.text = "增加受伤后无敌时间";
						}
						if (tooltipLine.text == "Temporary immunity to lava")
						{
							tooltipLine.text = "暂时免疫岩浆伤害";
						}
						if (tooltipLine.text == "Increased melee knockback")
						{
							tooltipLine.text = "增加近战击退";
						}
					}
				}
			}
		}
	}
}
