using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.NPCs
{
	public class CalamityModTownNPC : GlobalNPC
	{
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DILF"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大魔法师");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("FAP"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "醉仙女");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SEAHOE"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大海之王");
				}
			}
		}
	}
}
