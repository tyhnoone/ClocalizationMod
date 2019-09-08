using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class HolyLight : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("HolyLight").DisplayName.AddTranslation(GameCulture.Chinese,"神圣之火");
				ModLoader.GetMod("CalamityMod").GetBuff("HolyLight").Description.AddTranslation(GameCulture.Chinese,"神圣之光分解而来");
			}
		}
	}
}
