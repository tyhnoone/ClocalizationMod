using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsCrabulon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Fungicide"))
				{
					item.SetNameOverride("真菌枪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HyphaeRod"))
				{
					item.SetNameOverride("菌丝杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MycelialClaws"))
				{
					item.SetNameOverride("菌丝爪");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Fungicide"))
					{
						if (tooltipLine.text == "Shoots fungal rounds that split on death")
						{
							tooltipLine.text = "发出击中后裂开的真菌弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HyphaeRod"))
					{
						if (tooltipLine.text == "Creates mushroom spores near the player")
						{
							tooltipLine.text = "在玩家附近召唤孢子球";
						}
					}
				}
			}
		}
	}
}
