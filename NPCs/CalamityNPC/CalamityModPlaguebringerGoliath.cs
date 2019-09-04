using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000019 RID: 25
	public class CalamityModPlaguebringerGoliath : GlobalNPC
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000059D0 File Offset: 0x00003BD0
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlagueBeeG") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlagueBeeLargeG"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫毒蜂");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlaguebringerGoliath"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫使者歌莉娅");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlagueHomingMissile"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫导弹");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlagueMine"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫雷");
				}
			}
		}
	}
}
