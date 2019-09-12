using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BrimstoneMount : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BrimstoneMount").DisplayName.AddTranslation(GameCulture.Chinese,"硫火玫瑰坐骑");
				ModLoader.GetMod("CalamityMod").GetBuff("BrimstoneMount").Description.AddTranslation(GameCulture.Chinese, "啊，柔软~~这便足够");
			}
		}
	}
}
