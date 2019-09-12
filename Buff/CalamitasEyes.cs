using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamitasEyes : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("CalamitasEyes").DisplayName.AddTranslation(GameCulture.Chinese,"枯萎之眼");
				ModLoader.GetMod("CalamityMod").GetBuff("CalamitasEyes").Description.AddTranslation(GameCulture.Chinese, "灾厄之眼和她的兄弟们会保护你");
			}
		}
	}
}
