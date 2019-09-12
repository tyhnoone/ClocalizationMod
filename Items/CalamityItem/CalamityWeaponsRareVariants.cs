using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsRareVariants : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Arbalest"))
				{
					item.SetNameOverride("劲弩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Carnage"))
				{
					item.SetNameOverride("屠杀");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ClothiersWrath"))
				{
					item.SetNameOverride("服装商之怒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Cryophobia"))
				{
					item.SetNameOverride("恐寒症");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EvilSmasher"))
				{
					item.SetNameOverride("邪恶克星");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EyeofMagnus"))
				{
					item.SetNameOverride("玛格努斯之眼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrandDad"))
				{
					item.SetNameOverride("“大老爹”");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Hellborn"))
				{
					item.SetNameOverride("地狱之子");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Infinity"))
				{
					item.SetNameOverride("无限");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeadWizard"))
				{
					item.SetNameOverride("铅质巫师帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Norfleet"))
				{
					item.SetNameOverride("诺法雷");
					ModItem item2 = ModLoader.GetMod("CalamityMod").GetItem("Norfleet");
					item2.Tooltip.AddTranslation(GameCulture.Chinese, "(译注：无主之地2中的武器)");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PearlGod"))
				{
					item.SetNameOverride("至臻珍珠枪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Skullmasher"))
				{
					item.SetNameOverride("颅骨击碎者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Swordsplosion"))
				{
					item.SetNameOverride("爆炸剑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ThornBlossom"))
				{
					item.SetNameOverride("荆棘之花");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Thunderstorm"))
				{
					item.SetNameOverride("雷霆风暴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrueConferenceCall"))
				{
					item.SetNameOverride("电话会议");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VoidVortex"))
				{
					item.SetNameOverride("虚空旋涡");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Arbalest"))
					{
						if (tooltipLine.text == "Fires volleys of high-speed arrows")
						{
							tooltipLine.text = "发射一团高速箭矢";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Carnage"))
					{
						if (tooltipLine.text == "Enemies explode into homing blood on death")
						{
							tooltipLine.text = "敌人死亡时炸出追踪血弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Cryophobia"))
					{
						if (tooltipLine.text == "Chill")
						{
							tooltipLine.text = "颤栗";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EvilSmasher"))
					{
						if (tooltipLine.text == "EViL! sMaSH eVIl! SmAsh...ER!")
						{
							tooltipLine.text = "邪恶将被消灭！消灭！邪恶！将被！！消灭/n(译注：无主之地2中的武器)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EyeofMagnus"))
					{
						if (tooltipLine.text == "Fires powerful beams")
						{
							tooltipLine.text = "发射强力射线";
						}
						if (tooltipLine.text == "Heals mana and health on enemy hits")
						{
							tooltipLine.text = "击中敌人会恢复生命值和魔法值";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrandDad"))
					{
						if (tooltipLine.text == "Lowers enemy defense to 0 when they are struck")
						{
							tooltipLine.text = "击中敌人令他们防御归零";
						}
						if (tooltipLine.text == "Yeets enemies across space and time")
						{
							tooltipLine.text = "把敌人打飞至九霄云外超越时空";
						}
						if (tooltipLine.text == "7")
						{
							tooltipLine.text = "7\n(译注：GrandDad的名字和描述出自于一个中国盗版游戏《7 Grand Dad》\n盗版自美国红白机游戏《摩登原始人》 The Flintstones The Rescue of Dino Hoppy)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Hellborn"))
					{
						if (tooltipLine.text == "Converts all bullets to explosive rounds")
						{
							tooltipLine.text = "将所有子弹变为爆炸弹";
						}
						if (tooltipLine.text == "Enemies that touch the gun while it's being fired take massive damage")
						{
							tooltipLine.text = "如果敌人在发射时碰到枪会造成巨量伤害\n(译注：Hellborn，无主之地2中疯子技能名)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Infinity"))
					{
						if (tooltipLine.text == "Bad PC")
						{
							tooltipLine.text = "破电脑";
						}
						if (tooltipLine.text == "Fires a barrage of energy bolts that split and bounce")
						{
							tooltipLine.text = "发射一团会分裂弹射的能量子弹";
						}
						if (tooltipLine.text == "Right click to fire a barrage of normal bullets")
						{
							tooltipLine.text = "右击可发射一连串普通子弹";
						}
						if (tooltipLine.text == "They say infinity is neverending, yet you hold it in your hands")
						{
							tooltipLine.text = "他们说无限即是永恒，而你却把它握在手中";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeadWizard"))
					{
						if (tooltipLine.text == "Something's not right...")
						{
							tooltipLine.text = "好像有什么不对...";
						}
						if (tooltipLine.text == "33% chance to not consume ammo")
						{
							tooltipLine.text = "33%几率不消耗弹药\n(译注：源于《以撒的结合》中的巫师帽 The Wiz)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PearlGod"))
					{
						if (tooltipLine.text == "Your life is mine...")
						{
							tooltipLine.text = "你的生命，是我的了...";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Skullmasher"))
					{
						if (tooltipLine.text == "Sniper shotgun, because why not?")
						{
							tooltipLine.text = "狙击霰弹枪，为什么不呢？";
						}
						if (tooltipLine.text == "If you crit the target a second swarm of bullets will fire near the target")
						{
							tooltipLine.text = "如果子弹对目标暴击则会在其身周散射出第二梭子弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Swordsplosion"))
					{
						if (tooltipLine.text == "Sword swarm")
						{
							tooltipLine.text = "剑群来袭\n(译注：无主之地2同名护盾)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ThornBlossom"))
					{
						if (tooltipLine.text == "Every rose has its thorn")
						{
							tooltipLine.text = "每朵玫瑰都有刺";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ThornBlossom"))
					{
						if (tooltipLine.text == "Make it rain")
						{
							tooltipLine.text = "暴雨将临";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrueConferenceCall"))
					{
						if (tooltipLine.text == "@everyone")
						{
							tooltipLine.text = "@全体成员";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VoidVortex"))
					{
						if (tooltipLine.text == "Fires a circular spread of magnetic orbs around the mouse cursor")
						{
							tooltipLine.text = "鼠标周围散射呈环形运动的电磁球";
						}
					}
				}
			}
		}
	}
}
