using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityKnowledge : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge"))
				{
					item.SetNameOverride("荒漠灾虫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge2"))
				{
					item.SetNameOverride("猪鲨公爵");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge3"))
				{
					item.SetNameOverride("克苏鲁之眼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge4"))
				{
					item.SetNameOverride("月教至尊");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge5"))
				{
					item.SetNameOverride("菌生蟹");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge6"))
				{
					item.SetNameOverride("硫磺火之崖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge7"))
				{
					item.SetNameOverride("地狱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge8"))
				{
					item.SetNameOverride("猩红之地");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge9"))
				{
					item.SetNameOverride("腐化之地");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge10"))
				{
					item.SetNameOverride("海洋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge11"))
				{
					item.SetNameOverride("克苏鲁之脑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge12"))
				{
					item.SetNameOverride("世界吞噬者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge13"))
				{
					item.SetNameOverride("血肉寄生者和宿主");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge14"))
				{
					item.SetNameOverride("腐巢意志");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge15"))
				{
					item.SetNameOverride("史莱姆之神");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge16"))
				{
					item.SetNameOverride("蜂后");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge17"))
				{
					item.SetNameOverride("骷髅王");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge18"))
				{
					item.SetNameOverride("血肉之墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge19"))
				{
					item.SetNameOverride("极地之灵");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge20"))
				{
					item.SetNameOverride("机械暴乱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge21"))
				{
					item.SetNameOverride("机械毁灭者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge22"))
				{
					item.SetNameOverride("双子魔眼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge23"))
				{
					item.SetNameOverride("钢铁骷髅王");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge24"))
				{
					item.SetNameOverride("灾厄之影");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge25"))
				{
					item.SetNameOverride("世纪之花");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge26"))
				{
					item.SetNameOverride("硫磺火元素");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge27"))
				{
					item.SetNameOverride("渊海灾虫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge28"))
				{
					item.SetNameOverride("利维坦和塞壬");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge29"))
				{
					item.SetNameOverride("星神游龙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge30"))
				{
					item.SetNameOverride("白金之星");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge31"))
				{
					item.SetNameOverride("石巨人");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge32"))
				{
					item.SetNameOverride("瘟疫使者歌莉娅");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge33"))
				{
					item.SetNameOverride("毁灭魔像");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge34"))
				{
					item.SetNameOverride("血月");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge35"))
				{
					item.SetNameOverride("沉沦之渊");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge36"))
				{
					item.SetNameOverride("彗星地");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge37"))
				{
					item.SetNameOverride("月球领主");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge38"))
				{
					item.SetNameOverride("亵渎守卫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge39"))
				{
					item.SetNameOverride("亵渎天神，普罗维登斯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge40"))
				{
					item.SetNameOverride("吞噬者的仆从");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge41"))
				{
					item.SetNameOverride("噬魂幽花");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge42"))
				{
					item.SetNameOverride("神明吞噬者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge43"))
				{
					item.SetNameOverride("嗡嗡蜂鸟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge44"))
				{
					item.SetNameOverride("丛林龙，犽戎");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge45"))
				{
					item.SetNameOverride("灾厄");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge"))
					{
						if (tooltipLine.text == "The great sea worm appears to have survived the extreme heat and has even adapted to it.")
						{
							tooltipLine.text = "庞大的海虫似乎从极度的炎热之中存活下来了，甚至完全适应了此处";
						}
						if (tooltipLine.text == "What used to be a majestic beast swimming through the water has now become a dried-up and")
						{
							tooltipLine.text = "曾于水中畅游的巨兽现如今变得干燥而贪食";
						}
						if (tooltipLine.text == "gluttonous husk, constantly on a voracious search for its next meal.")
						{
							tooltipLine.text = "他不断地寻找着下一顿美餐";
						}
						if (tooltipLine.text == "Place in your inventory for an increase to defense while in the desert or sunken sea.")
						{
							tooltipLine.text = "在沙漠或沉沦之海中增加防御，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge2"))
					{
						if (tooltipLine.text == "The mutant terror of the sea was once the trusted companion of an old king; he tamed it using its favorite treat.")
						{
							tooltipLine.text = "这个来自大海的象征着恐惧的畸变生物是曾经某位旧主的可靠伙伴；他用它最喜爱的食物驯养着它";
						}
						if (tooltipLine.text == "Long ago, the creature flew in desperation from the raging bloody inferno consuming its home, ultimately finding its way to the ocean.")
						{
							tooltipLine.text = "很久以前，这只生物绝望的飞离了被硫磺火蒸腾的大海。那是它曾经的家乡，而他不得不另寻住处";
						}
						if (tooltipLine.text == "Place in your inventory for an increase to all damage, crit, and movement speed while submerged in liquid.")
						{
							tooltipLine.text = "在水中增加所有伤害，暴击率和移速，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge3"))
					{
						if (tooltipLine.text == "That eye...how peculiar.")
						{
							tooltipLine.text = "这眼睛...相当让人不适";
						}
						if (tooltipLine.text == "I sensed it watching you more intensely as you grew stronger.")
						{
							tooltipLine.text = "我感觉你越强大，它就越会警觉地观察你";
						}
						if (tooltipLine.text == "Place in your inventory for night vision at night.")
						{
							tooltipLine.text = "在晚上获得夜视能力，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge4"))
					{
						if (tooltipLine.text == "The gifted one that terminated my grand summoning so long ago with his uncanny powers over the arcane.")
						{
							tooltipLine.text = "他是天赐之人，很久以前用他的怪异奥术终结了我的召唤。";
						}
						if (tooltipLine.text == "Someone I once held in such contempt for his actions is now...deceased, his sealing ritual undone...prepare for the end.")
						{
							tooltipLine.text = "我手下曾经鄙视嘲讽他的人如今...都已经死了，他的封印仪式被取消了...准备末日的降临吧.";
						}
						if (tooltipLine.text == "Your impending doom approaches...")
						{
							tooltipLine.text = "你即将来临的厄运...";
						}
						if (tooltipLine.text == "Place in your inventory for an increase to all stats during the lunar event.")
						{
							tooltipLine.text = "月球入侵时增加所有属性，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge5"))
					{
						if (tooltipLine.text == "A crab and its mushrooms, a love story.")
						{
							tooltipLine.text = "螃蟹和它的蘑菇，爱情佳话";
						}
						if (tooltipLine.text == "It's interesting how creatures can adapt given certain circumstances.")
						{
							tooltipLine.text = "这些生物，能适应各种特殊环境，真有趣";
						}
						if (tooltipLine.text == "Place in your inventory to gain the Mushy buff while underground or in the mushroom biome.")
						{
							tooltipLine.text = "在地下和蘑菇地中时，获得粘稠效果，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge6"))
					{
						if (tooltipLine.text == "Ah...this place.")
						{
							tooltipLine.text = "啊...这个地方.";
						}
						if (tooltipLine.text == "The scent of broken promises, pain, and eventual death is heavy in the air...")
						{
							tooltipLine.text = "处处弥漫着痛苦，破灭的承诺和终有一死的绝望气息...";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge7"))
					{
						if (tooltipLine.text == "These obsidian and hellstone towers were once home to thousands of...'people'.")
						{
							tooltipLine.text = "这些黑曜石塔和狱炎塔，曾经是无数...'人'的家园";
						}
						if (tooltipLine.text == "Unfortunately for them, they were twisted by their inner demons until they were beyond saving.")
						{
							tooltipLine.text = "很遗憾，他们被内心的恶魔们扭曲了，他们最终不值得被救赎";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge8"))
					{
						if (tooltipLine.text == "This bloody hell, spawned from a formless mass of flesh that fell from the stars eons ago.")
						{
							tooltipLine.text = "形成这个血腥地狱的，是无数团数世纪前自星空落下的，无形无相的血肉";
						}
						if (tooltipLine.text == "It is now home to many hideous creatures, spawned from the pumping blood and lurching organs deep within.")
						{
							tooltipLine.text = "这地方现如今一群自地底深处跳动的血泵和奇形怪状的器官中诞生出的丑陋而可怕的怪物家园";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge9"))
					{
						if (tooltipLine.text == "The rotten and forever-deteriorating landscape of infected life, brought upon by a deadly microbe long ago.")
						{
							tooltipLine.text = "这片腐烂破败，持续恶化的腐化生物们的家园，是很久前由一个致命的细菌带来的";
						}
						if (tooltipLine.text == "It is rumored that the microbe was created through experimentation by a long-dead race, predating the Terrarians.")
						{
							tooltipLine.text = "传闻这个细菌是由一群存在于比如今泰拉人类还要古老的种族创造的";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge10"))
					{
						if (tooltipLine.text == "Take care to not disturb the deep waters of this world.")
						{
							tooltipLine.text = "小心，莫要惊扰深渊";
						}
						if (tooltipLine.text == "You may awaken something more terrifying than death itself.")
						{
							tooltipLine.text = "你或许会唤醒比死亡更可怕的东西";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge11"))
					{
						if (tooltipLine.text == "An eye and now a brain.")
						{
							tooltipLine.text = "之前是眼睛，现在又来了个大脑";
						}
						if (tooltipLine.text == "Most likely another abomination spawned from this inchoate mass of flesh.")
						{
							tooltipLine.text = "看起来，另一个怪物很大可能也是自这大块不完整的血肉中诞生的";
						}
						if (tooltipLine.text == "Allows you to teleport similar to the Rod of Discord while in the crimson. Place in your hotbar to use it.")
						{
							tooltipLine.text = "让你在血腥之地中获得位裂法杖的能力. 放置在顶部快速使用栏中使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge12"))
					{
						if (tooltipLine.text == "Perhaps it was just a giant worm infected by the microbe, given centuries to feed and grow its festering body.")
						{
							tooltipLine.text = "也许就是被那种细菌感染的虫子，在长达数世纪的吞食和成长中获得了这副腐败的身躯";
						}
						if (tooltipLine.text == "Seems likely, given the origins of this place.")
						{
							tooltipLine.text = "考虑到此地的起源，这很有可能";
						}
						if (tooltipLine.text == "Deadly microbes spawn around you while this is placed in your inventory.")
						{
							tooltipLine.text = "致命细菌会环绕周身，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge13"))
					{
						if (tooltipLine.text == "An abomination of comingled flesh, bone, and organ, infested primarily by blood-slurping worms.")
						{
							tooltipLine.text = "一只混合了血肉，骨头和器官的混合体，最初被吸血的虫子所寄生";
						}
						if (tooltipLine.text == "The chunks left over from the brain must have been absorbed by the crimson and reconstituted into it.")
						{
							tooltipLine.text = "那个大脑所分离的肉块或许已经被这猩红的大地所吸收并重组成了这个东西";
						}
						if (tooltipLine.text == "Place in your inventory for all of your projectiles to inflict ichor when in the crimson.")
						{
							tooltipLine.text = "在血腥之地，你的所有弹幕附着灵液效果，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge13"))
					{
						if (tooltipLine.text == "A hive of clustered microbial-infected flesh.")
						{
							tooltipLine.text = "被细菌腐化的生物们的巢心";
						}
						if (tooltipLine.text == "I do not believe killing it will lessen the corruption here.")
						{
							tooltipLine.text = "我不认为杀掉它就会停止腐化的散播";
						}
						if (tooltipLine.text == "Place in your inventory for all of your projectiles to inflict cursed flames when in the corruption.")
						{
							tooltipLine.text = "在腐化之地，你的所有弹幕附着诅咒之炎效果，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge14"))
					{
						if (tooltipLine.text == "It is a travesty, one of the most threatening biological terrors ever created.")
						{
							tooltipLine.text = "荒谬的是，这是有史以来最令人恐惧，最具威胁性的生命";
						}
						if (tooltipLine.text == "I do not believe killing it will lessen the corruption here.")
						{
							tooltipLine.text = "我不认为杀掉它就会停止腐化的散播";
						}
						if (tooltipLine.text == "Place in your inventory for all of your projectiles to inflict cursed flames when in the corruption.")
						{
							tooltipLine.text = "在腐化之地，你的所有弹幕附着诅咒之炎效果，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge15"))
					{
						if (tooltipLine.text == "It is a travesty, one of the most threatening biological terrors ever created.")
						{
							tooltipLine.text = "荒谬的是，这是有史以来最令人恐惧，最具威胁性的生命";
						}
						if (tooltipLine.text == "If this creature were allowed to combine every slime on the planet it would become nearly unstoppable.")
						{
							tooltipLine.text = "如果这个生物能够融合星球之上所有史莱姆的话，它将不可阻挡";
						}
						if (tooltipLine.text == "Place in your inventory to become slimed and able to slide around on tiles quickly, at the cost of reduced defense.")
						{
							tooltipLine.text = "在身上裹层凝胶，增加行走速度，放在背包中会生效，以减少防御为代价";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge16"))
					{
						if (tooltipLine.text == "As crude as the giant insects are they can prove useful in certain situations...given the ability to control them.")
						{
							tooltipLine.text = "跟那些巨型昆虫一样残忍，特定情况下她们会证明自身的作用...比如在被控制时";
						}
						if (tooltipLine.text == "Place in your inventory to make small bees and weak hornets friendly.")
						{
							tooltipLine.text = "放在背包中小蜜蜂和较弱的马蜂将变得亲和";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge17"))
					{
						if (tooltipLine.text == "The curse is said to only affect the elderly.")
						{
							tooltipLine.text = "据传，这个诅咒只对长者有效";
						}
						if (tooltipLine.text == "After they are afflicted they become an immortal vessel for an ancient demon of the underworld.")
						{
							tooltipLine.text = "当他们被诅咒时，他们就成为了地狱中的一个远古恶魔夺舍的躯壳";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased defense and damage while in the dungeon.")
						{
							tooltipLine.text = "在地牢中增加防御和伤害，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge18"))
					{
						if (tooltipLine.text == "I see the deed is done.")
						{
							tooltipLine.text = "契约，已成";
						}
						if (tooltipLine.text == "The unholy amalgamation of flesh and hatred has been defeated.")
						{
							tooltipLine.text = "那个污浊的，由血肉和憎恨所融合而成的怪物死了";
						}
						if (tooltipLine.text == "Prepare to face the terrors that lurk in the light and dark parts of this world.")
						{
							tooltipLine.text = "准备迎接潜藏在这世界的光与暗之中的真正的恐惧吧";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased item grab range.")
						{
							tooltipLine.text = "增加物品捡拾距离，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge19"))
					{
						if (tooltipLine.text == "The archmage's prison.")
						{
							tooltipLine.text = "关押冰法师的监狱";
						}
						if (tooltipLine.text == "I am unsure if it has grown weaker over the decades of imprisonment.")
						{
							tooltipLine.text = "不过我不清楚在数十年的禁锢后，它是否失去了部分力量";
						}
						if (tooltipLine.text == "Place in your inventory to gain a frost dash that freezes enemies, at the cost of slightly reduced defense.")
						{
							tooltipLine.text = "获得冰霜冲刺能力，撞上敌人会冻住他们，放在背包中会生效，稍微减少防御";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge20"))
					{
						if (tooltipLine.text == "I see you have awakened Draedon's old toys.")
						{
							tooltipLine.text = "我看你已唤醒了嘉登的一些小玩具";
						}
						if (tooltipLine.text == "Once useful tools turned into savage beasts when their AIs went rogue, a mistake that Draedon failed to rectify in time.")
						{
							tooltipLine.text = "这些曾经大有用处的工具，在嘉登的一次错误调试后AI出bug并暴走了";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge21"))
					{
						if (tooltipLine.text == "A machine brought to life by the mighty souls of warriors, and built to excavate massive tunnels in planets to gather resources.")
						{
							tooltipLine.text = "用强大的战士灵魂激活的机械虫子，用于在各个星球之中挖掘隧道以收集矿产资源";
						}
						if (tooltipLine.text == "Could have proven useful if Draedon didn't have an obsession with turning everything into a tool of destruction.")
						{
							tooltipLine.text = "如果嘉登不醉心于把什么东西都变成毁灭的工具的话，它本可以发挥大用的";
						}
						if (tooltipLine.text == "Place in your inventory to gain a boost to your pick speed.")
						{
							tooltipLine.text = "增加挖掘速度，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge22"))
					{
						if (tooltipLine.text == "The bio-mechanical watchers of the night, originally created as security using the souls extracted from human eyes.")
						{
							tooltipLine.text = "夜晚的生化机械看守者，由从人类眼中提取出的灵魂精粹创造而出";
						}
						if (tooltipLine.text == "These creatures did not belong in this world, it's best to be rid of them.")
						{
							tooltipLine.text = "这种生物不应当存在于这个世界，最好让它们消失";
						}
						if (tooltipLine.text == "Place in your inventory to gain invisibility at night.")
						{
							tooltipLine.text = "夜晚增加无敌时间，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge23"))
					{
						if (tooltipLine.text == "What a silly and pointless contraption for something created with the essence of pure terror.")
						{
							tooltipLine.text = "用纯净的恐惧之力打造这么个愚蠢而毫无意义的机器，多么暴殄天物啊";
						}
						if (tooltipLine.text == "Draedon obviously took several liberties with its design...I am not impressed.")
						{
							tooltipLine.text = "很明显，嘉登对他的设计做出了一些“灵活”改动，这并不让我感到新奇";
						}
						if (tooltipLine.text == "Place in your inventory to gain a boost to your armor penetration.")
						{
							tooltipLine.text = "增加护甲穿透，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge24"))
					{
						if (tooltipLine.text == "You are indeed stronger than I thought.")
						{
							tooltipLine.text = "你确实比我想象的要强不少";
						}
						if (tooltipLine.text == "Though the bloody inferno still lingers, observing your progress.")
						{
							tooltipLine.text = "不过那团猩红狱火仍然在注视着你，监视着你的发展";
						}
						if (tooltipLine.text == "Place in your inventory to gain a boost to your minion slots but at the cost of reduced max health.")
						{
							tooltipLine.text = "减少生命上限，增加1召唤栏，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge25"))
					{
						if (tooltipLine.text == "Well done, you killed a plant.")
						{
							tooltipLine.text = "恭喜你，你干掉了一朵花儿";
						}
						if (tooltipLine.text == "It was used as a vessel to house the spirits of those unfortunate enough to find their way down here.")
						{
							tooltipLine.text = "它是一所囚笼，用于囚禁那些不幸到此的灵魂";
						}
						if (tooltipLine.text == "I wish you luck in dealing with the fallout.")
						{
							tooltipLine.text = "杀死它会引发许多后果，祝你好运";
						}
						if (tooltipLine.text == "Place in your inventory to gain a boost to your item grab range.")
						{
							tooltipLine.text = "极大增加物品捡拾距离，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge26"))
					{
						if (tooltipLine.text == "The most powerful of the elementals, bent on exacting revenge upon the bloody inferno that demolished her home.")
						{
							tooltipLine.text = "所有元素态生命中最强大的存在，一直以来迷失于向毁灭她家乡的猩红狱火复仇的扭曲心智之中";
						}
						if (tooltipLine.text == "Finally put to rest, she will suffer no longer from the grief caused by the deaths of her people.")
						{
							tooltipLine.text = "她终于不会再去忍受她的追随者全部死亡的痛苦之中了";
						}
						if (tooltipLine.text == "Place in your inventory to improve the inferno potion effect.")
						{
							tooltipLine.text = "强化狱火药水的效果，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge27"))
					{
						if (tooltipLine.text == "A horror born of pollution and insatiable hunger; based on size alone this was merely a juvenile.")
						{
							tooltipLine.text = "在污染与贪食之中诞生的恐怖存在。据研究，当前大小的渊海灾虫只是青年时期的";
						}
						if (tooltipLine.text == "These scourge creatures are the largest aquatic predators and very rarely do they frequent such shallow waters..")
						{
							tooltipLine.text = "这些灾虫生物是海洋中最大的捕食者，不过它们很少出现在浅海之中";
						}
						if (tooltipLine.text == "Place in your inventory to gain immunity to the sulphurous waters and increase the stat gains from the Well Fed buff.")
						{
							tooltipLine.text = "免疫硫磺海的污染，增幅饱腹加成的各项属性，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge28"))
					{
						if (tooltipLine.text == "An odd pair of creatures; one seeking companionship and the other seeking sustenance.")
						{
							tooltipLine.text = "一对诡异的生物。一个在寻找伙伴，另一个在寻找食物";
						}
						if (tooltipLine.text == "Perhaps two genetic misfits outcast from their homes that found comfort in assisting one another.")
						{
							tooltipLine.text = "或许两个基因怪异的生物被家乡抛弃，并在相互扶持后才安稳了下来";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased max health while wearing the siren heart and treasure detect while wearing the strange orb.")
						{
							tooltipLine.text = "佩戴塞壬之心饰品时增加生命上限，佩戴奇光球时能感知到附近的宝物位置，放在背包中会生效";
						}
						if (tooltipLine.text == "Allows the young siren pet to move normally while outside of liquids.")
						{
							tooltipLine.text = "允许小塞壬宠物在液体外正常移动";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge29"))
					{
						if (tooltipLine.text == "God of the stars and largest vessel for the Astral Infection.")
						{
							tooltipLine.text = "星体之神，星体瘟疫的散播者";
						}
						if (tooltipLine.text == "Though struck down from its place among the stars its remnants have gathered strength, aiming to take its rightful place in the cosmos once more.")
						{
							tooltipLine.text = "尽管它失去它在群星之中本该有的地位，它仍在聚集残余力量，准备夺回宇宙中属于它的一切";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased movement speed in space.")
						{
							tooltipLine.text = "在太空中增加移速，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge30"))
					{
						if (tooltipLine.text == "A titanic cyborg infected by a star-borne disease expelled from the belly of an ancient god.")
						{
							tooltipLine.text = "从远古之神腹中排出的星体瘟疫所感染的巨型电子半机械生物";
						}
						if (tooltipLine.text == "The destruction of this creature will not prevent the spread of the disease.")
						{
							tooltipLine.text = "即便是击杀它也无法阻挡瘟疫的传播";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased jump speed in space.")
						{
							tooltipLine.text = "在宇宙中增加跳跃速度，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge31"))
					{
						if (tooltipLine.text == "A primitive construct.")
						{
							tooltipLine.text = "原始机械";
						}
						if (tooltipLine.text == "I admire the lihzahrd race for their ingenuity, though finding faith in such a flawed idol would invariably lead to their downfall.")
						{
							tooltipLine.text = "我羡慕蜥蜴族的心灵手巧，虽然崇拜这么个满是瑕疵的玩偶必然会令他们的族群走向衰亡";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased defense while standing still.")
						{
							tooltipLine.text = "站立不动时增加防御力，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge32"))
					{
						if (tooltipLine.text == "A horrific amalgam of steel, flesh, and infection, capable of destroying an entire civilization in just one onslaught.")
						{
							tooltipLine.text = "合金，血肉和瘟疫的恐怖组合体，仅需一击就可以摧毁一整个文明";
						}
						if (tooltipLine.text == "Its plague nuke barrage can leave an entire area uninhabitable for months. A shame that it came to this but the plague must be contained.")
						{
							tooltipLine.text = "她携带的瘟疫核弹井可以让一片地区数月之间千里无烟寸草不生。很遗憾，这件事已经发生了。我必须控制住瘟疫";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased wing flight time but at the cost of reduced life regen.")
						{
							tooltipLine.text = "增加翅膀飞行时间，减少生命恢复速度，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge33"))
					{
						if (tooltipLine.text == "The flesh golem constructed using twisted necromancy during the time of my conquest to counter my unstoppable forces.")
						{
							tooltipLine.text = "于吾之征服不可阻挡之时，用扭曲之死灵术制造的血肉魔像";
						}
						if (tooltipLine.text == "Its creators were slaughtered by it moments after its conception. It is for the best that it has been destroyed.")
						{
							tooltipLine.text = "它们的制造者在这东西诞生的瞬间就被杀了，最好销毁这些玩意";
						}
						if (tooltipLine.text == "Place in your inventory to gain an increase to all damage but reduced wing flight time.")
						{
							tooltipLine.text = "增加所有伤害，减少翅膀飞行时间，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge34"))
					{
						if (tooltipLine.text == "We long ago feared the light of the red moon.")
						{
							tooltipLine.text = "很久以前，我们都曾害怕过血月的光芒";
						}
						if (tooltipLine.text == "Many went mad, others died, but a scant few became blessed with a wealth of cosmic understanding.")
						{
							tooltipLine.text = "有些疯了，有些死了，但一小部分人则被丰富的宇宙知识祝福了";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge35"))
					{
						if (tooltipLine.text == "I remember the serene waves and the clear breeze.")
						{
							tooltipLine.text = "我还记得那柔和的海浪和清凉的微风";
						}
						if (tooltipLine.text == "The bitterness of my youth has long since subsided, but it is far too late. I must never repeat a mistake like this again.")
						{
							tooltipLine.text = "青年时的那种痛苦已经随着岁月消磨干净了，但世上没有后悔药。我不能再犯这种错误";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge36"))
					{
						if (tooltipLine.text == "This twisted dreamscape, surrounded by unnatural pillars under a dark and hazy sky.")
						{
							tooltipLine.text = "这个扭曲的梦境，黑暗朦胧的夜空下四周还环绕着非自然巨柱";
						}
						if (tooltipLine.text == "Natural law has been upturned. What will you make of it?")
						{
							tooltipLine.text = "自然法则被颠倒了，你对此想做些什么呢？";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge37"))
					{
						if (tooltipLine.text == "What a waste.")
						{
							tooltipLine.text = "多么浪费";
						}
						if (tooltipLine.text == "Had it been fully restored it would have been a force to behold, but what you fought was an empty shell.")
						{
							tooltipLine.text = "如果它的力量恢复完全，那还有的看，但是一直与你激战的只是一具空壳.";
						}
						if (tooltipLine.text == "However, that doesn't diminish the immense potential locked within it, released upon its death.")
						{
							tooltipLine.text = "然而，它体内仍然蕴藏着庞大的能量，一旦死亡就会释放.";
						}
						if (tooltipLine.text == "Place in your inventory to gain an improved Gravity Globe that gives you an increase to all stats while upside down.")
						{
							tooltipLine.text = "获得增强的重力球效果，颠倒时增加所有属性，放在背包中会生效.";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge38"))
					{
						if (tooltipLine.text == "The ever-rejuvenating guardians of the profaned flame.")
						{
							tooltipLine.text = "由亵渎之火铸就的，永生不朽的守卫";
						}
						if (tooltipLine.text == "Much like a phoenix from the ashes their deaths are simply a part of their life cycle.")
						{
							tooltipLine.text = "好似灰烬中浴火重生的凤凰.";
						}
						if (tooltipLine.text == "Many times my forces have had to destroy these beings in search of the Profaned Goddess.")
						{
							tooltipLine.text = "为了寻找亵渎天神，很多时候我都不得不摧毁这些生物.";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge39"))
					{
						if (tooltipLine.text == "A core surrounded by stone and flame, a simple origin and a simple goal.")
						{
							tooltipLine.text = "被顽石和异火所包裹的核心，有一个简单的起源和简单的目标";
						}
						if (tooltipLine.text == "What would have become of us had she not been defeated is a frightening concept to consider.")
						{
							tooltipLine.text = "如果她没有击败，那么我们会成为什么呢？这真是个令人恐惧的想法";
						}
						if (tooltipLine.text == "Place in your inventory to imbue all projectiles with profaned flames, causing them to inflict extra damage.")
						{
							tooltipLine.text = "令所有弹幕附着亵渎之炎debuff，使敌人受到额外伤害，放在背包中会生效.";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge40"))
					{
						if (tooltipLine.text == "Signus. The Void. The Weaver.")
						{
							tooltipLine.text = "西格纳斯，无尽虚空和风暴编织者";
						}
						if (tooltipLine.text == "Each represent one of the Devourer’s largest spheres of influence.")
						{
							tooltipLine.text = "每一个都象征着神明吞噬者的强大影响力";
						}
						if (tooltipLine.text == "Dispatching them has most likely invoked its anger and marked you as a target for destruction.")
						{
							tooltipLine.text = "它们的出现说明你激起了它的愤怒并将你当成了它的下一个毁灭目标";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge41"))
					{
						if (tooltipLine.text == "A creature born of hatred and anger, formed by countless human souls with all of their energy entirely devoted to consuming others.")
						{
							tooltipLine.text = "自憎恨与愤怒中诞生的生灵，由无尽的人类灵魂塑形而成，专注于继续吞噬他人的灵魂";
						}
						if (tooltipLine.text == "It seems a waste to have had such a potent source of power ravage mindlessly through these empty halls.")
						{
							tooltipLine.text = "让一么一大团能量在这空荡的地牢里漫无目的地肆虐似乎是一种浪费";
						}
						if (tooltipLine.text == "Place in your inventory to gain increased item grab range.")
						{
							tooltipLine.text = "增加捡拾距离，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge42"))
					{
						if (tooltipLine.text == "This serpent’s power to assimilate the abilities and energy of those it consumed is unique in almost all the known cosmos, save for its lesser brethren.")
						{
							tooltipLine.text = "它吸收那些被吞噬者的能力与能量即便放诸整个宇宙也是种独特的本事，除了它的那些小弟";
						}
						if (tooltipLine.text == "I would have soon had to eliminate it as a threat had it been given more time and creatures to feast upon.")
						{
							tooltipLine.text = "随着时间的推移和它吞噬的生命增多，它逐渐成为了个威胁。该尽快除掉它了";
						}
						if (tooltipLine.text == "Place in your inventory to boost your true melee damage by 50%.")
						{
							tooltipLine.text = "真实近战伤害（武器本体伤害）增加50%，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge43"))
					{
						if (tooltipLine.text == "A failure of twisted scientific ambition; it appears our faulted arrogance over life has shown once more in the results.")
						{
							tooltipLine.text = "一个大科学项目的失败品。这个结果再次说明我们对待生命不该自大";
						}
						if (tooltipLine.text == "Originally intended to be a clone of the Jungle Dragon, these were left to roam about the jungle, attacking anything in their path.")
						{
							tooltipLine.text = "最初是希望它成为丛林龙的克隆体，但是它们如今在丛林里乱窜，攻击所有挡道的人们";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge44"))
					{
						if (tooltipLine.text == "I would not be able to bear a world without my faithful companion by my side.")
						{
							tooltipLine.text = "如果不是他，我最信任的伙伴，我是不可能有如今的成就的";
						}
						if (tooltipLine.text == "Fortunately, fate will have it so that it is a world I shall never have to see, for better or for worse.")
						{
							tooltipLine.text = "幸运的是，命运让我拥有了它，这样这个世界我可以不必操心，无论是好是坏";
						}
						if (tooltipLine.text == "Place in your inventory to gain nearly-infinite wing flight time but at the cost of a 25% decrease to all damage.")
						{
							tooltipLine.text = "获得近乎无限的飞行能力，但是降低25%所有伤害，放在背包中会生效";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Knowledge45"))
					{
						if (tooltipLine.text == "The witch unrivaled. Perhaps the only one amongst my cohorts to have ever given me cause for doubt.")
						{
							tooltipLine.text = "那个无可匹敌的女巫，或许是我的手下中唯一让我疑虑的人";
						}
						if (tooltipLine.text == "Now that you have defeated her your destiny is clear.")
						{
							tooltipLine.text = "现在你击败了她，你的命运清晰可见";
						}
						if (tooltipLine.text == "Come now, face me.")
						{
							tooltipLine.text = "来吧，面对我吧";
						}
						if (tooltipLine.text == "Place in your inventory to die instantly from every hit.")
						{
							tooltipLine.text = "被击中后后立即死亡，放在背包中会生效";
						}
					}
				}
			}
		}
	}
}
