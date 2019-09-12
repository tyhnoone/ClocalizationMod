using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BearBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BearBuff").DisplayName.AddTranslation(GameCulture.Chinese, "小熊");
				ModLoader.GetMod("CalamityMod").GetBuff("BearBuff").Description.AddTranslation(GameCulture.Chinese, "一位守护天使正跟着你");
			}
		}
	}
}
