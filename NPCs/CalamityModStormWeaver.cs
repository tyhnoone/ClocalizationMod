using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000020 RID: 32
	public class CalamityModStormWeaver : GlobalNPC
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000061FC File Offset: 0x000043FC
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("StasisProbe"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "静电球");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("StasisProbeNaked"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "静置探测器");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("StormWeaverBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("StormWeaverBodyNaked") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("StormWeaverHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("StormWeaverHeadNaked") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("StormWeaverTail") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("StormWeaverTailNaked"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "风暴编织者");
				}
			}
		}
	}
}
