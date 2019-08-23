using CLocalizationMod;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Terraria;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using System.Threading;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.ModLoader.Audio;
using Terraria.ModLoader.Core;
using Terraria.ModLoader.Exceptions;
using Terraria.ModLoader.IO;
using Terraria.UI;
using Terraria.ModLoader;
using Terraria.ID;

namespace CLocalizationMod.Tiles
{
    public class CalamityGlobalTiles : GlobalTile
    {
        public override void SetDefaults()
        {
                if(ModLoader.GetMod("CalamityMod") != null)
                {
                        ModTile tile = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("DraedonsForge"));
                        ModTranslation DraedonsForge = tile.CreateMapEntryName();
		        DraedonsForge.AddTranslation(GameCulture.Chinese, "嘉登熔炉");
                        tile.AddMapEntry(new Color(0, 255, 0), DraedonsForge);

                        ModTile tile2 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("AncientAltar"));
                        ModTranslation AncientAltar = tile2.CreateMapEntryName();
		        AncientAltar.AddTranslation(GameCulture.Chinese, "硫古铸祭台");
                        tile2.AddMapEntry(new Color(191, 142, 111), AncientAltar);

                        ModTile tile3 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("AshenAltar"));
                        ModTranslation AshenAltar = tile3.CreateMapEntryName();
		        AshenAltar.AddTranslation(GameCulture.Chinese, "余烬铸祭台");
                        tile3.AddMapEntry(new Color(191, 142, 111), AshenAltar);

                        ModTile tile4 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("BotanicPlanter"));
                        ModTranslation BotanicPlanter = tile4.CreateMapEntryName();
		        BotanicPlanter.AddTranslation(GameCulture.Chinese, "蒿蔓培植基");
                        tile4.AddMapEntry(new Color(191, 142, 111), BotanicPlanter);

                        ModTile tile5 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("EutrophicCrafting"));
                        ModTranslation EutrophicCrafting = tile5.CreateMapEntryName();
		        EutrophicCrafting.AddTranslation(GameCulture.Chinese, "富养渊制作台");
                        tile5.AddMapEntry(new Color(191, 142, 111), EutrophicCrafting);
                        
                        ModTile tile6 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("PlagueInfuser"));
                        ModTranslation PlagueInfuser = tile6.CreateMapEntryName();
		        PlagueInfuser.AddTranslation(GameCulture.Chinese, "瘟疫注射机");
                        tile6.AddMapEntry(new Color(191, 142, 111), PlagueInfuser);

                        ModTile tile7 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("ProfanedBasin"));
                        ModTranslation ProfanedBasin = tile7.CreateMapEntryName();
		        ProfanedBasin.AddTranslation(GameCulture.Chinese, "渎神坩埚");
                        tile7.AddMapEntry(new Color(191, 142, 111), ProfanedBasin);

                        ModTile tile8 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("SilvaBasin"));
                        ModTranslation SilvaBasin = tile8.CreateMapEntryName();
		        SilvaBasin.AddTranslation(GameCulture.Chinese, "闪耀金羽操作机");
                        tile8.AddMapEntry(new Color(191, 142, 111), SilvaBasin);

                        ModTile tile9 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("StaticRefiner"));
                        ModTranslation StaticRefiner = tile9.CreateMapEntryName();
		        StaticRefiner.AddTranslation(GameCulture.Chinese, "静态凝胶精炼机");
                        tile9.AddMapEntry(new Color(191, 142, 111), StaticRefiner);

                        ModTile tile10 = TileLoader.GetTile(ModLoader.GetMod("CalamityMod").TileType("VoidCondenser"));
                        ModTranslation VoidCondenser = tile10.CreateMapEntryName();
		        VoidCondenser.AddTranslation(GameCulture.Chinese, "寂渊冷凝机");
                        tile10.AddMapEntry(new Color(191, 142, 111), VoidCondenser);
                    
                    
                    
                }
			
        }
	}
}