using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BrittleStar : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BrittleStar").DisplayName.AddTranslation(GameCulture.Chinese,"脆弱之星");
				ModLoader.GetMod("CalamityMod").GetBuff("BrittleStar").Description.AddTranslation(GameCulture.Chinese, "代表星星消灭你");
			}
		}
	}
}
