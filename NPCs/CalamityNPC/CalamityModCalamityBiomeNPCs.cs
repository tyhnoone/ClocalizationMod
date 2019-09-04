using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200000E RID: 14
	public class CalamityModCalamityBiomeNPCs : GlobalNPC
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00004164 File Offset: 0x00002364
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CultistAssassin"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "邪教刺客");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DespairStone"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "绝望之石");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Scryllar") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScryllarRage"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "恶魔仆从");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SoulSlurper"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灵魂饮食者");
				}
			}
		}
	}
}
