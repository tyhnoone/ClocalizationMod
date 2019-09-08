using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityProvidence : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DivineGeode"))
				{
					item.SetNameOverride("神圣晶石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElysianAegis"))
				{
					item.SetNameOverride("极乐之庇护");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElysianWings"))
				{
					item.SetNameOverride("极乐之翼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCore"))
				{
					item.SetNameOverride("亵渎晶核");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCoreUnlimited"))
				{
					item.SetNameOverride("亵渎晶核");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProvidenceBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UnholyEssence"))
				{
					item.SetNameOverride("亵渎生物的精华");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DivineGeode"))
					{
						if (tooltipLine.text == "A chunk of crystallized holy energy")
						{
							tooltipLine.text = "蕴藏着神圣能量的晶石";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UnholyEssence"))
					{
						if (tooltipLine.text == "The essence of profaned creatures")
						{
							tooltipLine.text = "亵渎生物的精华";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElysianAegis"))
					{
						if (tooltipLine.text == "Grants immunity to fire blocks and knockback")
						{
							tooltipLine.text = "免疫灼烧砖块和击退";
						}
						if (tooltipLine.text == "+40 max life and increased life regen")
						{
							tooltipLine.text = "+40生命上限并增加生命再生速度";
						}
						if (tooltipLine.text == "Grants a supreme holy flame dash")
						{
							tooltipLine.text = "获得究极圣火冲刺";
						}
						if (tooltipLine.text == "Can be used to ram enemies")
						{
							tooltipLine.text = "可以冲撞敌人";
						}
						if (tooltipLine.text == "Press N to activate buffs to all damage, crit chance, and defense")
						{
							tooltipLine.text = "按N以激活增加所有伤害，暴击率和防御的buff";
						}
						if (tooltipLine.text == "Activating this buff will reduce your movement speed and increase enemy aggro")
						{
							tooltipLine.text = "激活buff会让你移速下降并增加敌人的攻击性";
						}
						if (tooltipLine.text == "Toggle visibility of this accessory to enable/disable the dash")
						{
							tooltipLine.text = "开关饰品的可见性可开关冲刺功能";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCore"))
					{
						if (tooltipLine.text == "The core of the unholy flame")
						{
							tooltipLine.text = "不洁火焰的核心";
						}
						if (tooltipLine.text == "Summons Providence")
						{
							tooltipLine.text = "召唤亵渎天神";
						}
						if (tooltipLine.text == "Can only be used during daytime")
						{
							tooltipLine.text = "只能在白天使用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedCoreUnlimited"))
					{
						if (tooltipLine.text == "The core of the unholy flame")
						{
							tooltipLine.text = "不洁火焰的核心";
						}
						if (tooltipLine.text == "Summons Providence")
						{
							tooltipLine.text = "召唤亵渎天神";
						}
						if (tooltipLine.text == "Can only be used during daytime")
						{
							tooltipLine.text = "只能在白天使用";
						}
					}
				}
			}
		}
	}
}
