using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsLeviathan : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Atlantis"))
				{
					item.SetNameOverride("亚特兰蒂斯");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Greentide"))
				{
					item.SetNameOverride("翡翠之潮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Leviatitan"))
				{
					item.SetNameOverride("利维泰坦");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LureofEnthrallment"))
				{
					item.SetNameOverride("沉醉珍珠");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensSong"))
				{
					item.SetNameOverride("塞壬迷歌");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Atlantis"))
					{
						if (tooltipLine.text == "Casts aquatic spears that split as they travel")
						{
							tooltipLine.text = "发射分裂的海之三叉戟";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Greentide"))
					{
						if (tooltipLine.text == "Summons green blasts of water from the sky on enemy hits")
						{
							tooltipLine.text = "攻击敌人时从天空召唤翡翠水流";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Leviatitan"))
					{
						if (tooltipLine.text == "Fires green and normal water blasts")
						{
							tooltipLine.text = "发射绿色和正常的水浪";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LureofEnthrallment"))
					{
						if (tooltipLine.text == "Summons a siren to fight for you")
						{
							tooltipLine.text = "召唤塞壬为你而战";
						}
						if (tooltipLine.text == "The siren stays above you, shooting water spears, ice mist, and treble clefs at nearby enemies")
						{
							tooltipLine.text = "塞壬会停留在你上方并向敌人发射水矛，冰雾和高音谱号";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensSong"))
					{
						if (tooltipLine.text == "Casts slow-moving treble clefs that confuse enemies")
						{
							tooltipLine.text = "发射缓慢移动的高音谱号迷惑敌人";
						}
					}
				}
			}
		}
	}
}
