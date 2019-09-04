using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	public class CalamityModAbyssNPCs : GlobalNPC
	{
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticParasite"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "渊海寄生虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeBodyAlt") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "渊海灾虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticSeekerBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticSeekerHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticSeekerTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "渊海追魂虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AquaticUrchin"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "渊海海胆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Bloatfish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "肿胀翻车鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("BobbitWormHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("BobbitWormSegment"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "博比特虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("BoxJellyfish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "灯水母");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Catfish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "鲶鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ChaoticPuffer"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "混乱渊豚");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ColossalSquid"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "巨像乌贼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Cuttlefish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "红乌贼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DevilFish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "恶魔鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBodyAlt") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBodyAltHuge") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBodyHuge") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmHeadHuge") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmTail") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmTailHuge"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幻海妖龙");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Flounder"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "比目鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Frogfish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "躄鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("GiantSquid"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "巨大乌贼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Gnasher"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "噬咬龟");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("GulperEelBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("GulperEelBodyAlt") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("GulperEelHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("GulperEelTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大嘴鳗");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Laserfish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "激光鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("LuminousCorvina"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "流光石首鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("MantisShrimp"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "螳螂虾");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Mauler"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "轰鲨");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("MirageJelly"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幻海水母");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("MorayEel"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "海鳝");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("OarfishBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("OarfishHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("OarfishTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大嘴鳗");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Reaper"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "猎魂鲨");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SeaUrchin"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "海胆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ToxicMinnow"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "剧毒米诺鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Trasher"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "捣鳄");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Viperfish"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "蝰蛇鱼");
				}
			}
		}
	}
}
