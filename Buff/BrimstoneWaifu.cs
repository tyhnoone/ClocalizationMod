using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BrimstoneWaifu : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BrimstoneWaifu").DisplayName.AddTranslation(GameCulture.Chinese,"硫磺火元素");
				ModLoader.GetMod("CalamityMod").GetBuff("BrimstoneWaifu").Description.AddTranslation(GameCulture.Chinese, "硫磺火元素会保护你");
			}
		}
	}
}
