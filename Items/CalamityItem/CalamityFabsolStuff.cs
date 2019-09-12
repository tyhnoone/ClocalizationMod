using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityFabsolStuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyMary"))
				{
					item.SetNameOverride("血腥玛丽鸡尾酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueCandle"))
				{
					item.SetNameOverride("失重蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CaribbeanRum"))
				{
					item.SetNameOverride("加勒比椰子朗姆酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CinnamonRoll"))
				{
					item.SetNameOverride("肉桂卷增味酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Everclear"))
				{
					item.SetNameOverride("清如许");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EvergreenGin"))
				{
					item.SetNameOverride("常青琴酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FabsolsVodka"))
				{
					item.SetNameOverride("Fabsol的伏特加");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Fireball"))
				{
					item.SetNameOverride("火龙威士忌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrapeBeer"))
				{
					item.SetNameOverride("葡萄啤");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Margarita"))
				{
					item.SetNameOverride("玛格丽特鸡尾酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Moonshine"))
				{
					item.SetNameOverride("摩闪私酿酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MoscowMule"))
				{
					item.SetNameOverride("莫斯科骡子鸡尾酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OddMushroom"))
				{
					item.SetNameOverride("怪异蘑菇");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkCandle"))
				{
					item.SetNameOverride("活力蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkCandle"))
				{
					item.SetNameOverride("活力蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PurpleCandle"))
				{
					item.SetNameOverride("恢复蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RedWine"))
				{
					item.SetNameOverride("红葡萄酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Rum"))
				{
					item.SetNameOverride("朗姆酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Screwdriver"))
				{
					item.SetNameOverride("螺丝起子鸡尾酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StarBeamRye"))
				{
					item.SetNameOverride("星宾黑麦威士忌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Tequila"))
				{
					item.SetNameOverride("龙舌兰酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TequilaSunrise"))
				{
					item.SetNameOverride("龙舌兰日出");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Vodka"))
				{
					item.SetNameOverride("伏特加");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Whiskey"))
				{
					item.SetNameOverride("威士忌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WhiteWine"))
				{
					item.SetNameOverride("白葡萄酒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YellowCandle"))
				{
					item.SetNameOverride("恶毒蜡烛");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OddMushroom"))
					{
						if (tooltipLine.text == "Trippy")
						{
							tooltipLine.text = "幻觉";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YellowCandle"))
					{
						if (tooltipLine.text == "When placed, nearby enemies take 5% more damage.")
						{
							tooltipLine.text = "放置时，四周敌人受到额外5%伤害";
						}
						if (tooltipLine.text == "This extra damage bypasses enemy damage reduction")
						{
							tooltipLine.text = "此效果无视敌人免伤";
						}
						if (tooltipLine.text == "'Its hateful glow flickers with ire'")
						{
							tooltipLine.text = "“它可恨的光芒会随着火闪烁”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PurpleCandle"))
					{
						if (tooltipLine.text == "When placed, nearby players' defense blocks 5% more damage")
						{
							tooltipLine.text = "放置时，附近玩家的防御力抵消伤害效果增强5%";
						}
						if (tooltipLine.text == "'Neither rain nor wind can snuff its undying flame'")
						{
							tooltipLine.text = "“暴风骤雨都无法熄灭这永恒的火焰”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkCandle"))
					{
						if (tooltipLine.text == "When placed, nearby players regenerate 0.4% of their maximum health per second")
						{
							tooltipLine.text = "放置后，附近的玩家增加0.4%生命上限的生命再生";
						}
						if (tooltipLine.text == "This regeneration is at full power even while moving and bypasses Revengeance Mode caps")
						{
							tooltipLine.text = "玩家达到复仇模式的再生上限时，这个生命再生仍处于最大值";
						}
						if (tooltipLine.text == "'Its brilliant light suffuses those nearby with hope'")
						{
							tooltipLine.text = "“它灿烂的光芒使附近的人们充满希望。”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyMary"))
					{
						if (tooltipLine.text == "Boosts damage, movement speed, and melee speed by 15% and crit chance by 7% during a Blood Moon")
						{
							tooltipLine.text = "血月期间增加15%伤害，移速，近战攻速以及7%暴击率";
						}
						if (tooltipLine.text == "Reduces life regen by 2 and defense by 6")
						{
							tooltipLine.text = "减少2生命再生速度和6点防御";
						}
						if (tooltipLine.text == "Extra spicy and bloody!")
						{
							tooltipLine.text = "更辣更血腥！";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueCandle"))
					{
						if (tooltipLine.text == "When placed, nearby players gain 15% movement speed, 10% wing time, and 5% acceleration")
						{
							tooltipLine.text = "放置时，增加附近玩家15%移动速度，10%飞行时间，5%加速度";
						}
						if (tooltipLine.text == "'The floating flame seems to uplift your very spirit'")
						{
							tooltipLine.text = "“漂浮的火焰似乎让你更精神”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CaribbeanRum"))
					{
						if (tooltipLine.text == "Boosts life regen by 2 and movement speed and wing flight time by 20%")
						{
							tooltipLine.text = "增加2生命恢复速度和20%移速以及飞行时间";
						}
						if (tooltipLine.text == "Makes you floaty and reduces defense by 12")
						{
							tooltipLine.text = "令你变得飘飘若仙并减少12点防御";
						}
						if (tooltipLine.text == "Why is the rum gone?")
						{
							tooltipLine.text = "咦？酒怎么突然没了？";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CinnamonRoll"))
					{
						if (tooltipLine.text == "Boosts mana regeneration rate and all fire-based weapon damage by 15%")
						{
							tooltipLine.text = "增加15%魔法恢复速度和所有火属性武器伤害";
						}
						if (tooltipLine.text == "Cursed flame, shadowflame, god slayer inferno, brimstone flame, and frostburn weapons will not receive this benefit")
						{
							tooltipLine.text = "咒炎，暗影炎，弑神之火，硫磺火和霜火武器不会受到此增益";
						}
						if (tooltipLine.text == "The weapon must be more fire-related than anything else")
						{
							tooltipLine.text = "武器必须跟火焰紧密相关才会受到此加成";
						}
						if (tooltipLine.text == "Reduces defense by 12")
						{
							tooltipLine.text = "减少12点防御";
						}
						if (tooltipLine.text == "A great-tasting cinnamon whiskey with a touch of cream soda")
						{
							tooltipLine.text = "肉桂威士忌，品起来就如奶油苏打一样，啊，绝赞美味";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Everclear"))
					{
						if (tooltipLine.text == "Boosts damage by 25%")
						{
							tooltipLine.text = "增加25%的伤害";
						}
						if (tooltipLine.text == "Reduces life regen by 10 and defense by 40")
						{
							tooltipLine.text = "减少10点生命再生和40点防御";
						}
						if (tooltipLine.text == "This is the most potent booze I have, be careful with it")
						{
							tooltipLine.text = "这是我喝的最猛的酒，小心点\n(译注：Everclear，清如许，美国烈酒品牌)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EvergreenGin"))
					{
						if (tooltipLine.text == "Boosts nature-based weapon damage by 15% and damage reduction by 5%")
						{
							tooltipLine.text = "使自然属性的武器伤害增加15%，增加5%伤害减免";
						}
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "It tastes like a Christmas tree if you can imagine that")
						{
							tooltipLine.text = "如果你能想象的话，它尝起来就像一棵圣诞树\n(译注：Gin，琴酒，金酒，杜松子酒)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FabsolsVodka"))
					{
						if (tooltipLine.text == "Boosts all damage stats by 8% but lowers defense by 20")
						{
							tooltipLine.text = "增加8%所有伤害，降低20防御";
						}
						if (tooltipLine.text == "Increases immune time after being struck")
						{
							tooltipLine.text = "延长受伤后无敌帧时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Fireball"))
					{
						if (tooltipLine.text == "Boosts all fire-based weapon damage by 10%")
						{
							tooltipLine.text = "增加10%所有火炎属性武器的伤害";
						}
						if (tooltipLine.text == "Cursed flame, shadowflame, god slayer inferno, brimstone flame, and frostburn weapons will not receive this benefit")
						{
							tooltipLine.text = "咒炎，暗影炎，弑神之火，硫磺火和霜火武器不会受到此增益";
						}
						if (tooltipLine.text == "The weapon must be more fire-related than anything else")
						{
							tooltipLine.text = "武器必须跟火焰紧密相关才会受到此加成";
						}
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "A great-tasting cinnamon whiskey")
						{
							tooltipLine.text = "非常爽口的肉桂威士忌";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrapeBeer"))
					{
						if (tooltipLine.text == "Restores 100 mana")
						{
							tooltipLine.text = "恢复100点魔力";
						}
						if (tooltipLine.text == "Reduces defense by 2 and movement speed by 5%")
						{
							tooltipLine.text = "减少2点防御和5%移动速度";
						}
						if (tooltipLine.text == "This crap is abhorrent but you might like it")
						{
							tooltipLine.text = "这鬼玩意真恶心，但你可能会喜欢它";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Margarita"))
					{
						if (tooltipLine.text == "Restores 200 mana")
						{
							tooltipLine.text = "恢复200点魔力";
						}
						if (tooltipLine.text == "Makes you immune to most debuffs")
						{
							tooltipLine.text = "使你对大多数debuff免疫";
						}
						if (tooltipLine.text == "Reduces defense by 6 and life regen by 1")
						{
							tooltipLine.text = "减少6点防御和1点生命回复";
						}
						if (tooltipLine.text == "One of the best drinks ever created, enjoy it while it lasts")
						{
							tooltipLine.text = "有史以来最好的饮品之一，好好回味吧";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Moonshine"))
					{
						if (tooltipLine.text == "Increases defense by 10 and damage reduction by 5%")
						{
							tooltipLine.text = "增加10点防御，减少5%伤害";
						}
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "This stuff is pretty strong but I'm sure you can handle it")
						{
							tooltipLine.text = "这东西很强大，但我相信你轻松掌控\n(译注：为避免被发现所以蒸馏通常在夜间进行，所以美国也用“月光”（英语：Moonshine）一词来指代私酒)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MoscowMule"))
					{
						if (tooltipLine.text == "Boosts damage and knockback by 9% and critical strike chance by 3%")
						{
							tooltipLine.text = "增加9%的伤害和击退，3%暴击率";
						}
						if (tooltipLine.text == "Reduces life regen by 2")
						{
							tooltipLine.text = "减少2生命再生";
						}
						if (tooltipLine.text == "I once heard the copper mug can be toxic and I told 'em 'listen dummy, I'm already poisoning myself'")
						{
							tooltipLine.text = "听说铜杯有毒，我告诉他们“听着，笨蛋，我中毒了”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RedWine"))
					{
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "Too dry for my taste")
						{
							tooltipLine.text = "让我觉得太干了";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RedWine"))
					{
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "Too dry for my taste")
						{
							tooltipLine.text = "让我觉得太干了";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Rum"))
					{
						if (tooltipLine.text == "Boosts life regen by 2 and movement speed by 10%")
						{
							tooltipLine.text = "增加2生命再生和10%移动速度";
						}
						if (tooltipLine.text == "Reduces defense by 8")
						{
							tooltipLine.text = "减少8防御力";
						}
						if (tooltipLine.text == "Sweet and potent, just how I like it")
						{
							tooltipLine.text = "又甜又烈，正合我意";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Rum"))
					{
						if (tooltipLine.text == "Boosts piercing projectile damage by 10%")
						{
							tooltipLine.text = "增加10%穿透类弹幕的伤害";
						}
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "Do you have a screw loose?")
						{
							tooltipLine.text = "你...耍酒疯吗？";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StarBeamRye"))
					{
						if (tooltipLine.text == "Boosts max mana by 50, magic damage by 8%,")
						{
							tooltipLine.text = "+50魔力上限，增加8%魔法伤害";
						}
						if (tooltipLine.text == "and reduces mana usage by 10%")
						{
							tooltipLine.text = "减少10%的魔力消耗";
						}
						if (tooltipLine.text == "Reduces defense by 6 and life regen by 1")
						{
							tooltipLine.text = "减少6点的防御和1生命再生";
						}
						if (tooltipLine.text == "Made from some stuff I found near the Astral Meteor crash site, don't worry it's safe, trust me")
						{
							tooltipLine.text = "这是我在彗星坠落地附近发现的一些东西制作的，别担心，很安全，相信我";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Tequila"))
					{
						if (tooltipLine.text == "Boosts damage, damage reduction, and knockback by 3%, crit chance by 2%, and defense by 5 during daytime")
						{
							tooltipLine.text = "在白天增加3%伤害，伤害减免，击退和2%暴击率，增加5防御";
						}
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "Reduces defense by 6 and life regen by 1")
						{
							tooltipLine.text = "减少6点的防御和1生命再生";
						}
						if (tooltipLine.text == "Great for mixing up daytime drinks")
						{
							tooltipLine.text = "适合与一些日间酒品调配鸡尾酒";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TequilaSunrise"))
					{
						if (tooltipLine.text == "Boosts damage, damage reduction, and knockback by 7%, crit chance by 3%, and defense by 15 during daytime")
						{
							tooltipLine.text = "在白天增加7%伤害，伤害减免，击退和3%暴击率，增加15防御";
						}
						if (tooltipLine.text == "Reduces life regen by 1")
						{
							tooltipLine.text = "减少1生命再生";
						}
						if (tooltipLine.text == "The greatest daytime drink I've ever had")
						{
							tooltipLine.text = "我白天喝的最好的酒";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Vodka"))
					{
						if (tooltipLine.text == "Boosts damage by 6% and critical strike chance by 2%")
						{
							tooltipLine.text = "增加6%的伤害和2%暴击率";
						}
						if (tooltipLine.text == "Reduces life regen by 1 and defense by 4")
						{
							tooltipLine.text = "减少1生命再生和4防御力";
						}
						if (tooltipLine.text == "The number one alcohol for creating great mixed drinks")
						{
							tooltipLine.text = "适合混调的头号酒";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Whiskey"))
					{
						if (tooltipLine.text == "Boosts damage and knockback by 4% and critical strike chance by 2%")
						{
							tooltipLine.text = "增加4%伤害和击退，2%暴击率";
						}
						if (tooltipLine.text == "Reduces defense by 8")
						{
							tooltipLine.text = "减少8防御";
						}
						if (tooltipLine.text == "The burning sensation makes it tastier")
						{
							tooltipLine.text = "灼烧的口感使它更美味";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WhiteWine"))
					{
						if (tooltipLine.text == "Boosts magic damage by 10%")
						{
							tooltipLine.text = "增加10%魔法伤害";
						}
						if (tooltipLine.text == "Reduces defense by 6 and life regen by 1")
						{
							tooltipLine.text = "减少6防御和1点生命再生";
						}
						if (tooltipLine.text == "I drank a full barrel of this stuff once in one night, I couldn't remember who I was the next day")
						{
							tooltipLine.text = "我昨晚喝一整桶这种东西，第二天我连我叫啥都不知道了";
						}
					}
				}
			}
		}
	}
}
