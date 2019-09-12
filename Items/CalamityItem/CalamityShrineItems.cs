using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityShrineItems : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorruptionEffigy"))
				{
					item.SetNameOverride("腐化塑像");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrimsonEffigy"))
				{
					item.SetNameOverride("血腥塑像");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FungalSymbiote"))
				{
					item.SetNameOverride("真菌共生体");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GladiatorsLocket"))
				{
					item.SetNameOverride("角斗士链坠");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LuxorsGift"))
				{
					item.SetNameOverride("卢克索的礼物");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OnyxExcavatorKey"))
				{
					item.SetNameOverride("玛瑙挖掘机钥匙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrinketofChi"))
				{
					item.SetNameOverride("气之挂饰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TundraLeash"))
				{
					item.SetNameOverride("冻土套圈");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UnstablePrism"))
				{
					item.SetNameOverride("不稳定棱镜");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorruptionEffigy"))
					{
						if (tooltipLine.text == "When placed down nearby players have their movement speed increased by 15% and crit chance by 10%")
						{
							tooltipLine.text = "放置后，增加附近玩家15%移动速度和10%暴击率";
						}
						if (tooltipLine.text == "Nearby players also suffer a 20% decrease to their damage reduction")
						{
							tooltipLine.text = "然而附近的玩家也会减少20%伤害减免";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorruptionEffigy"))
					{
						if (tooltipLine.text == "When placed down nearby players have their movement speed increased by 15% and crit chance by 10%")
						{
							tooltipLine.text = "放置后，增加附近玩家15%移动速度和10%暴击率";
						}
						if (tooltipLine.text == "Nearby players also suffer a 20% decrease to their damage reduction")
						{
							tooltipLine.text = "然而附近的玩家也会减少20%伤害减免";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FungalSymbiote"))
					{
						if (tooltipLine.text == "True melee weapons emit mushrooms when swung")
						{
							tooltipLine.text = "真实近战伤害（武器本体伤害）挥舞时释放蘑菇孢子";
						}
						if (tooltipLine.text == "Boosts true melee damage by 25%")
						{
							tooltipLine.text = "增加25%真实近战伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FungalSymbiote"))
					{
						if (tooltipLine.text == "Summons two spirit swords to protect you")
						{
							tooltipLine.text = "召唤两个灵魂之剑保护你";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LuxorsGift"))
					{
						if (tooltipLine.text == "Weapons fire unique projectiles based on the damage type they have")
						{
							tooltipLine.text = "根据武器伤害类型发射特殊弹幕";
						}
						if (tooltipLine.text == "Some weapons are unable to receive this bonus")
						{
							tooltipLine.text = "某些武器无法获得此物品的增幅";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OnyxExcavatorKey"))
					{
						if (tooltipLine.text == "Summons a drill to drill through the world so you can destroy all the neat world generation")
						{
							tooltipLine.text = "召唤钻洞车钻穿整个世界";
						}
						if (tooltipLine.text == "with complete disregard for all the creatures that inhabit these lands. I am sure the EPA and PETA would like")
						{
							tooltipLine.text = "看来你完全无视了在这片土地上栖息的生物";
						}
						if (tooltipLine.text == "to have a word with you afterwards.")
						{
							tooltipLine.text = "我相信环保局和动物保护组织在之后会和你谈谈的";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrinketofChi"))
					{
						if (tooltipLine.text == "After 2 seconds of standing still and not attacking you gain a buff")
						{
							tooltipLine.text = "站立不动不攻击2秒后获得一个增益buff";
						}
						if (tooltipLine.text == "This buff boosts your damage by 50% and decreases damage taken by 15%")
						{
							tooltipLine.text = "此buff增加你50%伤害和15%伤害减免";
						}
						if (tooltipLine.text == "The buff deactivates after you move or attack once")
						{
							tooltipLine.text = "移动或攻击，效果消失";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TundraLeash"))
					{
						if (tooltipLine.text == "Summons an angry dog mount")
						{
							tooltipLine.text = "召唤愤怒的雪狗坐骑";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UnstablePrism"))
					{
						if (tooltipLine.text == "Three sparks are released on critical hits")
						{
							tooltipLine.text = "暴击时释放三道火花";
						}
					}
				}
			}
		}
	}
}
