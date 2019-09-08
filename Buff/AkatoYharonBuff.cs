using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AkatoYharonBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AkatoYharonBuff").DisplayName.AddTranslation(GameCulture.Chinese, "阿卡托");
				ModLoader.GetMod("CalamityMod").GetBuff("AkatoYharonBuff").Description.AddTranslation(GameCulture.Chinese, "'看起来你不得不照顾它了'");
			}
		}
	}
}
