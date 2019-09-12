using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AmidiasBlessing : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("AmidiasBlessing").DisplayName.AddTranslation(GameCulture.Chinese, "阿米迪亚斯的祝福");
				ModLoader.GetMod("CalamityMod").GetBuff("AmidiasBlessing").Description.AddTranslation(GameCulture.Chinese, "你被阿米迪亚斯祝福了\n允许你在水中，甚至在深渊中呼吸自如\n只是别被攻击到就好...");
			}
		}
	}
}
