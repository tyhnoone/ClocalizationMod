using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000017 RID: 23
	public class CalamityModNormalNPCs : GlobalNPC
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004B90 File Offset: 0x00002D90
		public override void SetDefaults(NPC npc)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AeroSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "天蓝史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("AngryDog"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "恼怒雪狗");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ArmoredDiggerBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ArmoredDiggerHead") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ArmoredDiggerTail"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "装甲掘地虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("BlightedEye"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "枯萎之眼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("BloomSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "龙蒿史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CalamityEye"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小灾厄眼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CharredSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "焦炭史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Cnidrion"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "卧龙海马");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CosmicElemental"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "宇宙元素");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerAmber"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "琥珀爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerAmethyst"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "紫水晶爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerCrystal"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "水晶爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerDiamond"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "钻石爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerEmerald"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "绿宝石爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerRuby"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "红宝石爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerSapphire"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "蓝宝石爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrawlerTopaz"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "黄玉爬虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CrimulanBlightSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "血腥枯萎史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Cryon"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "寒元人");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("CryoSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "寒元史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("EbonianBlightSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "黑檀枯萎史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Eidolist"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幻妖灵巫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("HeatSpirit"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "热能之魂");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Horse"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "地元魔魂");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("IceClasper"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "食魂冰虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ImpiousImmolator"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "亵渎献祭者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("IrradiatedSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "辐射史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("OverloadedSoldier"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "过载装甲骷髅");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PerennialSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "永恒史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PhantomDebris"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幻影骸虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PhantomSpirit") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PhantomSpiritL") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PhantomSpiritM") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PhantomSpiritS"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "幻魂");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Piggy"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "小猪猪");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Pitbull"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "血犬");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlagueBee") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlagueBeeLarge"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫毒蜂");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlaguedDerpling"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "毒飞虫");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlaguedFlyingFox"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "蚀化者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlaguedJungleSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "鸩毒史莱姆");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("PlaguedTortoise"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "瘟疫毒龟");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProfanedEnergyBody") || npc.type == ModLoader.GetMod("CalamityMod").NPCType("ProfanedEnergyLantern"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "亵渎能量");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SandTortoise"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "沙漠龟");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ScornEater"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "吞食魔");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ShockstormShuttle"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "风暴飞碟");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("StormlionCharger"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "风暴蚁狮");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SunBat"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "太阳蝙蝠");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("Sunskater"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "寻阳鱼");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SuperDummy"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大草人");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("ThiccWaifu"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "雨云元素");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("WulfrumDrone"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "钨钢土行者");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("WulfrumSlime"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "钨钢史莱姆");
				}
			}
		}
	}
}
