using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000013 RID: 19
	public class CalamityModDesertScourgeNPC : GlobalNPC
	{
		// Token: 0x06000026 RID: 38 RVA: 0x0000463C File Offset: 0x0000283C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DesertScourgeBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DesertScourgeHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DesertScourgeTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "荒漠灾虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DesertScourgeBodySmall") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DesertScourgeHeadSmall") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DesertScourgeTailSmall"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小荒漠灾虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DriedSeekerBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DriedSeekerHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("DriedSeekerTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小灾虫");
				}
			}
		}
	}
}
