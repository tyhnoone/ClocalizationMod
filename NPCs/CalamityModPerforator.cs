using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000018 RID: 24
	public class CalamityModPerforator : GlobalNPC
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000057D0 File Offset: 0x000039D0
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorCyst"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "血肉囊");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorHive"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "血肉宿主");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorTailSmall") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorBodySmall") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorHeadSmall"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "弱体血肉寄生蠕虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorTailMedium") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorBodyMedium") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorHeadMedium"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "普通血肉寄生蠕虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorTailLarge") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorBodyLarge") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerforatorHeadLarge"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "巨型血肉寄生蠕虫");
				}
			}
		}
	}
}
