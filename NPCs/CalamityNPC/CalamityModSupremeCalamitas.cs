using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000022 RID: 34
	public class CalamityModSupremeCalamitas : GlobalNPC
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0000665C File Offset: 0x0000485C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SCalWormBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SCalWormHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SCalWormTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灾坟虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SCalWormBodyWeak") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("SCalWormHeart"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灾坟虫心");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SoulSeekerSupreme"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "至尊探魂眼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SupremeCalamitas"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "至尊灾厄之影");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SupremeCataclysm"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "至尊灾祸");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SupremeCatastrophe"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "至尊灾难");
				}
			}
		}
	}
}
