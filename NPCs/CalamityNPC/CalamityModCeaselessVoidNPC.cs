using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200000F RID: 15
	public class CalamityModCeaselessVoidNPC : GlobalNPC
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000429C File Offset: 0x0000249C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CeaselessVoid"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "无尽虚空");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DarkEnergy") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DarkEnergy2") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DarkEnergy3"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "暗能量");
				}
			}
		}
	}
}
