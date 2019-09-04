using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWings : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AureateWings"))
				{
					item.SetNameOverride("玉金喷射器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CelestialTracers"))
				{
					item.SetNameOverride("天神之靴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DiscordianWings"))
				{
					item.SetNameOverride("混乱之翼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DrewsWings"))
				{
					item.SetNameOverride("Drew之翼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElysianTracers"))
				{
					item.SetNameOverride("极乐之靴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HadarianWings"))
				{
					item.SetNameOverride("哈德安之翼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("InfinityBoots"))
				{
					item.SetNameOverride("六翼天使之靴");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MOAB"))
				{
					item.SetNameOverride("气球之母");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SkylineWings"))
				{
					item.SetNameOverride("天羽之翼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StarlightWings"))
				{
					item.SetNameOverride("星光之翼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonWings"))
				{
					item.SetNameOverride("龙蒿叶之翼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocWings"))
				{
					item.SetNameOverride("克希洛克之翼");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					string wing1 = "水平飞行速度:";
					string wing2 = "加速倍率:";
					string wing3 = "飞行时间:";
					string wingsult1 = tooltipLine.text.Replace("Horizontal speed:", wing1);
					string wingsult2 = wingsult1.Replace("Acceleration multiplier:", wing2);
					string wingsult3 = wingsult2.Replace("Flight time:", wing3);
					tooltipLine.text = wingsult3;
					if (tooltipLine.text == "Good vertical speed")
					{
						tooltipLine.text = "不错的垂直飞行速度";
					}
					if (tooltipLine.text == "Excellent vertical speed")
					{
						tooltipLine.text = "绝佳的垂直飞行速度";
					}
					if (tooltipLine.text == "Average vertical speed")
					{
						tooltipLine.text = "普通的垂直飞行速度";
					}
					if (tooltipLine.text == "Great vertical speed")
					{
						tooltipLine.text = "很赞的垂直飞行速度";
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AureateWings"))
					{
						if (tooltipLine.text == "Mach speed with style!")
						{
							tooltipLine.text = "优雅而快速的飞行！";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CelestialTracers"))
					{
						if (tooltipLine.text == "Counts as wings")
						{
							tooltipLine.text = "算作翅膀";
						}
						if (tooltipLine.text == "Taking speed EVEN FURTHER BEYOND!")
						{
							tooltipLine.text = "让你的速度超越自我!";
						}
						if (tooltipLine.text == "Greater mobility on ice")
						{
							tooltipLine.text = "在冰上大幅增加自由移动能力";
						}
						if (tooltipLine.text == "Water and lava walking")
						{
							tooltipLine.text = "能在水和岩浆上行走";
						}
						if (tooltipLine.text == "Temporary immunity to lava")
						{
							tooltipLine.text = "提供暂时的岩浆免疫";
						}
						if (tooltipLine.text == "Being hit for over 200 damage will make you immune for an extended period of time")
						{
							tooltipLine.text = "受到超过200点的伤害会增加你的无敌时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DiscordianWings"))
					{
						if (tooltipLine.text == "Formed from the flames of pure chaos")
						{
							tooltipLine.text = "由纯粹的混乱之火打造";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DrewsWings"))
					{
						if (tooltipLine.text == "Absolutely Fabulous")
						{
							tooltipLine.text = "精妙绝伦";
						}
						if (tooltipLine.text == "Revengeance drop")
						{
							tooltipLine.text = "复仇模式专属";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ElysianTracers") || item.type == ModLoader.GetMod("CalamityMod").ItemType("InfinityBoots"))
					{
						if (tooltipLine.text == "Counts as wings")
						{
							tooltipLine.text = "算作翅膀";
						}
						if (tooltipLine.text == "Ludicrous speed!")
						{
							tooltipLine.text = "荒诞的速度！";
						}
						if (tooltipLine.text == "Greater mobility on ice")
						{
							tooltipLine.text = "在冰上大幅增加自由移动能力";
						}
						if (tooltipLine.text == "Water and lava walking")
						{
							tooltipLine.text = "能在水和岩浆上行走";
						}
						if (tooltipLine.text == "Temporary immunity to lava")
						{
							tooltipLine.text = "提供暂时的岩浆免疫";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HadarianWings"))
					{
						if (tooltipLine.text == "Powered by the Astral Infection")
						{
							tooltipLine.text = "被幻星疫病强化的翅膀";
						}
						if (tooltipLine.text == "Hold down to hover during flight, greatly extending flight duration")
						{
							tooltipLine.text = "飞行中保持悬停，大大延长飞行时间";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MOAB"))
					{
						if (tooltipLine.text == "The mother of all balloons")
						{
							tooltipLine.text = "所有气球的母亲";
						}
						if (tooltipLine.text == "Counts as wings")
						{
							tooltipLine.text = "算作翅膀";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("StarlightWings"))
					{
						if (tooltipLine.text == "Wings of the Nightingale")
						{
							tooltipLine.text = "夜莺之翼";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TarragonWings"))
					{
						if (tooltipLine.text == "Born of the jungle")
						{
							tooltipLine.text = "生于丛林";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("XerocWings"))
					{
						if (tooltipLine.text == "Highly radioactive")
						{
							tooltipLine.text = "高放射性";
						}
					}
				}
			}
		}
	}
}
