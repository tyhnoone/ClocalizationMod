using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class ChibiiBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("ChibiiBuff").DisplayName.AddTranslation(GameCulture.Chinese,"卡通迷你吞噬者");
				ModLoader.GetMod("CalamityMod").GetBuff("ChibiiBuff").Description.AddTranslation(GameCulture.Chinese, "啥？你以为会出来啥？");
			}
		}
	}
}
