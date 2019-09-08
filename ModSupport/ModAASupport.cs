using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod
{
    public class AASupport
	{
        public static void AACalculateLootLoad()
        {
            if(ModLoader.GetMod("AAMod") != null)
			{
				var downed = new List<string>();
				downed.Add("MUSHMAN");
            	downed.Add("GrabbyHands");
            	downed.Add("Hydra");
            	downed.Add("Nacho");
            	downed.Add("Dynaskull");
            	downed.Add("MechBoss");
            	downed.Add("Evil");
            	downed.Add("MoonLord");
            	downed.Add("Equinox");
            	downed.Add("AA");
            	downed.Add("A");
            	downed.Add("SA");
            	downed.Add("Akuma");
            	downed.Add("Yamata");
            	downed.Add("0");
            	downed.Add("Shen");
            	downed.Add("DAA");
            	downed.Add("ShenS");
            	downed.Add("Serpent");
            	downed.Add("JojoReference");
            	downed.Add("Toad");
            	downed.Add("Fungus");
            	downed.Add("IStripe");
            	downed.Add("MStripe");
            	downed.Add("BetterDragonWaifu");
            	downed.Add("TrashDragonWaifu");
            	downed.Add("Sisters");
            	downed.Add("Sag");
            	downed.Add("WorldGenned");
            	downed.Add("Summoned");
            	downed.Add("Rajah");
            	downed.Add("Rajah2");
            	downed.Add("ZUS");
            	downed.Add("Doggo");
            	downed.Add("BirdBitch");
            	downed.Add("BirdBitchA");
            	downed.Add("GimmeGimme");
            	downed.Add("BitchBird");
				int RabbitKills = 0;
            	int SmashDragonEgg = 2;
            	int SmashHydraPod = 2;
            	int squid1 = 0;
            	int squid2 = 0;
            	int squid3 = 0;
            	int squid4 = 0;
            	int squid5 = 0;
            	int squid6 = 0;
            	int squid7 = 0;
           	 	int squid8 = 0;
            	int squid9 = 0;
            	int squid10 = 0;
            	int squid11 = 0;
            	int squid12 = 0;
            	int squid13 = 0;
            	int squid14 = 0;
            	int squid15 = 0;
            	int squid16 = 0;
           		TagCompound tag = new TagCompound {
                {"downed", downed},
				{"MCenter", -Vector2.One},
				{"ICenter", -Vector2.One},
                {"squid1", squid1},
                {"squid2", squid2},
                {"squid3", squid3},
                {"squid4", squid4},
                {"squid5", squid5},
                {"squid6", squid6},
                {"squid7", squid7},
                {"squid8", squid8},
                {"squid9", squid9},
                {"squid10", squid10},
                {"squid11", squid11},
                {"squid12", squid12},
                {"squid13", squid13},
                {"squid14", squid14},
                {"squid15", squid15},
                {"squid16", squid16},
                {"Bunny", RabbitKills},
                {"Egg", SmashDragonEgg},
                {"Pod", SmashHydraPod}
            	};
				ModLoader.GetMod("AAMod").GetModWorld("AAWorld").Load(tag);
				
			}
        }
        public static void AACalculateLootUnLoad()
        {
			if(ModLoader.GetMod("AAMod") != null)
			{
				TagCompound tag = new TagCompound();
				List<string> list = new List<string>();
				ModLoader.GetMod("AAMod").GetModWorld("AAWorld").Load(tag);
			}
        }

        public static string AAZone(Player player)
        {
				string zone = "";
				ModPlayer playerAA = player.GetModPlayer(ModLoader.GetMod("AAMod"), "AAPlayer");
            	bool ZoneMire = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneMire").GetValue(playerAA));
            	bool ZoneInferno = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneInferno").GetValue(playerAA));
            	bool ZoneMush = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneMush").GetValue(playerAA));
            	bool Terrarium = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("Terrarium").GetValue(playerAA));
            	bool ZoneVoid = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneVoid").GetValue(playerAA));
            	bool ZoneRisingMoonLake = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneRisingMoonLake").GetValue(playerAA));
            	bool ZoneRisingSunPagoda = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneRisingSunPagoda").GetValue(playerAA));
            	bool ZoneStars = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneStars").GetValue(playerAA));
            	bool ZoneHoard = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneHoard").GetValue(playerAA));
            	bool ZoneAcropolis = (bool)(ModLoader.GetMod("AAMod").GetPlayer("AAPlayer").GetType().GetField("ZoneAcropolis").GetValue(playerAA));

				if(ZoneMire) zone += "\n潭渊 (远古觉醒)";
				if(ZoneInferno) zone += "\n燎狱 (远古觉醒)";
				if(ZoneMush) zone += "\n红色蘑菇地 (远古觉醒)";
				if(Terrarium) zone += "\n泰拉心球 (远古觉醒)";
				if(ZoneVoid) zone += "\n虚空 (远古觉醒)";
				if(ZoneRisingMoonLake) zone += "\n升月之湖 (远古觉醒)";
				if(ZoneRisingSunPagoda) zone += "\n望日之塔 (远古觉醒)";
				if(ZoneStars) zone += "\n天外星辰 (远古觉醒)";
				if(ZoneHoard) zone += "\n欲望金窟 (远古觉醒)";
				if(ZoneAcropolis) zone += "\n天穹卫城 (远古觉醒)";

				return zone;
        }
    }
}