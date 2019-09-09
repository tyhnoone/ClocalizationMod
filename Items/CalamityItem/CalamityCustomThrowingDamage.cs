using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityCustomThrowingDamage : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AccretionDisk"))
				{
					item.SetNameOverride("元素飞盘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AdamantiteThrowingAxe"))
				{
					item.SetNameOverride("精金飞斧");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BallisticPoisonBomb"))
				{
					item.SetNameOverride("子母追魂夺命胆");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrackishFlask"))
				{
					item.SetNameOverride("盐水瓶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Brimblade"))
				{
					item.SetNameOverride("硫磺火刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Celestus"))
				{
					item.SetNameOverride("星神之杀");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CobaltKunai"))
				{
					item.SetNameOverride("钴蓝苦无");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmicKunai"))
				{
					item.SetNameOverride("星体苦无");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CraniumSmasher"))
				{
					item.SetNameOverride("碎颅磨盘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrushsawCrasher"))
				{
					item.SetNameOverride("硫火飞爪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Crystalline"))
				{
					item.SetNameOverride("晶体飞刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrystalPiercer"))
				{
					item.SetNameOverride("水晶穿透者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CursedDagger"))
				{
					item.SetNameOverride("咒炎匕首");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DuststormInABottle"))
				{
					item.SetNameOverride("瓶中尘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EmpyreanKnivesThrown"))
				{
					item.SetNameOverride("苍穹飞刀");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Eradicator"))
				{
					item.SetNameOverride("湮灭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ExecutionersBlade"))
				{
					item.SetNameOverride("终结者之刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FeatherKnife"))
				{
					item.SetNameOverride("羽刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FlameScythe"))
				{
					item.SetNameOverride("灼热之镰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostyFlare"))
				{
					item.SetNameOverride("霜火信号弹");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GalaxySmasherRogue"))
				{
					item.SetNameOverride("银河裂碎");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GelDart"))
				{
					item.SetNameOverride("凝胶飞镖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GhoulishGouger"))
				{
					item.SetNameOverride("狱卒之镰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HeavenfallenStardisk"))
				{
					item.SetNameOverride("堕天星盘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Icebreaker"))
				{
					item.SetNameOverride("破冰者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IceStar"))
				{
					item.SetNameOverride("冰花");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IchorSpear"))
				{
					item.SetNameOverride("灵液标枪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Lionfish"))
				{
					item.SetNameOverride("狮子鱼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Malachite"))
				{
					item.SetNameOverride("孔雀翎");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MangroveChakram"))
				{
					item.SetNameOverride("红木环刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeteorFist"))
				{
					item.SetNameOverride("陨星拳");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MoltenAmputator"))
				{
					item.SetNameOverride("熔岩切割者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Mycoroot"))
				{
					item.SetNameOverride("狂菌根刺");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MythrilKnife"))
				{
					item.SetNameOverride("秘银飞刀");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NanoblackReaperRogue"))
				{
					item.SetNameOverride("黑色纳米收割者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OrichalcumSpikedGemstone"))
				{
					item.SetNameOverride("山铜宝石钉");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PalladiumJavelin"))
				{
					item.SetNameOverride("钯金投矛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Prismalline"))
				{
					item.SetNameOverride("棱晶飞刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedTrident"))
				{
					item.SetNameOverride("炼火狱矛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Pwnagehammer"))
				{
					item.SetNameOverride("圣时之锤");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RadiantStar"))
				{
					item.SetNameOverride("光辉星匕");
				}
				
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			bool rogue = false;
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (tooltipLine.Name == "Damage")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("rogue ", "盗贼");
						tooltipLine.text = resultA;
						if(resultA!=str) rogue =true;
					}
					if (tooltipLine.text == "Legendary Drop")
					{
						tooltipLine.text = "传奇物品";
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AccretionDisk"))
					{
						if (tooltipLine.text == "Throws a disk that has a chance to generate several disks if enemies are near it")
						{
							tooltipLine.text = "如果敌人靠近它，则抛出一个有概率分裂开多个的飞盘";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BallisticPoisonBomb"))
					{
						if (tooltipLine.text == "Throws a sticky bomb that explodes into spikes and poison clouds")
						{
							tooltipLine.text = "投掷一枚粘弹，炸成尖刺和毒云";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrackishFlask"))
					{
						if (tooltipLine.text == "Explodes into poisonous seawater blasts")
						{
							tooltipLine.text = "爆炸飞溅剧毒海水";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Brimblade"))
					{
						if (tooltipLine.text == "Throws a blade that splits on enemy hits")
						{
							tooltipLine.text = "投掷一把在击中敌人时分裂的刀刃";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Celestus"))
					{
						if (tooltipLine.text == "Throws a scythe that splits into multiple scythes on enemy hits")
						{
							tooltipLine.text = "投掷一把在击中敌人时分裂的镰刀";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmicKunai"))
					{
						if (tooltipLine.text == "Fires a stream of short-range kunai")
						{
							tooltipLine.text = "发射一串短距离苦无";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CraniumSmasher"))
					{
						if (tooltipLine.text == "Throws disks that roll on the ground, occasionally launches an explosive disk")
						{
							tooltipLine.text = "投掷在地上翻滚的磨盘，有时会掷出爆炸磨盘";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrushsawCrasher"))
					{
						if (tooltipLine.text == "Throws bouncing axes")
						{
							tooltipLine.text = "投掷弹跳爪斧";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Crystalline"))
					{
						if (tooltipLine.text == "Splits into several projectiles as it travels")
						{
							tooltipLine.text = "投掷时分裂成几个飞刀";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CursedDagger"))
					{
						if (tooltipLine.text == "Throws bouncing daggers")
						{
							tooltipLine.text = "投掷反弹匕首";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DuststormInABottle"))
					{
						if (tooltipLine.text == "Explodes into a dust cloud")
						{
							tooltipLine.text = "炸裂成一团粉尘云";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EmpyreanKnivesThrown"))
					{
						if (tooltipLine.text == "Throws a flurry of bouncing knives that can heal the user")
						{
							tooltipLine.text = "抛出一堆可以治疗使用者的反弹飞刀";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Eradicator"))
					{
						if (tooltipLine.text == "Throws a disk that fires lasers at nearby enemies")
						{
							tooltipLine.text = "投掷一个飞盘，向附近的敌人发射激光";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ExecutionersBlade"))
					{
						if (tooltipLine.text == "Throws a stream of homing blades")
						{
							tooltipLine.text = "抛出一堆跟踪飞刀";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FlameScythe"))
					{
						if (tooltipLine.text == "Throws a scythe that explodes on enemy hits")
						{
							tooltipLine.text = "投掷一个在命中敌人时爆炸的镰刀";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostyFlare"))
					{
						if (tooltipLine.text == "Sticks to enemies")
						{
							tooltipLine.text = "扎入敌人";
						}
						if (tooltipLine.text == "Generates a localized hailstorm")
						{
							tooltipLine.text = "产生小范围冰霜风";
						}
						if (tooltipLine.text == "'Do not insert in flare gun'")
						{
							tooltipLine.text = "“无需填进信号枪”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GalaxySmasherRogue"))
					{
						if (tooltipLine.text == "Explodes and summons death lasers on enemy hits")
						{
							tooltipLine.text = "击中敌人爆炸并召唤死亡激光";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GelDart"))
					{
						if (tooltipLine.text == "Throws bouncing darts")
						{
							tooltipLine.text = "投掷弹跳飞镖";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GhoulishGouger"))
					{
						if (tooltipLine.text == "Throws a ghoulish scythe that ignores immunity frames")
						{
							tooltipLine.text = "投掷一把无视地形的残影镰刀";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HeavenfallenStardisk"))
					{
						if (tooltipLine.text == "Throws a stardisk upwards which then launches itself towards your mouse cursor,")
						{
							tooltipLine.text = "向上掷出一枚星盘，之后会击向鼠标位置处";
						}
						if (tooltipLine.text == "explodes into several astral energy bolts if the thrower is moving vertically when throwing it and during its impact")
						{
							tooltipLine.text = "在玩家垂直移动时，星盘会在击中敌人后炸开，向四周散射幻星法球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IceStar"))
					{
						if (tooltipLine.text == "Throws homing ice stars")
						{
							tooltipLine.text = "投出追踪的冰花";
						}
						if (tooltipLine.text == "Ice Stars are too brittle to be recovered after being thrown")
						{
							tooltipLine.text = "用冰做的雪花太脆了，丢出去就会成为碎片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Lionfish"))
					{
						if (tooltipLine.text == "Sticks to enemies and injects a potent toxin")
						{
							tooltipLine.text = "粘在敌人身上注射一种强力毒素";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Malachite"))
					{
						if (tooltipLine.text == "Striking an enemy with the blade causes an earthen eruption")
						{
							tooltipLine.text = "用剑击中敌人时，庇护之光会爆发出火焰";
						}
						if (tooltipLine.text == "Right click to fire an aegis bolt that costs 4 mana")
						{
							tooltipLine.text = "右键发射庇护火矢，消耗4魔法";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeteorFist"))
					{
						if (tooltipLine.text == "Fires a fist that explodes")
						{
							tooltipLine.text = "发射一个爆炸的拳头";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MoltenAmputator"))
					{
						if (tooltipLine.text == "Throws a scythe that emits molten globs on enemy hits")
						{
							tooltipLine.text = "投掷一把镰刀，在敌人击中时发出熔化的球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Mycoroot"))
					{
						if (tooltipLine.text == "Fires a stream of short-range fungal roots")
						{
							tooltipLine.text = "疯狂发射短距离根系";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NanoblackReaperRogue"))
					{
						if (tooltipLine.text == "Unleashes a storm of nanoblack energy blades")
						{
							tooltipLine.text = "释放风暴般的黑色纳米能量刀片";
						}
						if (tooltipLine.text == "Blades target bosses whenever possible")
						{
							tooltipLine.text = "刀刃以攻击目标Boss为优先";
						}
						if (tooltipLine.text == "'She smothered them in Her hatred'")
						{
							tooltipLine.text = "“她在仇恨中扼杀了他们”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Prismalline"))
					{
						if (tooltipLine.text == "Throws daggers that split after a while")
						{
							tooltipLine.text = "投掷会在一小段时间后分裂的匕首";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedTrident"))
					{
						if (tooltipLine.text == "Throws a homing spear that explodes on enemy hits")
						{
							tooltipLine.text = "投掷追踪敌人的矛，在命中时爆炸";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Pwnagehammer"))
					{
						if (tooltipLine.text == "Throws an extremely fast hammer")
						{
							tooltipLine.text = "投掷一个极快的锤子";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RadiantStar"))
					{
						if (tooltipLine.text == "Throws daggers that explode and split after a while")
						{
							tooltipLine.text = "投掷一小段时间后会分裂的匕首";
						}
					}
					
				}
				
				if (rogue)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "rogue", "-盗贼职业-")
					{
						overrideColor = new Color?(Color.RosyBrown)
					});
				}
				if (!rogue && item.ranged)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "range", "-射手职业-")
					{
						overrideColor = new Color?(Color.MediumSpringGreen)
					});
				}
			}
		}
	}
}
