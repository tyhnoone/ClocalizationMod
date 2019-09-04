using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000023 RID: 35
	public class CalamityModTheDevourerofGods : GlobalNPC
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00006844 File Offset: 0x00004A44
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "神明吞噬者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsBody2") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsHead2") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsTail2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "宇宙守护者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsBodyS") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsHeadS") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsTailS"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "神明吞噬者");
				}
			}
		}
	}
}
