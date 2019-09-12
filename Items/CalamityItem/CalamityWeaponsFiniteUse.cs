using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsFiniteUse : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Bazooka"))
				{
					item.SetNameOverride("反坦克火箭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElephantKiller"))
				{
					item.SetNameOverride("弑象者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ExplosiveShells"))
				{
					item.SetNameOverride("爆破霰弹片");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrenadeRounds"))
				{
					item.SetNameOverride("榴弹片");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Hydra"))
				{
					item.SetNameOverride("九头蛇");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LightningHawk"))
				{
					item.SetNameOverride("闪电鹰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Magnum"))
				{
					item.SetNameOverride("马格南");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MagnumRounds"))
				{
					item.SetNameOverride("马格南弹");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Bazooka"))
					{
						if (tooltipLine.text == "Uses Grenade Shells")
						{
							tooltipLine.text = "以榴弹片为弹药";
						}
						if (tooltipLine.text == "Does more damage to inorganic enemies")
						{
							tooltipLine.text = "对无机生物（石头或金属）造成更多伤害";
						}
						if (tooltipLine.text == "Can be used twice per boss battle")
						{
							tooltipLine.text = "boss战限制只能发射两发弹药";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElephantKiller"))
					{
						if (tooltipLine.text == "Uses Magnum Rounds")
						{
							tooltipLine.text = "以马格姆弹为弹药";
						}
						if (tooltipLine.text == "Does more damage to organic enemies")
						{
							tooltipLine.text = "对有机生物造成更多伤害";
						}
						if (tooltipLine.text == "Can be used thrice per boss battle")
						{
							tooltipLine.text = "boss战限制只能发射三发弹药\n(译注：Elephant Killer，弑象者，生化危机6中的武器)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Hydra"))
					{
						if (tooltipLine.text == "Uses Explosive Shotgun Shells")
						{
							tooltipLine.text = "以爆破霰弹片为弹药";
						}
						if (tooltipLine.text == "Does more damage to everything")
						{
							tooltipLine.text = "对所有生物造成更多伤害";
						}
						if (tooltipLine.text == "Can be used once per boss battle")
						{
							tooltipLine.text = "boss战限制只能发射一发弹药";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LightningHawk"))
					{
						if (tooltipLine.text == "Uses Magnum Rounds")
						{
							tooltipLine.text = "以马格南弹为弹药";
						}
						if (tooltipLine.text == "Does more damage to organic enemies")
						{
							tooltipLine.text = "对有机生物造成更多伤害";
						}
						if (tooltipLine.text == "Can be used thrice per boss battle")
						{
							tooltipLine.text = "boss战限制只能发射三发弹药";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Magnum"))
					{
						if (tooltipLine.text == "Uses Magnum Rounds")
						{
							tooltipLine.text = "以马格南弹为弹药";
						}
						if (tooltipLine.text == "Does more damage to organic enemies")
						{
							tooltipLine.text = "对有机生物造成更多伤害";
						}
						if (tooltipLine.text == "Can be used thrice per boss battle")
						{
							tooltipLine.text = "boss战限制只能发射三发弹药";
						}
					}
				}
			}
		}
	}
}
