using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityWeaponsCryogen : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Avalanche"))
				{
					item.SetNameOverride("雪崩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BittercoldStaff"))
				{
					item.SetNameOverride("苦寒法杖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EffluviumBow"))
				{
					item.SetNameOverride("冰川之风");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GlacialCrusher"))
				{
					item.SetNameOverride("冰川之刃");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SnowstormStaff"))
				{
					item.SetNameOverride("冰晶风暴");
				}
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Avalanche"))
					{
						if (tooltipLine.text == "Spawns ice bombs that explode after 2 seconds into ice shards on enemy hits")
						{
							tooltipLine.text = "生成会在接触敌人2两秒钟后爆炸出冰晶的冰炸弹";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BittercoldStaff"))
					{
						if (tooltipLine.text == "Fires a spread of homing ice spikes")
						{
							tooltipLine.text = "散射出跟踪寒冰碎片";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EffluviumBow"))
					{
						if (tooltipLine.text == "Fires two mist arrows at once")
						{
							tooltipLine.text = "同时发射两支雾箭";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GlacialCrusher"))
					{
						if (tooltipLine.text == "Fires very slow frost projectiles that gain strength as they travel and freeze enemies")
						{
							tooltipLine.text = "投掷速度慢的冰霜弹幕，会冻住敌人，强度取决于穿行距离";
						}
						if (tooltipLine.text == "Enemies are frozen for longer the further the projectile travels")
						{
							tooltipLine.text = "穿行距离越远，冰冻时间越长";
						}
						if (tooltipLine.text == "True melee strikes cause tremendous damage to frozen enemies")
						{
							tooltipLine.text = "真实近战伤害（武器本体伤害）对被冻住的敌人造成海量伤害";
						}
						if (tooltipLine.text == "Enemies that cannot be frozen take increased damage")
						{
							tooltipLine.text = "无法被冰冻的敌人受到的伤害增加";
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SnowstormStaff"))
					{
						if (tooltipLine.text == "Fires a snowflake that follows the mouse cursor")
						{
							tooltipLine.text = "发射一个冰晶跟随你的鼠标攻击敌人";
						}
					}
				}
			}
		}
	}
}
