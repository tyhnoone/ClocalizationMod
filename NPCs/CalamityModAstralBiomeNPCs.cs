using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000009 RID: 9
	public class CalamityModAstralBiomeNPCs : GlobalNPC
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00003974 File Offset: 0x00001B74
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Aries"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "白羊座");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstralachneaGround") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstralachneaWall"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星幻蛛");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstralProbe"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星幻探测器");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstralSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星幻史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Atlas"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "擎星者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("BigSightseer"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大监星眼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AstralSeekerSpit"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "跟踪液");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("FusionFeeder"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "融食鲨");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Hadarian"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "哈德安翼龙");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Hive"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星幻巢");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Hiveling"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星幻蜂");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Mantis"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星幻螳螂");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Nova"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "新星");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SmallSightseer"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小监星眼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("StellarCulex"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "星幻蚊");
				}
			}
		}
	}
}
