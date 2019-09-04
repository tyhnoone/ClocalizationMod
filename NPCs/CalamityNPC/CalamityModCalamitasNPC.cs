using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200000D RID: 13
	public class CalamityModCalamitasNPC : GlobalNPC
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003FD0 File Offset: 0x000021D0
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Calamitas"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灾厄之影");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CalamitasRun"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灾祸");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CalamitasRun2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灾难");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CalamitasRun3"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灾厄之影");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("LifeSeeker"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "探灵眼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SoulSeeker"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "搜魂眼");
				}
			}
		}
	}
}
