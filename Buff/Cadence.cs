using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class Cadence : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("Cadence").DisplayName.AddTranslation(GameCulture.Chinese, "余音");
				ModLoader.GetMod("CalamityMod").GetBuff("Cadence").Description.AddTranslation(GameCulture.Chinese, "你的心灵是纯洁的");
			}
		}
	}
}
