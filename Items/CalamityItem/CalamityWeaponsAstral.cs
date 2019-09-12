using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsAstral : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralachneaStaff"))
				{
					item.SetNameOverride("星幻蛛法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBlade"))
				{
					item.SetNameOverride("幻星刀");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBlaster"))
				{
					item.SetNameOverride("幻星冲击");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralPike"))
				{
					item.SetNameOverride("幻星矛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralRepeater"))
				{
					item.SetNameOverride("幻星弩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralScythe"))
				{
					item.SetNameOverride("星幻镰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralStaff"))
				{
					item.SetNameOverride("幻星法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HivePod"))
				{
					item.SetNameOverride("星幻巢");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StellarCannon"))
				{
					item.SetNameOverride("恒星加农");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TitanArm"))
				{
					item.SetNameOverride("泰坦臂");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralachneaStaff"))
					{
						if (tooltipLine.text == "Fires a spread of homing astral spider fangs")
						{
							tooltipLine.text = "施放追踪星幻蛛毒牙";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBlaster"))
					{
						if (tooltipLine.text == "Fires a homing astral round")
						{
							tooltipLine.text = "发射可追踪的星体子弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralPike"))
					{
						if (tooltipLine.text == "Summons astral star swarms on critical hits")
						{
							tooltipLine.text = "暴击时召唤星体群星";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralRepeater"))
					{
						if (tooltipLine.text == "Fires a burst of three arrows")
						{
							tooltipLine.text = "射出三支箭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralScythe"))
					{
						if (tooltipLine.text == "Shoots a scythe ring that accelerates over time")
						{
							tooltipLine.text = "发射会加速的镰刀环";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralStaff"))
					{
						if (tooltipLine.text == "Summons a large crystal from the sky that has a large area of effect on impact.")
						{
							tooltipLine.text = "自天外召唤水晶陨落造成大面积伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HivePod"))
					{
						if (tooltipLine.text == "Summons an astral hive to protect you")
						{
							tooltipLine.text = "召唤星幻巢保护你";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StellarCannon"))
					{
						if (tooltipLine.text == "Launches an explosive astral crystal")
						{
							tooltipLine.text = "发射会爆炸的星幻水晶";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TitanArm"))
					{
						if (tooltipLine.text == "Slap Hand but better")
						{
							tooltipLine.text = "拍拍手，但是更强";
						}
					}
				}
			}
		}
	}
}
