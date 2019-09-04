using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityLeviathan : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EnchantedPearl"))
				{
					item.SetNameOverride("注魔珍珠");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IOU"))
				{
					item.SetNameOverride("利维坦武器支票");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeviathanAmbergris"))
				{
					item.SetNameOverride("利维坦龙涎香");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeviathanBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EnchantedPearl"))
					{
						if (tooltipLine.text == "Increases fishing skill")
						{
							tooltipLine.text = "增加钓鱼能力";
						}
						if (tooltipLine.text == "Crate potion effect, does not stack with crate potions")
						{
							tooltipLine.text = "具有板条箱药剂效果，不可与板条箱药剂叠加";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IOU"))
					{
						if (tooltipLine.text == "Use to craft any Leviathan weapon you want")
						{
							tooltipLine.text = "用于制作所有利维坦掉落的武器";
						}
						if (tooltipLine.text == "Combine with Living Shards from Plantera to get your item!")
						{
							tooltipLine.text = "结合世纪之花掉落的生命碎片使用\n(注：困难模式前击败利维坦掉落)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeviathanAmbergris"))
					{
						if (tooltipLine.text == "You leave behind poisonous seawater as you move")
						{
							tooltipLine.text = "在水中移动时身后留下剧毒海水";
						}
						if (tooltipLine.text == "75% increased movement speed, 10% increase to all damage, and plus 20 defense while submerged in liquid")
						{
							tooltipLine.text = "完全处于水中时增加75%速度，10%所有伤害和20防御";
						}
						if (tooltipLine.text == "If you are damaged while submerged in liquid you will gain a damaging aura for a short time")
						{
							tooltipLine.text = "如果你在水中受伤，那你会短时间内获得获得一个伤害光环";
						}
						if (tooltipLine.text == "Being outside of liquid increases all damage by 5% and increases damage reduction by 5%")
						{
							tooltipLine.text = "不在水中时会增加所有伤害5%并增加5%伤害减免";
						}
					}
				}
			}
		}
	}
}
