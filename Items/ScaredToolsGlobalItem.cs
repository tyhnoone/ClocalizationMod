using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000026 RID: 38
	public class ScaredToolsGlobalItem : GlobalItem
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00006C00 File Offset: 0x00004E00
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("SacredTools") != null)
			{
				if (item.type == ModLoader.GetMod("SacredTools").ItemType("FieryFin"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 熔火之地钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("SacredTools").ItemType("Blazefury")
				|| item.type == ModLoader.GetMod("SacredTools").ItemType("FlameBeamFish"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 熔火之地洞穴层岩浆钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("SacredTools").ItemType("FlariumCrate"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 熔火之地洞穴层水池或者岩浆钓鱼")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
				if (item.type == ModLoader.GetMod("SacredTools").ItemType("Claymarine"))
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "fish", "可获得方式: 困难模式任意位置钓鱼(概率极低)")
					{
						overrideColor = new Color?(Color.BlueViolet)
					});
				}
			}
		}
	}
}
