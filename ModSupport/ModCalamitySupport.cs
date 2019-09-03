
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;
using Terraria.Localization;

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
				if (ZZLocalizationModWorld.calamityTiles > 50) zone += "\n硫磺火之崖 (灾厄)";
				if (!player.ZoneDungeon && (ZZLocalizationModWorld.astralTiles > 950 || (player.ZoneSnow && ZZLocalizationModWorld.astralTiles > 300))) zone += "\n星幻之地 (灾厄)";
				if (ZZLocalizationModWorld.sunkenSeaTiles > 150) zone += "\n沉沦之渊 (灾厄)";
				Point point = Utils.ToTileCoordinates(player.Center);
				int maxTilesX = Main.maxTilesX;
				int maxTilesY = Main.maxTilesY;
				int num = maxTilesX / 2;
				int num2 = maxTilesY - 250;
				int num3 = ZZLocalizationModWorld.abyssSide ? (num - (num - 135)) : (num + (num - 135));
				bool flag = false;
				bool flag2 = false;
				bool flag3 = point.Y <= num2;
				if (ZZLocalizationModWorld.abyssSide)
				{
					if (point.X < 380)
					{
						flag2 = true;
					}
					if (point.X < num3 + 80)
					{
						flag = true;
					}
				}
				else
				{
					if (point.X > Main.maxTilesX - 380)
					{
						flag2 = true;
					}
					if (point.X > num3 - 80)
					{
						flag = true;
					}
				}
				bool ZoneAbyss = ((double)point.Y > Main.rockLayer - (double)maxTilesY * 0.05 && !player.lavaWet && !player.honeyWet && flag3 && flag);
				bool ZoneAbyssLayer1 = (ZoneAbyss && (double)point.Y <= Main.rockLayer + (double)maxTilesY * 0.03);
				bool ZoneAbyssLayer2 = (ZoneAbyss && (double)point.Y > Main.rockLayer + (double)maxTilesY * 0.03 && (double)point.Y <= Main.rockLayer + (double)maxTilesY * 0.14);
				bool ZoneAbyssLayer3 = (ZoneAbyss && (double)point.Y > Main.rockLayer + (double)maxTilesY * 0.14 && (double)point.Y <= Main.rockLayer + (double)maxTilesY * 0.26);
				bool ZoneAbyssLayer4 = (ZoneAbyss && (double)point.Y > Main.rockLayer + (double)maxTilesY * 0.26);
				bool ZoneSulphur = ((ZZLocalizationModWorld.sulphurTiles > 30 || (player.ZoneOverworldHeight && flag2)) && !ZoneAbyss);
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
		}

		// Token: 0x04000001 RID: 1
		private static string[][] _localizations;
    }

}