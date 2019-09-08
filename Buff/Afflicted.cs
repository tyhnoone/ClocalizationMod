using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class Afflicted : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("Afflicted").DisplayName.AddTranslation(GameCulture.Chinese, "折磨");
				ModLoader.GetMod("CalamityMod").GetBuff("Afflicted").Description.AddTranslation(GameCulture.Chinese, "被异界之魂增幅");
			}
		}
	}
}
