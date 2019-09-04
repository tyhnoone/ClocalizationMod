using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityCryogen : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryoBar"))
				{
					item.SetNameOverride("极寒锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryogenBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryoKey"))
				{
					item.SetNameOverride("极寒之钥");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryoStone"))
				{
					item.SetNameOverride("冰川石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SoulofCryogen"))
				{
					item.SetNameOverride("极寒之魂");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryoBar"))
					{
						if (tooltipLine.text == "Cold to the touch")
						{
							tooltipLine.text = "寒冷到无法触碰";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryoKey"))
					{
						if (tooltipLine.text == "Summons Cryogen")
						{
							tooltipLine.text = "召唤极地之灵";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryoStone"))
					{
						if (tooltipLine.text == "One of the ancient relics")
						{
							tooltipLine.text = "远古遗物之一";
						}
						if (tooltipLine.text == "Increases damage reduction by 5% and all damage by 3%")
						{
							tooltipLine.text = "增加5%伤害减免以及3%所有伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SoulofCryogen"))
					{
						if (tooltipLine.text == "The magic of the ancient ice castle is yours")
						{
							tooltipLine.text = "古代寒冰堡垒的魔力归属于你";
						}
						if (tooltipLine.text == "Counts as wings")
						{
							tooltipLine.text = "当作翅膀";
						}
						if (tooltipLine.text == "Horizontal speed: 6.25")
						{
							tooltipLine.text = "水平飞行速度: 6.25";
						}
						if (tooltipLine.text == "Acceleration multiplier: 1")
						{
							tooltipLine.text = "加速倍率: 1";
						}
						if (tooltipLine.text == "Average vertical speed")
						{
							tooltipLine.text = "普通的垂直飞行速度";
						}
						if (tooltipLine.text == "Flight time: 100")
						{
							tooltipLine.text = "飞行时间: 100";
						}
						if (tooltipLine.text == "5% increase to all damage and pick speed")
						{
							tooltipLine.text = "增加5%所有伤害和挖掘速度";
						}
						if (tooltipLine.text == "All melee attacks and projectiles inflict frostburn")
						{
							tooltipLine.text = "所有近战武器和其弹幕附着霜火效果";
						}
					}
				}
			}
		}
	}
}
