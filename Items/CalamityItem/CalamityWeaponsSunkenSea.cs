using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsSunkenSea : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquamarineStaff"))
				{
					item.SetNameOverride("渊洋蓝杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquashardShotgun"))
				{
					item.SetNameOverride("碎流霰弹枪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ClamCrusher"))
				{
					item.SetNameOverride("海蚌锤");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ClamorRifle"))
				{
					item.SetNameOverride("音波步枪");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicScimitar"))
				{
					item.SetNameOverride("水华弯刀");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicShank"))
				{
					item.SetNameOverride("水华刺剑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Poseidon"))
				{
					item.SetNameOverride("波塞冬");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeashineSword"))
				{
					item.SetNameOverride("海耀剑");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Serpentine"))
				{
					item.SetNameOverride("海蟒咒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Serpentine"))
				{
					item.SetNameOverride("海蟒咒");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShellfishStaff"))
				{
					item.SetNameOverride("海贝法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Whirlpool"))
				{
					item.SetNameOverride("激流");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquamarineStaff"))
					{
						if (tooltipLine.text == "Shoots two blue bolts")
						{
							tooltipLine.text = "施放两发蓝球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AquashardShotgun"))
					{
						if (tooltipLine.text == "Shoots aquashards which split upon hitting an enemy")
						{
							tooltipLine.text = "发射击中敌人后分裂的碎水弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ClamCrusher"))
					{
						if (tooltipLine.text == "Launches a huge clam that stuns enemies for a short amount of time")
						{
							tooltipLine.text = "掷出大蚌，令敌人短时间内晕眩";
						}
						if (tooltipLine.text == "Starts being affected by gravity and does much more damage after being airborne for a while")
						{
							tooltipLine.text = "锤子受重力影响，掷向空中砸到敌人时造成更多伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ClamorRifle"))
					{
						if (tooltipLine.text == "Shoots homing energy bolts")
						{
							tooltipLine.text = "发射追踪能量弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicScimitar"))
					{
						if (tooltipLine.text == "Fires a beam upon swing that stuns enemies")
						{
							tooltipLine.text = "挥舞发射激光弹幕，会晕眩敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicShank"))
					{
						if (tooltipLine.text == "Shoots electric sparks")
						{
							tooltipLine.text = "挥动产生电火花";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Poseidon"))
					{
						if (tooltipLine.text == "Casts a poseidon typhoon")
						{
							tooltipLine.text = "释放波塞冬的台风";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeashineSword"))
					{
						if (tooltipLine.text == "Shoots an aqua sword beam")
						{
							tooltipLine.text = "发射水之剑气";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Serpentine"))
					{
						if (tooltipLine.text == "Casts a serpent that follows the mouse cursor")
						{
							tooltipLine.text = "向鼠标位置召唤海蟒蛇";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShellfishStaff"))
					{
						if (tooltipLine.text == "Summons a shellfish to fight for you")
						{
							tooltipLine.text = "召唤海贝为你而战";
						}
						if (tooltipLine.text == "Takes up 2 minion slots")
						{
							tooltipLine.text = "占据2召唤栏";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Whirlpool"))
					{
						if (tooltipLine.text == "Sprays a spiral of aqua streams in random directions")
						{
							tooltipLine.text = "随机方向喷射螺旋水流";
						}
					}
				}
			}
		}
	}
}
