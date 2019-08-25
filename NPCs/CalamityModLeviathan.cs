using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000016 RID: 22
	public class CalamityModLeviathan : GlobalNPC
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000049C0 File Offset: 0x00002BC0
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticAberration"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "深海吞食者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Leviathan"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "利维坦");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("LeviathanStart"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "迷人的歌声？");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Parasea"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "海蠕虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Siren"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "塞壬");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SirenClone"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "塞壬分身");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SirenIce"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "冰护盾");
				}
			}
		}
	}
}
