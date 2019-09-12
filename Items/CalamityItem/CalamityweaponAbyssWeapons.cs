using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityweaponAbyssWeapons : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Archerfish"))
				{
					item.SetNameOverride("射水鱼");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BallOFugu"))
				{
					item.SetNameOverride("河豚链球");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlackAnurian"))
				{
					item.SetNameOverride("黑泡蟾蜍");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamarisLament"))
				{
					item.SetNameOverride("乌贼之哀歌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DreadmineStaff"))
				{
					item.SetNameOverride("恐惧渊雷法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EidolicWail"))
				{
					item.SetNameOverride("幻龙恸鸣");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FlakKraken"))
				{
					item.SetNameOverride("克拉肯高射炮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HalibutCannon"))
				{
					item.SetNameOverride("大比目鱼炮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HerringStaff"))
				{
					item.SetNameOverride("鲱鱼法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SoulEdge"))
				{
					item.SetNameOverride("灵魂之锋");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SulphuricAcidCannon"))
				{
					item.SetNameOverride("硫磺酸炮");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TyphonsGreed"))
				{
					item.SetNameOverride("贪魂台风");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UndinesRetribution"))
				{
					item.SetNameOverride("水精灵的惩罚");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Archerfish"))
					{
						if (tooltipLine.text == "Fires a stream of water")
						{
							tooltipLine.text = "发射一股水流";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BallOFugu"))
					{
						if (tooltipLine.text == "Throws a fish that spews homing spikes")
						{
							tooltipLine.text = "投掷会发射跟踪尖刺的鱼";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlackAnurian"))
					{
						if (tooltipLine.text == "Spews bubbles and homing plankton")
						{
							tooltipLine.text = "喷出气泡和跟踪小浮游生物";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamarisLament"))
					{
						if (tooltipLine.text == "Summons a squid to fight for you")
						{
							tooltipLine.text = "召唤小乌贼为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DreadmineStaff"))
					{
						if (tooltipLine.text == "Summons a dreadmine turret to fight for you")
						{
							tooltipLine.text = "召唤恐惧渊雷炮台为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EidolicWail"))
					{
						if (tooltipLine.text == "Earrape")
						{
							tooltipLine.text = "爆音";
						}
						if (tooltipLine.text == "Fires a string of bouncing sound waves that become stronger as they travel")
						{
							tooltipLine.text = "发出一串可反弹的声波，这些声波在传播时会变得更强";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FlakKraken"))
					{
						if (tooltipLine.text == "Fires an energy reticle that becomes more powerful over time")
						{
							tooltipLine.text = "在鼠标位置生成能量体，随着时间的推移变得更强大";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HalibutCannon"))
					{
						if (tooltipLine.text == "This weapon is overpowered, use at the risk of ruining your playthrough")
						{
							tooltipLine.text = "此武器过于强大，使用时请慎重抉择，以免其破坏游戏体验";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HerringStaff"))
					{
						if (tooltipLine.text == "Summons a herring to fight for you")
						{
							tooltipLine.text = "召唤鲱鱼为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SoulEdge"))
					{
						if (tooltipLine.text == "Fires the ghastly souls of long-deceased abyss dwellers")
						{
							tooltipLine.text = "发射深渊居民的令人恐惧的幽魂";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SulphuricAcidCannon"))
					{
						if (tooltipLine.text == "Fires an acidic bubble that sticks to enemies and emits sulphuric gas")
						{
							tooltipLine.text = "发射一个粘在敌人身上的酸性气泡，并释放出硫酸气体";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TyphonsGreed"))
					{
						if (tooltipLine.text == "Summons water spirits while in use")
						{
							tooltipLine.text = "使用时召唤水精灵";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UndinesRetribution"))
					{
						if (tooltipLine.text == "Casts a swarm of homing spears")
						{
							tooltipLine.text = "从地下窜出一大群追踪矛";
						}
					}
				}
			}
		}
	}
}
