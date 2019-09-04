using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000010 RID: 16
	public class CalamityModCosmicWraithNPC : GlobalNPC
	{
		// Token: 0x06000020 RID: 32 RVA: 0x0000437C File Offset: 0x0000257C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CosmicLantern"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "无限灯笼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CosmicWraith"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "神之使徒西格纳斯");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SignusBomb"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星界雷");
				}
			}
		}
	}
}
