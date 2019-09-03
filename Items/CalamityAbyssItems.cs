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
