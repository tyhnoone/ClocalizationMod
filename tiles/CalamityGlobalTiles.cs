using System;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Tiles
{
	// Token: 0x02000006 RID: 6
	public class CalamityGlobalTiles : GlobalTile
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002A20 File Offset: 0x00000C20
		public override void SetDefaults()
		{
			
				
				
			if (ModLoader.GetMod("CalamityMod") != null)
			{


				ModTile tile = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("DraedonsForge"));
				ModTranslation DraedonsForge = tile.CreateMapEntryName(null);
				DraedonsForge.AddTranslation(GameCulture.Chinese, "嘉登熔炉");
				tile.AddMapEntry(new Color(0, 255, 0), DraedonsForge);
				ModTile tile2 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("AncientAltar"));
				ModTranslation AncientAltar = tile2.CreateMapEntryName(null);
				AncientAltar.AddTranslation(GameCulture.Chinese, "硫古铸祭台");
				tile2.AddMapEntry(new Color(191, 142, 111), AncientAltar);
				ModTile tile3 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("AshenAltar"));
				ModTranslation AshenAltar = tile3.CreateMapEntryName(null);
				AshenAltar.AddTranslation(GameCulture.Chinese, "余烬铸祭台");
				tile3.AddMapEntry(new Color(191, 142, 111), AshenAltar);
				ModTile tile4 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("BotanicPlanter"));
				ModTranslation BotanicPlanter = tile4.CreateMapEntryName(null);
				BotanicPlanter.AddTranslation(GameCulture.Chinese, "蒿蔓培植基");
				tile4.AddMapEntry(new Color(191, 142, 111), BotanicPlanter);
				ModTile tile5 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("EutrophicCrafting"));
				ModTranslation EutrophicCrafting = tile5.CreateMapEntryName(null);
				EutrophicCrafting.AddTranslation(GameCulture.Chinese, "富养渊制作台");
				tile5.AddMapEntry(new Color(191, 142, 111), EutrophicCrafting);
				ModTile tile6 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("PlagueInfuser"));
				ModTranslation PlagueInfuser = tile6.CreateMapEntryName(null);
				PlagueInfuser.AddTranslation(GameCulture.Chinese, "瘟疫注射机");
				tile6.AddMapEntry(new Color(191, 142, 111), PlagueInfuser);
				ModTile tile7 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("ProfanedBasin"));
				ModTranslation ProfanedBasin = tile7.CreateMapEntryName(null);
				ProfanedBasin.AddTranslation(GameCulture.Chinese, "渎神坩埚");
				tile7.AddMapEntry(new Color(191, 142, 111), ProfanedBasin);
				ModTile tile8 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("SilvaBasin"));
				ModTranslation SilvaBasin = tile8.CreateMapEntryName(null);
				SilvaBasin.AddTranslation(GameCulture.Chinese, "闪耀金羽操作机");
				tile8.AddMapEntry(new Color(191, 142, 111), SilvaBasin);
				ModTile tile9 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("StaticRefiner"));
				ModTranslation StaticRefiner = tile9.CreateMapEntryName(null);
				StaticRefiner.AddTranslation(GameCulture.Chinese, "静态凝胶精炼机");
				tile9.AddMapEntry(new Color(191, 142, 111), StaticRefiner);
				ModTile tile10 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("VoidCondenser"));
				ModTranslation VoidCondenser = tile10.CreateMapEntryName(null);
				VoidCondenser.AddTranslation(GameCulture.Chinese, "寂渊冷凝机");
				tile10.AddMapEntry(new Color(191, 142, 111), VoidCondenser);
				ModTile tile11 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("AstralOre"));
				ModTranslation AstralOre = tile11.CreateMapEntryName(null);
				AstralOre.AddTranslation(GameCulture.Chinese, "炫星矿");
				tile11.AddMapEntry(new Color(255, 153, 255), AstralOre);
				ModTile tile12 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("AerialiteOre"));
				ModTranslation AerialiteOre = tile12.CreateMapEntryName(null);
				AerialiteOre.AddTranslation(GameCulture.Chinese, "天蓝矿");
				tile12.AddMapEntry(new Color(0, 255, 255), AerialiteOre);
				ModTile tile13 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("AuricOre"));
				ModTranslation AuricOre = tile13.CreateMapEntryName(null);
				AuricOre.AddTranslation(GameCulture.Chinese, "圣金源矿");
				tile13.AddMapEntry(new Color(255, 200, 0), AuricOre);
				ModTile tile14 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("ChaoticOre"));
				ModTranslation ChaoticOre = tile14.CreateMapEntryName(null);
				ChaoticOre.AddTranslation(GameCulture.Chinese, "混乱矿");
				tile14.AddMapEntry(new Color(255, 0, 0), ChaoticOre);
				ModTile tile15 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("CharredOre"));
				ModTranslation CharredOre = tile15.CreateMapEntryName(null);
				CharredOre.AddTranslation(GameCulture.Chinese, "焦炭矿");
				tile15.AddMapEntry(new Color(128, 0, 0), CharredOre);
				ModTile tile16 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("CryonicOre"));
				ModTranslation CryonicOre = tile16.CreateMapEntryName(null);
				CryonicOre.AddTranslation(GameCulture.Chinese, "寒元矿");
				tile16.AddMapEntry(new Color(0, 0, 150), CryonicOre);
				ModTile tile17 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("ExodiumOre"));
				ModTranslation ExodiumOre = tile17.CreateMapEntryName(null);
				ExodiumOre.AddTranslation(GameCulture.Chinese, "天外星簇");
				tile17.AddMapEntry(new Color(51, 48, 68), ExodiumOre);
				ModTile tile18 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("PerennialOre"));
				ModTranslation PerennialOre = tile18.CreateMapEntryName(null);
				PerennialOre.AddTranslation(GameCulture.Chinese, "亘青矿");
				tile18.AddMapEntry(new Color(200, 250, 100), PerennialOre);
				ModTile tile19 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("UelibloomOre"));
				ModTranslation UelibloomOre = tile19.CreateMapEntryName(null);
				UelibloomOre.AddTranslation(GameCulture.Chinese, "龙蒿矿");
				tile19.AddMapEntry(new Color(0, 255, 0), UelibloomOre);
			}
		}
	}
}
