using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BrimstoneFlames : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BrimstoneFlames").DisplayName.AddTranslation(GameCulture.Chinese,"硫磺火");
				ModLoader.GetMod("CalamityMod").GetBuff("BrimstoneFlames").Description.AddTranslation(GameCulture.Chinese,"大量生命流失");
			}
		}
	}
}
