using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class Corroslime : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("Corroslime").DisplayName.AddTranslation(GameCulture.Chinese,"小腐化史莱姆");
				ModLoader.GetMod("CalamityMod").GetBuff("Corroslime").Description.AddTranslation(GameCulture.Chinese, "小腐化史莱姆会保护你的");
			}
		}
	}
}
