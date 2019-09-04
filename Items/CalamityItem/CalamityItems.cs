using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityItems : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalWarhammer"))
				{
					item.SetNameOverride("深渊战斧");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerialHamaxe"))
				{
					item.SetNameOverride("天蓝斧锤");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerialiteBar"))
				{
					item.SetNameOverride("天蓝锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AncientBoneDust"))
				{
					item.SetNameOverride("上古骨尘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicCoating"))
				{
					item.SetNameOverride("吸音涂层");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AridArtifact"))
				{
					item.SetNameOverride("人工制旱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AshenKey"))
				{
					item.SetNameOverride("余烬钥匙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralHamaxe"))
				{
					item.SetNameOverride("幻星锤斧");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralPickaxe"))
				{
					item.SetNameOverride("幻星镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BarofLife"))
				{
					item.SetNameOverride("生命锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BeastialPickaxe"))
				{
					item.SetNameOverride("野性镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BeetleJuice"))
				{
					item.SetNameOverride("甲虫汁");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BerserkerWaraxe"))
				{
					item.SetNameOverride("狂战士斧");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlightedLens"))
				{
					item.SetNameOverride("枯萎透镜");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodIdol"))
				{
					item.SetNameOverride("血祸古符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodlettingEssence"))
				{
					item.SetNameOverride("鲜血精元");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodOrange"))
				{
					item.SetNameOverride("血橙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodOrb"))
				{
					item.SetNameOverride("血珠");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Bloodstone"))
				{
					item.SetNameOverride("血石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodstoneCore"))
				{
					item.SetNameOverride("血石核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlossomPickaxe"))
				{
					item.SetNameOverride("繁花镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BossRush"))
				{
					item.SetNameOverride("终界石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Brimrose"))
				{
					item.SetNameOverride("硫火玫瑰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneKey"))
				{
					item.SetNameOverride("硫磺火石钥匙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BulbofDoom"))
				{
					item.SetNameOverride("世纪之花苞");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitousEssence"))
				{
					item.SetNameOverride("灾厄精华");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaoswarpedSlashaxe"))
				{
					item.SetNameOverride("混乱斩斧");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CometShard"))
				{
					item.SetNameOverride("彗星碎片");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoreofCalamity"))
				{
					item.SetNameOverride("灾劫核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoreofChaos"))
				{
					item.SetNameOverride("混乱核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoreofCinder"))
				{
					item.SetNameOverride("日光核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CoreofEleum"))
				{
					item.SetNameOverride("冰川核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Cosmolight"))
				{
					item.SetNameOverride("宇宙之光");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CruptixBar"))
				{
					item.SetNameOverride("混乱锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrystylCrusher"))
				{
					item.SetNameOverride("终级水晶碾碎器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DarksunFragment"))
				{
					item.SetNameOverride("日蚀之阴碎片");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Daylight"))
				{
					item.SetNameOverride("白昼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonicBoneAsh"))
				{
					item.SetNameOverride("恶魔骨灰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DesertFeather"))
				{
					item.SetNameOverride("荒漠之羽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DimensionalSoulArtifact"))
				{
					item.SetNameOverride("维魂神物");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonBar"))
				{
					item.SetNameOverride("亘青锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonsRemote"))
				{
					item.SetNameOverride("嘉登遥控器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Dragonfruit"))
				{
					item.SetNameOverride("火龙果");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EbonianGel"))
				{
					item.SetNameOverride("枯萎凝胶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Ectoblood"))
				{
					item.SetNameOverride("幽魂之血");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Ectoheart"))
				{
					item.SetNameOverride("幽魂之心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EidolonTablet"))
				{
					item.SetNameOverride("幻海灵石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Elderberry"))
				{
					item.SetNameOverride("接骨木莓");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EldritchSoulArtifact"))
				{
					item.SetNameOverride("惧魂神物");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElectrolyteGelPack"))
				{
					item.SetNameOverride("电磁凝胶包");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EndothermicEnergy"))
				{
					item.SetNameOverride("吸热能量");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EssenceofChaos"))
				{
					item.SetNameOverride("混乱精华");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EssenceofCinder"))
				{
					item.SetNameOverride("日光精华");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EssenceofEleum"))
				{
					item.SetNameOverride("冰川精华");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EtherealCore"))
				{
					item.SetNameOverride("飘渺之核");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FetidEssence"))
				{
					item.SetNameOverride("腐臭精元");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FlamebeakHampick"))
				{
					item.SetNameOverride("炎喙锤镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GalacticaSingularity"))
				{
					item.SetNameOverride("卡拉狄加异石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GallantPickaxe"))
				{
					item.SetNameOverride("巨星镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Gelpick"))
				{
					item.SetNameOverride("凝胶镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodlySoulArtifact"))
				{
					item.SetNameOverride("圣魂神物");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreatbayPickaxe"))
				{
					item.SetNameOverride("海湾镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GypsyPowder"))
				{
					item.SetNameOverride("吉普赛粉尘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HadarianMembrane"))
				{
					item.SetNameOverride("哈德安翼膜");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("InfernalBlood"))
				{
					item.SetNameOverride("地狱之血");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IronHeart"))
				{
					item.SetNameOverride("钢铁之心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LivingShard"))
				{
					item.SetNameOverride("生命碎片");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ManeaterBulb"))
				{
					item.SetNameOverride("食人花苞");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MarniteObliterator"))
				{
					item.SetNameOverride("花岗岩抹除者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeldBlob"))
				{
					item.SetNameOverride("混溶剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeldiateBar"))
				{
					item.SetNameOverride("混溶锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MiracleFruit"))
				{
					item.SetNameOverride("神秘果");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MLGRune2"))
				{
					item.SetNameOverride("天体洋葱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Moonlight"))
				{
					item.SetNameOverride("夜光");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MurkyPaste"))
				{
					item.SetNameOverride("浆糊泥");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MurkySludge"))
				{
					item.SetNameOverride("黑淤泥");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MushroomPlasmaRoot"))
				{
					item.SetNameOverride("蘑菇根质");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NightmareFuel"))
				{
					item.SetNameOverride("梦魇燃料");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OldPowerCell"))
				{
					item.SetNameOverride("老旧能源核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PhantomHeart"))
				{
					item.SetNameOverride("幻影之心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm"))
				{
					item.SetNameOverride("幻魂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RedLightningContainer"))
				{
					item.SetNameOverride("电刑之容");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReefclawHamaxe"))
				{
					item.SetNameOverride("暗礁锤斧");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Rock"))
				{
					item.SetNameOverride("古恒石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShadowspecBar"))
				{
					item.SetNameOverride("Shadowspec锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShardlightPickaxe"))
				{
					item.SetNameOverride("碎光镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SkyfringePickaxe"))
				{
					item.SetNameOverride("铸天镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SquishyBeanMount"))
				{
					item.SetNameOverride("可疑的果冻豆");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Stardust"))
				{
					item.SetNameOverride("星尘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StarlightFuelCell"))
				{
					item.SetNameOverride("星光燃料电池");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StarterBag"))
				{
					item.SetNameOverride("新手礼包");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StormlionMandible"))
				{
					item.SetNameOverride("风暴蚁狮颚");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SuperDummy"))
				{
					item.SetNameOverride("超级大草人");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrapperBulb"))
				{
					item.SetNameOverride("猎捕花苞");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrashmanTrashcan"))
				{
					item.SetNameOverride("垃圾罐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UeliaceBar"))
				{
					item.SetNameOverride("龙蒿锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UnholyCore"))
				{
					item.SetNameOverride("污痕核心");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VerstaltiteBar"))
				{
					item.SetNameOverride("寒元锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideBar"))
				{
					item.SetNameOverride("胜潮锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumAxe"))
				{
					item.SetNameOverride("钨钢斧");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHammer"))
				{
					item.SetNameOverride("钨钢锤");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumPickaxe"))
				{
					item.SetNameOverride("钨钢镐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumShard"))
				{
					item.SetNameOverride("钨钢碎片");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharimsStimulants"))
				{
					item.SetNameOverride("犽戾武兴奋剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ZenPotion"))
				{
					item.SetNameOverride("禅定药剂");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ZergPotion"))
				{
					item.SetNameOverride("虫潮药剂");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeldBlob"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "usedname", "冥思溶剂")
					{
						overrideColor = new Color?(Color.SteelBlue)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeldiateBar"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "usedname", "冥思锭")
					{
						overrideColor = new Color?(Color.SteelBlue)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonBar"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "usedname", "永恒锭")
					{
						overrideColor = new Color?(Color.SteelBlue)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShadowspecBar"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "usedname", "魔影锭\n注：Shadowspec灾厄的一个开发者")
					{
						overrideColor = new Color?(Color.SteelBlue)
					});
				}
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (tooltipLine.text == "Permanently increases maximum mana by 50")
					{
						tooltipLine.text = "永久增加50点魔力上限";
					}
					if (tooltipLine.text == "Permanently increases maximum life by 25")
					{
						tooltipLine.text = "永久增加25点最大生命值";
					}
					if (tooltipLine.text == "Can only be used if the max amount of life fruit has been consumed")
					{
						tooltipLine.text = "只能在食用生命之果已经达到上限时才能使用";
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicCoating"))
					{
						if (tooltipLine.text == "Reduces creature's ability to detect you in the abyss")
						{
							tooltipLine.text = "降低深渊生物侦测到你的可能性";
						}
						if (tooltipLine.text == "Reduces the defense reduction that the abyss causes")
						{
							tooltipLine.text = "降低深渊削减的防御值";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicCoating"))
					{
						if (tooltipLine.text == "Summons a sandstorm")
						{
							tooltipLine.text = "召唤沙尘暴";
						}
						if (tooltipLine.text == "The sandstorm will happen shortly after the item is used")
						{
							tooltipLine.text = "使用后沙尘暴等一段时间出现";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicCoating"))
					{
						if (tooltipLine.text == "Used in crafting to lock/unlock ashen chests")
						{
							tooltipLine.text = "合成用于锁住/解锁余烬箱";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodIdol"))
					{
						if (tooltipLine.text == "Summons a blood moon")
						{
							tooltipLine.text = "召唤血月";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodOrange"))
					{
						if (tooltipLine.text == "Permanently increases maximum life by 25")
						{
							tooltipLine.text = "永久增加25点最大生命值";
						}
						if (tooltipLine.text == "Can only be used if the max amount of life fruit has been consumed")
						{
							tooltipLine.text = "只能在食用生命之果已经达到上限时才能使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlossomPickaxe"))
					{
						if (tooltipLine.text == "Can mine Auric Ore")
						{
							tooltipLine.text = "可挖掘圣金源矿";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BossRush"))
					{
						if (tooltipLine.text == "A ritualistic artifact, thought to have brought upon The End many millennia ago")
						{
							tooltipLine.text = "一个仪式用神物，据说曾在数千年前给世界带来末日劫难";
						}
						if (tooltipLine.text == "Sealed away in the abyss, far from those that would seek to misuse it")
						{
							tooltipLine.text = "被封印在在深渊的最深处以远离那些想利用此神物心怀不轨的人";
						}
						if (tooltipLine.text == "Activates Boss Rush Mode, using it again will deactivate Boss Rush Mode")
						{
							tooltipLine.text = "激活boss brush，可以开启和关闭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Brimrose"))
					{
						if (tooltipLine.text == "Summons a brimrose mount")
						{
							tooltipLine.text = "召唤硫火玫瑰坐骑";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneKey"))
					{
						if (tooltipLine.text == "Grants access to Locked Ashen Chests")
						{
							tooltipLine.text = "能打开上锁的灰烬箱";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BulbofDoom"))
					{
						if (tooltipLine.text == "Summons Plantera")
						{
							tooltipLine.text = "召唤世纪之花";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CometShard"))
					{
						if (tooltipLine.text == "Permanently increases maximum mana by 50")
						{
							tooltipLine.text = "永久增加50点魔力上限";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Cosmolight"))
					{
						if (tooltipLine.text == "Changes night to day and vice versa")
						{
							tooltipLine.text = "切换白天与黑夜";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrystylCrusher"))
					{
						if (tooltipLine.text == "Gotta dig faster, gotta go deeper")
						{
							tooltipLine.text = "更快，更深！";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DarksunFragment"))
					{
						if (tooltipLine.text == "A shard of lunar and solar energy")
						{
							tooltipLine.text = "日月能量聚合之碎片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Daylight"))
					{
						if (tooltipLine.text == "Summons the sun")
						{
							tooltipLine.text = "召唤白昼";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DimensionalSoulArtifact"))
					{
						if (tooltipLine.text == "Power")
						{
							tooltipLine.text = "力量";
						}
						if (tooltipLine.text == "Boosts all damage by 25%")
						{
							tooltipLine.text = "增加25%所有伤害";
						}
						if (tooltipLine.text == "But at what cost?")
						{
							tooltipLine.text = "但是代价是什么呢？";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonsRemote"))
					{
						if (tooltipLine.text == "Mayhem...")
						{
							tooltipLine.text = "骚乱...";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Dragonfruit"))
					{
						if (tooltipLine.text == "Permanently increases maximum life by 25")
						{
							tooltipLine.text = "永久增加25点最大生命值";
						}
						if (tooltipLine.text == "Can only be used if the max amount of life fruit has been consumed")
						{
							tooltipLine.text = "只能在食用生命之果已经达到上限时才能使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Ectoheart"))
					{
						if (tooltipLine.text == "Permanently makes Adrenaline Mode take 5 less seconds to charge")
						{
							tooltipLine.text = "永久减少5秒肾上腺素条的充能时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Elderberry"))
					{
						if (tooltipLine.text == "Permanently increases maximum life by 25")
						{
							tooltipLine.text = "永久增加25点最大生命值";
						}
						if (tooltipLine.text == "Can only be used if the max amount of life fruit has been consumed")
						{
							tooltipLine.text = "只能在食用生命之果已经达到上限时才能使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EldritchSoulArtifact"))
					{
						if (tooltipLine.text == "Knowledge")
						{
							tooltipLine.text = "知识";
						}
						if (tooltipLine.text == "Boosts melee speed by 10%, shoot speed by 25%, rogue damage by 15%, max minions by 2, and reduces mana cost by 15%")
						{
							tooltipLine.text = "增加10%近战攻速，25%射速，15%盗贼伤害，2召唤栏并减少15%魔法消耗";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElectrolyteGelPack"))
					{
						if (tooltipLine.text == "Permanently makes Adrenaline Mode take 10 less seconds to charge")
						{
							tooltipLine.text = "永久减少10秒肾上腺素条的充能时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EndothermicEnergy"))
					{
						if (tooltipLine.text == "Great for preventing heat stroke")
						{
							tooltipLine.text = "防御高温的绝佳材料";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EssenceofChaos"))
					{
						if (tooltipLine.text == "The essence of chaotic creatures")
						{
							tooltipLine.text = "混乱生物之精华";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EssenceofCinder"))
					{
						if (tooltipLine.text == "The essence of sky, light, and storm creatures")
						{
							tooltipLine.text = "天空，阳光及风暴生物之精华";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EssenceofEleum"))
					{
						if (tooltipLine.text == "The essence of cold creatures")
						{
							tooltipLine.text = "寒冰生物之精华";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EtherealCore"))
					{
						if (tooltipLine.text == "Permanently increases maximum mana by 50")
						{
							tooltipLine.text = "永久增加50点魔法上限";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Fabsol"))
					{
						if (tooltipLine.text == "Summons an alicorn")
						{
							tooltipLine.text = "召唤一只小马坐骑“音韵公主”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FlamebeakHampick"))
					{
						if (tooltipLine.text == "Capable of mining Lihzahrd Bricks")
						{
							tooltipLine.text = "可以挖掘神庙砖";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GalacticaSingularity"))
					{
						if (tooltipLine.text == "A shard of the cosmos")
						{
							tooltipLine.text = "广阔宇宙的结晶";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GallantPickaxe"))
					{
						if (tooltipLine.text == "Can mine Uelibloom Ore")
						{
							tooltipLine.text = "可以挖掘龙蒿矿";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodlySoulArtifact"))
					{
						if (tooltipLine.text == "Loyalty")
						{
							tooltipLine.text = "忠诚";
						}
						if (tooltipLine.text == "Boosts max minions by 8")
						{
							tooltipLine.text = "增加8召唤栏";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreatbayPickaxe"))
					{
						if (tooltipLine.text == "Can mine Meteorite")
						{
							tooltipLine.text = "可以挖掘陨石";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HadarianMembrane"))
					{
						if (tooltipLine.text == "The membrane of an astral creature's wings")
						{
							tooltipLine.text = "幻星生物的翅膀膜";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("InfernalBlood"))
					{
						if (tooltipLine.text == "Permanently makes Rage Mode do 15% (50% in Death Mode) more damage")
						{
							tooltipLine.text = "永久增加15% (死亡模式50%)怒气状态伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IronHeart"))
					{
						if (tooltipLine.text == "Makes dying while a boss is alive permanently kill you.")
						{
							tooltipLine.text = "开启硬核难度，被boss击杀会永久死亡";
						}
						if (tooltipLine.text == "Can be toggled on and off.")
						{
							tooltipLine.text = "此模式可以开启和关闭";
						}
						if (tooltipLine.text == "Using this while a boss is alive will permanently kill you.")
						{
							tooltipLine.text = "Boss存活时使用会永久死亡";
						}
						if (tooltipLine.text == "Cannot be activated if any boss has been killed.")
						{
							tooltipLine.text = "任意boss被击杀后将无法使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MiracleFruit"))
					{
						if (tooltipLine.text == "Permanently increases maximum life by 25")
						{
							tooltipLine.text = "永久增加25点最大生命值";
						}
						if (tooltipLine.text == "Can only be used if the max amount of life fruit has been consumed")
						{
							tooltipLine.text = "只能在食用生命之果已经达到上限时才能使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Moonlight"))
					{
						if (tooltipLine.text == "Summons the moon")
						{
							tooltipLine.text = "入夜";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MushroomPlasmaRoot"))
					{
						if (tooltipLine.text == "Permanently makes Rage Mode do 15% (50% in Death Mode) more damage")
						{
							tooltipLine.text = "永久增加15% (死亡模式50%)怒气状态伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NightmareFuel"))
					{
						if (tooltipLine.text == "May drain your sanity")
						{
							tooltipLine.text = "会搅乱你的心智";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OldPowerCell"))
					{
						if (tooltipLine.text == "Summons the ancient golem when used in the Temple")
						{
							tooltipLine.text = "在神庙中召唤远古的守护者";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PhantomHeart"))
					{
						if (tooltipLine.text == "Permanently increases maximum mana by 50")
						{
							tooltipLine.text = "永久增加50点魔力上限";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RedLightningContainer"))
					{
						if (tooltipLine.text == "Permanently makes Rage Mode do 15% (50% in Death Mode) more damage")
						{
							tooltipLine.text = "永久增加15% (死亡模式50%)怒气状态伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Rock"))
					{
						if (tooltipLine.text == "The first object Xeroc ever created")
						{
							tooltipLine.text = "克希洛克创造的第一种物品";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SkyfringePickaxe"))
					{
						if (tooltipLine.text == "Able to mine Hellstone")
						{
							tooltipLine.text = "可以挖掘狱炎石";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SquishyBeanMount"))
					{
						if (tooltipLine.text == "JELLY BEAN")
						{
							tooltipLine.text = "果 冻 豆";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StarlightFuelCell"))
					{
						if (tooltipLine.text == "Permanently makes Adrenaline Mode take 10 less seconds to charge")
						{
							tooltipLine.text = "永久减少10秒肾上腺素条的充能时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SuperDummy"))
					{
						if (tooltipLine.text == "Creates a super dummy")
						{
							tooltipLine.text = "生成一个超级草人";
						}
						if (tooltipLine.text == "Regenerates 1 million life per second")
						{
							tooltipLine.text = "每秒恢复百万生命值";
						}
						if (tooltipLine.text == "Will not die when taking damage over time from debuffs")
						{
							tooltipLine.text = "受到debuff影响不会死亡";
						}
						if (tooltipLine.text == "Right click to kill all super dummies")
						{
							tooltipLine.text = "右键点击消灭所有大草人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrashmanTrashcan"))
					{
						if (tooltipLine.text == "Summons the trash man")
						{
							tooltipLine.text = "召唤垃圾男！";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharimsStimulants"))
					{
						if (tooltipLine.text == "Gives decent buffs to ALL offensive and defensive stats")
						{
							tooltipLine.text = "给予能增强所有防御和进攻的属性";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ZenPotion"))
					{
						if (tooltipLine.text == "Reduces spawn rates...a lot...")
						{
							tooltipLine.text = "减少怪物生成率...相当大...";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharimsStimulants"))
					{
						if (tooltipLine.text == "Boosts spawn rates...a lot...")
						{
							tooltipLine.text = "暴增刷怪率...相当大...";
						}
					}
				}
			}
		}
	}
}
