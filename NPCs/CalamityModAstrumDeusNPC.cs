using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x0200000A RID: 10
	public class CalamityModAstrumDeusNPC : GlobalNPC
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00003D38 File Offset: 0x00001F38
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusBodySpectral") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusHeadSpectral") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusTail") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusTailSpectral"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星神游龙");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusProbe") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusProbe2") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstrumDeusProbe3"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星神探测器");
				}
			}
		}
	}
}
