using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AstralInfectionDebuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AstralInfectionDebuff").DisplayName.AddTranslation(GameCulture.Chinese, "星体感染");
				ModLoader.GetMod("CalamityMod").GetBuff("AstralInfectionDebuff").Description.AddTranslation(GameCulture.Chinese, "你的肉体正在融化");
			}
		}
	}
}
