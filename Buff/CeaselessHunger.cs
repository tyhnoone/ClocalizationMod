using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CeaselessHunger : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("CeaselessHunger").DisplayName.AddTranslation(GameCulture.Chinese,"无尽之饥");
				ModLoader.GetMod("CalamityMod").GetBuff("CeaselessHunger").Description.AddTranslation(GameCulture.Chinese, "令你吸附全世界的物品");
			}
		}
	}
}
