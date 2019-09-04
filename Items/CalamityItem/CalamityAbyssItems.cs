using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityAbyssItems : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalAmulet"))
				{
					item.SetNameOverride("深渊护身符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalDivingGear"))
				{
					item.SetNameOverride("幽影潜渊装");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AlluringBait"))
				{
					item.SetNameOverride("诱惑鱼饵");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicPlating"))
				{
					item.SetNameOverride("吸音镀层");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CloakingGland"))
				{
					item.SetNameOverride("渐隐鳞");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DepthCells"))
				{
					item.SetNameOverride("深渊细胞");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DepthCharm"))
				{
					item.SetNameOverride("深渊咒符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IronBoots"))
				{
					item.SetNameOverride("铁靴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Lumenite"))
				{
					item.SetNameOverride("流明晶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LumenousAmulet"))
				{
					item.SetNameOverride("流明护身符");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaperTooth"))
				{
					item.SetNameOverride("猎魂鲨牙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaperToothNecklace"))
				{
					item.SetNameOverride("猎魂鲨牙项链");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StrangeOrb"))
				{
					item.SetNameOverride("奇光球");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SunkenStew"))
				{
					item.SetNameOverride("乱渊炖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TorrentialTear"))
				{
					item.SetNameOverride("滂沱之泪");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalAmulet"))
					{
						if (tooltipLine.text == "Attacks inflict the Crush Depth debuff")
						{
							tooltipLine.text = "攻击附着深渊碾压debuff";
						}
						if (tooltipLine.text == "While in the abyss you gain 10% increased max life")
						{
							tooltipLine.text = "在深渊之中时，增加额外10%生命值";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalDivingGear"))
					{
						if (tooltipLine.text == "Reduces the damage caused by the pressure of the abyss while out of breath")
						{
							tooltipLine.text = "呼吸槽归零时，减少水压对你造成的伤害";
						}
						if (tooltipLine.text == "Removes the bleed effect caused by the abyss")
						{
							tooltipLine.text = "移除深渊对你造成的生命流失";
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
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AlluringBait"))
					{
						if (tooltipLine.text == "30% increased fishing power during the day")
						{
							tooltipLine.text = "白天增加30%钓力";
						}
						if (tooltipLine.text == "45% increased fishing power during the night")
						{
							tooltipLine.text = "夜晚增加45%钓力";
						}
						if (tooltipLine.text == "60% increased fishing power during a solar eclipse")
						{
							tooltipLine.text = "日食期间增加60%钓力";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicPlating"))
					{
						if (tooltipLine.text == "Reduces creature's ability to detect you in the abyss")
						{
							tooltipLine.text = "降低深渊生物发现你的可能性";
						}
						if (tooltipLine.text == "Reduces the defense reduction that the abyss causes")
						{
							tooltipLine.text = "降低深渊削减的防御值";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicPlating"))
					{
						if (tooltipLine.text == "The cells of abyssal creatures")
						{
							tooltipLine.text = "深渊生物的细胞";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DepthCharm"))
					{
						if (tooltipLine.text == "Reduces the damage caused by the pressure of the abyss while out of breath")
						{
							tooltipLine.text = "呼吸槽归零时，减少水压对你造成的伤害";
						}
						if (tooltipLine.text == "Removes the bleed effect caused by the upper layers of the abyss")
						{
							tooltipLine.text = "移除浅层深渊对你造成的生命流失伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IronBoots"))
					{
						if (tooltipLine.text == "Allows you to fall faster while in liquids")
						{
							tooltipLine.text = "让你在水中下潜更快";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Lumenite"))
					{
						if (tooltipLine.text == "A shard of lumenous energy")
						{
							tooltipLine.text = "蕴含着闪光能量的晶片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LumenousAmulet"))
					{
						if (tooltipLine.text == "Attacks inflict the Crush Depth debuff")
						{
							tooltipLine.text = "攻击附着深海水压debuff";
						}
						if (tooltipLine.text == "While in the abyss you gain 25% increased max life")
						{
							tooltipLine.text = "在深渊之中时，增加额外25%生命值";
						}
						if (tooltipLine.text == "Provides a moderate amount of light in the abyss")
						{
							tooltipLine.text = "在深渊里提供适量的光照";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaperTooth"))
					{
						if (tooltipLine.text == "Sharp enough to cut diamonds")
						{
							tooltipLine.text = "锋利无比, 可斩钻石";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ReaperToothNecklace"))
					{
						if (tooltipLine.text == "Increases armor penetration by 100")
						{
							tooltipLine.text = "增加100点护甲穿透";
						}
						if (tooltipLine.text == "Increases all damage by 25%")
						{
							tooltipLine.text = "增加25%所有伤害";
						}
						if (tooltipLine.text == "Cuts your defense and damage reduction in half")
						{
							tooltipLine.text = "将你的防御削减一半";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StrangeOrb"))
					{
						if (tooltipLine.text == "Summons a young Siren light pet")
						{
							tooltipLine.text = "召唤一个萝莉塞壬照亮四周";
						}
						if (tooltipLine.text == "Provides a large amount of light while underwater")
						{
							tooltipLine.text = "在深渊里提供大量光照";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SunkenStew"))
					{
						if (tooltipLine.text == "Restores 150 mana")
						{
							tooltipLine.text = "恢复150点魔力";
						}
						if (tooltipLine.text == "Only gives 50 (37 with Philosopher's Stone) seconds of Potion Sickness")
						{
							tooltipLine.text = "药水病将低至50秒(佩戴点金石后为37秒)";
						}
						if (tooltipLine.text == "Grants Well Fed")
						{
							tooltipLine.text = "获得饱食";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TorrentialTear"))
					{
						if (tooltipLine.text == "Summons the rain")
						{
							tooltipLine.text = "呼风唤雨";
						}
						if (tooltipLine.text == "Rain will start some time after this item is used")
						{
							tooltipLine.text = "使用后等待一段时间开始下雨";
						}
						if (tooltipLine.text == "If used when raining the rain will stop some time after this item is used")
						{
							tooltipLine.text = "如果在下雨时使用, 一段时间后雨将会停止";
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalAmulet"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 深渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Floodtide"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 深渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AlluringBait"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 深渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IronBoots"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 深渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DepthCharm"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 深渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AnechoicPlating"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 深渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StrangeOrb"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 深渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
			}
		}
	}
}
