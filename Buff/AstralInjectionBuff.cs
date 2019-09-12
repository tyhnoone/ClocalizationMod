using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AstralInjectionBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AstralInjectionBuff").DisplayName.AddTranslation(GameCulture.Chinese, "幻星注射剂");
				ModLoader.GetMod("CalamityMod").GetBuff("AstralInjectionBuff").Description.AddTranslation(GameCulture.Chinese, "魔力极速再生");
			}
		}
	}
}
