using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamitySunkenSea : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmidiasPendant"))
				{
					item.SetNameOverride("阿米迪亚斯之垂饰");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GiantPearl"))
				{
					item.SetNameOverride("巨蛤珍珠");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskHusk"))
				{
					item.SetNameOverride("软体动物外壳");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AmidiasPendant"))
					{
						if (tooltipLine.text == "Periodically rains down prism shards")
						{
							tooltipLine.text = "周期性的降下棱晶碎片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GiantPearl"))
					{
						if (tooltipLine.text == "You have a light aura around you")
						{
							tooltipLine.text = "光明之环环绕身周";
						}
						if (tooltipLine.text == "Enemies within the aura are slowed down")
						{
							tooltipLine.text = "被光环笼罩的敌人降低移速";
						}
						if (tooltipLine.text == "Does not work on bosses")
						{
							tooltipLine.text = "此效果对boss不起作用";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MolluskHusk"))
					{
						if (tooltipLine.text == "The remains of a mollusk")
						{
							tooltipLine.text = "软体动物的遗留物";
						}
					}
				}
			}
		}
	}
}
