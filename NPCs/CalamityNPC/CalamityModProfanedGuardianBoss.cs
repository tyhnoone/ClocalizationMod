using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200001C RID: 28
	public class CalamityModProfanedGuardianBoss : GlobalNPC
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00005C8C File Offset: 0x00003E8C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProfanedGuardianBoss") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProfanedGuardianBoss2") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProfanedGuardianBoss3")))
			{
				NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "亵渎守卫");
			}
		}
	}
}
