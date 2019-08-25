using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200001D RID: 29
	public class CalamityModProvidence : GlobalNPC
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00005D2C File Offset: 0x00003F2C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Providence"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "亵渎天神");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProvSpawnDefense"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "亵渎守卫者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProvSpawnHealer"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "亵渎治愈者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProvSpawnOffense"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "亵渎前驱者");
				}
			}
		}
	}
}
