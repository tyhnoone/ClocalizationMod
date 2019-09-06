using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000026 RID: 38
	public class AAGlobalItem : GlobalItem
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00006C00 File Offset: 0x00004E00
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("AAMod") != null)
			{
				if (item.type == ModLoader.GetMod("AAMod").ItemType("IceCrate"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 雪地钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("DesertCrate"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 沙漠钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("InfernoCrate"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 燎狱岩浆或水池钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("MireCrate"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 潭渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ItemID.GoldenCrate)
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						if(tooltipLine.Name == "fish")
						{
							tooltipLine.text += "欲望金窟钓鱼";
						}
					}
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("HellCrate"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 地狱岩浆钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("TriHeadedKoi"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 潭渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("Fishmother"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 燎狱钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("ScorchShark"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 困难模式燎狱钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("AAMod").ItemType("SwimmingHydra"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 困难模式潭渊钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
			}
		}
	}
}
