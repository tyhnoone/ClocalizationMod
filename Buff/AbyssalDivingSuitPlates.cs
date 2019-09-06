﻿using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AbyssalDivingSuitPlates : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.SetNameOverride("");
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalDivingSuitPlates").DisplayName.AddTranslation(GameCulture.Chinese,"深渊潜游服金属外壳");
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalDivingSuitPlates").Description.AddTranslation(GameCulture.Chinese, "外壳金属会吸收15%的伤害");
			}
		}
	}
}
