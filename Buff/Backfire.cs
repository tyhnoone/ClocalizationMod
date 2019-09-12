using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class Backfire : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("Backfire").DisplayName.AddTranslation(GameCulture.Chinese, "逆火");
				ModLoader.GetMod("CalamityMod").GetBuff("Backfire").Description.AddTranslation(GameCulture.Chinese, "伤害，防御飞行时间大幅降低");
			}
		}
	}
}
