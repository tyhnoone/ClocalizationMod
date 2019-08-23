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

namespace CLocalizationMod.NPCs
{
    public class CalamityGlobalNPC : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
           
           if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
                if(ModLoader.GetMod("CalamityMod") != null)
                {
                    if(npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Cnidrion")))
                    {
                        ModNPC NPCname = NPCLoader.GetNPC(npc.type);
                        ModTranslation name = NPCname.DisplayName;
			            name.AddTranslation(GameCulture.Chinese,"卧龙海马");
                    }
                    
                    
                    
                    
                }
            }
			
        }
	}
}