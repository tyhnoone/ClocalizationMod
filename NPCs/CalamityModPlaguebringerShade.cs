using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200001A RID: 26
	public class CalamityModPlaguebringerShade : GlobalNPC
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00005B08 File Offset: 0x00003D08
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlaguebringerShade"))
			{
				NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫使者");
			}
		}
	}
}
