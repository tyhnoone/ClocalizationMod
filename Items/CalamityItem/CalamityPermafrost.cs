using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityPermafrost : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbsoluteZero"))
				{
					item.SetNameOverride("绝对零度");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ArcticBearPaw"))
				{
					item.SetNameOverride("北极熊爪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ColdheartIcicle"))
				{
					item.SetNameOverride("寒心冰柱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryogenicStaff"))
				{
					item.SetNameOverride("寒极法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeliciousMeat"))
				{
					item.SetNameOverride("水晶冻肉");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EnchantedMetal"))
				{
					item.SetNameOverride("注魔寒金");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EternalBlizzard"))
				{
					item.SetNameOverride("恒吹雪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostbiteBlaster"))
				{
					item.SetNameOverride("霜牙冲击");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IcicleArrow"))
				{
					item.SetNameOverride("冰棱箭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IcicleTrident"))
				{
					item.SetNameOverride("冰棱三叉戟");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IcyBullet"))
				{
					item.SetNameOverride("冰砾弹");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PermafrostsConcoction"))
				{
					item.SetNameOverride("佩码·福洛斯特之融魔台");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Popo"))
				{
					item.SetNameOverride("魔法围巾帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WintersFury"))
				{
					item.SetNameOverride("凛冬之怒");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbsoluteZero"))
					{
						if (tooltipLine.text == "Ancient blade imbued with the Archmage of Ice's magic")
						{
							tooltipLine.text = "被冰之大魔法师祝福的远古之刃";
						}
						if (tooltipLine.text == "Shoots dark ice crystals")
						{
							tooltipLine.text = "发射暗影冰晶";
						}
						if (tooltipLine.text == "The blade creates frost explosions on direct hits")
						{
							tooltipLine.text = "剑刃接触产生冰爆";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ArcticBearPaw"))
					{
						if (tooltipLine.text == "Fires spiritual claws that ignore walls and confuse enemies")
						{
							tooltipLine.text = "发出无视墙壁和迷惑敌人的爪子";
						}
						if (tooltipLine.text == "'The savage mauling that fits in your pocket'")
						{
							tooltipLine.text = "“放在口袋里的野蛮攻击”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ColdheartIcicle"))
					{
						if (tooltipLine.text == "Drains a percentage of enemy health on hit")
						{
							tooltipLine.text = "攻击按百分比让敌人生命流失";
						}
						if (tooltipLine.text == "Cannot inflict critical hits")
						{
							tooltipLine.text = "不受暴击率的影响";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryogenicStaff"))
					{
						if (tooltipLine.text == "Summons an animated ice construct to protect you")
						{
							tooltipLine.text = "召唤冰结体保护你";
						}
						if (tooltipLine.text == "Fire rate and range increase the longer it targets an enemy")
						{
							tooltipLine.text = "弹幕射速和射程会随着攻击时间的增加而增加";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeliciousMeat"))
					{
						if (tooltipLine.text == "Minor improvements to all stats")
						{
							tooltipLine.text = "所有属性小幅增强";
						}
						if (tooltipLine.text == "'So very delicious'")
						{
							tooltipLine.text = "“太好吃了”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EternalBlizzard"))
					{
						if (tooltipLine.text == "Wooden arrows turn into icicle arrows that shatter on impact")
						{
							tooltipLine.text = "将木箭转化为冰坠箭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FrostbiteBlaster"))
					{
						if (tooltipLine.text == "Fires a spread of icicles")
						{
							tooltipLine.text = "发射一团冰柱";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IcicleArrow"))
					{
						if (tooltipLine.text == "Shatters into shards on impact")
						{
							tooltipLine.text = "命中后碎裂";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IcicleTrident"))
					{
						if (tooltipLine.text == "Shoots piercing icicles")
						{
							tooltipLine.text = "发射穿透性冰柱";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IcyBullet"))
					{
						if (tooltipLine.text == "Can hit up to three times")
						{
							tooltipLine.text = "可以命中至多三次";
						}
						if (tooltipLine.text == "Breaks into ice shards on last impact")
						{
							tooltipLine.text = "最后一次冲击分裂成冰霜碎片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PermafrostsConcoction"))
					{
						if (tooltipLine.text == "Increases maximum mana by 50")
						{
							tooltipLine.text = "+50魔力上限";
						}
						if (tooltipLine.text == "Increases life regen as life decreases")
						{
							tooltipLine.text = "随着生命值降低增加生命恢复速度";
						}
						if (tooltipLine.text == "Increases life regen when afflicted with Poison, On Fire, or Brimstone Flames")
						{
							tooltipLine.text = "在受到中毒，着火或硫磺火debuff影响时增加生命恢复速度";
						}
						if (tooltipLine.text == "You will survive fatal damage and revive with 30% life on a 3 minute cooldown")
						{
							tooltipLine.text = "你可以抵挡一次致命伤害并恢复30%的血量，3分钟CD";
						}
						if (tooltipLine.text == "You are encased in an ice barrier for 5 seconds when revived")
						{
							tooltipLine.text = "复活后你会被封锁在寒冰屏障里五秒种";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Popo"))
					{
						if (tooltipLine.text == "Transforms the holder into a snowman")
						{
							tooltipLine.text = "将玩家变成个雪人";
						}
						if (tooltipLine.text == "Don't let the demons steal your nose")
						{
							tooltipLine.text = "不要让恶魔偷走你的鼻子";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WintersFury"))
					{
						if (tooltipLine.text == "The pages are freezing to the touch")
						{
							tooltipLine.text = "这书摸起来冷极了";
						}
					}
				}
			}
		}
	}
}
