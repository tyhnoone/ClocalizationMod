using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsPlaguebringer : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DiseasedPike"))
				{
					item.SetNameOverride("瘟疫长枪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Malevolence"))
				{
					item.SetNameOverride("怨毒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MepheticSprayer"))
				{
					item.SetNameOverride("枯萎散播者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PestilentDefiler"))
				{
					item.SetNameOverride("致命玷污者");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheHive"))
				{
					item.SetNameOverride("毒蜂火箭巢");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ThePlaguebringer"))
				{
					item.SetNameOverride("疵疫");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VirulentKatana"))
				{
					item.SetNameOverride("绝瘟毒刃");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DiseasedPike"))
					{
						if (tooltipLine.text == "Fires plague seekers on enemy hits")
						{
							tooltipLine.text = "打击敌人会发射瘟疫搜寻者";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Malevolence"))
					{
						if (tooltipLine.text == "Fires two plague arrows that explode into bees on death")
						{
							tooltipLine.text = "发射两枚瘟疫箭，在消失时爆发成蜜蜂";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PestilentDefiler"))
					{
						if (tooltipLine.text == "Fires a plague round that explodes and splits on death")
						{
							tooltipLine.text = "发射瘟疫子弹，在消失时爆炸并分裂";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlagueStaff"))
					{
						if (tooltipLine.text == "Fires a spread of plague fangs")
						{
							tooltipLine.text = "发射瘟疫之牙";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheHive"))
					{
						if (tooltipLine.text == "Launches a variety of rockets that explode into bees on death")
						{
							tooltipLine.text = "发射各种火箭，在消失后爆炸成蜜蜂";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ThePlaguebringer"))
					{
						if (tooltipLine.text == "Fires plague seekers when enemies are near")
						{
							tooltipLine.text = "敌人接近时发射瘟疫搜寻者";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VirulentKatana"))
					{
						if (tooltipLine.text == "Fires a plague cloud")
						{
							tooltipLine.text = "发射瘟疫云";
						}
					}
				}
			}
		}
	}
}
