using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class ArmorShattering : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				ModLoader.GetMod("CalamityMod").GetBuff("ArmorShattering").DisplayName.AddTranslation(GameCulture.Chinese, "装甲撕裂");
				ModLoader.GetMod("CalamityMod").GetBuff("ArmorShattering").Description.AddTranslation(GameCulture.Chinese, "近战和盗贼攻击会斩裂敌人的防御");
			}
		}
	}
}
