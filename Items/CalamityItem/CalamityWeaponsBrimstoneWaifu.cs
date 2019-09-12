using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsBrimstoneWaifu : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Brimlance"))
				{
					item.SetNameOverride("硫磺火矛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeethingDischarge"))
				{
					item.SetNameOverride("腾焰爆发");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Brimlance"))
					{
						if (tooltipLine.text == "Enemies killed by the spear explode into brimstone flames")
						{
							tooltipLine.text = "被矛杀死的敌人爆炸成硫磺火焰";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeethingDischarge"))
					{
						if (tooltipLine.text == "Fires a barrage of brimstone blasts")
						{
							tooltipLine.text = "发射一团硫磺火烈焰";
						}
					}
				}
			}
		}
	}
}
