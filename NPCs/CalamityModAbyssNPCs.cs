using ZZLocalizationMod;
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

namespace ZZLocalizationMod.NPCs
{
    public class CalamityGlobalNPC : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
           
           if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
                if(ModLoader.GetMod("CalamityMod") != null)
                {
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticParasite")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"渊海寄生虫");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeBody")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeBodyAlt")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeHead")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeTail")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"渊海灾虫");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticSeekerBody")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticSeekerHead")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticSeekerTail")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"渊海追魂虫");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticUrchin")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"渊海海胆");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Bloatfish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"肿胀翻车鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("BobbitWormHead")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("BobbitWormSegment")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"博比特虫");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("BoxJellyfish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"灯水母");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Catfish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"鲶鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("ChaoticPuffer")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"混乱渊豚");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("ColossalSquid")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"巨像乌贼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Cuttlefish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"红乌贼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("DevilFish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"恶魔鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBody")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBodyAlt")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBodyAltHuge")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmBodyHuge")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmHead"))
                    || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmHeadHuge")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmTail")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("EidolonWyrmTailHuge")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"幻海妖龙");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Flounder")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"比目鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Frogfish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"躄鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("GiantSquid")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"巨大乌贼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Gnasher")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"噬咬龟");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("GulperEelBody")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("GulperEelBodyAlt")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("GulperEelHead")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("GulperEelTail")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"大嘴鳗");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Laserfish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"激光鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("LuminousCorvina")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"流光石首鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("MantisShrimp")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"螳螂虾");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Mauler")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"轰鲨");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("MirageJelly")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"幻海水母");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("MorayEel")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"海鳝");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("OarfishBody")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("OarfishHead")) || npc.type == (ModLoader.GetMod("CalamityMod").NPCType("OarfishTail")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"大嘴鳗");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Reaper")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"猎魂鲨");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("SeaUrchin")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"海胆");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("ToxicMinnow")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"剧毒米诺鱼");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Trasher")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"捣鳄");
                    }
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Viperfish")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"蝰蛇鱼");
                    }
                    
                    
                    
                    
                }
            }
			
        }
	}
}