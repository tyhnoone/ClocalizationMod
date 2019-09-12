using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityArmor : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalDivingSuit"))
				{
					item.SetNameOverride("幽影潜渊服");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecBreastplate"))
				{
					item.SetNameOverride("天蓝胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHat"))
				{
					item.SetNameOverride("天蓝帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecLeggings"))
				{
					item.SetNameOverride("天蓝护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHelm"))
				{
					item.SetNameOverride("天蓝战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHeadgear"))
				{
					item.SetNameOverride("天蓝头套");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHelmet"))
				{
					item.SetNameOverride("天蓝头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHood"))
				{
					item.SetNameOverride("天蓝兜帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBreastplate"))
				{
					item.SetNameOverride("星幻胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralHelm"))
				{
					item.SetNameOverride("星幻头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralLeggings"))
				{
					item.SetNameOverride("星幻护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstrumDeusMask"))
				{
					item.SetNameOverride("星神游龙面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaArmor"))
				{
					item.SetNameOverride("阿塔西亚盔甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHeadgear"))
				{
					item.SetNameOverride("阿塔西亚头套");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHelm"))
				{
					item.SetNameOverride("阿塔西亚战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHelmet"))
				{
					item.SetNameOverride("阿塔西亚头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHood"))
				{
					item.SetNameOverride("阿塔西亚兜帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaMask"))
				{
					item.SetNameOverride("阿塔西亚面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaSubligar"))
				{
					item.SetNameOverride("阿塔西亚战裙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AureusMask"))
				{
					item.SetNameOverride("白金之星面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaBodyArmor"))
				{
					item.SetNameOverride("古圣金体身战甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaCuisses"))
				{
					item.SetNameOverride("古圣金源胫皮甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaHelm"))
				{
					item.SetNameOverride("古圣金皇耀日盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaHoodedFacemask"))
				{
					item.SetNameOverride("古圣金兜铁面盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaPlumedHelm"))
				{
					item.SetNameOverride("古圣金羽十杀盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaSpaceHelmet"))
				{
					item.SetNameOverride("古圣金宇星界盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaWireHemmedVisage"))
				{
					item.SetNameOverride("古圣金虚万象盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareBodyArmor"))
				{
					item.SetNameOverride("血炎铠甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareCuisses"))
				{
					item.SetNameOverride("血炎护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHelm"))
				{
					item.SetNameOverride("血炎战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHelmet"))
				{
					item.SetNameOverride("血炎头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHornedHelm"))
				{
					item.SetNameOverride("血炎角盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHornedMask"))
				{
					item.SetNameOverride("血炎魔盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareMask"))
				{
					item.SetNameOverride("血炎面盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareMask"))
				{
					item.SetNameOverride("血炎面盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitasMask"))
				{
					item.SetNameOverride("灾厄面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrabulonMask"))
				{
					item.SetNameOverride("菌生蟹面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryogenMask"))
				{
					item.SetNameOverride("极地之灵面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusBreastplate"))
				{
					item.SetNameOverride("代达罗斯胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHat"))
				{
					item.SetNameOverride("代达罗斯兜帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHeadgear"))
				{
					item.SetNameOverride("代达罗斯头饰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHelm"))
				{
					item.SetNameOverride("代达罗斯头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHelmet"))
				{
					item.SetNameOverride("代达罗斯头罩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusLeggings"))
				{
					item.SetNameOverride("代达罗斯护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusVisor"))
				{
					item.SetNameOverride("代达罗斯面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeBreastplate"))
				{
					item.SetNameOverride("魔影胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeGreaves"))
				{
					item.SetNameOverride("魔影护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeHelm"))
				{
					item.SetNameOverride("魔影头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DesertScourgeMask"))
				{
					item.SetNameOverride("荒漠灾虫面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DevourerofGodsMask"))
				{
					item.SetNameOverride("神明吞噬者面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerChestplate"))
				{
					item.SetNameOverride("弑神者胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerHelm"))
				{
					item.SetNameOverride("弑神者头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerHelmet"))
				{
					item.SetNameOverride("弑神者头套");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerHornedHelm"))
				{
					item.SetNameOverride("弑神者角盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerLeggings"))
				{
					item.SetNameOverride("弑神者腿甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerMask"))
				{
					item.SetNameOverride("弑神者面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerVisage"))
				{
					item.SetNameOverride("弑神者面罩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HiveMindMask"))
				{
					item.SetNameOverride("腐巢意志面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeviathanMask"))
				{
					item.SetNameOverride("利维坦面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskShelleggings"))
				{
					item.SetNameOverride("软壳贝腿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskShellmet"))
				{
					item.SetNameOverride("软壳贝盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskShellplate"))
				{
					item.SetNameOverride("软壳贝甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaBlueChestplate"))
				{
					item.SetNameOverride("蓝色欧米茄胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaBlueHelmet"))
				{
					item.SetNameOverride("蓝色欧米茄头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaBlueLeggings"))
				{
					item.SetNameOverride("蓝色欧米茄护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaBlueLeggings"))
				{
					item.SetNameOverride("蓝色欧米茄护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerforatorMask"))
				{
					item.SetNameOverride("血肉宿主面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguebringerGoliathMask"))
				{
					item.SetNameOverride("瘟疫使者面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProvidenceMask"))
				{
					item.SetNameOverride("亵渎天神面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverCap"))
				{
					item.SetNameOverride("掠夺者头饰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverCuisses"))
				{
					item.SetNameOverride("掠夺者护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverHelm"))
				{
					item.SetNameOverride("掠夺者战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverHelmet"))
				{
					item.SetNameOverride("掠夺者头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverMask"))
				{
					item.SetNameOverride("掠夺者面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverScaleMail"))
				{
					item.SetNameOverride("掠夺者鳞甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverVisage"))
				{
					item.SetNameOverride("掠夺者面罩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShroomiteVisage"))
				{
					item.SetNameOverride("蘑菇面罩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaArmor"))
				{
					item.SetNameOverride("始源林海盔甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaHelm"))
				{
					item.SetNameOverride("始源林海战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaHelmet"))
				{
					item.SetNameOverride("始源林海头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaHornedHelm"))
				{
					item.SetNameOverride("始源林海角盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaLeggings"))
				{
					item.SetNameOverride("始源林海护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaMask"))
				{
					item.SetNameOverride("始源林海面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaMaskedCap"))
				{
					item.SetNameOverride("始源林海兜帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensHeart"))
				{
					item.SetNameOverride("塞壬之心（蓝）");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensHeartAlt"))
				{
					item.SetNameOverride("塞壬之心（绿）");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SlimeGodMask"))
				{
					item.SetNameOverride("史莱姆之神面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SlimeGodMask2"))
				{
					item.SetNameOverride("史莱姆之神面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelArmor"))
				{
					item.SetNameOverride("斯塔提斯盔甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelCap"))
				{
					item.SetNameOverride("斯塔提斯帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelGreaves"))
				{
					item.SetNameOverride("斯塔提斯护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelHeadgear"))
				{
					item.SetNameOverride("斯塔提斯头饰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelHelm"))
				{
					item.SetNameOverride("斯塔提斯头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelHood"))
				{
					item.SetNameOverride("斯塔提斯兜帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelMask"))
				{
					item.SetNameOverride("斯塔提斯面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonBreastplate"))
				{
					item.SetNameOverride("龙蒿胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonHelm"))
				{
					item.SetNameOverride("龙蒿战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonHelmet"))
				{
					item.SetNameOverride("龙蒿头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonHornedHelm"))
				{
					item.SetNameOverride("龙蒿角盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonLeggings"))
				{
					item.SetNameOverride("龙蒿护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonMask"))
				{
					item.SetNameOverride("龙蒿面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonVisage"))
				{
					item.SetNameOverride("龙蒿面罩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideBreastplate"))
				{
					item.SetNameOverride("胜潮胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideHeadgear"))
				{
					item.SetNameOverride("胜潮头饰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideHelm"))
				{
					item.SetNameOverride("胜潮战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideHelmet"))
				{
					item.SetNameOverride("胜潮头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideLeggings"))
				{
					item.SetNameOverride("胜潮护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideMask"))
				{
					item.SetNameOverride("胜潮面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideVisage"))
				{
					item.SetNameOverride("胜潮面罩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumArmor"))
				{
					item.SetNameOverride("钨钢盔甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHeadgear"))
				{
					item.SetNameOverride("钨钢头饰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHelm"))
				{
					item.SetNameOverride("钨钢战盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHelmet"))
				{
					item.SetNameOverride("钨钢头盔");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHood"))
				{
					item.SetNameOverride("钨钢兜帽");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumLeggings"))
				{
					item.SetNameOverride("钨钢护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumMask"))
				{
					item.SetNameOverride("钨钢面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocCuisses"))
				{
					item.SetNameOverride("克希洛克护胫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocMask"))
				{
					item.SetNameOverride("克希洛克面具");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocPlateMail"))
				{
					item.SetNameOverride("克希洛克胸甲");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharonMask"))
				{
					item.SetNameOverride("丛林龙面具");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalDivingSuit"))
					{
						if (tooltipLine.text == "Transforms the holder into an armored diver")
						{
							tooltipLine.text = "将穿戴者变成一个身披重甲的潜水员";
						}
						if (tooltipLine.text == "Increases movement speed while underwater and moves slowly outside of water")
						{
							tooltipLine.text = "增加水下移速，降低陆上移速";
						}
						if (tooltipLine.text == "The suits' armored plates reduce damage taken by 15%")
						{
							tooltipLine.text = "这套服装的坚硬金属壳会提供15%的伤害减免";
						}
						if (tooltipLine.text == "The plates will only take damage if the damage taken is over 50")
						{
							tooltipLine.text = "超过50的伤害将会对坚硬金属壳造成损伤";
						}
						if (tooltipLine.text == "After the suit has taken too much damage its armored plates will take 3 minutes to regenerate")
						{
							tooltipLine.text = "受到过量伤害后，坚硬金属壳需要3分钟时间再生";
						}
						if (tooltipLine.text == "Reduces the damage caused by the pressure of the abyss while out of breath")
						{
							tooltipLine.text = "呼吸槽归零时，减少水压对你造成的伤害";
						}
						if (tooltipLine.text == "Removes the bleed effect caused by the abyss in all layers except the deepest one")
						{
							tooltipLine.text = "移除深渊对你造成的生命流失伤害，但在最深一层无效";
						}
						if (tooltipLine.text == "Grants the ability to swim and greatly extends underwater breathing")
						{
							tooltipLine.text = "获得游泳能力并大幅增加水下呼吸槽";
						}
						if (tooltipLine.text == "Provides light underwater and extra mobility on ice")
						{
							tooltipLine.text = "水下提供额外光照以及冰面上的额外行走能力";
						}
						if (tooltipLine.text == "Provides a moderate amount of light in the abyss")
						{
							tooltipLine.text = "在深渊里提供适量的光照";
						}
						if (tooltipLine.text == "Greatly reduces breath loss in the abyss")
						{
							tooltipLine.text = "大幅增强肺活量，减少呼吸槽消耗率";
						}
						if (tooltipLine.text == "Allows you to fall faster while in liquids")
						{
							tooltipLine.text = "让你在水中下潜更快";
						}
						if (tooltipLine.text == "Reduces creature's ability to detect you in the abyss")
						{
							tooltipLine.text = "降低深渊生物发现你的可能性";
						}
						if (tooltipLine.text == "Reduces the defense reduction that the abyss causes")
						{
							tooltipLine.text = "降低深渊削减的防御值";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHat") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecBreastplate") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecLeggings")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHeadgear")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AerospecHood"))
					{
						if (tooltipLine.text == "12% increased movement speed")
						{
							tooltipLine.text = "增加12%移动速度";
						}
						if (tooltipLine.text == "3% increased critical strike chance")
						{
							tooltipLine.text = "增加3%暴击率";
						}
						if (tooltipLine.text == "8% increased magic damage and +20 max mana")
						{
							tooltipLine.text = "增加8%魔法伤害，+20魔法上限";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased movement speed and magic critical strike chance\nTaking over 25 damage in one hit will cause a spread of homing feathers to fall\nAllows you to fall more quickly and disables fall damage";
							string tooltipLinech = "增加5%移动速度和魔法暴击率\n受到超过25点的伤害会造成一次追踪落羽攻击\n加快你的下落速度并让你免疫掉落伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "8% increased melee damage")
						{
							tooltipLine.text = "增加8%近战伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased movement speed and melee critical strike chance\nTaking over 25 damage in one hit will cause a spread of homing feathers to fall\nAllows you to fall more quickly and disables fall damage";
							string tooltipLinech = "增加5%移动速度和近战暴击率\n受到超过25点的伤害会造成一次追踪落羽攻击\n加快你的下落速度并让你免疫掉落伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "8% increased rogue damage and 5% increased movement speed")
						{
							tooltipLine.text = "增加8%盗贼伤害，增加5%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased movement speed and rogue critical strike chance\nTaking over 25 damage in one hit will cause a spread of homing feathers to fall\nAllows you to fall more quickly and disables fall damage\nRogue stealth builds while not attacking and not moving, up to a max of 100\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "增加5%移动速度和盗贼暴击率\n受到超过25点的伤害会造成一次追踪落羽攻击\n加快你的下落速度并让你免疫掉落伤害\n站立不动时会盗贼潜行，最高100\n盗贼潜行只会在你攻击时减少，而在移动时不会减少\n你的盗贼潜行越高，你的盗贼伤害，暴击和移动速度就越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased movement speed and +1 max minion")
						{
							tooltipLine.text = "增加5%移动速度并+1召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "16% increased minion damage\nSummons a valkyrie to protect you\nTaking over 25 damage in one hit will cause a spread of homing feathers to fall\nAllows you to fall more quickly and disables fall damage";
							string tooltipLinech = "增加16%召唤伤害\n召唤女武神保护你\n受到超过25点的伤害会造成一次追踪落羽攻击\n加快你的下落速度并让你免疫掉落伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "8% increased ranged damage")
						{
							tooltipLine.text = "增加8%远程伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased movement speed and ranged critical strike chance\nTaking over 25 damage in one hit will cause a spread of homing feathers to fall\nAllows you to fall more quickly and disables fall damage";
							string tooltipLinech = "增加5%移动速度和远程暴击率\n受到超过25点的伤害会造成一次追踪落羽攻击\n加快你的下落速度并让你免疫掉落伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBreastplate") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralHelm") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralLeggings"))
					{
						if (tooltipLine.text == "+20 max mana and life")
						{
							tooltipLine.text = "+20魔力上限和生命上限";
						}
						if (tooltipLine.text == "+3 max minions")
						{
							tooltipLine.text = "+3召唤栏";
						}
						if (tooltipLine.text == "Creature detection")
						{
							tooltipLine.text = "生物探测效果";
						}
						if (tooltipLine.text == "Danger detection")
						{
							tooltipLine.text = "危险感知效果";
						}
						if (tooltipLine.text == "10% increased movement speed")
						{
							tooltipLine.text = "增加10%移动速度";
						}
						if (tooltipLine.text == "Treasure and ore detection")
						{
							tooltipLine.text = "宝物以及矿石检测效果";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "25% increased movement speed\n28% increased damage and 21% increased critical strike chance\nWhenever you crit an enemy fallen, hallowed, and astral stars will rain down\nThis effect has a 1 second cooldown before it can trigger again";
							string tooltipLinech = "增加25%移动速度\n增加28%伤害和21%暴击率\n当你打出暴击时，神圣落星和彗星会从天空中下落\n这个效果有1秒的冷却时间";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaArmor") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHeadgear") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaHood")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaMask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AtaxiaSubligar"))
					{
						if (tooltipLine.text == "+20 max life")
						{
							tooltipLine.text = "+20生命上限";
						}
						if (tooltipLine.text == "8% increased damage and 4% increased critical strike chance")
						{
							tooltipLine.text = "增加8%伤害和4%暴击率";
						}
						if (tooltipLine.text == "12% increased ranged damage and 10% increased ranged critical strike chance")
						{
							tooltipLine.text = "增加12%远程伤害，增加10%远程暴击率";
						}
						if (tooltipLine.text == "Reduces ammo usage by 25%, temporary immunity to lava, and immunity to fire damage")
						{
							tooltipLine.text = "减少25%的弹药消耗\n暂时免疫岩浆伤害，免疫砖块灼烧伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased ranged damage\nInferno effect when below 50% life\nYou have a 50% chance to fire a homing chaos flare when using ranged weapons\nYou have a 20% chance to emit a blazing explosion when you are hit";
							string tooltipLinech = "增加5%远程伤害\n低于50%生命值时获得地狱降临效果\n使用远程武器时，你有50%的几率发射一次追踪混乱之火\n你有20%几率在受到伤害时散射热炎爆破";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "12% increased melee damage and 10% increased melee critical strike chance")
						{
							tooltipLine.text = "增加12%近战伤害，增加10%近战暴击率";
						}
						if (tooltipLine.text == "12% increased melee and movement speed")
						{
							tooltipLine.text = "增加12%近战和移动速度";
						}
						if (tooltipLine.text == "Melee attacks and melee projectiles inflict on fire")
						{
							tooltipLine.text = "近战攻击和弹幕附着着火debuff";
						}
						if (tooltipLine.text == "Temporary immunity to lava and immunity to fire damage")
						{
							tooltipLine.text = "暂时免疫岩浆伤害，免疫砖块灼烧伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased melee damage\nInferno effect when below 50% life\nMelee attacks and projectiles cause chaos flames to erupt on enemy hits\nYou have a 20% chance to emit a blazing explosion when you are hit";
							string tooltipLinech = "增加5%近战伤害\n低于50%生命值时获得地狱降临效果\n近战武器和弹幕攻击到敌人会爆发混乱之火\n你有20%几率在受到伤害时散射热炎爆破";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased minion damage and increased minion knockback")
						{
							tooltipLine.text = "增加5%召唤伤害和增加召唤物击退";
						}
						if (tooltipLine.text == "+2 max minions")
						{
							tooltipLine.text = "+2召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "40% increased minion damage\nInferno effect when below 50% life\nSummons a chaos spirit to protect you\nYou have a 20% chance to emit a blazing explosion when you are hit";
							string tooltipLinech = "增加40%召唤伤害\n低于50%血获得地狱降临效果\n召唤混乱之灵保护你\n你有20%几率在受到伤害时散射热炎爆破";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "12% increased rogue damage and 10% increased rogue critical strike chance")
						{
							tooltipLine.text = "增加12%盗贼伤害，增加10%盗贼暴击率";
						}
						if (tooltipLine.text == "50% chance to not consume rogue items and 15% increased movement speed")
						{
							tooltipLine.text = "50%几率不消耗盗贼投掷物，增加15%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased rogue damage\nInferno effect when below 50% life\nRogue weapons have a 10% chance to unleash a volley of chaos flames around the player that chase enemies when used\nYou have a 20% chance to emit a blazing explosion when you are hit\nRogue stealth builds while not attacking and not moving, up to a max of 120\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "增加5%盗贼伤害\n低于50%血获得地狱降临效果\n投掷武器有10%的几率在玩家周围释放会跟踪敌人的混乱之火\n你有20%几率在受到伤害时散射热炎爆破\n不攻击和不移动进入盗贼潜行，最高值为120\n盗贼潜行只有在攻击时才会减少，移动时不会减少\n盗贼潜行越高，盗贼的伤害、暴击和移动速度就越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "12% increased magic damage, reduces mana usage by 15%, and 10% increased magic critical strike chance")
						{
							tooltipLine.text = "增加12%魔法伤害，减少15%魔力消耗，增加10%魔法暴击率";
						}
						if (tooltipLine.text == "+100 max mana, temporary immunity to lava, and immunity to fire damage")
						{
							tooltipLine.text = "+100魔力上限\n暂时免疫岩浆伤害，免疫砖块灼烧伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased magic damage\nInferno effect when below 50% life\nMagic attacks summon damaging and healing flare orbs on hit\nYou have a 20% chance to emit a blazing explosion when you are hit";
							string tooltipLinech = "增加5%的魔法伤害\n低于50%血获得地狱降临效果\n魔法武器攻击敌人时会释放混乱之球伤害敌人和治疗自己\n你有20%几率在受到伤害时散射热炎爆破";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "3% increased critical strike chance")
						{
							tooltipLine.text = "增加3%暴击率";
						}
						if (tooltipLine.text == "15% increased movement speed")
						{
							tooltipLine.text = "增加15%移速";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaBodyArmor") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaCuisses") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaHoodedFacemask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaPlumedHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaSpaceHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricTeslaWireHemmedVisage"))
					{
						if (tooltipLine.text == "+100 max life")
						{
							tooltipLine.text = "+100生命上限";
						}
						if (tooltipLine.text == "25% increased movement speed")
						{
							tooltipLine.text = "增加25%移动速度";
						}
						if (tooltipLine.text == "Attacks have a 2% chance to do no damage to you")
						{
							tooltipLine.text = "你有2%几率免疫攻击";
						}
						if (tooltipLine.text == "8% increased damage and 5% increased critical strike chance")
						{
							tooltipLine.text = "增加8%伤害和5%暴击率";
						}
						if (tooltipLine.text == "You will freeze enemies near you when you are struck")
						{
							tooltipLine.text = "被击中后冻结你周围的敌人";
						}
						if (tooltipLine.text == "50% increased movement speed")
						{
							tooltipLine.text = "增加50%移动速度";
						}
						if (tooltipLine.text == "12% increased damage and 5% increased critical strike chance")
						{
							tooltipLine.text = "增加12%伤害和5%暴击率";
						}
						if (tooltipLine.text == "Magic carpet effect")
						{
							tooltipLine.text = "魔毯能力";
						}
						if (tooltipLine.text == "Not moving boosts all damage and critical strike chance")
						{
							tooltipLine.text = "不移动时增加所有伤害和暴击率";
						}
						if (tooltipLine.text == "20% increased melee damage and critical strike chance")
						{
							tooltipLine.text = "增加20%近战伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Melee Tarragon, Bloodflare, God Slayer, and Silva armor effects\nAll projectiles spawn healing auric orbs on enemy hits\nMax run speed and acceleration boosted by 10%\nYour melee damage is multiplied based on how high your HP is; at full HP this effect is at max";
							string tooltipLinech = "获得龙蒿、血炎、弑神、始源林海的近战套装效果\n所有弹幕击中敌人后会释放治愈金珠\n最大移速和加速度增加10%\n你的血量百分比越高，近战伤害越高，满血时此状态为最大值";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "30% increased ranged damage and critical strike chance")
						{
							tooltipLine.text = "增加30%远程伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Ranged Tarragon, Bloodflare, God Slayer, and Silva armor effects\nAll projectiles spawn healing auric orbs on enemy hits\nMax run speed and acceleration boosted by 10%";
							string tooltipLinech = "获得龙蒿、血炎、弑神、始源林海的远程套装效果\n所有弹幕击中敌人后会释放治愈金珠\n最大移速和加速度增加10%";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "20% increased rogue damage and critical strike chance, 25% increased movement speed")
						{
							tooltipLine.text = "增加20%盗贼伤害和暴击几率，增加25%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Rogue Tarragon, Bloodflare, God Slayer, and Silva armor effects\nAll projectiles spawn healing auric orbs on enemy hits\nMax run speed and acceleration boosted by 10%\nRogue weapon critical strikes will do 1.25 times damage while you are above 50% HP\nRogue stealth builds while not attacking and not moving, up to a max of 160\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "获得龙蒿、血炎、弑神、始源林海的盗贼套装效果\n所有弹幕击中敌人后会释放治愈金珠\n最大移速和加速度增加10%\n高于50%生命且盗贼武器暴击时，暴击造成伤害为原伤害1.25倍\n不攻击且站立不动时增加潜行值，最大值160\n攻击时降低潜行值，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "+7 max minions")
						{
							tooltipLine.text = "+7召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Summoner Tarragon, Bloodflare, God Slayer, and Silva armor effects\nAll projectiles spawn healing auric orbs on enemy hits\nMax run speed and acceleration boosted by 10%\n120% increased minion damage";
							string tooltipLinech = "获得龙蒿、血炎、弑神、始源林海的召唤套装效果\n所有弹幕击中敌人后会释放治愈金珠\n最大移速和加速度增加10%\n增加120%召唤伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "20% increased magic damage and critical strike chance, +100 max mana, and 20% reduced mana usage")
						{
							tooltipLine.text = "增加20%魔法伤害和魔法暴击率，+100魔力上限，减少20%魔力消耗";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Magic Tarragon, Bloodflare, God Slayer, and Silva armor effects\nAll projectiles spawn healing auric orbs on enemy hits\nMax run speed and acceleration boosted by 10%";
							string tooltipLinech = "获得龙蒿、血炎、弑神、始源林海的魔法套装效果\n所有弹幕击中敌人后会释放治愈金珠\n最大移速和加速度增加10%";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareBodyArmor") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareCuisses") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHornedHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareHornedMask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodflareMask"))
					{
						if (tooltipLine.text == "12% increased damage and 8% increased critical strike chance")
						{
							tooltipLine.text = "增加12%伤害和8%暴击率";
						}
						if (tooltipLine.text == "You regenerate life quickly and gain +30 defense while in lava")
						{
							tooltipLine.text = "在岩浆中大幅增加生命恢复速度以及+30防御";
						}
						if (tooltipLine.text == "+40 max life")
						{
							tooltipLine.text = "+40生命上限";
						}
						if (tooltipLine.text == "30% increased movement speed, 10% increased damage and 7% increased critical strike chance")
						{
							tooltipLine.text = "增加30%移动速度，10%伤害和7%暴击率";
						}
						if (tooltipLine.text == "You can move freely through liquids and have temporary immunity to lava")
						{
							tooltipLine.text = "在液体中行动不受阻碍，暂时免疫岩浆伤害";
						}
						if (tooltipLine.text == "10% increased rogue damage and critical strike chance, 15% increased movement speed")
						{
							tooltipLine.text = "增加10%盗贼伤害和暴击率，增加15%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Greatly increases life regen\nEnemies below 50% life have a chance to drop hearts when struck\nEnemies above 50% life have a chance to drop mana stars when struck\nEnemies killed during a Blood Moon have a much higher chance to drop Blood Orbs\nBeing over 80% life boosts your defense by 30 and rogue crit by 5%\nBeing below 80% life boosts your rogue damage by 10%\nRogue critical strikes have a 50% chance to heal you\nRogue stealth builds while not attacking and not moving, up to a max of 135\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "大幅提升生命恢复速度\n在攻击低于50%血量的敌人时几率掉落红心\n攻击高于50%血量的敌人时几率掉落蓝星\n在血月被击杀的敌人有更大几率掉落血珠\n高于80%生命值时，防御增加30，盗贼暴击率增加5%\n低于80%生命值会使你的盗贼伤害提升10%\n盗贼暴击有50%几率回复你的生命\n不攻击且站立不动时增加潜行层数，至多135层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "+3 max minions")
						{
							tooltipLine.text = "+3召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "55% increased minion damage\nGreatly increases life regen\nEnemies below 50% life have a chance to drop hearts when struck\nEnemies above 50% life have a chance to drop mana stars when struck\nEnemies killed during a Blood Moon have a much higher chance to drop Blood Orbs\nSummons polterghast mines to circle you\nAt 90% life and above you gain 10% increased minion damage\nAt 50% life and below you gain 20 defense and 2 life regen";
							string tooltipLinech = "增加55%召唤伤害\n大幅提升生命恢复速度\n在攻击低于50%血量的敌人时几率掉落红心\n攻击高于50%血量的敌人时几率掉落蓝星\n在血月被击杀的敌人有更大几率掉落血珠\n召唤噬魂幽炎雷围绕身周\n高于90%生命时增加10%召唤物伤害\n低于50%生命时你获得20点防御值并增加2生恢复速度";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "10% increased ranged damage and critical strike chance")
						{
							tooltipLine.text = "增加10%的远程伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Greatly increases life regen\nEnemies below 50% life have a chance to drop hearts when struck\nEnemies above 50% life have a chance to drop mana stars when struck\nEnemies killed during a Blood Moon have a much higher chance to drop Blood Orbs\nPress Y to unleash the lost souls of polterghast to destroy your enemies\nThis effect has a 30 second cooldown\nRanged weapons have a chance to fire bloodsplosion orbs";
							string tooltipLinech = "大幅提升生命恢复速度\n在攻击低于50%血量的敌人时几率掉落红心\n攻击高于50%血量的敌人时几率掉落蓝星\n在血月被击杀的敌人有更大几率掉落血珠\n按Y键以释放幽火游魂摧毁你的敌人\n此技能有30秒cd\n远程武器有几率发射血毒珠";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "10% increased magic damage and critical strike chance, +100 max mana, and 17% reduced mana usage")
						{
							tooltipLine.text = "增加10%魔法伤害和暴击率，最大魔力增加100，减少17%魔力消耗";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Greatly increases life regen\nEnemies below 50% life have a chance to drop hearts when struck\nEnemies above 50% life have a chance to drop mana stars when struck\nEnemies killed during a Blood Moon have a much higher chance to drop Blood Orbs\nMagic weapons will sometimes fire ghostly bolts\nMagic critical strikes cause flame explosions every 2 seconds";
							string tooltipLinech = "大幅提升生命恢复速度\n在攻击低于50%血量的敌人时几率掉落红心\n攻击高于50%血量的敌人时几率掉落蓝星\n在血月被击杀的敌人有更大几率掉落血珠\n魔法武器有时发射幽火球\n魔法暴击每2秒就会引发火焰爆炸";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "10% increased melee damage and critical strike chance")
						{
							tooltipLine.text = "增加10%近战伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Greatly increases life regen\nEnemies are more likely to target you\nEnemies below 50% life have a chance to drop hearts when struck\nEnemies above 50% life have a chance to drop mana stars when struck\nEnemies killed during a Blood Moon have a much higher chance to drop Blood Orbs\nTrue melee strikes will heal you\nAfter striking an enemy 15 times with true melee you will enter a blood frenzy for 5 seconds\nDuring this you will gain 25% increased melee damage, critical strike chance, and contact damage is halved\nThis effect has a 30 second cooldown";
							string tooltipLinech = "大幅提升生命恢复速度\n敌人更有可能瞄准你\n在攻击低于50%血量的敌人时几率掉落红心\n攻击高于50%血量的敌人时几率掉落蓝星\n在血月被击杀的敌人有更大几率掉落血之珠\n近战攻击（非弹幕伤害）会治疗你\n真近战攻击15次后，进入鲜血狂暴状态5秒钟\n在这期间你获得25%近战伤害和暴击率，敌人接触伤害减半\n此效果有30秒冷却";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusBreastplate") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHat") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHeadgear")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusLeggings")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DaedalusVisor"))
					{
						if (tooltipLine.text == "3% increased damage and critical strike chance")
						{
							tooltipLine.text = "增加3%伤害和暴击率";
						}
						if (tooltipLine.text == "13% increased magic damage and 7% increased magic critical strike chance")
						{
							tooltipLine.text = "增加13%魔法伤害，增加7%魔法暴击率";
						}
						if (tooltipLine.text == "10% decreased mana usage and +60 max mana")
						{
							tooltipLine.text = "减少10%的魔力消耗，+60魔力上限";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased magic damage\nYou have a 10% chance to absorb physical attacks and projectiles when hit\nIf you absorb an attack you are healed for 1/2 of that attack's damage";
							string tooltipLinech = "增加5%魔法伤害\n10%几率吸收受到的物理和弹幕攻击\n如果你吸收了攻击，你会恢复相当于攻击所造成伤害的一半的血量";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "13% increased rogue damage and 7% increased rogue critical strike chance, increases rogue velocity by 15%")
						{
							tooltipLine.text = "增加13%盗贼伤害，增加升7%盗贼暴击率，增加15%盗贼投掷速度";
						}
						if (tooltipLine.text == "17% increased movement speed")
						{
							tooltipLine.text = "增加17%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased rogue damage\nRogue projectiles throw out crystal shards as they travel\nRogue stealth builds while not attacking and not moving, up to a max of 110\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "增加5%的盗贼伤害\n投掷物击中敌人会分裂出水晶碎片\n不攻击且站立不动时增加潜行层数，至多110层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "10% increased melee damage and critical strike chance")
						{
							tooltipLine.text = "增加10%的近战伤害和暴击几率";
						}
						if (tooltipLine.text == "10% increased melee and movement speed")
						{
							tooltipLine.text = "增加10%的近战和移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased melee damage\nYou have a 33% chance to reflect projectiles back at enemies\nIf you reflect a projectile you are also healed for 1/5 of that projectile's damage";
							string tooltipLinech = "增加5%近战伤害\n你有33%几率反弹敌人的弹幕\n反弹之后恢复弹幕伤害20%的血量";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "13% increased ranged damage and 7% increased ranged critical strike chance")
						{
							tooltipLine.text = "远程伤害增加13%，远程暴击几率增加7%";
						}
						if (tooltipLine.text == "Reduces ammo usage by 20%")
						{
							tooltipLine.text = "弹药消耗减少20%";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased ranged damage\nGetting hit causes you to emit a blast of crystal shards";
							string tooltipLinech = "增加5%的远程伤害\n受到伤害时释放一团爆破水晶";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased minion damage and +2 max minions")
						{
							tooltipLine.text = "增加5%召唤伤害，+2召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "20% increased minion damage\nA daedalus crystal floats above you to protect you";
							string tooltipLinech = "增加20%召唤物伤害\n代达罗斯水晶漂浮在你的上方保护你";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "3% increased critical strike chance")
						{
							tooltipLine.text = "增加3%暴击率";
						}
						if (tooltipLine.text == "10% increased movement speed")
						{
							tooltipLine.text = "增加10%移动速度";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeBreastplate") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeGreaves") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeHelm"))
					{
						if (tooltipLine.text == "20% increased melee speed, 15% increased damage and critical strike chance")
						{
							tooltipLine.text = "增加20%近战攻速，15%所有伤害和暴击率";
						}
						if (tooltipLine.text == "Enemies take ungodly damage when they touch you")
						{
							tooltipLine.text = "敌人触碰你时受到鬼魔伤害";
						}
						if (tooltipLine.text == "Increased max life and mana by 200")
						{
							tooltipLine.text = "+200血量上限和魔力上限";
						}
						if (tooltipLine.text == "Standing still lets you absorb the shadows and boost your life regen")
						{
							tooltipLine.text = "站立不动你将吸收暗影能量并大幅增加生命恢复速度";
						}
						if (tooltipLine.text == "Shadow speed")
						{
							tooltipLine.text = "影子疾步";
						}
						if (tooltipLine.text == "30% increased damage and 15% increased critical strike chance, +10 max minions")
						{
							tooltipLine.text = "增加30%伤害和15%暴击率，+10召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "100% increased minion damage\nAll attacks inflict the demon flame debuff\nShadowbeams and demon scythes will fire down when you are hit\nA friendly red devil follows you around\nPress Y to enrage nearby enemies with a dark magic spell for 10 seconds\nThis makes them do 25% more damage but they also take 125% more damage";
							string tooltipLinech = "增加100%召唤伤害\n所有攻击附着魔影炎\n你受到伤害时会释放暗影射线及恶魔镰刀\n一个友好的红恶魔会跟随着你\n按Y键以用黑魔咒激怒四周敌人\n这会让敌人造成和受到的伤害都增加25%";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerChestplate") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerHelm") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerHornedHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerLeggings")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerMask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("GodSlayerVisage"))
					{
						if (tooltipLine.text == "+60 max life")
						{
							tooltipLine.text = "+60生命上限";
						}
						if (tooltipLine.text == "15% increased movement speed")
						{
							tooltipLine.text = "增加15%移动速度";
						}
						if (tooltipLine.text == "Enemies take damage when they hit you")
						{
							tooltipLine.text = "敌人在攻击你后会受到伤害";
						}
						if (tooltipLine.text == "Attacks have a 2% chance to do no damage to you")
						{
							tooltipLine.text = "来犯的攻击有2%几率对你无效";
						}
						if (tooltipLine.text == "11% increased damage and 6% increased critical strike chance")
						{
							tooltipLine.text = "增加11%伤害和6%暴击率";
						}
						if (tooltipLine.text == "14% increased melee damage and critical strike chance")
						{
							tooltipLine.text = "增加14%近战伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You will survive fatal damage and will be healed 150 HP if an attack would have killed you\nThis effect can only occur once every 45 seconds\nWhile the cooldown for this effect is active you gain a 10% increase to all damage\nTaking over 80 damage in one hit will cause you to release a swarm of high-damage god killer darts\nEnemies take a lot of damage when they hit you\nAn attack that would deal 80 damage or less will have its damage reduced to 1";
							string tooltipLinech = "你受到致死伤害时会复活并恢复150点生命值\n此效果只能每45秒触发一次\n此效果冷却时间内增加10%伤害\n受到超过80点伤害会发射一团弑神者飞镖\n敌人击中你时会受到可观的反伤\n伤害等于或低于80点时，伤害削减至1";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "14% increased ranged damage and critical strike chance")
						{
							tooltipLine.text = "增加14%远程伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You will survive fatal damage and will be healed 150 HP if an attack would have killed you\nThis effect can only occur once every 45 seconds\nWhile the cooldown for this effect is active you gain a 10% increase to all damage\nYour ranged critical hits have a chance to critically hit, causing 4 times the damage\nYou have a chance to fire a god killer shrapnel round while firing ranged weapons";
							string tooltipLinech = "你受到致死伤害时会复活并恢复150点生命值\n此效果只能每45秒触发一次\n此效果冷却时间内增加10%伤害\n你的远程暴击伤害有几率再翻一倍，即造成四倍伤害\n你在射击时有几率会发射一团弑神者飞镖";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "+3 max minions")
						{
							tooltipLine.text = "+3召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "65% increased minion damage\nYou will survive fatal damage and will be healed 150 HP if an attack would have killed you\nThis effect can only occur once every 45 seconds\nWhile the cooldown for this effect is active you gain a 10% increase to all damage\nHitting enemies will summon god slayer phantoms\nSummons a god-eating mechworm to fight for you";
							string tooltipLinech = "增加65%召唤伤害\n你受到致死伤害时会复活并恢复150点生命值\n此效果只能每45秒触发一次\n此效果冷却时间内增加10%伤害\n击中敌人会召唤弑神者幻魂\n召唤弑神者机械虫为你战斗";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "14% increased rogue damage and critical strike chance, 18% increased movement speed")
						{
							tooltipLine.text = "增加14%盗贼伤害和暴击率，增加18%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You will survive fatal damage and will be healed 150 HP if an attack would have killed you\nThis effect can only occur once every 45 seconds\nWhile the cooldown for this effect is active you gain a 10% increase to all damage\nWhile at full HP all of your rogue stats are boosted by 10%\nIf you take over 80 damage in one hit you will be given extra immunity frames\nRogue stealth builds while not attacking and not moving, up to a max of 140\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "你受到致死伤害时会复活并恢复150点生命值\n此效果只能每45秒触发一次\n此效果冷却时间内增加10%伤害\n满血时所有盗贼属性提升10%\n如果受到超过80点伤害的打击则会获得额外的无敌时间\n不攻击且站立不动时增加潜行层数，至多140层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "14% increased magic damage and critical strike chance")
						{
							tooltipLine.text = "增加14%的魔法伤害和暴击率";
						}
						if (tooltipLine.text == "+100 max mana and 17% reduced mana usage")
						{
							tooltipLine.text = "+100魔力上限，减少17%魔力消耗";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You will survive fatal damage and will be healed 150 HP if an attack would have killed you\nThis effect can only occur once every 45 seconds\nWhile the cooldown for this effect is active you gain a 10% increase to all damage\nEnemies will release god slayer flames and healing flames when hit with magic attacks\nTaking damage will cause you to release a magical god slayer explosion";
							string tooltipLinech = "你受到致死伤害时会复活并恢复150点生命值\n此效果只能每45秒触发一次\n此效果冷却时间内增加10%伤害\n用魔法武器攻击敌人时，敌人有几率留下弑神者心炎和治愈心炎\n受到伤害会令你释放弑神者怒焰";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskShelleggings") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskShellmet") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskShellplate"))
					{
						if (tooltipLine.text == "10% increased damage and 6% increased critical strike chance")
						{
							tooltipLine.text = "增加10%伤害和6%暴击率";
						}
						if (tooltipLine.text == "15% decreased movement speed")
						{
							tooltipLine.text = "降低15%移动速度";
						}
						if (tooltipLine.text == "12% increased damage and 4% increased critical strike chance")
						{
							tooltipLine.text = "增加12%伤害，增加4%暴击率";
						}
						if (tooltipLine.text == "7% decreased movement speed")
						{
							tooltipLine.text = "降低7%移动速度";
						}
						if (tooltipLine.text == "5% increased damage and 4% increased critical strike chance")
						{
							tooltipLine.text = "增加5%伤害和4%暴击率";
						}
						if (tooltipLine.text == "You can move freely through liquids")
						{
							tooltipLine.text = "在液体中行动不受阻碍";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Two shellfishes aid you in combat\n10% increased damage\nYour horizontal movement is slowed";
							string tooltipLinech = "两扇贝壳会在战斗中帮助你\n增加10%伤害\n你的水平移动速度会降低";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaBlueChestplate") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaBlueHelmet") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("OmegaBlueLeggings"))
					{
						if (tooltipLine.text == "12% increased damage and 8% increased critical strike chance")
						{
							tooltipLine.text = "增加12%伤害和8%暴击率";
						}
						if (tooltipLine.text == "Your attacks inflict Crush Depth")
						{
							tooltipLine.text = "你的攻击附着深渊水压debuff";
						}
						if (tooltipLine.text == "No positive life regen")
						{
							tooltipLine.text = "无法生命再生";
						}
						if (tooltipLine.text == "You can move freely through liquids")
						{
							tooltipLine.text = "你可以在液体中自由移动";
						}
						if (tooltipLine.text == "+2 max minions")
						{
							tooltipLine.text = "+2召唤栏";
						}
						if (tooltipLine.text == "30% increased movement speed")
						{
							tooltipLine.text = "增加30%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Increases armor penetration by 50\n10% increased damage and critical strike chance\nShort-ranged tentacles heal you by sucking enemy life\nPress Y to activate abyssal madness for 5 seconds\nAbyssal madness increases damage, critical strike chance, and tentacle aggression/range\nThis effect has a 30 second cooldown";
							string tooltipLinech = "增加50点护甲穿透\n增加10%伤害和暴击率\n短触距的触手会通过吸取敌人的生命治疗你自己\n按Y激活深渊狂乱效果持续5秒\n深渊狂乱增加伤害，暴击率，触手的攻击性和攻击距离\n30秒CD";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverCap") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverCuisses") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverMask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverScaleMail")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaverVisage"))
					{
						if (tooltipLine.text == "15% increased ranged damage, 20% decreased ammo usage, and 5% increased ranged critical strike chance")
						{
							tooltipLine.text = "增加15%远程伤害，减少20%弹药消耗，增加5%远程暴击率";
						}
						if (tooltipLine.text == "10% increased movement speed and can move freely through liquids")
						{
							tooltipLine.text = "增加10%移动速度，可在液体中自由移动";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased ranged damage\nWhile using a ranged weapon you have a 10% chance to fire a powerful rocket";
							string tooltipLinech = "增加5%远程伤害\n使用远程武器时你有10%的几率发射一颗强大的火箭";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "15% increased rogue damage, 5% increased rogue velocity and critical strike chance")
						{
							tooltipLine.text = "增加15%的盗贼伤害，增加5%的盗贼投掷速度和暴击率";
						}
						if (tooltipLine.text == "20% increased movement speed and can move freely through liquids")
						{
							tooltipLine.text = "增加20%移动速度，可在液体中自由移动";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "15% increased rogue damage, 5% increased rogue velocity and critical strike chance\nWhile using a ranged weapon you have a 10% chance to fire a powerful rocket";
							string tooltipLinech = "增加5%盗贼伤害\n被击中时会释放孢子毒云\n不攻击且站立不动时增加潜行层数，至多115层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased critical strike chance")
						{
							tooltipLine.text = "增加5%暴击率";
						}
						if (tooltipLine.text == "12% increased movement speed")
						{
							tooltipLine.text = "增加12%移速";
						}
						if (tooltipLine.text == "15% increased melee damage, 10% increased melee speed, and 5% increased melee critical strike chance")
						{
							tooltipLine.text = "增加15%的近战伤害，增加10%的近战速度，增加5%的近战暴击率";
						}
						if (tooltipLine.text == "10% increased movement speed and can move freely through liquids")
						{
							tooltipLine.text = "增加10%移动速度，可在液体中自由移动";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased melee damage\nMelee projectiles explode on hit\nReaver thorns\nRage activates when you are damaged";
							string tooltipLinech = "增加5%近战伤害\n近战弹幕击中造成爆炸\n产生掠夺者荆棘\n受伤后进入暴怒状态";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased minion damage, +2 max minions, and increased minion knockback")
						{
							tooltipLine.text = "增加5%召唤伤害，+2召唤栏，增加召唤物击退";
						}
						if (tooltipLine.text == "10% increased movement speed and can move freely through liquids")
						{
							tooltipLine.text = "增加10%移动速度，可在液体中自由移动";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "16% increased minion damage\nSummons a reaver orb that emits spore gas when enemies are near";
							string tooltipLinech = "增加16%召唤伤害\n召唤一个掠夺者之球，敌人接近时释放孢子毒云";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "15% increased magic damage, 12% reduced mana cost, and 5% increased magic critical strike chance")
						{
							tooltipLine.text = "魔法伤害，魔力消耗降低12%，魔法暴击几率增加5%";
						}
						if (tooltipLine.text == "10% increased movement speed, can move freely through liquids, and +80 max mana")
						{
							tooltipLine.text = "增加10%移动速度，可在液体中自由移动，+80魔力上限";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "5% increased magic damage\nYour magic projectiles emit a burst of spore gas on enemy hits";
							string tooltipLinech = "增加5%魔法伤害\n你的魔法攻击击中敌人后会释放毒云";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShroomiteVisage")
					|| item.type == 1549 
					|| item.type == 1550)
					{
						if (tooltipLine.text == "25% increased ranged damage for flamethrowers")
						{
							tooltipLine.text = "增加25%喷火器的伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Ranged stealth while standing still";
							string tooltipLinech = "站立不动时进入隐身状态";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaArmor") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaHelm") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaHornedHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaLeggings")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaMask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("SilvaMaskedCap"))
					{
						if (tooltipLine.text == "+80 max life")
						{
							tooltipLine.text = "+80生命上限";
						}
						if (tooltipLine.text == "20% increased movement speed")
						{
							tooltipLine.text = "增加20%移动速度";
						}
						if (tooltipLine.text == "12% increased damage and 8% increased critical strike chance")
						{
							tooltipLine.text = "增加12%伤害和8%暴击率";
						}
						if (tooltipLine.text == "13% increased melee damage and critical strike chance")
						{
							tooltipLine.text = "增加13%近战伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You are immune to almost all debuffs\nAll projectiles spawn healing leaf orbs on enemy hits\nMax run speed and acceleration boosted by 5%\nIf you are reduced to 1 HP you will not die from any further damage for 10 seconds\nIf you get reduced to 1 HP again while this effect is active you will lose 100 max life\nThis effect only triggers once per life and if you are reduced to 400 max life the invincibility effect will stop\nYour max life will return to normal if you die\nTrue melee strikes have a 25% chance to do five times damage\nAfter the silva invincibility is over you will take 20% less contact damage\nMelee projectiles have a 25% chance to stun enemies for a very brief moment";
							string tooltipLinech = "免疫几乎所有debuff\n所有弹幕击中敌人后会释放治愈叶珠\n最大移速和加速度增加5%\n如果你生命值降到1，你10秒钟受到伤害不会立即死亡\n这期间如果你这时生命值又被打到1，你的血量上限会减少100\n这个效果每条命触发一次，在这期间，血量上限被削减到400时，无敌效果会直接消失\n你的血量上限会在死后恢复为原来值\n真实近战伤害（武器本体伤害）有25%几率造成5倍伤害\n始源林海的无敌状态结束后，受到的接触伤害减少20%\n近战弹幕有25%的几率晕眩敌人小段时间";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "+5 max minions")
						{
							tooltipLine.text = "+5召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "75% increased minion damage\nYou are immune to almost all debuffs\nAll projectiles spawn healing leaf orbs on enemy hits\nMax run speed and acceleration boosted by 5%\nIf you are reduced to 1 HP you will not die from any further damage for 10 seconds\nIf you get reduced to 1 HP again while this effect is active you will lose 100 max life\nThis effect only triggers once per life and if you are reduced to 400 max life the invincibility effect will stop\nYour max life will return to normal if you die\nSummons an ancient leaf prism to blast your enemies with life energy\nAfter the silva invulnerability time your minions will deal 10% more damage and you will gain +2 max minions";
							string tooltipLinech = "增加75%召唤伤害\n免疫几乎所有debuff\n所有弹幕击中敌人后会释放治愈叶珠\n最大移速和加速度增加5%\n如果你生命值降到1，你10秒钟内受到伤害不会立即死亡\n这期间如果你这时生命值又被打到1，你的血量上限会减少100\n这个效果每条命触发一次，在这期间，血量上限被削减到400时，无敌效果会直接消失\n你的血量上限会在死后恢复为原来水准\n召唤用生机之力炸伤敌人的古叶灵晶\n始源林海的无敌状态结束后，召唤物造成额外10%伤害并+2召唤栏";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "13% increased ranged damage and critical strike chance")
						{
							tooltipLine.text = "增加13%远程伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You are immune to almost all debuffs\nAll projectiles spawn healing leaf orbs on enemy hits\nMax run speed and acceleration boosted by 5%\nIf you are reduced to 1 HP you will not die from any further damage for 10 seconds\nIf you get reduced to 1 HP again while this effect is active you will lose 100 max life\nThis effect only triggers once per life and if you are reduced to 400 max life the invincibility effect will stop\nYour max life will return to normal if you die\nIncreases your rate of fire with all ranged weapons\nDuring the silva invulnerability time your ranged weapons will do 40% more damage";
							string tooltipLinech = "免疫几乎所有debuff\n所有弹幕击中敌人后会释放治愈叶珠\n最大移速和加速度增加5%\n如果你生命值降到1，你10秒钟内受到伤害不会立即死亡\n这期间如果你这时生命值又被打到1，你的血量上限会减少100\n这个效果每条命触发一次，在这期间，血量上限被削减到400时，无敌效果会直接消失\n你的血量上限会在死后恢复为原来水准\n增加你远程武器的射击频率\n始源林海的无敌时间内，远程伤害增加40%";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "45% increased movement speed")
						{
							tooltipLine.text = "增加45%移动速度";
						}
						if (tooltipLine.text == "12% increased damage and 7% increased critical strike chance")
						{
							tooltipLine.text = "增加12%伤害和7%暴击率";
						}
						if (tooltipLine.text == "13% increased rogue damage and critical strike chance, 20% increased movement speed")
						{
							tooltipLine.text = "增加13%盗贼伤害和暴击率，增加20%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You are immune to almost all debuffs\nAll projectiles spawn healing leaf orbs on enemy hits\nMax run speed and acceleration boosted by 5%\nIf you are reduced to 1 HP you will not die from any further damage for 10 seconds\nIf you get reduced to 1 HP again while this effect is active you will lose 100 max life\nThis effect only triggers once per life and if you are reduced to 400 max life the invincibility effect will stop\nYour max life will return to normal if you die\nRogue weapons have a faster throwing rate while you are above 50% life\nAfter the silva invulnerability time your rogue weapons will do 10% more damage\nRogue stealth builds while not attacking and not moving, up to a max of 150\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "免疫几乎所有debuff\n所有弹幕击中敌人后会释放治愈叶珠\n最大移速和加速度增加5%\n如果你生命值降到1，你10秒钟内受到伤害不会立即死亡\n这期间如果你这时生命值又被打到1，你的血量上限会减少100\n这个效果每条命触发一次，在这期间，血量上限被削减到400时，无敌效果会直接消失\n你的血量上限会在死后恢复为原来水准\n高于50%生命时，投掷频率加快\n始源林海的无敌状态结束后，盗贼伤害造成伤害增加10%\n不攻击且站立不动时增加潜行层数，至多150层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "13% increased magic damage and critical strike chance")
						{
							tooltipLine.text = "增加13%的魔法伤害和暴击率";
						}
						if (tooltipLine.text == "+100 max mana and 19% reduced mana usage")
						{
							tooltipLine.text = "+100魔力上限，减少19%魔力消耗";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "You are immune to almost all debuffs\nAll projectiles spawn healing leaf orbs on enemy hits\nMax run speed and acceleration boosted by 5%\nIf you are reduced to 1 HP you will not die from any further damage for 10 seconds\nIf you get reduced to 1 HP again while this effect is active you will lose 100 max life\nThis effect only triggers once per life and if you are reduced to 400 max life the invincibility effect will stop\nYour max life will return to normal if you die\nMagic projectiles have a 10% chance to cause a massive explosion on enemy hits\nAfter the silva invulnerability time your magic weapons will do 10% more damage";
							string tooltipLinech = "免疫几乎所有debuff\n所有弹幕击中敌人后会释放治愈叶珠\n最大移速和加速度增加5%\n如果你生命值降到1，你10秒钟内受到伤害不会立即死亡\n这期间如果你这时生命值又被打到1，你的血量上限会减少100\n这个效果每条命触发一次，在这期间，血量上限被削减到400时，无敌效果会直接消失\n你的血量上限会在死后恢复为原来水准\n魔法弹幕有10%几率在击中敌人时引发爆炸\n始源林海的无敌状态结束后，增加10%魔法伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensHeart") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensHeartAlt"))
					{
						if (tooltipLine.text == "Transforms the holder into a siren")
						{
							tooltipLine.text = "将装备者变成塞壬";
						}
						if (tooltipLine.text == "Siren scales give increased defense (gives more defense in hardmode and post-ML)")
						{
							tooltipLine.text = "塞壬的鳞片给予防御值提升（困难模式下和月球领主后提升更多）";
						}
						if (tooltipLine.text == "Siren sight reveals enemy locations (blue-only)")
						{
							tooltipLine.text = "塞壬能感知到敌人位置（仅限蓝）";
						}
						if (tooltipLine.text == "Siren sight reveals danger locations (green-only)")
						{
							tooltipLine.text = "塞壬能感知到危险位置（仅限绿）";
						}
						if (tooltipLine.text == "Increases life regen (gives more life regen in hardmode and post-ML)")
						{
							tooltipLine.text = "增加生命再生（困难模式下和月球领主后增加更多）";
						}
						if (tooltipLine.text == "Going underwater gives you a buff")
						{
							tooltipLine.text = "潜水后获得一个buff";
						}
						if (tooltipLine.text == "Greatly reduces breath loss in the abyss")
						{
							tooltipLine.text = "大幅减少深渊里呼吸槽的流失速度";
						}
						if (tooltipLine.text == "Enemies become frozen when they touch you")
						{
							tooltipLine.text = "敌人触碰你时会被冰冻";
						}
						if (tooltipLine.text == "You have a layer of ice around you that absorbs 15% damage but breaks after one hit")
						{
							tooltipLine.text = "身周有寒冰护体，吸收15%的伤害，但是受击破碎";
						}
						if (tooltipLine.text == "After 30 seconds the ice shield will regenerate")
						{
							tooltipLine.text = "30秒后寒冰护盾会恢复";
						}
						if (tooltipLine.text == "Your alluring figure allows you to buy items at a reduced price from town npcs (only works in hardmode)")
						{
							tooltipLine.text = "受你那凹凸有致的完美弧线影响，npc们无论男女老少都痴迷于你的美丽。你购买时会为你提供优惠（仅限困难模式下）";
						}
						if (tooltipLine.text == "Wow, you can swim now!")
						{
							tooltipLine.text = "哇，你可以畅游了！";
						}
						if (tooltipLine.text == "Most of these effects are only active after Skeletron has been defeated")
						{
							tooltipLine.text = "大多数效果只有在击败骷髅王后才会激活";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelArmor")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelCap")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelGreaves")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelHeadgear")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelHood")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("StatigelMask"))
					{
						if (tooltipLine.text == "5% increased critical strike chance")
						{
							tooltipLine.text = "增加5%暴击率";
						}
						if (tooltipLine.text == "10% increased magic damage and 10% decreased mana cost")
						{
							tooltipLine.text = "增加10%魔法伤害减少10%魔力消耗";
						}
						if (tooltipLine.text == "7% increased magic critical strike chance and +30 max mana")
						{
							tooltipLine.text = "增加7%魔法暴击率\n+30魔法上限";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "When you take over 100 damage in one hit you become immune to damage for an extended period of time\nGrants an extra jump and increased jump height";
							string tooltipLinech = "受到超过100的伤害时你的无敌时间会延长一小会\n增加额外跳跃段并增加跳跃高度";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased damage and movement speed")
						{
							tooltipLine.text = "增加5%伤害和移动速度";
						}
						if (tooltipLine.text == "10% increased ranged damage")
						{
							tooltipLine.text = "增加10%远程伤害";
						}
						if (tooltipLine.text == "7% increased ranged critical strike chance")
						{
							tooltipLine.text = "增加7%远程暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "When you take over 100 damage in one hit you become immune to damage for an extended period of time\nGrants an extra jump and increased jump height";
							string tooltipLinech = "受到超过100的伤害时你的无敌时间会延长一小会\n增加额外跳跃段并增加跳跃高度";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "10% increased melee damage and melee speed")
						{
							tooltipLine.text = "增加10%近战伤害和近战速度";
						}
						if (tooltipLine.text == "7% increased melee critical strike chance")
						{
							tooltipLine.text = "增加7%近战暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "When you take over 100 damage in one hit you become immune to damage for an extended period of time\nGrants an extra jump and increased jump height";
							string tooltipLinech = "受到超过100的伤害时你的无敌时间会延长一小会\n增加额外跳跃段并增加跳跃高度";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "Increased minion knockback and +1 max minion")
						{
							tooltipLine.text = "增加10%召唤伤害并+1召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "18% increased minion damage\nSummons a mini slime god to fight for you, the type depends on what world evil you have\nWhen you take over 100 damage in one hit you become immune to damage for an extended period of time\nGrants an extra jump and increased jump height";
							string tooltipLinech = "增加18%召唤伤害\n召唤一个小史莱姆之神为你而战，其颜色取决于你地图中的邪恶之地种类\n受到超过100的伤害时你的无敌时间会延长一小会\n增加额外跳跃段并增加跳跃高度";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "10% increased rogue damage and 33% chance to not consume rogue items")
						{
							tooltipLine.text = "增加10%的盗贼伤害，33%的几率不消耗盗贼投掷物";
						}
						if (tooltipLine.text == "7% increased rogue critical strike chance and 12% increased movement speed")
						{
							tooltipLine.text = "增加7%盗贼暴击率，增加12%移动速度";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "When you take over 100 damage in one hit you become immune to damage for an extended period of time\nGrants an extra jump and increased jump height\nRogue stealth builds while not attacking and not moving, up to a max of 105\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "受到超过100点的伤害后你会无敌一段时间\n增加一段跳跃并增加跳跃高度\n不攻击且站立不动时增加潜行层数，至多105层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonBreastplate")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonHornedHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonLeggings")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonMask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonVisage"))
					{
						if (tooltipLine.text == "10% increased damage and 5% increased critical strike chance")
						{
							tooltipLine.text = "增加10%伤害和5%暴击率";
						}
						if (tooltipLine.text == "+2 life regen and +40 max life")
						{
							tooltipLine.text = "增加2生命再生，+40生命上限";
						}
						if (tooltipLine.text == "Breastplate of the exiler")
						{
							tooltipLine.text = "被放逐者的胸甲";
						}
						if (tooltipLine.text == "Temporary immunity to lava and immunity to cursed inferno, fire, cursed, and chilled debuffs")
						{
							tooltipLine.text = "暂时免疫岩浆伤害，免疫咒炎，着火，诅咒和冰冻debuff";
						}
						if (tooltipLine.text == "Can move freely through liquids")
						{
							tooltipLine.text = "液体中行走无阻力";
						}
						if (tooltipLine.text == "5% increased damage reduction")
						{
							tooltipLine.text = "增加5%伤害减免";
						}
						if (tooltipLine.text == "Helm of the disciple of ancients")
						{
							tooltipLine.text = "远古信徒的头盔";
						}
						if (tooltipLine.text == "10% increased melee damage and critical strike chance")
						{
							tooltipLine.text = "增加10%近战伤害和暴击";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Increased heart pickup range\nEnemies have a chance to drop extra hearts on death\nYou have a 25% chance to gain a life regen buff when you take damage\nPress Y to cloak yourself in life energy that heavily reduces enemy contact damage for 10 seconds\nThis has a 30 second cooldown";
							string tooltipLinech = "增加红心捡取范围\n敌人死后有几率掉落额外红心\n受到攻击时你有25%几率加快生恢复速度\n按Y以召唤生命能量覆盖周身，能在10秒内大幅降低敌人的接触伤害\n30秒cd";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "Can move freely through liquids and 12% increased movement speed")
						{
							tooltipLine.text = "可在液体中自由移动\n移动速度提高12%";
						}
						if (tooltipLine.text == "10% increased rogue damage and critical strike chance")
						{
							tooltipLine.text = "增加10%的盗贼伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Reduces enemy spawn rates\nIncreased heart pickup range\nEnemies have a chance to drop extra hearts on death\nAfter every 25 rogue critical hits you will gain 5 seconds of damage immunity\nThis effect can only occur once every 30 seconds\nWhile under the effects of a debuff you gain 10% increased rogue damage\nRogue stealth builds while not attacking and not moving, up to a max of 130\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "降低怪物生成率\n增加红心捡取范围\n敌人死后有几率掉落额外红心\n每暴击25次后，会获得5秒的伤害免疫\n这效果有30秒cd\n如果你身上有debuff，增加10%盗贼伤害\n不攻击且站立不动时增加潜行层数，至多130层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased damage reduction and +3 max minions")
						{
							tooltipLine.text = "增加5%伤害减免并+3召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "50% increased minion damage\nReduces enemy spawn rates\nIncreased heart pickup range\nEnemies have a chance to drop extra hearts on death\nAt full health you gain +2 max minions and 10% increased minion damage\nSummons a life aura around you that damages nearby enemies";
							string tooltipLinech = "增加50%召唤伤害\n降低怪物生成率\n增加红心捡取范围\n敌人死后有几率掉落额外红心\n满血时+2召唤栏和增加10%召唤伤害\n召唤生命光环对周围的敌人造成伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "20% increased movement speed; 35% increase when below half health")
						{
							tooltipLine.text = "增加20%移动速度，生命低于一半时增加35%";
						}
						if (tooltipLine.text == "6% increased damage and critical strike chance")
						{
							tooltipLine.text = "增加6%伤害和暴击率";
						}
						if (tooltipLine.text == "Leggings of a fabled explorer")
						{
							tooltipLine.text = "传说探险家的护胫";
						}
						if (tooltipLine.text == "10% increased magic damage and critical strike chance")
						{
							tooltipLine.text = "增加10%的魔法伤害和暴击率";
						}
						if (tooltipLine.text == "5% increased damage reduction, +100 max mana, and 15% reduced mana usage")
						{
							tooltipLine.text = "增加5%的伤害减免，+100魔力上限，减少15%魔力消耗";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Reduces enemy spawn rates\nIncreased heart pickup range\nEnemies have a chance to drop extra hearts on death\nOn every 5th critical strike you will fire a leaf storm\nMagic projectiles have a 50% chance to heal you on enemy hits\nAmount healed is based on projectile damage";
							string tooltipLinech = "降低怪物生成率\n增加红心捡取范围\n敌人死后有几率掉落额外红心\n每5次魔法暴击会释放一次叶刃风暴\n魔法弹幕攻击有50%几率治疗你\n治疗量基于弹幕伤害";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "10% increased ranged damage and critical strike chance")
						{
							tooltipLine.text = "增加10%远程伤害和暴击率";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Reduces enemy spawn rates\nIncreased heart pickup range\nEnemies have a chance to drop extra hearts on death\nRanged critical strikes will cause an explosion of leaves\nRanged projectiles have a chance to split into life energy on death";
							string tooltipLinech = "降低怪物生成率\n增加红心捡取范围\n敌人死后有几率掉落额外红心\n远程暴击会引发叶片爆炸\n远程弹幕在击杀敌人后有几率分裂出生命光束伤害其他敌人";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideBreastplate")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideHeadgear")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideLeggings")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideMask")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("VictideVisage"))
					{
						if (tooltipLine.text == "5% increased damage reduction and critical strike chance")
						{
							tooltipLine.text = "增加5%伤害减免和暴击率";
						}
						if (tooltipLine.text == "Defense increased while submerged in liquid")
						{
							tooltipLine.text = "在液体中时防御增加";
						}
						if (tooltipLine.text == "Movement speed increased by 8%")
						{
							tooltipLine.text = "增加8%移动速度";
						}
						if (tooltipLine.text == "Speed greatly increased while submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时大幅增加移速";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Increased life regen and rogue damage while submerged in liquid\nWhen using any weapon you have a 10% chance to throw a returning seashell projectile\nThis seashell does true damage and does not benefit from any damage class\nSlightly reduces breath loss in the abyss\nRogue stealth builds while not attacking and not moving, up to a max of 100\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "在水中增加盗贼伤害和生命再生\n使用武器时有10%几率抛出一个贝壳回旋镖\n贝壳回旋镖造成真实伤害并不接受任何增幅\n在深渊微幅减少呼吸槽消耗率\n不攻击且站立不动时增加潜行层数，至多100层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased melee damage")
						{
							tooltipLine.text = "增加5%近战伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Increased life regen and melee damage while submerged in liquid\nWhen using any weapon you have a 10% chance to throw a returning seashell projectile\nThis seashell does true damage and does not benefit from any damage class\nSlightly reduces breath loss in the abyss";
							string tooltipLinech = "在水中增加近战伤害和生命再生\n使用武器时有10%几率抛出一个贝壳回旋镖\n贝壳回旋镖造成真实伤害并不接受任何增幅\n在深渊微幅减少呼吸槽消耗率";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "9% increased minion damage")
						{
							tooltipLine.text = "增加9%召唤伤害";
						}
						if (tooltipLine.text == "+1 max minion")
						{
							tooltipLine.text = "+1召唤栏";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Increased life regen and minion damage while submerged in liquid\nSummons a sea urchin to protect you\nWhen using any weapon you have a 10% chance to throw a returning seashell projectile\nThis seashell does true damage and does not benefit from any damage class\nSlightly reduces breath loss in the abyss";
							string tooltipLinech = "在水中增加召唤伤害和生命再生\n召唤一个海胆保护你\n使用武器时有10%几率抛出一个贝壳回旋镖\n贝壳回旋镖造成真实伤害并不接受任何增幅\n在深渊微幅减少呼吸槽消耗率";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased magic damage")
						{
							tooltipLine.text = "增加5%魔法伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Increased life regen and magic damage while submerged in liquid\nWhen using any weapon you have a 10% chance to throw a returning seashell projectile\nThis seashell does true damage and does not benefit from any damage class\nSlightly reduces breath loss in the abyss";
							string tooltipLinech = "在水中增加魔法伤害和生命再生\n使用武器时有10%几率抛出一个贝壳回旋镖\n贝壳回旋镖造成真实伤害并不接受任何增幅\n在深渊微幅减少呼吸槽消耗率";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
						if (tooltipLine.text == "5% increased ranged damage")
						{
							tooltipLine.text = "增加5%远程伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "Increased life regen and ranged damage while submerged in liquid\nWhen using any weapon you have a 10% chance to throw a returning seashell projectile\nThis seashell does true damage and does not benefit from any damage class\nSlightly reduces breath loss in the abyss";
							string tooltipLinech = "在水中增加远程伤害和生命恢复速度\n用武器时有10%几率抛出一个贝壳回旋镖\n贝壳回旋镖造成真实伤害并不接受任何增幅\n在深渊微幅减少呼吸槽消耗率";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumArmor")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHeadgear")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHelm")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHelmet")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumHood")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumLeggings")
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("WulfrumMask"))
					{
						if (tooltipLine.text == "3% increased critical strike chance")
						{
							tooltipLine.text = "增加3%暴击率";
						}
						if (tooltipLine.text == "3% increased ranged damage")
						{
							tooltipLine.text = "增加3%远程伤害";
						}
						if (tooltipLine.text == "3% increased melee damage")
						{
							tooltipLine.text = "增加3%近战伤害";
						}
						if (tooltipLine.text == "6% increased minion damage")
						{
							tooltipLine.text = "增加6%召唤伤害";
						}
						if (tooltipLine.text == "+1 max minion")
						{
							tooltipLine.text = "+1召唤栏";
						}
						if (tooltipLine.text == "3% increased magic damage")
						{
							tooltipLine.text = "增加3%魔法伤害";
						}
						if (tooltipLine.text == "Movement speed increased by 5%")
						{
							tooltipLine.text = "增加5%移动速度";
						}
						if (tooltipLine.text == "3% increased rogue damage")
						{
							tooltipLine.text = "增加3%盗贼伤害";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "+3 defense\n+5 defense when below 50% life";
							string tooltipLinech = "+3防御\n低于50%生命值时加5防御";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocPlateMail") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocCuisses") 
					|| item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocMask"))
					{
						if (tooltipLine.text == "+20 max life")
						{
							tooltipLine.text = "+20生命上限";
						}
						if (tooltipLine.text == "6% increased movement speed")
						{
							tooltipLine.text = "增加6%移动速度";
						}
						if (tooltipLine.text == "7% increased rogue damage and critical strike chance")
						{
							tooltipLine.text = "增加7%盗贼伤害和暴击率";
						}
						if (tooltipLine.text == "Armor of the cosmos")
						{
							tooltipLine.text = "天宙之盔甲";
						}
						if (tooltipLine.text == "5% increased rogue damage and critical strike chance")
						{
							tooltipLine.text = "增加5%盗贼伤害和暴击率";
						}
						if (tooltipLine.text == "20% increased movement speed")
						{
							tooltipLine.text = "增加20%移动速度";
						}
						if (tooltipLine.text == "Speed of the cosmos")
						{
							tooltipLine.text = "寰宇之极速";
						}
						if (tooltipLine.text == "11% increased rogue damage and critical strike chance, 22% increased movement speed")
						{
							tooltipLine.text = "增加11%盗贼伤害和暴击率，增加22%移动速度";
						}
						if (tooltipLine.text == "Temporary immunity to lava and immunity to cursed, fire, cursed inferno, and chilled")
						{
							tooltipLine.text = "暂时免疫岩浆伤害，免疫岩浆，咒炎，着火，诅咒和冷冻debuff";
						}
						if (tooltipLine.text == "Wrath of the cosmos")
						{
							tooltipLine.text = "深空之惧怒";
						}
						if (tooltipLine.Name == "SetBonus")
						{
							string SetBonus = "9% increased rogue damage and velocity\nAll projectile types have special effects on enemy hits\nImbued with cosmic wrath and rage when you are damaged\nRogue stealth builds while not attacking and not moving, up to a max of 125\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed";
							string tooltipLinech = "增加9%盗贼伤害和投掷速度\n所有弹幕打击敌人时有特殊效果\n受伤时会被宇宙诸天之怒火所充斥\n不攻击且站立不动时增加潜行层数，至多125层\n攻击时降低层数，移动时不会降低也不会上涨\n潜行程度越深，伤害，暴击率和移速越高";
							string tooltipLineresult = tooltipLine.text.Replace(SetBonus, tooltipLinech);
							tooltipLine.text = tooltipLineresult;
						}
					}
				}
			}
		}
	}
}
