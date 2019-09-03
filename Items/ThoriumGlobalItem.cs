using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000026 RID: 38
	public class ThoriumGlobalItem : GlobalItem
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00006C00 File Offset: 0x00004E00
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("ThoriumMod") != null)
			{
				foreach (TooltipLine tooltipLine in tooltips)
				{
					if (tooltipLine.Name == "AccesoryWarning")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("-Sound Device-", "-音响设备-");
						string resultB = resultA.Replace("-Gem Ring-", "-宝石戒指-");
						tooltipLine.text = resultB;
					}
					if (tooltipLine.Name == "TransformationTag")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("-Transformation-", "-化形-");
						tooltipLine.text = resultA;
					}
					if (tooltipLine.Name == "ThrowerTag")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("-Thrower Class-", "-投手职业-");
						tooltipLine.text = resultA;
					}
					if (tooltipLine.Name == "BardTag")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("-Bard Class-", "-乐师职业-");
						tooltipLine.text = resultA;
					}
					if (tooltipLine.Name == "ScytheSoulCharge")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Grants ", "直接命中时获得");
						string resultB = str.Replace(" soul essence on direct hit", "灵魂精华");
						tooltipLine.text = resultB;
					}
					if (tooltipLine.Name == "UseMana")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Uses ", "使用");
						string resultB = resultA.Replace(" mana & ", "魔法以及");
						string resultC = resultB.Replace(" life", "生命");
						tooltipLine.text = resultC;
					}
					if (tooltipLine.Name == "ButterflyTag")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("-Tier ", "-阶段");
						string resultB = resultA.Replace(" Butterfly -", "蝴蝶-");
						tooltipLine.text = resultB;
					}
					if (tooltipLine.Name == "Damage")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace(" symphonic damage", "交响伤害");
						string resultB = resultA.Replace(" radiant damage", "光辉伤害");
						tooltipLine.text = resultB;
					}
					if (tooltipLine.Name == "CritChance")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("% critical strike chance", "%暴击率");
						tooltipLine.text = resultA;
					}
					if (tooltipLine.Name == "InspirationCost")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Uses ", "使用");
						string resultB = resultA.Replace(" inspiration","灵感");
						tooltipLine.text = resultB;
					}
					if (tooltipLine.Name == "HealerTag")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("-Healer Class-", "-牧师职业-");
						tooltipLine.text = resultA;
					}
					if (tooltipLine.Name == "HealerAmount")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Heals ally life equal to your bonus healing", "依据你的增益治疗量回复你盟友的生命");
						string resultB = resultA.Replace("Heals ally life by ", "盟友生命回复");
						tooltipLine.text = resultB;
					}
					if (tooltipLine.Name == "HealerAmount")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Heals ally life equal to your bonus healing", "依据你的治疗量回复你队友和玩家的生命");
						string resultB = resultA.Replace("Heals ally life by ", "队友和玩家生命回复");
						tooltipLine.text = resultA;
					}
					if (tooltipLine.Name == "HealerAmount")
					{
						string str = tooltipLine.text;
						string resultA = str.Replace("Heals ally life equal to your bonus healing", "依据你的治疗量回复你队友和玩家的生命");
						string resultB = resultA.Replace("Heals ally life by ", "队友和玩家生命回复");
						tooltipLine.text = resultA;
					}
					
				}
					

			}
		}
	}
}
