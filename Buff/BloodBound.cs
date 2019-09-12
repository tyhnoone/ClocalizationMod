using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BloodBound : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BloodBound").DisplayName.AddTranslation(GameCulture.Chinese, "血之束缚");
				ModLoader.GetMod("CalamityMod").GetBuff("BloodBound").Description.AddTranslation(GameCulture.Chinese, "为了陪伴你必须铤而走险");
			}
		}
	}
}
