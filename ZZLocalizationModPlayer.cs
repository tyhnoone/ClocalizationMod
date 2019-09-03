using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.GameInput;
using ZZLocalizationMod.Interface;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.GameContent.Tile_Entities;

namespace ZZLocalizationMod
{

	public class ZZLocalizationModPlayer : ModPlayer
	{

		public override void OnEnterWorld(Player player)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				Main.NewText("感谢您使用ZZLocalizationMod，使用过程中出现什么问题欢迎反馈", 67, 100, 238, false);
				Mod CalamityMod = ModLoader.GetMod("CalamityMod");
				Version Cala_vers = new Version(1, 4, 1, 104);
				if (CalamityMod != null)
				{
					if (CalamityMod.Version == Cala_vers)
					{
						Main.NewText("检测到你已启用CalamityMod，当前汉化对应版本是" + Cala_vers + "，增加部分灾厄文本汉化", byte.MaxValue, byte.MaxValue, 147, false);
					}
					else
					{
						Main.NewText("检测到你已启用CalamityMod v" + CalamityMod.Version + "，当前汉化对应版本是v" + Cala_vers, byte.MaxValue, byte.MaxValue, 147, false);
					}
					Main.NewText("由于Calamity的更新频率，ZZLocalizationMod将不完全保证汉化文本的正确性", 26, byte.MaxValue, 138, false);
					return;
				}
			
			}
			else
			{
				Main.NewText("You didn't select Chinese, so the Chinese and other modifytooltips won't take effect.", 67, 110, 238, false);
			}
		}
		public override void ProcessTriggers(TriggersSet triggersSet)
		{

			if (ZZLocalizationMod.ZZPlayerInfoOK.JustPressed)
			{
				ZZPlayerInfo.visible = !ZZPlayerInfo.visible;
			}
			//if (ZZLocalizationMod.ZZRecipeInfoOK.JustPressed)
			//{
			//	Item item = new Item();
			//	if(!Main.HoverItem.IsAir)
			//	{
			//		ZZRicipeInfo.visible = true;
			//		item = Main.HoverItem;
			//	}
			//	else ZZRicipeInfo.visible = false;
			//	Player player = Main.player[Main.myPlayer];
			//	ZZLocalizationMod.instance.ZZRecipeInfoUI.UpdateValue(item,player);
			//}
		}

	}
}
