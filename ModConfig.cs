using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;
using Terraria.Localization;

namespace ZZLocalizationMod
{
	public class ModConfiguration : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;
		
		[DefaultValue(true)]
		[Label("ZZLocalizationMod辅助文本")]
		[Tooltip("是, 以启用ZZLocalizationMod的辅助文本")]
		public bool uitext;

		[DefaultValue(true)]
		[Label("ZZLocalizationMod掉落文本")]
		[Tooltip("是, 将在物品提示中显示该物品的可掉落怪物")]
		public bool droptext;
		

		public override ModConfig Clone() {
			var clone = (ModConfiguration)base.Clone();
			return clone;
		}

		public override void OnLoaded() 
		{
			ZZLocalizationMod.modConfiguration = this;
		}

	}
}