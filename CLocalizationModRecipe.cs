using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;
using Terraria.Localization;

namespace CLocalizationMod
{
    public class CLocalizationModRecipe
    {
        private static ModRecipe GetNewRecipe()
        {
            return new ModRecipe(CLocalizationMod.instance);
        }
        //public static void AddRecipes()
        //{

        //    ModRecipe recipe = GetNewRecipe();
        //    recipe.SetResult((ModLoader.GetMod("CalamityMod").ItemType("AmidiasSpark")), 1);
        //    recipe.AddRecipe();
        //}
    }
}

