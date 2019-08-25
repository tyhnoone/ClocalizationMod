using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000014 RID: 20
	public class CalamityModGreatSandSharkNPC : GlobalNPC
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000047C8 File Offset: 0x000029C8
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && npc.type == ModLoader.GetMod("CalamityMod").NPCType("GreatSandShark"))
			{
				NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "旱海狂鲨");
			}
		}
	}
}
