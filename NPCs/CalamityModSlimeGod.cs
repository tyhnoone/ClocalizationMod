using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200001F RID: 31
	public class CalamityModSlimeGod : GlobalNPC
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00005FD8 File Offset: 0x000041D8
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeGod"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "黑檀腐神史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeGodCore"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "史莱姆之神");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeGodRun"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "猩红血神史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeGodRunSplit"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "分裂猩红史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeGodSplit"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "分裂黑檀史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeSpawnCorrupt") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeSpawnCorrupt2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "腐化史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeSpawnCrimson"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "血化史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SlimeSpawnCrimson2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "尖刺血化史莱姆");
				}
			}
		}
	}
}
