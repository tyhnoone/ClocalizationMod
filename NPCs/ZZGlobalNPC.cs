using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.NPCs
{
	public class ZZGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}
		public override bool PreAI(NPC npc)
		{
			if(npc.townNPC)
			{
				this.SetTownNPCName(npc);
			}
			return true;
		}
		private bool setNewName = true;
		private void SetTownNPCName(NPC npc)
		{
			if (setNewName)
			{
				setNewName = false;
				if(npc.type == NPCID.Guide)
				{
					if(Main.rand.Next(50) == 0)
					{
						npc.GivenName = "Cerberus";
						return;
					}
					if(Main.rand.Next(50) == 1)
					{
						npc.GivenName = "ZY";
						return;
					}
				}
			}
		}
		public override void GetChat(NPC npc, ref string chat)
		{
			if(npc.type == NPCID.Guide && npc.GivenName == "ZY")
			{
				if (Main.rand.Next(3) == 0) 
				{
					chat = "I'll be back";
					return;
				}
			}
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				if(npc.type == NPCID.Guide && npc.GivenName == "Cerberus")
				{
					switch (Main.rand.Next(6)) 
					{
						case 0:
							chat = "等下，我应该正在电脑前玩游戏，怎么跑到这来了";
							break;
						case 1:
							chat = "趁你手里还没有巫毒娃娃，我准备赶紧交代后事";
							break;
						case 2:
							chat = "有什么要问的就赶紧问吧";
							break;
						case 3:
							chat = "制作？我不知道哎，你不如问问合成表mod，点一下你亲爱的合成表热键，它知道的比我多";
							break;
						case 4:
							chat = "为什么和ItemCheckList不兼容，我怎么知道，我要是知道，那它不就兼容了";
							break;
						case 5:
							chat = "我是谁？没事，这不重要";
							break;
						default:
							break;
					}
				}
				if(npc.type == NPCID.Guide && npc.GivenName == "Cerberus" && ModLoader.GetMod("CalamityMod")!=null && Main.rand.Next(2) == 0)
				{
					switch (Main.rand.Next(4)) 
					{
						case 0:
							chat = "你在玩灾厄啊，哦";
							break;
						case 1:
							chat = "我猜你下一句是喵刀砍神长直，不是？那就是棱镜杀丛林龙";
							break;
						case 2:
							chat = "别怂，开铁心模式啊";
							break;
						case 3:
							chat = "别老想肉山前搞到 [i:"  + ModLoader.GetMod("CalamityMod").ItemType("HalibutCannon")+ "] ，这东西掉率0.0001%。什么，你肉山前弄到了？我怀疑你是通过了某些奇怪的渠道拿的（识破）";
							break;
						default:
							break;
					}
					for (int i = 0 ; i < 50; i++)
					{
						if(Main.player[Main.myPlayer].inventory[i].type == ModLoader.GetMod("CalamityMod").ItemType("IronHeart"))
						{
							chat = "对就是这个 [i:" + ModLoader.GetMod("CalamityMod").ItemType("IronHeart") + "] ，打开它，GKD";
							break;
						}
						if(Main.player[Main.myPlayer].inventory[i].type == ModLoader.GetMod("CalamityMod").ItemType("HalibutCannon"))
						{
							chat = "[i:"  + ModLoader.GetMod("CalamityMod").ItemType("HalibutCannon")+ "]，这不是，大比目鱼炮吗，快说从哪弄的";
							break;
						}
						if(Main.player[Main.myPlayer].inventory[i].type == ModLoader.GetMod("CalamityMod").ItemType("PurifiedJam"))
						{
							chat = "[i:"  + ModLoader.GetMod("CalamityMod").ItemType("PurifiedJam")+ "]，净神果酱，这东西我记得好像和 [i:"  + ModLoader.GetMod("CalamityMod").ItemType("ColdheartIcicle")+ "] 一块用有奇效，你可以去问问那个冰魔法师，要不试试？";
							break;
						}
						if(Main.player[Main.myPlayer].inventory[i].type == ModLoader.GetMod("CalamityMod").ItemType("ColdheartIcicle"))
						{
							chat = "[i:"  + ModLoader.GetMod("CalamityMod").ItemType("PurifiedJam")+ "] 和 [i:"  + ModLoader.GetMod("CalamityMod").ItemType("ColdheartIcicle")+ "] 一块用有奇效";
							break;
						}
					}
				}
				if(npc.type == NPCID.Guide && npc.GivenName == "Cerberus" && ModLoader.GetMod("ThoriumMod")!=null && Main.rand.Next(2) == 0)
				{
					switch (Main.rand.Next(3)) 
					{
						case 0:
							chat = "啊，瑟银啊";
							break;
						case 1:
							chat = "为什么不来一次惊险刺激的纯牧开荒呢？";
							break;
						case 2:
							chat = "别怂，化形术开荒走起";
							break;
						default:
							break;
					}
					if(ModLoader.GetMod("CalamityMod")!=null && Main.rand.Next(2) == 0)
					{
						chat = "又想用 [i:"  + ModLoader.GetMod("ThoriumMod").ItemType("CelestialBow")+ "] 这个弓作弊通关灾厄了吧，快承认（识破）";
					}
				}
			}
			return;
		}
		public override void NPCLoot(NPC npc)
		{
			if(npc.type == NPCID.Guide && npc.GivenName == "Cerberus")
			{
				Item.NewItem(npc.getRect(), mod.ItemType("InvokerHood"));
				Item.NewItem(npc.getRect(), mod.ItemType("InvokerPants"));
				Item.NewItem(npc.getRect(), mod.ItemType("InvokerRobe"));
			}
		}
	}
}
