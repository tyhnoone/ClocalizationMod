using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.GameContent.Generation;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace ZZLocalizationMod
{
	public class ZZLocalizationModWorld : ModWorld
	{
		public static int calamityTiles = 0;
		public static int sunkenSeaTiles = 0;
		public static int abyssTiles = 0;
		public static int sulphurTiles = 0;
		public static int astralTiles = 0;

		public static int AquaTiles = 0;
		public static int AquaTiles2 =0;
		public static bool abyssSide = false;
		public static int zoneGranite = 0;
		public static int zoneMarble = 0;
		public static int mireTiles = 0;
		public static int infernoTiles = 0;
		public static int voidTiles = 0;
		public static int mushTiles = 0;
		public static int pagodaTiles = 0;
		public static int lakeTiles = 0;
		public static int terraTiles = 0;
		public static int Radium = 0;
		public static int HoardTiles = 0;
		public static int CloudTiles = 0;


		public override void ResetNearbyTileEffects()
		{
			ZZLocalizationModWorld.calamityTiles = 0;
			ZZLocalizationModWorld.astralTiles = 0;
			ZZLocalizationModWorld.sunkenSeaTiles = 0;
			ZZLocalizationModWorld.sulphurTiles = 0;
			ZZLocalizationModWorld.abyssTiles = 0;
			ZZLocalizationModWorld.AquaTiles = 0;
			ZZLocalizationModWorld.AquaTiles2 = 0;
			ZZLocalizationModWorld.zoneGranite = 0;
			ZZLocalizationModWorld.zoneMarble = 0;
			ZZLocalizationModWorld.mireTiles = 0;
            ZZLocalizationModWorld.infernoTiles = 0;
			ZZLocalizationModWorld.voidTiles = 0;
			ZZLocalizationModWorld.mushTiles = 0;
			ZZLocalizationModWorld.pagodaTiles = 0;
			ZZLocalizationModWorld.lakeTiles = 0;
			ZZLocalizationModWorld.terraTiles = 0;
			ZZLocalizationModWorld.Radium = 0;
			ZZLocalizationModWorld.HoardTiles = 0;
			ZZLocalizationModWorld.CloudTiles = 0;
		}
		public override void TileCountsAvailable(int[] tileCounts)
		{
			//CalamityMod
			if(ModLoader.GetMod("CalamityMod") != null){
			ZZLocalizationModWorld.calamityTiles = tileCounts[ModLoader.GetMod("CalamityMod").TileType("CharredOre")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("BrimstoneSlag")];
			ZZLocalizationModWorld.sunkenSeaTiles = tileCounts[ModLoader.GetMod("CalamityMod").TileType("EutrophicSand")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("Navystone")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("SeaPrism")];
			ZZLocalizationModWorld.abyssTiles = tileCounts[ModLoader.GetMod("CalamityMod").TileType("AbyssGravel")];
			ZZLocalizationModWorld.sulphurTiles = tileCounts[ModLoader.GetMod("CalamityMod").TileType("SulphurousSand")];
			int num = tileCounts[ModLoader.GetMod("CalamityMod").TileType("AstralSand")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("AstralSandstone")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("HardenedAstralSand")];
			int num2 = tileCounts[ModLoader.GetMod("CalamityMod").TileType("AstralIce")];
			Main.sandTiles += num;
			Main.snowTiles += num2;
			ZZLocalizationModWorld.astralTiles = num + num2 + tileCounts[ModLoader.GetMod("CalamityMod").TileType("AstralDirt")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("AstralStone")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("AstralGrass")] + tileCounts[ModLoader.GetMod("CalamityMod").TileType("AstralOre")];
			}
			//ThoriumMod
			if(ModLoader.GetMod("ThoriumMod") != null){
			ZZLocalizationModWorld.AquaTiles = tileCounts[ModLoader.GetMod("ThoriumMod").TileType("MarineRock")];
			ZZLocalizationModWorld.AquaTiles2 = tileCounts[ModLoader.GetMod("ThoriumMod").TileType("MarineRockMoss")];
			ZZLocalizationModWorld.zoneMarble = tileCounts[367];
			ZZLocalizationModWorld.zoneGranite = tileCounts[368];
			}
			//AAMod
			if(ModLoader.GetMod("AAMod") != null){
			ZZLocalizationModWorld.mireTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("MireGrass")]+ tileCounts[ModLoader.GetMod("AAMod").TileType("Depthstone")] + tileCounts[ModLoader.GetMod("AAMod").TileType("Depthsand")] + tileCounts[ModLoader.GetMod("AAMod").TileType("Depthsandstone")] + tileCounts[ModLoader.GetMod("AAMod").TileType("DepthsandHardened")] + tileCounts[ModLoader.GetMod("AAMod").TileType("IndigoIce")];
            ZZLocalizationModWorld.infernoTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("InfernoGrass")]+ tileCounts[ModLoader.GetMod("AAMod").TileType("Torchstone")] + tileCounts[ModLoader.GetMod("AAMod").TileType("Torchsand")] + tileCounts[ModLoader.GetMod("AAMod").TileType("Torchsandstone")] + tileCounts[ModLoader.GetMod("AAMod").TileType("TorchsandHardened")] + tileCounts[ModLoader.GetMod("AAMod").TileType("Torchice")] + tileCounts[ModLoader.GetMod("AAMod").TileType("TorchAsh")];
            ZZLocalizationModWorld.voidTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("Doomstone")] + tileCounts[ModLoader.GetMod("AAMod").TileType("Apocalyptite")];
            ZZLocalizationModWorld.mushTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("Mycelium")];

			ZZLocalizationModWorld.pagodaTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("ScorchedDynastyWoodS")] + tileCounts[ModLoader.GetMod("AAMod").TileType("ScorchedShinglesS")];
            ZZLocalizationModWorld.lakeTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("Darkmud")] + tileCounts[ModLoader.GetMod("AAMod").TileType("AbyssGrass")] + tileCounts[ModLoader.GetMod("AAMod").TileType("AbyssWood")] + tileCounts[ModLoader.GetMod("AAMod").TileType("AbyssWoodSolid")];
            ZZLocalizationModWorld.terraTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("TerraCrystal")] + tileCounts[ModLoader.GetMod("AAMod").TileType("TerraWood")] + tileCounts[ModLoader.GetMod("AAMod").TileType("TerraLeaves")];
            ZZLocalizationModWorld.Radium = tileCounts[ModLoader.GetMod("AAMod").TileType("RadiumOre")];
            ZZLocalizationModWorld.HoardTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("GreedBrick")] + tileCounts[ModLoader.GetMod("AAMod").TileType("GreedStone")] + tileCounts[ModLoader.GetMod("AAMod").TileType("GreedDoorClosed")] + tileCounts[ModLoader.GetMod("AAMod").TileType("GreedDoorOpen")];
            ZZLocalizationModWorld.CloudTiles = tileCounts[ModLoader.GetMod("AAMod").TileType("AcropolisBlock")] + tileCounts[ModLoader.GetMod("AAMod").TileType("AcropolisAltarBlock")] + tileCounts[ModLoader.GetMod("AAMod").TileType("AcropolisClouds")];
			}
		}
	}
}