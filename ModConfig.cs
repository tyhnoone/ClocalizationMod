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
		[Label("辅助文本")]
		[Tooltip("是, 以启用ZZLocalizationMod的辅助文本, 默认为是")]
		public bool uitext;

		[Range(0, 30)]
		[DefaultValue(10)]
		[Label("掉落文本长度")]
		[Tooltip("在物品提示中显示该物品的可掉落怪物列表中的怪物数量, 默认为10")]
		public int droptext;

		[DefaultValue(true)]
		[Label("环境信息")]
		[Tooltip("是, 将显示玩家所处的环境, 默认为是")]
		public bool zonetext;

		[DefaultValue(true)]
		[Label("NPC购买信息")]
		[Tooltip("是, 将显示玩家可购买的npc物品, 默认为是")]
		public bool buytext;
		

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