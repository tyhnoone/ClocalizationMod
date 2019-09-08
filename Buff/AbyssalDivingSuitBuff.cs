using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AbyssalDivingSuitBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalDivingSuitBuff").DisplayName.AddTranslation(GameCulture.Chinese,"深渊潜游服");
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalDivingSuitBuff").Description.AddTranslation(GameCulture.Chinese, "你是铁打的");
			}
		}
	}
}
