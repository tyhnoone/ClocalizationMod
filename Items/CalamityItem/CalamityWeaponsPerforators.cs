using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsPerforators : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Aorta"))
				{
					item.SetNameOverride("主动脉");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodBath"))
				{
					item.SetNameOverride("血浴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodClotStaff"))
				{
					item.SetNameOverride("血块召唤杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyRupture"))
				{
					item.SetNameOverride("血腥短剑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Eviscerator"))
				{
					item.SetNameOverride("肢体切离者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SausageMaker"))
				{
					item.SetNameOverride("香肠轧制机");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VeinBurster"))
				{
					item.SetNameOverride("血肉之雷");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodBath"))
					{
						if (tooltipLine.text == "Drenches your foes in blood")
						{
							tooltipLine.text = "让你的敌人鲜血淋漓";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodClotStaff"))
					{
						if (tooltipLine.text == "Summons a blood clot to fight for you")
						{
							tooltipLine.text = "召唤一个血块为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyRupture"))
					{
						if (tooltipLine.text == "Enemies release homing blood orbs on death")
						{
							tooltipLine.text = "敌人死后释放吸血球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Eviscerator"))
					{
						if (tooltipLine.text == "Fires a slow-moving blood clot")
						{
							tooltipLine.text = "发射缓慢移动的血块";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SausageMaker"))
					{
						if (tooltipLine.text == "Sprays homing blood on enemy hits")
						{
							tooltipLine.text = "击中敌人时喷射追踪血液";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VeinBurster"))
					{
						if (tooltipLine.text == "Fires a blood ball that sticks to tiles and explodes")
						{
							tooltipLine.text = "发射一个粘在物块上爆炸的血球";
						}
					}
				}
			}
		}
	}
}
