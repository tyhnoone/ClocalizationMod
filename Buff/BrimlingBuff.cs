using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BrimlingBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BrimlingBuff").DisplayName.AddTranslation(GameCulture.Chinese,"小硫火灵");
				ModLoader.GetMod("CalamityMod").GetBuff("BrimlingBuff").Description.AddTranslation(GameCulture.Chinese, "保护她或迎接苦难的折磨吧");
			}
		}
	}
}
