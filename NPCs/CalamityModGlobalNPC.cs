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
		
		// Token: 0x06000048 RID: 72 RVA: 0x000069D0 File Offset: 0x00004BD0
		public override void GetChat(NPC npc, ref string chat)
		{
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == 17)
				{
					if(chat == "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!")
					{
						string chatch = "要是酸雨继续下的话，那这的土块肯定就会因为腐烂而流失";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Are you daft?! Turn off those lamps!")
					{
						string chatch = "你疯了吗？ 快把这些灯都关上！";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.")
					{
						string chatch = "一夜比一夜让人不安. 我感觉一种未知恐惧的存在监视着你的一举一动";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 19)
				{
					if(chat == "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.")
					{
						string chatch = "我敢肯定那是我见过的最大的蛾怪. 你需要一把大枪才能打下来其中一只";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Is it me or are your weapons getting bigger and bigger?")
					{
						string chatch = "是我越来越小了还是你的武器越来越大了";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 20)
				{
							
					if(chat == "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?")
					{
						string chatch = "这次的日食中，蛾怪身上散发着日蚀之阴的能量。啊，随着你的脚步，蛾怪也在变强......嗯..... 亚戎还有什么保留实力？";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?")
					{
						string chatch = "那个星球传染病像一个水泡一样在这片土地上出现. 这个世界上又多了一种邪恶感染的形式? ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 22)
				{
							
					if(chat == "Could you be so kind as to, ah...check hell for me...? I left someone I kind of care about down there.")
					{
						string chatch = "你能不能好心的..啊...去地狱帮我瞅瞅...? 我一个很关心的“人”落在那了.";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.")
					{
						string chatch = "我脊椎发凉地抖了一下, 好像一颗流星刚刚落下, 星体间成千上万的无辜生物变成了怪物";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.")
					{
						string chatch = "地牢似乎比平时更不安分, 当心里面那些强大的怪物";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!")
					{
						string chatch = "好像杀了那个大蝴蝶之后, 它的生命融入了神圣之地, 去那瞅瞅看看你能找到什么!";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!")
					{
						string chatch = "我听说有一个反物质的入口, 吸收着它在地牢中所能看到的一切, 试试在那用一下宇宙符文！";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}			
					if(chat == "Who you gonna call?")
					{
						string chatch = "你想叫谁? ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Those screams...I�m not sure why, but I feel like a nameless fear has awoken in my heart.")
					{
						string chatch = "那些尖叫声...我不确定为什么, 但是我内心感到一种无名的恐惧";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Those screams...I'm not sure why, but I feel like a nameless fear has awoken in my heart.")
					{
						string chatch = "那些尖叫声...我不确定为什么, 但是我内心感到一种无名的恐惧";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "I can faintly hear ghostly shrieks from the dungeon...and not ones I�m familiar with at all. Just what is going on in there?")
					{
						string chatch = "我能隐约听到地牢里鬼鬼祟祟的尖叫声......我根本不熟悉. 到底发生了什么？";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "I can faintly hear ghostly shrieks from the dungeon...and not ones I'm familiar with at all. Just what is going on in there?")
					{
						string chatch = "我能隐约听到地牢里鬼鬼祟祟的尖叫声......我根本不熟悉. 到底发生了什么？";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Whatever that thing was, I�m glad it�s gone now.")
					{
						string chatch = "管他是什么, 没了我就挺高兴";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Whatever that thing was, I'm glad it's gone now.")
					{
						string chatch = "管他是什么, 没了我就挺高兴";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "God Slayer Dynamite? Boy do I like the sound of that!")
					{
						string chatch = "弑神炸药? 小子我很喜欢那声音";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "What do you mean your traps aren't making the cut? Don't look at me!")
					{
						string chatch = "你是说你的计划没成功? 别看我! ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Um...should my nightlight be on?")
					{
						string chatch = "啊....我是不是应该开着晚上的灯";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				if (npc.type == 124)
				{
					if(NPC.FindFirstNPC(ModLoader.GetMod("CalamityMod").NPCType("FAP"))!=-1)
					{
						string chatch1 = "好吧, 我喜欢";
						string chatch2 = ", 但是我, 啊...心里已经有别人了.";
						string chatresult1 = chat.Replace("Well, I like ", chatch1);
						string chatresult2 = chatresult1.Replace(", but I, ah...I have my eyes on someone else.", chatch2);
						chat = chatresult2;
					}
				}
				if (npc.type == 108)
				{
					if(NPC.FindFirstNPC(ModLoader.GetMod("CalamityMod").NPCType("DILF"))!=-1)
					{
						string chatch1 = "我想让";
						string chatch2 = "给我冻一根冰柱.";
						string chatresult1 = chat.Replace("I'd let ", chatch1);
						string chatresult2 = chatresult1.Replace(" coldheart MY icicle.", chatch2);
						chat = chatresult2;
					}
					if(chat == "Space just got way too close for comfort.")
					{
						string chatch = "距离太近了, 不舒服";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 107)
				{
					if(chat == "You know...we haven't had an invasion in a while...")
					{
						string chatch = "你知道......我们好久没有入侵了......";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 207)
				{
					if(chat == "Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!")
					{
						string chatch = "你看到洞穴里的宝石生物了吗? 他们的颜色简直令人叹为观止! ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(NPC.FindFirstNPC(ModLoader.GetMod("CalamityMod").NPCType("DILF"))!=-1)
					{
						string chatch1 = "你觉得";
						string chatch2 = "知不知道怎么样“let it go”?";
						string chatresult1 = chat.Replace("Do you think ", chatch1);
						string chatresult2 = chatresult1.Replace(" knows how to 'let it go?'", chatch2);
						chat = chatresult2;
					}
				}
				if (npc.type == 208)
				{
					if(NPC.FindFirstNPC(ModLoader.GetMod("CalamityMod").NPCType("FAP"))!=-1)
					{
						string chatch1 = "我有一种感觉, 有";
						string chatch2 = "在旁边我们会有一个非常棒的聚会";
						string chatresult1 = chat.Replace("I have a feeling we're going to have absolutely fantastic parties with ", chatch1);
						string chatresult2 = chatresult1.Replace(" around!", chatch2);
						chat = chatresult2;
					}
					if(chat == "I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.")
					{
						string chatch = "我想让我的灯光道具变成一个杀虫器. 至少怪物们会很享受. ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Ooh! I love parties where everyone wears a scary costume!")
					{
						string chatch = "哦! 我喜欢每个人都穿着恐怖服装的派对! ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 209)
				{
					if(chat == "All these moments will be lost in time. Like tears...in the rain.")
					{
						string chatch = "所有的时刻将在时间中迷失. 就像在雨中...的眼泪. ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Always shoot for the moon! It has clearly worked before.")
					{
						string chatch = "一直朝着月亮射击! 它显然之前起过作用.";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Draedon? He's...a little 'high octane' if you know what I mean.")
					{
						string chatch = "嘉登? 如果你懂我在说什么的话, 他有点“高辛烷”";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!")
					{
						string chatch = "那些超巨大的虫子威胁着丛林.....你们这些人中肯定会有人把他们清理掉的";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 229)
				{
					if(chat == "Aye, I�ve heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.")
					{
						string chatch = "是的, 我听说过一个神话中的海洋生物, 用诱人的声音唱歌. 你在外面钓鱼时要小心. ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.")
					{
						string chatch = "是的, 我听说过一个神话中的海洋生物, 用诱人的声音唱歌. 你在外面钓鱼时要小心. ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "I have to thank ye again for takin' care of that sea serpent. Or was that another one...")
					{
						string chatch = "我要再次感谢你们照顾那条海蛇. 或者还是另一个...";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 178)
				{
					if(chat == "Yep! I'm also considering being a space pirate now.")
					{
						string chatch = "是啊! 我现在也在考虑成为一名太空海盗.";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Just what is that contraption? It makes my Teleporters look like child's play!")
					{
						string chatch = "那是什么装置? 它让我的传送机看起来像小孩玩具";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 550)
				{
					if(chat == "Care for a little Moonshine?")
					{
						string chatch = "来点私酿酒?";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(NPC.FindFirstNPC(ModLoader.GetMod("CalamityMod").NPCType("FAP"))!=-1)
					{
						string chatch1 = "嘘, ";
						string chatch2 = "有点残忍, 不是吗? 我从未声称自己是除啤酒以外的任何东西的专家! ";
						string chatresult1 = chat.Replace("Sheesh, ", chatch1);
						string chatresult2 = chatresult1.Replace(" is a little cruel, isn't she? I never claimed to be an expert on anything but ale!", chatch2);
						chat = chatresult2;
					}
				}
				if (npc.type == 441)
				{
					if(chat == "BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!")
					{
						string chatch = "呸! 看来我再也不能为了镇上的债务吵架了! ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Where and how are you getting all of this money?")
					{
						string chatch = "你从哪怎么弄到的这么多钱?";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!")
					{
						string chatch = "也许你有时间的话, 可以检查那些古老的废墟? 当然, 这对你来说很有价值! ";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
					if(chat == "Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!")
					{
						string chatch = "啥玩意吞噬者, 你刚刚说? 金钱吞噬者, 如果能查一下它的工资单什么的!";
						string chatresult = chat.Replace(chat, chatch);
						chat = chatresult;
					}
				}
				if (npc.type == 353)
				{
					if(NPC.FindFirstNPC(ModLoader.GetMod("CalamityMod").NPCType("FAP"))!=-1)
					{
						string chatch1 = "我发现";
						string chatch2 = "从我背后鬼鬼祟祟的";
						string chatresult1 = chat.Replace("Sometimes I catch ", chatch1);
						string chatresult2 = chatresult1.Replace(" sneaking up from behind me.", chatch2);
						chat = chatresult2;
					}
					if(NPC.FindFirstNPC(ModLoader.GetMod("CalamityMod").NPCType("FAP"))!=-1)
					{
						string chatch1 = "总想让我变得心情愉快.....即使在内心深处, 我知道她很伤心.";
						string chatresult1 = chat.Replace(" is always trying to brighten my mood...even if, deep down, I know she's sad.", chatch1);
						chat = chatresult1;
					}
					string chatch_1 = "别抓天空跳蚤, 或者";
					string chatch_2 = "跳蚤. 反正只要是跳蚤就别抓.";
					string chatresult_1 = chat.Replace("Please don't catch space lice. Or ", chatch_1);
					string chatresult_2 = chatresult_1.Replace(" lice. Or just lice in general.", chatch_2);
					chat = chatresult_2;
					
				}
				
				
				
				
			}
		}
	}
}
