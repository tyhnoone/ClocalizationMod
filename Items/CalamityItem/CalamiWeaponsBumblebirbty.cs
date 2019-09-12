using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamiWeaponsBumblebirbty : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GildedProboscis"))
				{
					item.SetNameOverride("镀金鸟喙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GoldenEagle"))
				{
					item.SetNameOverride("金鹰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RougeSlash"))
				{
					item.SetNameOverride("殷红斩");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GildedProboscis"))
					{
						if (tooltipLine.text == "Ignores immunity frames")
						{
							tooltipLine.text = "此枪无视敌人无敌帧";
						}
						if (tooltipLine.text == "Heals the player on enemy hits")
						{
							tooltipLine.text = "你的攻击会治疗你自己";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GoldenEagle"))
					{
						if (tooltipLine.text == "Fires 5 bullets at once")
						{
							tooltipLine.text = "一次发射5枚子弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RougeSlash"))
					{
						if (tooltipLine.text == "Fires a wave of 3 rouge air slashes")
						{
							tooltipLine.text = "一次发射3道空气斩1";
						}
					}
				}
			}
		}
	}
}
