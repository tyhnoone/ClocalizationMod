using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsGreatSandShark : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SandSharknadoStaff"))
				{
					item.SetNameOverride("鲨卷沙法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Sandstorm"))
				{
					item.SetNameOverride("沙尘暴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShiftingSands"))
				{
					item.SetNameOverride("流沙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Tumbleweed"))
				{
					item.SetNameOverride("风滚草");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SandSharknadoStaff"))
					{
						if (tooltipLine.text == "Summons a sandnado to fight for you")
						{
							tooltipLine.text = "召唤鲨卷沙保护你";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Sandstorm"))
					{
						if (tooltipLine.text == "Fires sand bullets that explode")
						{
							tooltipLine.text = "发射会爆炸的沙弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShiftingSands"))
					{
						if (tooltipLine.text == "Casts a sand shard that follows the mouse cursor")
						{
							tooltipLine.text = "召唤跟随鼠标的沙能碎片攻击敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Tumbleweed"))
					{
						if (tooltipLine.text == "Releases a rolling tumbleweed on enemy hits")
						{
							tooltipLine.text = "击中敌人释放风滚草";
						}
					}
				}
			}
		}
	}
}
