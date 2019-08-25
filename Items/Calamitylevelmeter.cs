using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000027 RID: 39
	public class Calamitylevelmeter : GlobalItem
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000099D4 File Offset: 0x00007BD4
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeleeLevelMeter"))
				{
					item.SetNameOverride("近战等级测量器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MagicLevelMeter"))
				{
					item.SetNameOverride("魔法等级测量器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RangedLevelMeter"))
				{
					item.SetNameOverride("远程等级测量器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RogueLevelMeter"))
				{
					item.SetNameOverride("盗贼等级测量器");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SummonLevelMeter"))
				{
					item.SetNameOverride("召唤等级测量器");
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00009AC8 File Offset: 0x00007CC8
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MeleeLevelMeter"))
				{
					foreach (TooltipLine tooltipLine in tooltips)
					{
						if (tooltipLine.Name == "Tooltip0")
						{
							string[] array = Regex.Split(tooltipLine.text, "\n");
							string[] waitArray = Regex.Split(array[3], ": ");
							string[] waitArray2 = Regex.Split(array[4], ": ");
							string[] waitArray3 = Regex.Split(array[5], ": ");
							string[] waitArray4 = Regex.Split(array[6], ": ");
							string[] array2 = Regex.Split(array[7], ": ");
							string str = waitArray[1];
							string str2 = waitArray2[1];
							string str3 = waitArray3[1];
							string str4 = waitArray4[1];
							string str5 = array2[1];
							tooltipLine.text = string.Concat(new object[]
							{
								"测出你的近战武器熟练度\n装备中你的近战武器熟练度提升更快\n你的近战等级越高你的近战伤害，速度，暴击率越高\n近战武器熟练度(最高12500): ",
								str,
								"\n近战等级(最高15): ",
								str2,
								"\n近战伤害提升: ",
								str3,
								"\n近战速度提升: ",
								str4,
								"\n近战暴击率提升: ",
								str5
							});
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MagicLevelMeter"))
				{
					foreach (TooltipLine tooltipLine2 in tooltips)
					{
						if (tooltipLine2.Name == "Tooltip0")
						{
							string[] array3 = Regex.Split(tooltipLine2.text, "\n");
							string[] waitArray5 = Regex.Split(array3[3], ": ");
							string[] waitArray6 = Regex.Split(array3[4], ": ");
							string[] waitArray7 = Regex.Split(array3[5], ": ");
							string[] waitArray8 = Regex.Split(array3[6], ": ");
							string[] array4 = Regex.Split(array3[7], ": ");
							string str6 = waitArray5[1];
							string str7 = waitArray6[1];
							string str8 = waitArray7[1];
							string str9 = waitArray8[1];
							string str10 = array4[1];
							tooltipLine2.text = string.Concat(new object[]
							{
								"测出你的魔法武器熟练度\n装备中你的魔法武器熟练度提升更快\n你的魔法等级越高你的魔法伤害，暴击率越高，魔力消耗越低\n魔法武器熟练度(最高12500): ",
								str6,
								"\n魔法等级(最高15): ",
								str7,
								"\n魔法伤害提升: ",
								str8,
								"\n魔力消耗降低: ",
								str9,
								"\n魔法暴击率提升: ",
								str10
							});
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RangedLevelMeter"))
				{
					foreach (TooltipLine tooltipLine3 in tooltips)
					{
						if (tooltipLine3.Name == "Tooltip0")
						{
							string[] array5 = Regex.Split(tooltipLine3.text, "\n");
							string[] waitArray9 = Regex.Split(array5[3], ": ");
							string[] waitArray10 = Regex.Split(array5[4], ": ");
							string[] waitArray11 = Regex.Split(array5[5], ": ");
							string[] waitArray12 = Regex.Split(array5[6], ": ");
							string[] array6 = Regex.Split(array5[7], ": ");
							string str11 = waitArray9[1];
							string str12 = waitArray10[1];
							string str13 = waitArray11[1];
							string str14 = waitArray12[1];
							string str15 = array6[1];
							tooltipLine3.text = string.Concat(new object[]
							{
								"测出你的远程武器熟练度\n装备中你的远程武器熟练度提升更快\n你的远程等级越高你的远程伤害，暴击率越高，移动速度越快\n远程武器熟练度(最高12500): ",
								str11,
								"\n远程等级(最高15): ",
								str12,
								"\n远程伤害提升: ",
								str13,
								"\n移动速度提升: ",
								str14,
								"\n远程暴击率提升: ",
								str15
							});
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RogueLevelMeter"))
				{
					foreach (TooltipLine tooltipLine4 in tooltips)
					{
						if (tooltipLine4.Name == "Tooltip0")
						{
							string[] array7 = Regex.Split(tooltipLine4.text, "\n");
							string[] waitArray13 = Regex.Split(array7[3], ": ");
							string[] waitArray14 = Regex.Split(array7[4], ": ");
							string[] waitArray15 = Regex.Split(array7[5], ": ");
							string[] waitArray16 = Regex.Split(array7[6], ": ");
							string[] array8 = Regex.Split(array7[7], ": ");
							string str16 = waitArray13[1];
							string str17 = waitArray14[1];
							string str18 = waitArray15[1];
							string str19 = waitArray16[1];
							string str20 = array8[1];
							tooltipLine4.text = string.Concat(new object[]
							{
								"测出你的盗贼武器熟练度\n装备中你的盗贼武器熟练度提升更快\n你的盗贼等级越高你的盗贼伤害，盗贼投掷速度，暴击率越高\n盗贼武器熟练度(最高12500): ",
								str16,
								"\n盗贼等级(最高15): ",
								str17,
								"\n盗贼伤害提升: ",
								str18,
								"\n盗贼投掷速度提升: ",
								str19,
								"\n盗贼暴击率提升: ",
								str20
							});
						}
					}
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SummonLevelMeter"))
				{
					foreach (TooltipLine tooltipLine5 in tooltips)
					{
						if (tooltipLine5.Name == "Tooltip0")
						{
							string[] array9 = Regex.Split(tooltipLine5.text, "\n");
							string[] waitArray17 = Regex.Split(array9[3], ": ");
							string[] waitArray18 = Regex.Split(array9[4], ": ");
							string[] waitArray19 = Regex.Split(array9[5], ": ");
							string[] waitArray20 = Regex.Split(array9[6], ": ");
							string[] array10 = Regex.Split(array9[7], ": ");
							string str21 = waitArray17[1];
							string str22 = waitArray18[1];
							string str23 = waitArray19[1];
							string str24 = waitArray20[1];
							string str25 = array10[1];
							tooltipLine5.text = string.Concat(new object[]
							{
								"测出你的召唤武器熟练度\n装备中你的召唤武器熟练度提升更快\n你的召唤等级越高你的召唤物伤害，击退越高，并获得额外召唤栏\n召唤武器熟练度(最高12500): ",
								str21,
								"\n召唤等级(最高15): ",
								str22,
								"\n召唤物伤害提升: ",
								str23,
								"\n召唤物击退提升: ",
								str24,
								"\n召唤栏增加: ",
								str25
							});
						}
					}
				}
			}
		}
	}
}
