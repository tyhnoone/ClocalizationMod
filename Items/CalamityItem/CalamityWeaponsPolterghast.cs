using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsPolterghast : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BansheeHook"))
				{
					item.SetNameOverride("女妖钩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaemonsFlame"))
				{
					item.SetNameOverride("鬼火弓");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EtherealSubjugator"))
				{
					item.SetNameOverride("幽花之主");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FatesReveal"))
				{
					item.SetNameOverride("命运神启");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GhastlyVisage"))
				{
					item.SetNameOverride("古神之貌");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TerrorBlade"))
				{
					item.SetNameOverride("惊惧弯刀");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BansheeHook"))
					{
						if (tooltipLine.text == "Swings a banshee hook that fires blades and explodes on contact")
						{
							tooltipLine.text = "挥动一个女妖钩，在触碰时发射刀刃并爆炸。";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DaemonsFlame"))
					{
						if (tooltipLine.text == "Shoots daemon flame arrows as well as regular arrows")
						{
							tooltipLine.text = "射出常规箭矢的同时射出恶魔的火矢";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EtherealSubjugator"))
					{
						if (tooltipLine.text == "Summons a phantom to protect you")
						{
							tooltipLine.text = "召唤小幽花来保护你";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FatesReveal"))
					{
						if (tooltipLine.text == "Spawns ghostly fireballs that follow the player")
						{
							tooltipLine.text = "在身边召唤跟踪玩家的魂火";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GhastlyVisage"))
					{
						if (tooltipLine.text == "Fires homing ghast energy that explodes")
						{
							tooltipLine.text = "发射会跟踪敌人并爆炸的幽魂能量球";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TerrorBlade"))
					{
						if (tooltipLine.text == "Fires a terror beam that bounces off tiles")
						{
							tooltipLine.text = "发射会在物块上反弹的光剑";
						}
						if (tooltipLine.text == "On every bounce it emits an explosion")
						{
							tooltipLine.text = "每次反弹都会在该点产生一次爆炸";
						}
					}
				}
			}
		}
	}
}
