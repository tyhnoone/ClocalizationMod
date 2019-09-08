using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AngryChicken : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AngryChicken").DisplayName.AddTranslation(GameCulture.Chinese, "丛林龙之子");
				ModLoader.GetMod("CalamityMod").GetBuff("AngryChicken").Description.AddTranslation(GameCulture.Chinese, "亚戎之子会保护着你");
			}
		}
	}
}
