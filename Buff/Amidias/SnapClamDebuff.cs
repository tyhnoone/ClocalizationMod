using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class SnapClamDebuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("SnapClamDebuff").DisplayName.AddTranslation(GameCulture.Chinese, "夹住");
				ModLoader.GetMod("CalamityMod").GetBuff("SnapClamDebuff").Description.AddTranslation(GameCulture.Chinese, "被夹贝夹住了");
			}
		}
	}
}
