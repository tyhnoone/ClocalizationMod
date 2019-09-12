using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class BoundingBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("BoundingBuff").DisplayName.AddTranslation(GameCulture.Chinese,"弹跳");
				ModLoader.GetMod("CalamityMod").GetBuff("BoundingBuff").Description.AddTranslation(GameCulture.Chinese, "增加跳跃高度，跳跃速度，降低摔落伤害");
			}
		}
	}
}
