using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod
{
    public class CalamitySupport
	{
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
				list.Add("astralMeteor");
				list.Add("astralMeteor2");
				list.Add("astralMeteor3");
				list.Add("hardBoss");
				list.Add("polterghast");
				list.Add("lorde");
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
    }
}