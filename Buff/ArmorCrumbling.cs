using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class ArmorCrumbling : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("ArmorCrumbling").DisplayName.AddTranslation(GameCulture.Chinese, "装甲击破");
				ModLoader.GetMod("CalamityMod").GetBuff("ArmorCrumbling").Description.AddTranslation(GameCulture.Chinese, "近战和盗贼攻击会击碎敌人的防御");
			}
		}
	}
}
