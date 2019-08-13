using Microsoft.Xna.Framework;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using CLocalizationMod.Items;

namespace CLocalizationMod
{
	public class CLocalizationMod : Mod
	{
		public CLocalizationMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
			};	
			instance = this;
		}

		public static Mod Instance;
		internal static CLocalizationMod instance;
	}
}