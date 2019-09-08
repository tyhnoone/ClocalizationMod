using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class ArmorCrunch : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("ArmorCrunch").DisplayName.AddTranslation(GameCulture.Chinese, "碎甲");
				ModLoader.GetMod("CalamityMod").GetBuff("ArmorCrunch").Description.AddTranslation(GameCulture.Chinese, "你的护甲被撕裂了");
			}
		}
	}
}
