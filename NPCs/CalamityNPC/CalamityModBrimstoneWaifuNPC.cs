using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200000B RID: 11
	public class CalamityModBrimstoneWaifuNPC : GlobalNPC
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00003EA8 File Offset: 0x000020A8
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Brimling"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小硫火灵");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("BrimstoneElemental"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "硫磺火元素");
				}
			}
		}
	}
}
