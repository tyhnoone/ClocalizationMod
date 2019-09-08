﻿using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AquaticStar : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AquaticStar").DisplayName.AddTranslation(GameCulture.Chinese, "渊海海星");
				ModLoader.GetMod("CalamityMod").GetBuff("AquaticStar").Description.AddTranslation(GameCulture.Chinese, "渊海海星为你而战");
			}
		}
	}
}
