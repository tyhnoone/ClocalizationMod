
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;
using Terraria.GameInput;
using ReLogic.Graphics;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;
using Terraria.GameContent.UI.States;

namespace ZZLocalizationMod
{
    internal class CalamitySupport
	{
		public static void Setup()
		{
			CalamitySupport.BossChecklistSupport();
		}
		private static void BossChecklistSupport()
		{
			
		}
        public static void CalamityCalculateLootLoad()
        {
            if(ModLoader.GetMod("CalamityMod") != null)
			{
				List<string> list = new List<string>();
				list.Add("desertScourge");
				list.Add("perforator");
				list.Add("cryogen");
				list.Add("brimstoneElemental");
				list.Add("calamitas");
				list.Add("leviathan");
				list.Add("devourerOfGods");
				list.Add("guardians");
				list.Add("providence");
				list.Add("signus");
				list.Add("yharon");
				list.Add("eclipse");
				list.Add("bumblebirb");
				list.Add("crabulon");
				list.Add("betsy");
				list.Add("scavenger");
				list.Add("boss2");
				list.Add("boss3");
				list.Add("wall");
				list.Add("skeletronPrime");
				list.Add("planter");
				list.Add("baby");
				list.Add("moonDude");
				list.Add("anyBoss");
				list.Add("demonMode");
				list.Add("onionMode");
				list.Add("revenge");
				list.Add("starGod");
				list.Add("astrageldon");
				list.Add("hardBoss");
				list.Add("polterghast");
				list.Add("moth");
				list.Add("oldDuke");
				list.Add("death");
				list.Add("defiled");
				list.Add("armageddon");
				list.Add("ironHeart");
				list.Add("abyssSide");
				list.Add("clam");
				TagCompound tag = new TagCompound();
				tag.Add("downed", list);
				ModLoader.GetMod("CalamityMod").GetModWorld("CalamityWorld").Load(tag);
			}
        }
        public static void CalamityCalculateLootUnLoad()
        {
			if(ModLoader.GetMod("CalamityMod") != null)
			{
				TagCompound tag = new TagCompound();
				List<string> list = new List<string>();
				ModLoader.GetMod("CalamityMod").GetModWorld("CalamityWorld").Load(tag);
			}
        }

        public static string CalamityZone(Player player)
        {
				string zone = "";
				ModPlayer playerCalamity = player.GetModPlayer(ModLoader.GetMod("CalamityMod"), "CalamityPlayer");
				bool ZoneCalamity = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneCalamity").GetValue(playerCalamity));
				bool ZoneAstral = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneAstral").GetValue(playerCalamity));
				bool ZoneSunkenSea = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneSunkenSea").GetValue(playerCalamity));
				bool ZoneSulphur = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneSulphur").GetValue(playerCalamity));
				bool ZoneAbyss = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneAbyss").GetValue(playerCalamity));
				bool ZoneAbyssLayer1 = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneAbyssLayer1").GetValue(playerCalamity));
				bool ZoneAbyssLayer2 = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneAbyssLayer2").GetValue(playerCalamity));
				bool ZoneAbyssLayer3 = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneAbyssLayer3").GetValue(playerCalamity));
				bool ZoneAbyssLayer4 = (bool)(ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("ZoneAbyssLayer4").GetValue(playerCalamity));
				if (ZoneCalamity) zone += "\n硫磺火之崖 (灾厄)";
				if (ZoneAstral) zone += "\n星幻之地 (灾厄)";
				if (ZoneSunkenSea) zone += "\n沉沦之渊 (灾厄)";
				if (ZoneAbyss) zone += "\n灾厄深渊";
				if (ZoneAbyssLayer1) zone += "\n灾厄深渊浅层(第一层)";
				if (ZoneAbyssLayer2) zone += "\n灾厄深渊中层(第二层)";
				if (ZoneAbyssLayer3) zone += "\n灾厄深渊深层(第三层)";
				if (ZoneAbyssLayer4) zone += "\n灾厄深渊底层(第四层)";
				if (ZoneSulphur) zone += "\n硫磺海 (灾厄)";
			
				return zone;
        }
		public static void Load()
		{
			CalamitySupport._localizations = new string[][]
			{
				new string[]
				{
					"SkyOreText",
					"地下闪烁着天蓝色的微芒。"
				},
				new string[]
				{
					"IceOreText",
					"一股极寒的能量打破了冰层之下的宁静。"
				},
				new string[]
				{
					"PlantOreText",
					"注满着植物能量的物质在地下成型了。"
				},
				new string[]
				{
					"TreeOreText",
					"已变为化石的树突然在丛林的土地之中重新焕发了生机。"
				},
				new string[]
				{
					"AuricOreText",
					"属于神的光耀已然播撒进了这片大地的土层之中。."
				},
				new string[]
				{
					"FutureOreText",
					"太空中充斥着寒冷而寂灭的能量。"
				},
				new string[]
				{
					"UglyBossText",
					"沉沦海在动荡..."
				},
				new string[]
				{
					"SteelSkullBossText",
					"猩红狱火穿透夜空..."
				},
				new string[]
				{
					"PlantBossText",
					"大海深处传来震荡。"
				},
				new string[]
				{
					"BabyBossText",
					"瘟疫开始于丛林中传播。"
				},
				new string[]
				{
					"BabyBossText2",
					"远古机械傀儡正游走于丛林之中。"
				},
				new string[]
				{
					"MoonBossText",
					"亵渎之火正灼烧虚空！"
				},
				new string[]
				{
					"MoonBossText2",
					"来自天外的恐惧之源正虎视眈眈..."
				},
				new string[]
				{
					"MoonBossText3",
					"猩红之月被召唤了..."
				},
				new string[]
				{
					"PlagueBossText",
					"瘟疫核弹发射井已装填，准备发射！！！"
				},
				new string[]
				{
					"PlagueBossText2",
					"导弹已发射，目标追踪定位中！！！"
				},
				new string[]
				{
					"ProfanedBossText",
					"空气正在灼烧..."
				},
				new string[]
				{
					"ProfanedBossText2",
					"尖叫声于地牢中回响。"
				},
				new string[]
				{
					"ProfanedBossText3",
					"灾祸之物正被血石浸透。"
				},
				new string[]
				{
					"GhostBossText",
					"深渊之中的灵魂被惊扰了。"
				},
				new string[]
				{
					"GhostBossText2",
					"在破败的地牢大厅里回响着哀嚎..."
				},
				new string[]
				{
					"GhostBossText3",
					"死了很久的囚犯寻求他们的热情复仇..."
				},
				new string[]
				{
					"SupremeBossText3",
					"行，来吧。不知你因何来扰。"
				},
				new string[]
				{
					"SupremeBossText4",
					"你似乎很自信...但你对痛苦一无所知。"
				},
				new string[]
				{
					"SupremeBossText5",
					"一切本来安好的，直到你的出现。"
				},
				new string[]
				{
					"SupremeBossText6",
					"兄弟们，助我片刻？我已厌倦折磨这个可怜人了。"
				},
				new string[]
				{
					"SupremeBossText",
					"无妨，我仍有诸多小术未曾施展。"
				},
				new string[]
				{
					"SupremeBossText7",
					"嚯...或许，该让小家伙们出来耍耍了。"
				},
				new string[]
				{
					"SupremeBossText8",
					"令人惊叹，然不过尔尔！"
				},
				new string[]
				{
					"SupremeBossText9",
					"热身才刚结束！"
				},
				new string[]
				{
					"SupremeBossText20",
					"什么？你还活着？！"
				},
				new string[]
				{
					"SupremeBossText21",
					"且慢！"
				},
				new string[]
				{
					"SupremeBossText22",
					"便是击败我，你仍要同领主战斗！"
				},
				new string[]
				{
					"SupremeBossText23",
					"迄今为止他未尝一败！"
				},
				new string[]
				{
					"SupremeBossText24",
					"我与他差之千里，你又有何希望？"
				},
				new string[]
				{
					"SupremeBossText25",
					"上次对峙之后，他更强了...你没有机会的。"
				},
				new string[]
				{
					"SupremeBossText26",
					"如此...便结束了吧。"
				},
				new string[]
				{
					"SupremeBossText27",
					"或许某一时间我会改变我的想法..."
				},
				new string[]
				{
					"SupremeBossText28",
					"你受的伤与我不成对比...作弊么？"
				},
				new string[]
				{
					"SupremeBossText2",
					"下地狱吧！"
				},
				new string[]
				{
					"SupremeBossText10",
					"终于，我解脱了...不对...等等。一切不过再度上演不断轮回。行吧...."
				},
				new string[]
				{
					"SupremeBossText11",
					"可曾享受过地狱之旅？"
				},
				new string[]
				{
					"SupremeBossText12",
					"不要想错了，我欣赏痛苦，可你却在享受这受痛苦，疯子。"
				},
				new string[]
				{
					"SupremeBossText13",
					"比那些乌合之众更享受死亡，是么？"
				},
				new string[]
				{
					"SupremeBossText14",
					"莫非你有恋死癖？"
				},
				new string[]
				{
					"SupremeBossText15",
					"罢，不再做无谓之举。你来这么多次，或许仅是想看我还会说什么而已。"
				},
				new string[]
				{
					"SupremeBossText16",
					"未死？作弊尔。再来吧，堂堂正正。此乃你之奖励。"
				},
				new string[]
				{
					"SupremeBossText17",
					"死一次？仅此而已？ ...那这是你应得的吧。"
				},
				new string[]
				{
					"SupremeBossText18",
					"死两次，不错，这是你的奖励。"
				},
				new string[]
				{
					"SupremeBossText19",
					"魅力的第三次，这是你的特殊奖励。"
				},
				new string[]
				{
					"EdgyBossText",
					"别得意，小子！"
				},
				new string[]
				{
					"EdgyBossText2",
					"你竟觉得，你可以屠戮...我！？"
				},
				new string[]
				{
					"EdgyBossText3",
					"致命失误！"
				},
				new string[]
				{
					"EdgyBossText4",
					"祝你能舔干净那伤口！"
				},
				new string[]
				{
					"EdgyBossText5",
					"美味..."
				},
				new string[]
				{
					"EdgyBossText6",
					"疼吗？"
				},
				new string[]
				{
					"EdgyBossText7",
					"我并不是针对你，小子。"
				},
				new string[]
				{
					"EdgyBossText8",
					"你真的连躲都不会？"
				},
				new string[]
				{
					"EdgyBossText9",
					"我全身皆是武器..."
				},
				new string[]
				{
					"EdgyBossText10",
					"没完，小鬼！"
				},
				new string[]
				{
					"EdgyBossText11",
					"神，不惧死亡！"
				},
				new string[]
				{
					"EdgyBossText12",
					"虽然你不是神...但我会不惜一切代价吞噬你的精华！"
				},
				new string[]
				{
					"DoGBossText",
					"寒霜之月闪烁着微光。"
				},
				new string[]
				{
					"DoGBossText2",
					"丰饶之月散发出异光"
				},
				new string[]
				{
					"AstralText",
					"一颗彗星于天堂坠落！"
				},
				new string[]
				{
					"AureusBossText",
					"星界的敌人已被赋予权力！"
				},
				new string[]
				{
					"AureusBossText2",
					"从地牢里可以听到一丝轻灵的咔嗒声。"
				},
				new string[]
				{
					"AstralBossText",
					"星星的封印被打破了！你现在可以开采炫星矿了。"
				},
				new string[]
				{
					"DeusText",
					"一颗恒星通过了彗星地产生了恐怖的通道。"
				},
				new string[]
				{
					"DeusText2",
					"彗星地在颤动..."
				},
				new string[]
				{
					"DeusText3",
					"星星之神靠近了..."
				},
				new string[]
				{
					"CalamitasBossText",
					"你低估了我的力量..."
				},
				new string[]
				{
					"CalamitasBossText2",
					"灾厄之眼的兄弟们觉醒了！"
				},
				new string[]
				{
					"CalamitasBossText3",
					"了不起啊，小子，了不起...."
				},
				new string[]
				{
					"SandSharkText",
					"有什么东西在温暖的沙漠中搅动..."
				},
				new string[]
				{
					"SandSharkText2",
					"一个巨大的顶端捕食者接近..."
				},
				new string[]
				{
					"CryogenBossText",
					"极低之灵发怒了！"
				},
				new string[]
				{
					"BloodMoonText",
					"猩红之月正冉冉升起..."
				},
				new string[]
				{
					"DargonBossText",
					"日蚀之阴等待着你"
				},
				new string[]
				{
					"DargonBossText2",
					"我这小龙，觉得你还不值得他出手。你必须获得日蚀之阴的真正力量才有资格一睹他的真身。"
				},
				new string[]
				{
					"RevengeText",
					"复仇模式已开启"
				},
				new string[]
				{
					"RevengeText2",
					"复仇模式已关闭"
				},
				new string[]
				{
					"DeathText",
					"死亡模式已开启，玩的开心~"
				},
				new string[]
				{
					"DeathText2",
					"死亡模式已关闭，不够好玩吗？"
				},
				new string[]
				{
					"ArmageddonText",
					"Boss现在会一击绝杀你。"
				},
				new string[]
				{
					"ArmageddonText2",
					"Boss现在不会一击绝杀你。"
				},
				new string[]
				{
					"DefiledText",
					"你的灵魂归我了..."
				},
				new string[]
				{
					"DefiledText2",
					"你的灵魂又是你的了..."
				},
				new string[]
				{
					"IronHeartText",
					"钢铁之心被激活，别死哦~~"
				},
				new string[]
				{
					"IronHeartText2",
					"钢铁之心已关闭，你现在可以死了。"
				},
				new string[]
				{
					"FlameText",
					"四周的空气逐渐升温。"
				},
				new string[]
				{
					"BossRushStartText",
					"哦？又一位竞争者，好，仪式开始！"
				},
				new string[]
				{
					"BossRushTierOneEndText",
					"哦？还活着？意料之外，令人振奋。不过，不要自满。"
				},
				new string[]
				{
					"BossRushTierTwoEndText",
					"哦？还在坚持？或许你确实同以往的挑战者不一样，有通过的希望。"
				},
				new string[]
				{
					"BossRushTierThreeEndText",
					"哦？你的毅力真是个值得瞩目的优点。如此短之时间到达这里，甚至要超过一位半神。"
				},
				new string[]
				{
					"BossRushTierThreeEndText2",
					"最后一战，希望你仍能保持犀利。"
				},
				new string[]
				{
					"BossRushTierFourEndText",
					"哦？最后一阶段了。便是真神也会艳羡你的无上技艺。"
				},
				new string[]
				{
					"BossRushTierFourEndText2",
					"前进吧，征服吧，直到最后一刻！"
				},
				new string[]
				{
					"BossRushTierFiveEndText",
					"哦？你希望有比这净之石更好的奖励？耐心，挑战者。真正的奖励，马上到来..."
				},
				new string[]
				{
					"BossSpawnText",
					"什么东西过来了..."
				},
				new string[]
				{
					"MeleeLevelUp",
					"近战武器熟练度提升！"
				},
				new string[]
				{
					"MeleeLevelUpFinal",
					"近战武器熟练度已达到最大！"
				},
				new string[]
				{
					"RangedLevelUp",
					"远程武器熟练度提升！"
				},
				new string[]
				{
					"RangedLevelUpFinal",
					"远程武器熟练度已达到最大！"
				},
				new string[]
				{
					"MagicLevelUp",
					"魔法武器熟练度提升！"
				},
				new string[]
				{
					"MagicLevelUpFinal",
					"魔法武器熟练度已达到最大！"
				},
				new string[]
				{
					"SummonLevelUp",
					"召唤武器熟练度提升！"
				},
				new string[]
				{
					"SummonLevelUpFinal",
					"召唤武器熟练度已达到最大！"
				},
				new string[]
				{
					"RogueLevelUp",
					"盗贼武器熟练度提升！"
				},
				new string[]
				{
					"RogueLevelUpFinal",
					"盗贼武器熟练度已达到最大！"
				},
				new string[]
				{
					"OpenSunkenSea",
					"地下沙穴深处传来震荡..."
				},
				new string[]
				{
					"AprilFools",
					"LORDE正在接近..."
				}
			};
		}
		public static void Unload()
		{
			CalamitySupport._localizations = null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000030C8 File Offset: 0x000012C8
		public static void CalamityAddLocalizations()
		{
			CalamitySupport.Load();
			foreach (string[] array in CalamitySupport._localizations)
			{
				ModTranslation modTranslation = ModLoader.GetMod("CalamityMod").CreateTranslation(array[0]);
				modTranslation.SetDefault(array[1]);
				ModLoader.GetMod("CalamityMod").AddTranslation(modTranslation);
			}
			CalamitySupport.Unload();
		}

		public static void CalamityNPCChat()
		{
			bool flag = (Main.player[Main.myPlayer].talkNPC != -1);
			for(int k = 0 ; k < 200 && flag ; k++)
			{
				if(Main.npc[k].type == ModLoader.GetMod("CalamityMod").NPCType("DILF"))
				{
					if(Main.npcChatText == "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!")
					{
						string chatch = "在这片土地上又出现了一些新矿石. 这将让你打造出最强大的武器和盔甲！";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.")
					{
						string chatch = "犽戾武领主拥有着上帝般的力量. 幸运的是他可能不会出全力和你打, 他的攻击对你来说可以说是一击毙命, 所以务必小心";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Draedon's style of confrontation is very...alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.")
					{
						string chatch = "嘉登的作战方式非常...另类, 就是放手不管. 击败他, 你可能需要打败他创造的每个机械玩具";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "With the cosmic steel you can fashion many of your weapons into much more powerful forms.")
					{
						string chatch = "有了宇宙金属, 你可以把你的武器更新到更强力的形态";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Devourer of God’s cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.")
					{
						string chatch = "神明吞噬者的宇宙装甲是独一无二的, 既可以保护他在时空分裂时他的身体不会被撕裂, 也可以让他灵活自如地操控自己的能量";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Devourer of God�s cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.")
					{
						string chatch = "神明吞噬者的宇宙装甲是独一无二的, 既可以保护他在时空分裂时他的身体不会被撕裂, 也可以让他灵活自如地操控自己的能量";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.")
					{
						string chatch = "神明吞噬者相当强力. 但是, 他还年轻, 有勇无谋, 而且非常懒. 也许如果给他时间去成长, 他会成为一个巨大的威胁的";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.")
					{
						string chatch = "啊, 丛林龙亚戎脾气怪异. 你可能会发现他会拒绝使用他的全部力量, 除非你有足够的力量来释放黑暗之日的全部力量";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Rune of Kos holds a significant portion of Providence�s brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.")
					{
						string chatch = "宇宙符文拥有着亵渎天神魔法的重要部分, 很容易和其他的区分开来. 在某些地方激活它会产生一些......危险的后果";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.")
					{
						string chatch = "宇宙符文拥有着亵渎天神魔法的重要部分, 很容易和其他的区分开来. 在某些地方激活它会产生一些......危险的后果";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.")
					{
						string chatch = "真是讽刺, 不是吗, 斯塔提斯正是被他的人民从他的部下那里学来的潜行技艺所打败. 命运无常, 造化弄人啊.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void...I would recommend searching there before taking on the Sentinels.")
					{
						string chatch = "地牢现在似乎更活跃了. 你可能会听到还未离开虚空的愤怒灵魂的低语. 我建议你在与神明吞噬者哨兵交战之前先去那里搜索.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Your adventure focuses to the jungle it seems. Clearing out the infestation of Bumblebirbs that have cropped up is an excellent idea.")
					{
						string chatch = "好像你的探险应该集中在丛林里. 清除突然出现的嗡嗡蜂鸟是一个好主意.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.")
					{
						string chatch = "啊...我能感觉到天气的强烈变化. 你可能想在雨天再到硫磺海去大冒险.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.")
					{
						string chatch = "亵渎之生物现在潜伏在神圣之地和地狱里. 如果你杀死得足够多，把它们的精华聚集在一起，你就能吸引亵渎守卫的注意.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.")
					{
						string chatch = "亵渎守卫会尽一切努力保护他们的天神. 他们为她而死是有道理的，因为他们可以很快复活.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.")
					{
						string chatch = "触摸亵渎天神之物是找死. 遗憾的是犽戾武不认为弄乱了她的东西就能让她显露真身";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.")
					{
						string chatch = "亵渎天神是太阳女神, 月球领主是月亮之神. 他们就如同硬币的正反两面, 在我们的小打小闹中选择中立. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.")
					{
						string chatch = "传说中亵渎天神面对并击败犽戾武和他的部队时，她失去了很多力量，回到了干瘦的形态. 现在的她只拥有她以前的一小部分力量.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.")
					{
						string chatch = "地牢前面的人正在举行一个仪式, 把月球领主关在他的监狱里. 然而, 为了引起犽戾武的注意, 你可能需要打败他们. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.")
					{
						string chatch = "深渊比以前活跃得多. 你也许可以挖掘里面的一些火山碎石. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.")
					{
						string chatch = "瘟疫只是犽戾武授权将城镇夷为平地的众多试验之一. 这可能是他为数不多的因为太可怕而搁置的一个方案. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.")
					{
						string chatch = "你会发现更多的矿石已经被解锁, 因为它们封印的魔法已经被驱散. 其中一些可能需要的不仅仅是矿石本身. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.")
					{
						string chatch = "我建议你把不用的物品留起来. 你永远不知道你是否能在未来把它们合成更强大的武器. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.")
					{
						string chatch = "这些机械生物被击败的时候, 你最好去寻找女巫的弱体克隆, 灾厄之影. 它可能会提供一些有用的武器. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.")
					{
						string chatch = "如果你把一个玩偶带到硫磺火之崖边上你也许能看见在阴影中隐藏的东西";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Brimstone Crags...Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.")
					{
						string chatch = "硫磺火之崖...犽戾武看不起那个地方, 尽一切努力把它夷为平地. 这也许可以解释一些关于他的事情.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The witch just might offer you an opportunity for a challenge if you are willing to fight during the night.")
					{
						string chatch = "如果你愿意在夜里战斗, 女巫可能会给你一个挑战的机会.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "If you�ve gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!")
					{
						string chatch = "如果你已经收集到了那些用来驱动机器人的灵魂, 那么你可以再次前往丛林. 你会和一个强大的敌人战斗, 一旦击败他将释放出丛林的全部炽热. 别小看了！";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!")
					{
						string chatch = "如果你已经收集到了那些用来驱动机器人的灵魂, 那么你可以再次前往丛林. 你会和一个强大的敌人战斗, 一旦击败他将释放出丛林的全部炽热. 别小看了！";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.")
					{
						string chatch = "击败世纪之花和石巨人时要小心. 你可能会在丛林中意外地释放出一个需要处理的新威胁. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard�s idol, the Golem. It�s quite the destructive force.")
					{
						string chatch = "在丛林神庙探险时要小心. 你也许不想打扰蜥蜴神像, 石巨人. 它具有相当大的破坏力.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.")
					{
						string chatch = "在丛林神庙探险时要小心. 你也许不想打扰蜥蜴神像, 石巨人. 它具有相当大的破坏力.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.")
					{
						string chatch = "你听说过佩码·福洛斯特大法师的故事吗? 有传言称他被犽戾武领主关在寒冰监狱里, 也许极地之灵被打败之后你就能释放他. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.")
					{
						string chatch = "有一些关于还不能挖掘的矿石的谣言. 当你击败某些Boss时，你将解除封印这些材料的古老魔法. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.")
					{
						string chatch = "你听说过硫磺火之崖吗? 它曾经是一个伟大的王国, 和我的王国没有太大的不同. 然而, 它也遇到了类似的命运. 我不建议你去那里, 除非你想死的很惨.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.")
					{
						string chatch = "啊, 对, 深渊. 那个的海沟充满了各种强力生物, 它们能在一瞬间吞噬你. 我会先去探索地牢. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.")
					{
						string chatch = "硫磺海非常危险. 有毒的水会灼伤你的皮肤, 但如果你勇敢, 你就能到达深渊, 那里危险和强力武器共存.";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The Sulphurous Seas were created long ago, when Yharim�s dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.")
					{
						string chatch = "硫磺海很久之前就存在了, 那时犽戾武的地牢已经不能容纳更多的尸体了. 许多尸体被扔进海里. 这里, 再加上犽戾武实验时期的严重污染, 把天堂变成了一片废土。";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("CalamityMod").NPCType("DILF") && flag)
					{
						string chatch1 = "留意你在";
						string chatch2= "击杀的生物. 你很可能会释放出一个那里之前更大的威胁. ";
						string chatresult1 = Main.npcChatText.Replace("Be careful what you attack in the ", chatch1);
						string chatresult2 = chatresult1.Replace(". You might just unveil a greater threat than what was there before.", chatch2);
						Main.npcChatText = chatresult2;
					}
					if(Main.npcChatText == "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.")
					{
						string chatch = "散布在大地上的是供奉神灵的神龛. 你可以拿走里面的任何东西, 但有些东西你可能要等很久才能使用. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "I�m assuming you�ve heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.")
					{
						string chatch = "我猜你听说过有关斯塔西斯忍者的传说吧, 有人说, 如果你能打败他家族曾经崇拜的诸神, 你就可以获得他的一些力量. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.")
					{
						string chatch = "我猜你听说过有关斯塔西斯忍者的传说吧, 有人说, 如果你能打败他家族曾经崇拜的诸神, 你就可以获得他的一些力量. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npcChatText == "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.")
					{
						string chatch = "地牢是个黑暗的地方. 我们谁也不知道它的真正用途, 然而, 在犽戾武领主接管它之前, 远古幻海灵巫会用它来做礼拜. ";
						string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
						Main.npcChatText = chatresult;
					}
					if(Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("CalamityMod").NPCType("DILF") && flag)
					{
						string chatch1 = "";
						string chatch2= "在大自然下是非常容易控制和管理的. 然而, 最近的战争和污染打破了这种天平的平衡.";
						string chatresult1 = Main.npcChatText.Replace("The ", chatch1);
						string chatresult2 = chatresult1.Replace(" used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.", chatch2);
						Main.npcChatText = chatresult2;
					}
				}
				if(Main.npc[k].type == ModLoader.GetMod("CalamityMod").NPCType("FAP"))
				{	
					if(Main.npc[Main.player[Main.myPlayer].talkNPC].type == ModLoader.GetMod("CalamityMod").NPCType("FAP") && flag)
					{
						string chatch1 = "你已经失败死亡了";
						string chatch2= "次";
						string chatch3= "次";
						string chatresult1 = Main.npcChatText.Replace("You have failed ", chatch1);
						string chatresult2 = chatresult1.Replace(" times", chatch2);
						string chatresult3 = chatresult2.Replace(" time", chatch3);
						Main.npcChatText = chatresult3;

						if(Main.npcChatText == "Death Count")
						{
							string chatch = "死亡计数";
							string chatresult = Main.npcChatText.Replace(Main.npcChatText, chatch);
							Main.npcChatText = chatresult;
						}

						string B1 = "商店";
						string B2 = "死亡计数";
						NPCLoader.SetChatButtons(ref B1,ref B2);
					}
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private static string[][] _localizations;

		
    }

}