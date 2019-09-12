using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityBuff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item == null)
				{
					item.consumable = false;
					
				}
				//ModLoader.GetMod("CalamityMod").GetBuff("AbyssalDivingSuitPlatesBroken").DisplayName.AddTranslation(GameCulture.Chinese,"深渊潜游服受损外壳");
				//ModLoader.GetMod("CalamityMod").GetBuff("AbyssalFlames").DisplayName.AddTranslation(GameCulture.Chinese,"深渊之火");
				//ModLoader.GetMod("CalamityMod").GetBuff("AbyssalWeapon").DisplayName.AddTranslation(GameCulture.Chinese,"深渊武器");
				//ModLoader.GetMod("CalamityMod").GetBuff("AdrenalineMode").DisplayName.AddTranslation(GameCulture.Chinese,"兴奋状态");
				//ModLoader.GetMod("CalamityMod").GetBuff("Afflicted").DisplayName.AddTranslation(GameCulture.Chinese,"折磨");
				//ModLoader.GetMod("CalamityMod").GetBuff("AkatoYharonBuff").DisplayName.AddTranslation(GameCulture.Chinese,"阿卡托");
				//ModLoader.GetMod("CalamityMod").GetBuff("AnechoicCoating").DisplayName.AddTranslation(GameCulture.Chinese,"吸音涂层");
				//ModLoader.GetMod("CalamityMod").GetBuff("AngryChicken").DisplayName.AddTranslation(GameCulture.Chinese,"犽戎之子");
				//ModLoader.GetMod("CalamityMod").GetBuff("AquaticStar").DisplayName.AddTranslation(GameCulture.Chinese,"渊海海星");
				//ModLoader.GetMod("CalamityMod").GetBuff("ArmorCrumbling").DisplayName.AddTranslation(GameCulture.Chinese,"装甲击破");
				//ModLoader.GetMod("CalamityMod").GetBuff("ArmorCrunch").DisplayName.AddTranslation(GameCulture.Chinese,"碎甲");
				//ModLoader.GetMod("CalamityMod").GetBuff("ArmorShattering").DisplayName.AddTranslation(GameCulture.Chinese,"装甲撕裂");
				//ModLoader.GetMod("CalamityMod").GetBuff("AstralInfectionDebuff").DisplayName.AddTranslation(GameCulture.Chinese,"星体感染");
				//ModLoader.GetMod("CalamityMod").GetBuff("AstralInjectionBuff").DisplayName.AddTranslation(GameCulture.Chinese,"幻星注射剂");
				//ModLoader.GetMod("CalamityMod").GetBuff("BrimstoneFlames").DisplayName.AddTranslation(GameCulture.Chinese,"硫磺火");
				//
				//ModLoader.GetMod("CalamityMod").GetBuff("HolyLight").DisplayName.AddTranslation(GameCulture.Chinese,"神圣之火");
			}
		}
	}
}
