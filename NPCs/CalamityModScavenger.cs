using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200001E RID: 30
	public class CalamityModScavenger : GlobalNPC
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00005E48 File Offset: 0x00004048
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("FlamePillar"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "火焰柱");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("RockPillar"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "石元柱");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScavengerBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScavengerHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScavengerHead2") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScavengerLegLeft") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScavengerLegRight") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScavengerClawLeft") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScavengerClawRight"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "毁灭魔像");
				}
			}
		}
	}
}
