using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AbyssalFlames : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalFlames").DisplayName.AddTranslation(GameCulture.Chinese, "深渊之火");
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalFlames").Description.AddTranslation(GameCulture.Chinese, "你的灵魂正在被消耗");
			}
		}
	}
}
