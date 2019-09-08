using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class GlacialState : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("GlacialState").DisplayName.AddTranslation(GameCulture.Chinese,"冰河时代");
				ModLoader.GetMod("CalamityMod").GetBuff("GlacialState").Description.AddTranslation(GameCulture.Chinese,"无法移动，防御撕裂");
			}
		}
	}
}
