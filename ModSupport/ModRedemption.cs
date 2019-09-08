using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;
using Terraria.UI.Chat;

namespace ZZLocalizationMod
{
    public class ModRedemption
	{
        public static void ModRedemptionCalculateLootLoad()
        {
            if(ModLoader.GetMod("Redemption") != null)
			{
				List<string> list = new List<string>();
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				bool flag6 = false;
				bool flag7 = false;
				bool flag8 = false;
				bool flag9 = false;
				bool flag10 = false;
				bool flag11 = false;
				bool flag12 = false;
				bool flag13 = false;
				bool flag14 = false;
				bool flag15 = false;
				bool flag16 = false;
				bool flag17 = false;
				bool flag18 = false;
				bool flag19 = false;
				bool flag20 = false;
				bool flag21 = false;
				bool flag22 = false;
				bool flag23 = false;
				list.Add("KingChicken");
				list.Add("TheKeeper");
				list.Add("XenomiteCrystalPhase2");
				list.Add("InfectedEye");
				list.Add("StrangePortal");
				list.Add("VlitchCleaver");
				list.Add("VlitchWormHead");
				list.Add("DarkSlime");
				list.Add("KSEntrance");
				flag = true;
				flag2 = true;
				flag3 = true;
				flag4 = true;
				flag5 = true;
				list.Add("OmegaOblitDamaged");
				list.Add("SkullDigger");
				list.Add("SunkenCaptain");
				flag6 = true;
				flag7 = true;
				flag8 = true;
				flag9 = true;
				flag10 = true;
				flag11 = true;
				flag12 = true;
				list.Add("Blisterface");
				list.Add("Stage2ScientistBoss");
				list.Add("Stage3Scientist");
				flag13 = true;
				flag14 = true;
				flag15 = true;
				flag16 = true;
				flag17 = true;
				flag18 = true;
				flag19 = true;
				flag20 = true;
				flag21 = true;
				flag22 = true;
				list.Add("IrradiatedBehemoth");
				list.Add("MACEProjectHead");
				list.Add("PatientZero");
				list.Add("Nebuleus");
				flag23 = true;
				list.Add("EaglecrestGolem");
				list.Add("EaglecrestGolemPZ");
				list.Add("Thorn");
				list.Add("ThornPZ");
				TagCompound tagCompound = new TagCompound();
				tagCompound.Add("downed", list);
				tagCompound.Add("sapphiron", flag);
				tagCompound.Add("scarlion", flag2);
				tagCompound.Add("dragore", flag3);
				tagCompound.Add("deathSlayer", flag4);
				tagCompound.Add("newbFound", flag5);
				tagCompound.Add("wasteland", flag6);
				tagCompound.Add("starliteGen", flag7);
				tagCompound.Add("girTalk1", flag8);
				tagCompound.Add("girTalk2", flag9);
				tagCompound.Add("girTalk3", flag10);
				tagCompound.Add("labSafe1", flag11);
				tagCompound.Add("infection1", flag12);
				tagCompound.Add("labA1", flag13);
				tagCompound.Add("labA2", flag14);
				tagCompound.Add("labA3", flag15);
				tagCompound.Add("labA4", flag16);
				tagCompound.Add("labA5", flag17);
				tagCompound.Add("labA6", flag18);
				tagCompound.Add("labA7", flag19);
				tagCompound.Add("pzMessage", flag20);
				tagCompound.Add("tbotLabLasers", flag22);
				tagCompound.Add("keeperS", flag21);
				tagCompound.Add("deathNeb", flag23);
				tagCompound.Add("downedChickenInv", true);
				tagCompound.Add("downedChickenInvPZ", true);
				tagCompound.Add("redePoints", 0);

				ModLoader.GetMod("Redemption").GetModWorld("RedeWorld").Load(tagCompound);
			}
        }
        public static void ModRedemptionCalculateLootUnLoad()
        {
			if(ModLoader.GetMod("Redemption") != null)
			{
				TagCompound tag = new TagCompound();
				List<string> list = new List<string>();
				ModLoader.GetMod("Redemption").GetModWorld("RedeWorld").Load(tag);
			}
        }

        public static string ModRedemptionZone(Player player)
        {
				string zone = "";
				ModPlayer playerRedemption = player.GetModPlayer(ModLoader.GetMod("Redemption"), "RedePlayer");
				bool ZoneXeno = (bool)(ModLoader.GetMod("Redemption").GetPlayer("RedePlayer").GetType().GetField("ZoneXeno").GetValue(playerRedemption));
				bool ZoneLab = (bool)(ModLoader.GetMod("Redemption").GetPlayer("RedePlayer").GetType().GetField("ZoneLab").GetValue(playerRedemption));
				if(ZoneXeno) zone += "\n感染废土 (救赎)";
				if(ZoneLab) zone += "\n废弃实验室 (救赎)";

				return zone;
        }

		private static string[][] _translations;

		public static void Load()
		{
			ModRedemption._translations = new string[][]
			{
				new string[]
				{
					"DruidicOre",
					"督伊德的能量涌向这个世界的矿石"
				},
				new string[]
				{
					"DragonLeadMessage",
					"洞穴被龙骨加热...."
				},
				new string[]
				{
					"InfectionMessage1",
					"感染开始了..."
				},
				new string[]
				{
					"LabIsSafe",
					"感染在蔓延..."
				},
				new string[]
				{
					"GrowingInfection",
					"实验室的防御系统发生了故障..."
				},
				new string[]
				{
					"Lasers1",
					"激光系统#1已经被解除......"
				},
				new string[]
				{
					"Lasers2",
					"激光系统#2已经被解除......"
				},
				new string[]
				{
					"Lasers3",
					"激光系统#3已经被解除......"
				},
				new string[]
				{
					"Lasers4",
					"激光系统#4已经被解除......"
				},
				new string[]
				{
					"Lasers5",
					"激光系统#5已经被解除......"
				},
				new string[]
				{
					"Lasers6",
					"激光系统#6已经被解除......"
				},
				new string[]
				{
					"Lasers7",
					"激光系统#7已经被解除......"
				},
				new string[]
				{
					"PatientZeroMessage1",
					"随着感染的停止, 强大的埃匹多特拉生物回归了......"
				},
				new string[]
				{
					"PatientZeroMessage2",
					"被诅咒的猩红之石在地狱的灰烬中形成..."
				},
				new string[]
				{
					"PatientZeroMessage3",
					"空中满是宇宙生物..."
				},
				new string[]
				{
					"PatientZeroMessage4",
					"森林的诅咒从沉睡中苏醒..."
				},
				new string[]
				{
					"PatientZeroMessage5",
					"远古的存在于洞穴中漫步..."
				},
			};
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000229E File Offset: 0x0000049E
		public static void Unload()
		{
			ModRedemption._translations = null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00018E60 File Offset: 0x00017060
		public static void AddLocalizations()
		{
			ModRedemption.Load();
			foreach (string[] array in ModRedemption._translations)
			{
				ModTranslation modTranslation = ModLoader.GetMod("Redemption").CreateTranslation(array[0]);
				modTranslation.SetDefault(array[1]);
				ModLoader.GetMod("Redemption").AddTranslation(modTranslation);
			}
			ModRedemption.Unload();
		}

		public static void ModRedemptionChat()
		{
			
		}
		public static void ModRedemptionCombat()
		{
			for (int i = 0; i < 100; i++)
			{
				if (Main.combatText[i].text == "You fool! You idiot!" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "大傻X！臭傻B！";
                }
				if (Main.combatText[i].text == "Did you really think that dumb chicken was king?" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "你还真以为那只呆鸡是王？";
                }
				if (Main.combatText[i].text == "IT'S A CHICKEN, CHICKENS ARE FEMALE, FOOOOOOOOOOOOL!" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "那就是只鸡，还是母的，傻XXXXXXXXXXXX！";
                }
				if (Main.combatText[i].text == "I am the true 'King Chicken'! Or 'King Rooster' to be more accurate." && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "我才是真“鸡王”! 准确说是“公鸡王”";
                }
				if (Main.combatText[i].text == "So fight me, and feel the 'Wrath of the Rooster'!" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "那和我打，就得领略一下我“公鸡王之怒”";
                }
				if (Main.combatText[i].text == "You sure are taking your time to kill me." && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "想杀我，你这是浪费时间";
                }
				if (Main.combatText[i].text == "You fool... You dare think you can kill me?" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "你个傻X！你还想杀了我？";
                }
				if (Main.combatText[i].text == "I am the Mighty King Chicken, and I have come to annihilate you!" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "我就是无敌鸡王，我是来消灭你的";
                }
				if (Main.combatText[i].text == "So face me, mortal! And accept your fate!" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "所以面对我，凡人！然后接受你的命运！";
                }
				if (Main.combatText[i].text == "Stubborn fool... Are you letting me make the first move?" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "呆住的傻子...你还想让我先动手？";
                }
				if (Main.combatText[i].text == "So be it! A GOD DOES NOT FEAR DEATH!" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "那好！ 神 不 惧 死 亡！";
                }
				if (Main.combatText[i].text == "*pecks gracefully*" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "*华丽啄击*";
                }
				if (Main.combatText[i].text == "You still stand before me?" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "你怎么还能站在我面前？";
                }
				if (Main.combatText[i].text == "*clucks impatiently*" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "狂怒咯咯哒";
                }
				if (Main.combatText[i].text == "You bore me, mortal! I shall be gone, but I will return!   ...   Maybe." && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "你可真烦，凡人！我要走了，但我会回来！......也许";
                }
				if (Main.combatText[i].text == "*clucks a goodbye*" && Main.combatText[i].active)
				{
                    Main.combatText[i].text = "*再见一咯*";
                }
			}
		}
    }
}