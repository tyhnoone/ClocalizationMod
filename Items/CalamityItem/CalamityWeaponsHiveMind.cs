using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsHiveMind : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DankStaff"))
				{
					item.SetNameOverride("沼泽之眼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeechingDagger"))
				{
					item.SetNameOverride("汲血飞刀");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerfectDark"))
				{
					item.SetNameOverride("完美黑暗");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShaderainStaff"))
				{
					item.SetNameOverride("腐蚀之雨法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Shadethrower"))
				{
					item.SetNameOverride("影暗掷火者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShadowdropStaff"))
				{
					item.SetNameOverride("暗影之雨");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DankStaff"))
					{
						if (tooltipLine.text == "Summons a dank creeper to fight for you")
						{
							tooltipLine.text = "召唤沼泽之眼为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeechingDagger"))
					{
						if (tooltipLine.text == "Enemies release homing leech orbs on death")
						{
							tooltipLine.text = "敌人死亡后释放吸血球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerfectDark"))
					{
						if (tooltipLine.text == "Fires a vile ball that sticks to tiles and explodes")
						{
							tooltipLine.text = "发出一个黏住并爆炸的邪恶球\n(译注：Perfect Dark，N64平台FPS名作《完美黑暗》)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShaderainStaff"))
					{
						if (tooltipLine.text == "Fires a shade storm cloud")
						{
							tooltipLine.text = "召唤出一个阴影云";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Shadethrower"))
					{
						if (tooltipLine.text == "Fires a shade storm cloud")
						{
							tooltipLine.text = "66%几率不消耗凝胶";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShadowdropStaff"))
					{
						if (tooltipLine.text == "Summons dark aura rain from the sky")
						{
							tooltipLine.text = "酸雨从天而降！";
						}
					}
				}
			}
		}
	}
}
