using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BurntOut : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BurntOut").DisplayName.AddTranslation(GameCulture.Chinese,"灼伤");
				ModLoader.GetMod("CalamityMod").GetBuff("BurntOut").Description.AddTranslation(GameCulture.Chinese, "你被灼伤了，你的守卫现在难以起作用");
			}
		}
	}
}
