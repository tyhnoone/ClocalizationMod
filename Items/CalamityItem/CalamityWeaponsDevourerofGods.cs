using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsDevourerofGods : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeathhailStaff"))
				{
					item.SetNameOverride("死亡冰雹");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Deathwind"))
				{
					item.SetNameOverride("死亡之风");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EradicatorMelee"))
				{
					item.SetNameOverride("歼灭者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Excelsus"))
				{
					item.SetNameOverride("埃克塞萨斯");
				}
                if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StaffoftheMechworm"))
				{
					item.SetNameOverride("神明吞噬者召唤杖");
				}
                if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheObliterator"))
				{
					item.SetNameOverride("湮灭者");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeathhailStaff"))
					{
						if (tooltipLine.text == "Rain death upon your foes!")
						{
							tooltipLine.text = "把死亡降在你的敌人身上！";
						}
                        if (tooltipLine.text == "Casts a storm of nebula shots from the sky")
						{
							tooltipLine.text = "从天空投射出一阵星云照射";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Deathwind"))
					{
						if (tooltipLine.text == "Fires a spread of arrows")
						{
							tooltipLine.text = "射出一团箭";
						}
                        if (tooltipLine.text == "Wooden arrows are converted to nebula shots")
						{
							tooltipLine.text = "木箭被转换为星云射击";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EradicatorMelee"))
					{
						if (tooltipLine.text == "Throws a disk that fires lasers at nearby enemies")
						{
							tooltipLine.text = "投掷一个飞盘，向附近的敌人发射激光";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Excelsus"))
					{
						if (tooltipLine.text == "Fires a spread of spinning blades")
						{
							tooltipLine.text = "发出旋转的刀片";
						}
                        if (tooltipLine.text == "Summons laser fountains on enemy hits")
						{
							tooltipLine.text = "召唤激光喷泉攻击敌人";
						}
					}
                    if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StaffoftheMechworm"))
					{
						if (tooltipLine.text == "Summons an aerial mechworm to fight for you")
						{
							tooltipLine.text = "召唤虚空之吞噬者为你而战";
						}
                        if (tooltipLine.text == "Damage scales with the amount of minion slots you have")
						{
							tooltipLine.text = "召唤次数越多，伤害越高";
						}
                        if (tooltipLine.text == "The damage scaling stops growing after 10 minion slots")
						{
							tooltipLine.text = "超过10次时，伤害不在随之增加";
						}
					}
                    if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheObliterator"))
					{
						if (tooltipLine.text == "Fires death lasers when enemies are near")
						{
							tooltipLine.text = "敌人接近时发射死亡射线！";
						}
					}
				}
			}
		}
	}
}
