using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalciumBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("CalciumBuff").DisplayName.AddTranslation(GameCulture.Chinese,"补钙");
				ModLoader.GetMod("CalamityMod").GetBuff("CalciumBuff").Description.AddTranslation(GameCulture.Chinese, "你免疫坠落伤害");
			}
		}
	}
}
