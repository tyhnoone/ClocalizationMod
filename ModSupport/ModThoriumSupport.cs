using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod
{
    public class ThoriumSupport
	{
        public static void ThoriumCalculateLootLoad()
        {
            if(ModLoader.GetMod("ThoriumMod") != null)
			{
				List<string> list = new List<string>();
				list.Add("thunderBird");
				list.Add("fallenBeholder");
				list.Add("patchwerk");
				list.Add("lich");
				list.Add("jelly");
				list.Add("skelly");
				list.Add("storm");
				list.Add("scout");
				list.Add("realityBreaker");
				list.Add("depthBoss");
				list.Add("strider");
				list.Add("bloom");
				list.Add("champion");
				list.Add("ogre");
				list.Add("bat");

				TagCompound tag = new TagCompound();
				tag.Add("downed", list);
				tag.Add("valadiumSpawns", 0);
				tag.Add("lodestoneSpawns", 0);
				tag.Add("illumiteSpawns", 0);
				tag.Add("cook1", 0);
				tag.Add("cook2", 0);
				tag.Add("cook3", 0);
				tag.Add("cook4", 0);
				tag.Add("cook5", 0);
				tag.Add("cook6", 0);
				tag.Add("cook7", 0);
				tag.Add("cook8", 0);
				tag.Add("cook9", 0);
				tag.Add("cook10", 0);
				tag.Add("cook11", 0);
				tag.Add("cook12", 0);
				tag.Add("cook13", 0);
				tag.Add("cook14", 0);
				tag.Add("cook15", 0);
				tag.Add("cook16", 0);
				tag.Add("AltarPosition", -Vector2.One);
				tag.Add("CompletedContracts", null);
				ModLoader.GetMod("ThoriumMod").GetModWorld("ThoriumWorld").Load(tag);
				
			}
        }
        public static void ThoriumCalculateLootUnLoad()
        {
			if(ModLoader.GetMod("ThoriumMod") != null)
			{
				TagCompound tag = new TagCompound();
				List<string> list = new List<string>();
				ModLoader.GetMod("ThoriumMod").GetModWorld("ThoriumWorld").Load(tag);
			}
        }

        public static string ThoriumZone(Player player)
        {
				string zone = "";
				if (ZZLocalizationModWorld.AquaTiles + ZZLocalizationModWorld.AquaTiles2 > 700) zone += "\n瑟银水渊";
				return zone;
        }
		public static void Load()
		{
			ThoriumSupport._translations = new string[][]
			{
				new string[]
				{
					"LodestoneWarning1",
					"地脉石撕裂着你的世界!"
				},
				new string[]
				{
					"LodestoneWarning2",
					"大量的地脉石撕裂着你的世界!"
				},
				new string[]
				{
					"ValadiumWarning1",
					"你的世界获得了虚金!"
				},
				new string[]
				{
					"ValadiumWarning2",
					"你的世界获得了大量虚金!"
				},
				new string[]
				{
					"GraniteMarbleWarning",
					"花岗岩和大理石洞穴在你的世界中颤抖..."
				},
				new string[]
				{
					"IllumiteWarning",
					"世纪之花的闪光能量照耀着土地..."
				},
				new string[]
				{
					"AbyssionWarning",
					"水渊深处有东西在搅动..."
				},
				new string[]
				{
					"ExpertAbyssion1",
					"深渊之主的外壳碎裂!"
				},
				new string[]
				{
					"ExpertAbyssion2",
					"深渊之主从它寄居的古老监狱中重获自由!"
				},
				new string[]
				{
					"AbyssionDefeat",
					"水渊的剧毒已经消散..."
				},
				new string[]
				{
					"SpiderDefeat",
					"极地行者已被打败!"
				},
				new string[]
				{
					"SpiderWarning",
					"这个世界的蜘蛛在痛苦中喊叫..."
				},
				new string[]
				{
					"SpiderAppear",
					"八腿怪物正在雪地上徘徊..."
				},
				new string[]
				{
					"PatchDefeat",
					"恐怖的缝合人从这个世界上永远的消失了!"
				},
				new string[]
				{
					"BloomDefeat",
					"稀有的绝命花枯萎腐烂了..."
				},
				new string[]
				{
					"BuriedAppear",
					"英灵遗骸已苏醒!"
				},
				new string[]
				{
					"GraniteAppear",
					"花岗岩流能风暴被释放了!"
				},
				new string[]
				{
					"DiverFree",
					"有什么东西从这个水生怪物体内掉了出来!"
				},
				new string[]
				{
					"RagStart",
					"泰拉瑞亚在颤抖..."
				},
				new string[]
				{
					"RagVictory",
					"现实重归于宁静..."
				}
			};
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000229E File Offset: 0x0000049E
		public static void Unload()
		{
			ThoriumSupport._translations = null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00018E60 File Offset: 0x00017060
		public static void AddLocalizations()
		{
			ThoriumSupport.Load();
			foreach (string[] array in ThoriumSupport._translations)
			{
				ModTranslation modTranslation = ModLoader.GetMod("ThoriumMod").CreateTranslation(array[0]);
				modTranslation.SetDefault(array[1]);
				ModLoader.GetMod("ThoriumMod").AddTranslation(modTranslation);
			}
			ThoriumSupport.Unload();
		}

		// Token: 0x04000049 RID: 73
		private static string[][] _translations;
    }
}