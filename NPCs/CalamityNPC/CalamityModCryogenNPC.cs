using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000012 RID: 18
	public class CalamityModCryogenNPC : GlobalNPC
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00004504 File Offset: 0x00002704
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Cryocore") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("Cryocore2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "冰川核心");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Cryogen"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "极地之灵");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CryogenIce"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "冰川护盾");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("IceMass"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "极光之魂");
				}
			}
		}
	}
}
