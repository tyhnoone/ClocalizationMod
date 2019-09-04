using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityDesertScourge : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AeroStone"))
				{
					item.SetNameOverride("天蓝石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DesertScourgeBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DriedSeafood"))
				{
					item.SetNameOverride("荒漠币章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OceanCrest"))
				{
					item.SetNameOverride("海波项链");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VictoryShard"))
				{
					item.SetNameOverride("胜利碎片");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AeroStone"))
					{
						if (tooltipLine.text == "One of the ancient relics")
						{
							tooltipLine.text = "远古遗物之一";
						}
						if (tooltipLine.text == "Increases movement speed by 10%, jump speed by 100%, and all damage by 3%")
						{
							tooltipLine.text = "增加10%移速，100%跳跃速度，以及3%所有伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DriedSeafood"))
					{
						if (tooltipLine.text == "The desert sand stirs...")
						{
							tooltipLine.text = "沙漠开始颤抖起来...";
						}
						if (tooltipLine.text == "Summons the Desert Scourge")
						{
							tooltipLine.text = "召唤荒漠灾虫";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OceanCrest"))
					{
						if (tooltipLine.text == "Most ocean enemies become friendly and provides waterbreathing")
						{
							tooltipLine.text = "海洋生物对你变得友好，你可以在水下呼吸了!";
						}
					}
				}
			}
		}
	}
}
