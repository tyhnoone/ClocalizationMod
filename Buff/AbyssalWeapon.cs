using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AbyssalWeapon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalWeapon").DisplayName.AddTranslation(GameCulture.Chinese, "深渊武器");
				ModLoader.GetMod("CalamityMod").GetBuff("AbyssalWeapon").Description.AddTranslation(GameCulture.Chinese, "近战武器施加深渊之火，增加15%移速");
			}
		}
	}
}
