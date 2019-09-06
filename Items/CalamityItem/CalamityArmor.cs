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
				}
			}
		}
	}
}
