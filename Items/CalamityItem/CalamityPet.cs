using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityPet : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BearEye"))
				{
					item.SetNameOverride("猫眼石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CharredRelic"))
				{
					item.SetNameOverride("厄古炭钩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmicPlushie"))
				{
					item.SetNameOverride("星际毛绒娃娃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FoxDrive"))
				{
					item.SetNameOverride("狐盘");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IbarakiBox"))
				{
					item.SetNameOverride("包子仙的百药枡");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Levi"))
				{
					item.SetNameOverride("利维");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RomajedaOrchid"))
				{
					item.SetNameOverride("Romajeda之兰");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BearEye"))
					{
						if (tooltipLine.text == "Summons a pet guardian angel")
						{
							tooltipLine.text = "召唤守护天使宠物 -- 小熊";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CharredRelic"))
					{
						if (tooltipLine.text == "Contains a small amount of brimstone")
						{
							tooltipLine.text = "包含一些硫磺火石";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmicPlushie"))
					{
						if (tooltipLine.text == "Summons the devourer of the cosmos...?")
						{
							tooltipLine.text = "召唤宇宙的吞食者...?";
						}
						if (tooltipLine.text == "Sharp objects possibly included")
						{
							tooltipLine.text = "可能装有锋利物件";
						}
						if (tooltipLine.text == "Suppresses friendly red devils")
						{
							tooltipLine.text = "压抑住友情的红恶魔";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FoxDrive"))
					{
						if (tooltipLine.text == "'It contains 1 file on it'")
						{
							tooltipLine.text = "“这个云盘里只有这一个文件”";
						}
						if (tooltipLine.text == "'Fox.cs'")
						{
							tooltipLine.text = "“Fox.cs”";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IbarakiBox"))
					{
						if (tooltipLine.text == "As the ice melts in the springs")
						{
							tooltipLine.text = "气霁风梳新柳发";
						}
						if (tooltipLine.text == "And waves wash the old moss’ hair…")
						{
							tooltipLine.text = "冰消浪洗旧苔须";
						}
						if (tooltipLine.text == "Thank you, Goodbye.")
						{
							tooltipLine.text = "谢谢，再见";
						}
						if (tooltipLine.text == "While equipped, the player will spawn with full health rather than half.")
						{
							tooltipLine.text = "装备后，玩家复活时会恢复全部血量而不是一半";
						}
						if (tooltipLine.text == "Summons the Third Sage")
						{
							tooltipLine.text = "召唤第三圣蛇\n（译注：包子仙，Ibarak茨木华扇）";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Levi"))
					{
						if (tooltipLine.text == "Summons a baby Leviathan pet")
						{
							tooltipLine.text = "召唤利维坦宠物宝宝";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RomajedaOrchid"))
					{
						if (tooltipLine.text == "Summons a never forgotten friend")
						{
							tooltipLine.text = "召唤一个永不离弃的朋友";
						}
					}
				}
			}
		}
	}
}
