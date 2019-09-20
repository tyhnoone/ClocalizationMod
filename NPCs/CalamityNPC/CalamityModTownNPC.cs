using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ZZLocalizationMod.NPCs
{
	public class CalamityModTownNPC : GlobalNPC
	{
		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}
		public override void SetDefaults(NPC npc)
		{
			string B1 = "";
			string B2 = "";
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("DILF"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大魔法师");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("FAP"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "醉仙女");
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("SEAHOE"))
				{
					NPCLoader.GetNPC(npc.type).DisplayName.AddTranslation(GameCulture.Chinese, "大海之王");
				}
			}
			if (ModLoader.GetMod("CalamityMod") != null)
			{
				if (npc.type == ModLoader.GetMod("CalamityMod").NPCType("FAP"))
				{
					if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
					{
						B1 = "商店";
						B2 = "死亡计数";
					}
					else{
						B1 = "Shop";
						B2 = "Death Count";
					}
					NPCLoader.GetNPC(npc.type).SetChatButtons(ref B1,ref B2);
				}
			}
		}
	}
}
