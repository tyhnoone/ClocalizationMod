using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsYharon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AngryChickenStaff"))
				{
					item.SetNameOverride("犽戎之火法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChickenCannon"))
				{
					item.SetNameOverride("鸡农炮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DragonRage"))
				{
					item.SetNameOverride("巨龙之怒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DragonsBreath"))
				{
					item.SetNameOverride("巨龙之息");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PhoenixFlameBarrage"))
				{
					item.SetNameOverride("星火凤凰雨");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheBurningSky"))
				{
					item.SetNameOverride("焚天");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AngryChickenStaff"))
					{
						if (tooltipLine.text == "Summons the Son of Yharon to fight for you")
						{
							tooltipLine.text = "召唤犽戎之子为你而战";
						}
						if (tooltipLine.text == "The dragon increases your life regen, defense, and movement speed while summoned")
						{
							tooltipLine.text = "这条子龙会增加你的生命恢复速度，防御和移速";
						}
						if (tooltipLine.text == "Requires 4 minion slots to use")
						{
							tooltipLine.text = "需要4个召唤栏";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChickenCannon"))
					{
						if (tooltipLine.text == "Fires chicken rockets")
						{
							tooltipLine.text = "发射小鸡火箭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DragonRage"))
					{
						if (tooltipLine.text == "Fires a spread of five fire waves")
						{
							tooltipLine.text = "发射五道火浪";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DragonsBreath"))
					{
						if (tooltipLine.text == "80% chance to not consume ammo")
						{
							tooltipLine.text = "80%不消耗弹药";
						}
						if (tooltipLine.text == "Shoots a spread of exploding fire bullets")
						{
							tooltipLine.text = "散射爆炸火焰弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheBurningSky"))
					{
						if (tooltipLine.text == "Summons a massive barrage of burning meteors from the sky")
						{
							tooltipLine.text = "从天空中召唤出大量燃烧的流星";
						}
					}
				}
			}
		}
	}
}
