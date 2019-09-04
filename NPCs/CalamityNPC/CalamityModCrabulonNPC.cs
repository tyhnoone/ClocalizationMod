using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000011 RID: 17
	public class CalamityModCrabulonNPC : GlobalNPC
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00004460 File Offset: 0x00002660
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrabShroom"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "蟹菌");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrabulonIdle"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "菌生蟹");
				}
			}
		}
	}
}
