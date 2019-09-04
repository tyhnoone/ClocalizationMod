using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000024 RID: 36
	public class CalamityModYharon : GlobalNPC
	{
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DetonatingFlare"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "爆裂火焰");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DetonatingFlare2"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "爆裂火焰");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Yharon"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "丛林龙-亚戎");
				}
			}
		}
	}
}
