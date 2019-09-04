using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityDifficultyItems : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Armageddon"))
				{
					item.SetNameOverride("末日玩偶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Death"))
				{
					item.SetNameOverride("死亡之源");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DefiledRune"))
				{
					item.SetNameOverride("污秽符文");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MLGRune"))
				{
					item.SetNameOverride("恶魔证章");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Revenge"))
				{
					item.SetNameOverride("复仇之核");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Armageddon"))
					{
						if (tooltipLine.text == "Makes any hit while a boss is alive instantly kill you")
						{
							tooltipLine.text = "开启末日模式，boss会一击秒杀你";
						}
						if (tooltipLine.text == "Effect can be toggled on and off")
						{
							tooltipLine.text = "此模式可以开启和关闭";
						}
						if (tooltipLine.text == "Using this while a boss is alive will instantly kill you and despawn the boss")
						{
							tooltipLine.text = "在boss存活的时候使用此物品会立刻死亡，boss会立刻离开";
						}
						if (tooltipLine.text == "If a boss is defeated with this effect active it will drop 6 treasure bags, 5 in normal mode")
						{
							tooltipLine.text = "此模式开启后，击杀boss会掉落6个宝物袋，普通难度只掉5个";
						}
						if (tooltipLine.text == "If any player dies while a boss is alive the boss will instantly despawn")
						{
							tooltipLine.text = "如果任何玩家（指联机）在战斗过程中死亡，则boss立刻消失";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Death"))
					{
						if (tooltipLine.text == "Makes bosses even more EXTREME")
						{
							tooltipLine.text = "让Boss更加丧心病狂";
						}
						if (tooltipLine.text == "Effect can be toggled on and off")
						{
							tooltipLine.text = "此模式可以开启和关闭";
						}
						if (tooltipLine.text == "Effect will only work if revengeance mode is active")
						{
							tooltipLine.text = "此效果只能在复仇模式中开启";
						}
						if (tooltipLine.text == "Using this while a boss is alive will instantly kill you and despawn the boss")
						{
							tooltipLine.text = "在boss存活的时候使用此物品会立刻死亡，boss会立刻离开";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DefiledRune"))
					{
						if (tooltipLine.text == "Wings do nothing and enemies can critically hit you")
						{
							tooltipLine.text = "开启神殇模式，翅膀无效，敌人可以重创你";
						}
						if (tooltipLine.text == "Increases most rare item drop chances and enemies drop 50% more cash")
						{
							tooltipLine.text = "增加大部分稀有物品的掉率，敌人掉1.5倍金钱";
						}
						if (tooltipLine.text == "Using this while a boss is alive will instantly kill you and despawn the boss")
						{
							tooltipLine.text = "在boss存活的时候使用此物品会立刻死亡，boss会立刻离开";
						}
						if (tooltipLine.text == "Can only be used in revengeance and death mode")
						{
							tooltipLine.text = "此效果只能在复仇和死亡模式中开启";
						}
						if (tooltipLine.text == "Can be toggled on and off")
						{
							tooltipLine.text = "此模式可以开启和关闭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MLGRune"))
					{
						if (tooltipLine.text == "Boosts spawn rate by 1.25 times")
						{
							tooltipLine.text = "进入恶魔模式, 刷怪率增加25%";
						}
						if (tooltipLine.text == "Effects cannot be reversed")
						{
							tooltipLine.text = "效果不可逆(注：只起一次作用)";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Revenge"))
					{
						if (tooltipLine.text == "Activates revengeance mode, can only be used in expert mode.")
						{
							tooltipLine.text = "开启复仇模式，只能在专家模式下使用";
						}
						if (tooltipLine.text == "Activates rage. When rage is maxed press V to activate rage mode.")
						{
							tooltipLine.text = "激活愤怒槽。当愤怒槽满时，按V键进入怒气状态";
						}
						if (tooltipLine.text == "You gain rage whenever you take damage.")
						{
							tooltipLine.text = "受到伤害即可积攒愤怒槽";
						}
						if (tooltipLine.text == "Activates adrenaline. When adrenaline is maxed press B to activate adrenaline mode.")
						{
							tooltipLine.text = "激活肾上腺素槽。当肾上腺素槽满时，按B键进入兴奋状态";
						}
						if (tooltipLine.text == "You gain adrenaline whenever a boss is alive. Getting hit drops adrenaline back to 0.")
						{
							tooltipLine.text = "boss存活时可积攒肾上腺素槽，受到伤害即会归零";
						}
						if (tooltipLine.text == "If you hit max adrenaline and don't use it within 3 seconds your adrenaline damage will drop gradually.")
						{
							tooltipLine.text = "如果你达到肾上腺素充满后，3秒钟内不使用，你的肾上腺素伤害将逐渐下降";
						}
						if (tooltipLine.text == "All enemies drop 50% more cash and enemy spawn rates are boosted.")
						{
							tooltipLine.text = "敌人金钱掉落增加50%，刷怪率上升";
						}
						if (tooltipLine.text == "Before you have killed your first boss you take 20% LESS damage from everything.")
						{
							tooltipLine.text = "在击杀第一个boss之前，你受到的任何伤害减少20%";
						}
						if (tooltipLine.text == "Changes the Expert Mode 75% defense back to the Normal Mode 50% defense for the duration of prehardmode.")
						{
							tooltipLine.text = "在困难模式前，将专家模式0.75的伤害防御计算改为正常模式0.5的伤害防御计算";
						}
						if (tooltipLine.text == "Changes ALL boss AIs in vanilla and the Calamity Mod.")
						{
							tooltipLine.text = "改变原版和灾厄所有boss的ai";
						}
						if (tooltipLine.text == "DO NOT USE IF A BOSS IS ALIVE!")
						{
							tooltipLine.text = "Boss存活期间严禁使用！";
						}
						if (tooltipLine.text == "Can be toggled on and off.")
						{
							tooltipLine.text = "此模式可以开启和关闭";
						}
					}
				}
			}
		}
	}
}
