using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200000C RID: 12
	public class CalamityModBumblefuckNPC : GlobalNPC
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00003F4C File Offset: 0x0000214C
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Bumblefuck") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("Bumblefuck2")))
			{
				NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "嗡嗡蜂鸟");
			}
		}
	}
}
