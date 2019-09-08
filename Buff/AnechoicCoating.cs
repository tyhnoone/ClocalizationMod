using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AnechoicCoating : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AnechoicCoating").DisplayName.AddTranslation(GameCulture.Chinese, "吸音涂层");
				ModLoader.GetMod("CalamityMod").GetBuff("AnechoicCoating").Description.AddTranslation(GameCulture.Chinese, "降低深渊生物侦测到你的可能性");
			}
		}
	}
}
