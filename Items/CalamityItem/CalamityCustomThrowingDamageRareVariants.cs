using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityCustomThrowingDamageRareVariants : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DuneHopper"))
				{
					item.SetNameOverride("沙蝗");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Quasar"))
				{
					item.SetNameOverride("类星体");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SpearofDestiny"))
				{
					item.SetNameOverride("命运之矛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheReaper"))
				{
					item.SetNameOverride("收割之镰");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DuneHopper"))
					{
						if (tooltipLine.text == "Throws a spear that bounces a lot")
						{
							tooltipLine.text = "投掷一支弹跳很多次的矛";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SpearofDestiny"))
					{
						if (tooltipLine.text == "Throws three spears with the outer two having homing capabilities")
						{
							tooltipLine.text = "投掷三支长矛，外侧两支长矛具有追踪能力";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheReaper"))
					{
						if (tooltipLine.text == "Slice 'n dice")
						{
							tooltipLine.text = "切为齑粉";
						}
					}
				}
			}
		}
	}
}
