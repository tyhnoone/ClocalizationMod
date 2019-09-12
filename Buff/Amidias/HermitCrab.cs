﻿using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class HermitCrab : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("HermitCrab").DisplayName.AddTranslation(GameCulture.Chinese, "寄居蟹");
				ModLoader.GetMod("CalamityMod").GetBuff("HermitCrab").Description.AddTranslation(GameCulture.Chinese, "寄居蟹会为你而战");
			}
		}
	}
}
