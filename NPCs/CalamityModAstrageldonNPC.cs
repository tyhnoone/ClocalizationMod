using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000008 RID: 8
	public class CalamityModAstrageldonNPC : GlobalNPC
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000038D0 File Offset: 0x00001AD0
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Astrageldon"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "白金之星");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrageldonSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小白星");
				}
			}
		}
	}
}
