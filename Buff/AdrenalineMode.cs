using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class AdrenalineMode : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
				}
				String text;

				ModWorld CalamityWorld = ModLoader.GetMod("CalamityMod").GetModWorld("CalamityWorld");
				bool death = (bool) CalamityWorld.GetType().GetField("death").GetValue(CalamityWorld);
				
				if(death) text = "增加500%伤害. 筋疲力竭后会降至165%. ";
				else text = "增加150%伤害. 筋疲力竭后会降至49.5%. ";

				ModLoader.GetMod("CalamityMod").GetBuff("AdrenalineMode").DisplayName.AddTranslation(GameCulture.Chinese, "兴奋模式");
				ModLoader.GetMod("CalamityMod").GetBuff("AdrenalineMode").Description.AddTranslation(GameCulture.Chinese, text);
			}
		}
	}
}
