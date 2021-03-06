﻿using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BurningBlood : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BurningBlood").DisplayName.AddTranslation(GameCulture.Chinese,"沸腾之血");
				ModLoader.GetMod("CalamityMod").GetBuff("BurningBlood").Description.AddTranslation(GameCulture.Chinese, "你的血液沸腾了");
			}
		}
	}
}
