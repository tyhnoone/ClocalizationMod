using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000015 RID: 21
	public class CalamityModHiveMind : GlobalNPC
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00004830 File Offset: 0x00002A30
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DankCreeper"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "沼泽之眼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DarkHeart"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "暗之心");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("HiveBlob") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("HiveBlob2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "腐化球");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("HiveCyst"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "腐化囊");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("HiveMind") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("HiveMindP2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "腐巢意志");
				}
			}
		}
	}
}
