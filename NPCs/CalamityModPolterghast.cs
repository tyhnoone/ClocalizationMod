using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200001B RID: 27
	public class CalamityModPolterghast : GlobalNPC
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00005B70 File Offset: 0x00003D70
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PhantomFuckYou"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幻花灵");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Polterghast"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "噬魂幽花");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PolterghastHook"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幽花触爪");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PolterPhantom"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "噬魂幽花幻象");
				}
			}
		}
	}
}
