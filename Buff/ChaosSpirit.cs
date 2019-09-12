using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class ChaosSpirit : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("ChaosSpirit").DisplayName.AddTranslation(GameCulture.Chinese,"混乱之灵");
				ModLoader.GetMod("CalamityMod").GetBuff("ChaosSpirit").Description.AddTranslation(GameCulture.Chinese, "混乱之灵会保护你");
			}
		}
	}
}
