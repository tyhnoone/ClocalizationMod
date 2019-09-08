using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityPlaguebringerGoliath : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Abomination"))
				{
					item.SetNameOverride("疫体融溶物");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloomStone"))
				{
					item.SetNameOverride("绽花石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguebringerGoliathBag"))
				{
					item.SetNameOverride("宝藏袋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlagueCellCluster"))
				{
					item.SetNameOverride("瘟疫细胞罐");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ToxicHeart"))
				{
					item.SetNameOverride("猛毒之心");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Abomination"))
					{
						if (tooltipLine.text == "Calls in the airborne jungle abomination")
						{
							tooltipLine.text = "召唤丛林深处的瘟疫之源";
						}
						if (tooltipLine.text == "Summons the Plaguebringer Goliath")
						{
							tooltipLine.text = "召唤瘟疫使者歌莉娅";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ToxicHeart"))
					{
						if (tooltipLine.text == "Summons a damaging plague aura around the player to destroy nearby enemies")
						{
							tooltipLine.text = "召唤一个伤害性的瘟疫光环摧毁玩家周围的敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloomStone"))
					{
						if (tooltipLine.text == "One of the ancient relics")
						{
							tooltipLine.text = "远古遗物之一";
						}
						if (tooltipLine.text == "Enemies that get near you take damage and all damage is increased by 3%")
						{
							tooltipLine.text = "接近你的敌人会受到伤害，增加3%所有伤害";
						}
						if (tooltipLine.text == "You grow flowers on the grass beneath you, chance to grow very random dye plants on grassless dirt")
						{
							tooltipLine.text = "你走过的草地会百花齐放，并几率让无草的土块上随机生长颜料植物";
						}
					}
				}
			}
		}
	}
}
