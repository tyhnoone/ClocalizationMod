using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class Calamari : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("Calamari").DisplayName.AddTranslation(GameCulture.Chinese,"乌贼");
				ModLoader.GetMod("CalamityMod").GetBuff("Calamari").Description.AddTranslation(GameCulture.Chinese, "乌贼会保护你");
			}
		}
	}
}
