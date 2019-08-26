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
    }
}