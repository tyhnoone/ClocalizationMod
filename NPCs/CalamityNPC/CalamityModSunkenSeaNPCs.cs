using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000021 RID: 33
	public class CalamityModSunkenSeaNPCs : GlobalNPC
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000636C File Offset: 0x0000456C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("BlindedAngler"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "盲眼鮟鱇");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Clam"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "沉沦渊蛤");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("EutrophicRay"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "沉沦渊鳐");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("GhostBell"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幽铃水母");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("GhostBellSmall"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小幽铃水母");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("GiantClam"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "巨像蛤");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PrismTurtle"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "晶背龟");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaFloaty"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "海蜉虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaMinnow"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "渊米诺鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaSerpent1") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaSerpent2") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaSerpent3") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaSerpent4") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaSerpent5"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "沉沦渊蟒");
				}
			}
		}
	}
}
