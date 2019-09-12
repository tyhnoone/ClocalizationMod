using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class ChaosCandle : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("ChaosCandle").DisplayName.AddTranslation(GameCulture.Chinese,"混乱蜡烛");
				ModLoader.GetMod("CalamityMod").GetBuff("ChaosCandle").Description.AddTranslation(GameCulture.Chinese, "四周刷怪率提升！");
			}
		}
	}
}
