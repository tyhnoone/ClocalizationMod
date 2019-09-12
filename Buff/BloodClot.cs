using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BloodClot : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BloodClot").DisplayName.AddTranslation(GameCulture.Chinese,"血块");
				ModLoader.GetMod("CalamityMod").GetBuff("BloodClot").Description.AddTranslation(GameCulture.Chinese, "血块正在保护你");
			}
		}
	}
}
