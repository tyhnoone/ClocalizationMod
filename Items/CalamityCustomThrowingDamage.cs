using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000025 RID: 37
	public class CalamityCustomThrowingDamage : GlobalItem
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null && item.type == ModLoader.GetMod("CalamityMod").ItemType("AccretionDisk"))
			{
				item.SetNameOverride("元素飞盘");
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006B08 File Offset: 0x00004D08
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (tooltipLine.Name == "Damage")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("rogue ", "盗贼");
						tooltipLine.text = resultA;
					}
				}
				if(item.type == ModLoader.GetMod("CalamityMod").ItemType("AccretionDisk"))
				{
					
					foreach (TooltipLine tooltipLine in tooltips)
					{
						
						if (tooltipLine.Name == "Tooltip0")
						{
							tooltipLine.text = "切裂真实!";
						}
					}
				}
			}
		}
	}
}
