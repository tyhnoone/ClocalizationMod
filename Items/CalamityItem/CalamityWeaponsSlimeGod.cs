using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsSlimeGod : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalTome"))
				{
					item.SetNameOverride("深渊之书");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorroslimeStaff"))
				{
					item.SetNameOverride("腐化史莱姆召唤杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorruptedCrusherBlade"))
				{
					item.SetNameOverride("腐化碾碎刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrimslimeStaff"))
				{
					item.SetNameOverride("血腥史莱姆法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrimsonCrusherBlade"))
				{
					item.SetNameOverride("猩红碾碎刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EldritchTome"))
				{
					item.SetNameOverride("诡触之书");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GeliticBlade"))
				{
					item.SetNameOverride("凝胶波刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Goobow"))
				{
					item.SetNameOverride("凝胶弓");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GunkShot"))
				{
					item.SetNameOverride("胶泥射击");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OverloadedBlaster"))
				{
					item.SetNameOverride("过载凝胶喷射器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheGodsGambit"))
				{
					item.SetNameOverride("神翼弃兵");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssalTome"))
					{
						if (tooltipLine.text == "Casts a slow-moving ball of dark energy")
						{
							tooltipLine.text = "释放一个缓慢移动的黑暗能量球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorroslimeStaff"))
					{
						if (tooltipLine.text == "Summons a corro slime to fight for you")
						{
							tooltipLine.text = "召唤一个腐化史莱姆为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorruptedCrusherBlade"))
					{
						if (tooltipLine.text == "Inflicts cursed inferno and critical hits lower enemy defense")
						{
							tooltipLine.text = "造成诅咒地狱debuff，暴击降低敌人的防御力";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrimslimeStaff"))
					{
						if (tooltipLine.text == "Summons a crim slime to fight for you")
						{
							tooltipLine.text = "召唤血腥史莱姆为你而战";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrimsonCrusherBlade"))
					{
						if (tooltipLine.text == "Inflicts ichor and critical hits lower enemy contact damage")
						{
							tooltipLine.text = "造成灵液debuff，暴击降低敌人的接触伤害";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EldritchTome"))
					{
						if (tooltipLine.text == "Casts eldritch tentacles to spear your enemies")
						{
							tooltipLine.text = "释放怪异的触手攻击敌人";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Goobow"))
					{
						if (tooltipLine.text == "Fires two streams of slime")
						{
							tooltipLine.text = "发射两道凝胶流";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GunkShot"))
					{
						if (tooltipLine.text == "Shoots a spread of bullets")
						{
							tooltipLine.text = "发射一梭子弹/n(译注：精灵宝可梦中同名招式Gunk Shot，垃圾射击)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("OverloadedBlaster"))
					{
						if (tooltipLine.text == "33% chance to not consume gel")
						{
							tooltipLine.text = "33%几率不消耗凝胶";
						}
						if (tooltipLine.text == "Fires a large spread of bouncing slime")
						{
							tooltipLine.text = "发射大量能反弹的粘液";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheGodsGambit"))
					{
						if (tooltipLine.text == "Fires a stream of slime when enemies are near")
						{
							tooltipLine.text = "当敌人靠近时会发出一股粘液/n(译注：The king's Gambit，王翼弃兵，国际象棋战术";
						}
					}
				}
			}
		}
	}
}
