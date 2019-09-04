using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityGreatSandShark : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrandScale"))
				{
					item.SetNameOverride("大狂鲨鳞");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SandstormsCore"))
				{
					item.SetNameOverride("沙暴核心");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GrandScale"))
					{
						if (tooltipLine.text == "Large scale of an apex predator")
						{
							tooltipLine.text = "顶级捕食者的巨大鳞片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SandstormsCore"))
					{
						if (tooltipLine.text == "Summons the Great Sand Shark")
						{
							tooltipLine.text = "召唤旱海狂鲨";
						}
					}
				}
			}
		}
	}
}
