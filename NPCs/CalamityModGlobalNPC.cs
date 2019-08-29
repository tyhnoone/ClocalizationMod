using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.NPCs
{
	// Token: 0x02000024 RID: 36
	public class CalamityModGlobalNPC : GlobalNPC
	{
		public override void SetDefaults(NPC npc)
		{
		}
		// Token: 0x06000048 RID: 72 RVA: 0x000069D0 File Offset: 0x00004BD0
		public override void GetChat(NPC npc, ref string chat)
		{
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if(chat == "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!")
				{
					string chatch = "要是酸雨继续下的话，那这的土块肯定就会因为腐烂而流失";
					string chatresult = chat.Replace(chat, chatch);
					chat = chatresult;
				}
				if(chat == "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.")
				{
					string chatch = "一夜比一夜让人不安. 我感觉一种未知恐惧的存在监视着你的一举一动";
					string chatresult = chat.Replace(chat, chatch);
					chat = chatresult;
				}
				if(chat == "Is it me or are your weapons getting bigger and bigger?")
				{
					string chatch = "是我越来越小了还是你的武器越来越大了";
					string chatresult = chat.Replace(chat, chatch);
					chat = chatresult;
				}
				if(chat == "Are you daft?! Turn off those lamps!")
				{
					string chatch = "你疯了吗？ 快把这些灯都关上！";
					string chatresult = chat.Replace(chat, chatch);
					chat = chatresult;
				}
				if(chat == "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.")
				{
					string chatch = "我敢肯定那是我见过的最大的蛾怪. 你需要一把大枪才能打下来其中一只";
					string chatresult = chat.Replace(chat, chatch);
					chat = chatresult;
				}
				if(chat == "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?")
				{
					string chatch = "这次的日食中，蛾怪身上散发着日蚀之阴的能量。啊，随着你的脚步，蛾怪也在变强......嗯..... 亚戎还有什么保留实力？";
					string chatresult = chat.Replace(chat, chatch);
					chat = chatresult;
				}
				
			}
		}
	}
}
