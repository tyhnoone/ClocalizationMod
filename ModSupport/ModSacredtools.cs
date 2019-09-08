using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod
{
    public class SacredtoolsSupport
	{
        public static void SacredtoolsCalculateLootLoad()
        {
            if(ModLoader.GetMod("SacredTools") != null)
			{
				bool Revengeance = false;
				bool FlariumSpawns = false;
				bool CerniumSpawns = false;
				bool OblivionSpawns = false;
				bool FlameWorld = false;
				bool FrostWorld = false;
				bool PandolarMoveIn = false;
				bool trueMode = false;
				bool TRUEdownedAbaddon = false;
				bool TRUEdownedAraghur = false;
				bool TRUEdownedLunarians = false;
				bool MysteriousGem = false;
				int salvageTimer = 0;
				int erosionStatus = 0;
				List<string> list = new List<string>();
				list.Add("downedAbaddon");
				list.Add("downedRaynare");
				list.Add("downedHarpy");
				list.Add("downedLunarians");
				list.Add("downedChallenger");
				list.Add("downedPumpboi");
				list.Add("downedDecree");
				list.Add("downedGoblinSummoner");
				list.Add("downedAraneas");
				list.Add("downedPrimordia");
				list.Add("downedNihilus");
				list.Add("downedWoF");
				List<string> list2 = new List<string>();
				list2.Add("MoonLordMessage");
				list2.Add("QueenBeeMessage");
				TagCompound tagCompound = new TagCompound();
				tagCompound.Add("downed", list);
				tagCompound.Add("message", list2);
				tagCompound.Add("OblivionSpawns", OblivionSpawns);
				tagCompound.Add("FlariumSpawns", FlariumSpawns);
				tagCompound.Add("FlameWorld", FlameWorld);
				tagCompound.Add("FrostWorld", FrostWorld);
				tagCompound.Add("CerniumSpawns", CerniumSpawns);
				tagCompound.Add("PandolarMoveIn", PandolarMoveIn);
				tagCompound.Add("Revengeance", Revengeance);
				tagCompound.Add("MysteriousGem", MysteriousGem);
				tagCompound.Add("trueMode", trueMode);
				tagCompound.Add("TRUEdownedAbaddon", TRUEdownedAbaddon);
				tagCompound.Add("TRUEdownedAraghur", TRUEdownedAraghur);
				tagCompound.Add("TRUEdownedLunarians", TRUEdownedLunarians);
				tagCompound.Add("salvageTimer", salvageTimer);
				tagCompound.Add("erosionStatus", erosionStatus);
				ModLoader.GetMod("SacredTools").GetModWorld("ModdedWorld").Load(tagCompound);
			}
        }
        public static void SacredToolsCalculateLootUnLoad()
        {
			if(ModLoader.GetMod("SacredTools") != null)
			{
				TagCompound tag = new TagCompound();
				List<string> list = new List<string>();
				ModLoader.GetMod("SacredTools").GetModWorld("ModdedWorld").Load(tag);
			}
        }

        public static string SacredToolsZone(Player player)
        {
				string zone = "";
				ModPlayer playerSacredTools = player.GetModPlayer(ModLoader.GetMod("SacredTools"), "ModdedPlayer");
				bool FlameCrimson = (bool)(ModLoader.GetMod("SacredTools").GetPlayer("ModdedPlayer").GetType().GetField("FlameCrimson").GetValue(playerSacredTools));
				if(FlameCrimson) zone += "\n熔火之地 (圣域)";

				int num6 = (int)player.Center.X / 16;
				int num7 = (int)player.Center.Y / 16;
				if (player.whoAmI == Main.myPlayer && (int)Main.tile[num6, num7].wall == ModLoader.GetMod("SacredTools").WallType("WeaverWall"))
				{
					zone += "\n巨蛛毒洞 (圣域)";
				}

				return zone;
        }
    }
}