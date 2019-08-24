using ZZLocalizationMod;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Localization;
using System.Text.RegularExpressions;

namespace ZZLocalizationMod.Items
{
    public class Calamitylevelmeter : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MeleeLevelMeter")))
                {
                    item.SetNameOverride("近战等级测量器");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MagicLevelMeter")))
                {
                    item.SetNameOverride("魔法等级测量器");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("RangedLevelMeter")))
                {
                    item.SetNameOverride("远程等级测量器");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("RogueLevelMeter")))
                {
                    item.SetNameOverride("盗贼等级测量器");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SummonLevelMeter")))
                {
                    item.SetNameOverride("召唤等级测量器");
                }
                
			}
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
                if(ModLoader.GetMod("CalamityMod") != null)
                {
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MeleeLevelMeter")))
			        {
                        
				        foreach (TooltipLine tooltipLine in tooltips)
				        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                string str = tooltipLine.text;
                                string[] strArray = Regex.Split(str, "\n");
                                string wait1 = strArray[3];
                                string[] waitArray1 = Regex.Split(wait1, ": ");
                                string wait2 = strArray[4];
                                string[] waitArray2 = Regex.Split(wait2, ": ");
                                string wait3 = strArray[5];
                                string[] waitArray3 = Regex.Split(wait3, ": ");
                                string wait4 = strArray[6];
                                string[] waitArray4 = Regex.Split(wait4, ": ");
                                string wait5 = strArray[7];
                                string[] waitArray5 = Regex.Split(wait5, ": ");
                                string str1 = waitArray1[1];
                                string str2 = waitArray2[1];
                                string str3 = waitArray3[1];
                                string str4 = waitArray4[1];
                                string str5 = waitArray5[1];
                                tooltipLine.text = string.Concat(new object[]
					            {
						            "测出你的近战武器熟练度\n装备中你的近战武器熟练度提升更快\n你的近战等级越高你的近战伤害，速度，暴击率越高\n近战武器熟练度(最高12500): ",
						            str1,
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
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MagicLevelMeter")))
			        {
                        
				        foreach (TooltipLine tooltipLine in tooltips)
				        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                string str = tooltipLine.text;
                                string[] strArray = Regex.Split(str, "\n");
                                string wait1 = strArray[3];
                                string[] waitArray1 = Regex.Split(wait1, ": ");
                                string wait2 = strArray[4];
                                string[] waitArray2 = Regex.Split(wait2, ": ");
                                string wait3 = strArray[5];
                                string[] waitArray3 = Regex.Split(wait3, ": ");
                                string wait4 = strArray[6];
                                string[] waitArray4 = Regex.Split(wait4, ": ");
                                string wait5 = strArray[7];
                                string[] waitArray5 = Regex.Split(wait5, ": ");
                                string str1 = waitArray1[1];
                                string str2 = waitArray2[1];
                                string str3 = waitArray3[1];
                                string str4 = waitArray4[1];
                                string str5 = waitArray5[1];
                                tooltipLine.text = string.Concat(new object[]
					            {
						            "测出你的魔法武器熟练度\n装备中你的魔法武器熟练度提升更快\n你的魔法等级越高你的魔法伤害，暴击率越高，魔力消耗越低\n魔法武器熟练度(最高12500): ",
						            str1,
						            "\n魔法等级(最高15): ",
						            str2,
						            "\n魔法伤害提升: ",
						            str3,
						            "\n魔力消耗降低: ",
						            str4,
						            "\n魔法暴击率提升: ",
						            str5
					            });
                            }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("RangedLevelMeter")))
			        {
                        
				        foreach (TooltipLine tooltipLine in tooltips)
				        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                string str = tooltipLine.text;
                                string[] strArray = Regex.Split(str, "\n");
                                string wait1 = strArray[3];
                                string[] waitArray1 = Regex.Split(wait1, ": ");
                                string wait2 = strArray[4];
                                string[] waitArray2 = Regex.Split(wait2, ": ");
                                string wait3 = strArray[5];
                                string[] waitArray3 = Regex.Split(wait3, ": ");
                                string wait4 = strArray[6];
                                string[] waitArray4 = Regex.Split(wait4, ": ");
                                string wait5 = strArray[7];
                                string[] waitArray5 = Regex.Split(wait5, ": ");
                                string str1 = waitArray1[1];
                                string str2 = waitArray2[1];
                                string str3 = waitArray3[1];
                                string str4 = waitArray4[1];
                                string str5 = waitArray5[1];
                                tooltipLine.text = string.Concat(new object[]
					            {
						            "测出你的远程武器熟练度\n装备中你的远程武器熟练度提升更快\n你的远程等级越高你的远程伤害，暴击率越高，移动速度越快\n远程武器熟练度(最高12500): ",
						            str1,
						            "\n远程等级(最高15): ",
						            str2,
						            "\n远程伤害提升: ",
						            str3,
						            "\n移动速度提升: ",
						            str4,
						            "\n远程暴击率提升: ",
						            str5
					            });
                            }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("RogueLevelMeter")))
			        {
                        
				        foreach (TooltipLine tooltipLine in tooltips)
				        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                string str = tooltipLine.text;
                                string[] strArray = Regex.Split(str, "\n");
                                string wait1 = strArray[3];
                                string[] waitArray1 = Regex.Split(wait1, ": ");
                                string wait2 = strArray[4];
                                string[] waitArray2 = Regex.Split(wait2, ": ");
                                string wait3 = strArray[5];
                                string[] waitArray3 = Regex.Split(wait3, ": ");
                                string wait4 = strArray[6];
                                string[] waitArray4 = Regex.Split(wait4, ": ");
                                string wait5 = strArray[7];
                                string[] waitArray5 = Regex.Split(wait5, ": ");
                                string str1 = waitArray1[1];
                                string str2 = waitArray2[1];
                                string str3 = waitArray3[1];
                                string str4 = waitArray4[1];
                                string str5 = waitArray5[1];
                                tooltipLine.text = string.Concat(new object[]
					            {
						            "测出你的盗贼武器熟练度\n装备中你的盗贼武器熟练度提升更快\n你的盗贼等级越高你的盗贼伤害，盗贼投掷速度，暴击率越高\n盗贼武器熟练度(最高12500): ",
						            str1,
						            "\n盗贼等级(最高15): ",
						            str2,
						            "\n盗贼伤害提升: ",
						            str3,
						            "\n盗贼投掷速度提升: ",
						            str4,
						            "\n盗贼暴击率提升: ",
						            str5
					            });
                            }
				        }
			        }
                    if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SummonLevelMeter")))
			        {
                        
				        foreach (TooltipLine tooltipLine in tooltips)
				        {
                            if (tooltipLine.Name == "Tooltip0")
                            {
                                string str = tooltipLine.text;
                                string[] strArray = Regex.Split(str, "\n");
                                string wait1 = strArray[3];
                                string[] waitArray1 = Regex.Split(wait1, ": ");
                                string wait2 = strArray[4];
                                string[] waitArray2 = Regex.Split(wait2, ": ");
                                string wait3 = strArray[5];
                                string[] waitArray3 = Regex.Split(wait3, ": ");
                                string wait4 = strArray[6];
                                string[] waitArray4 = Regex.Split(wait4, ": ");
                                string wait5 = strArray[7];
                                string[] waitArray5 = Regex.Split(wait5, ": ");
                                string str1 = waitArray1[1];
                                string str2 = waitArray2[1];
                                string str3 = waitArray3[1];
                                string str4 = waitArray4[1];
                                string str5 = waitArray5[1];
                                tooltipLine.text = string.Concat(new object[]
					            {
						            "测出你的召唤武器熟练度\n装备中你的召唤武器熟练度提升更快\n你的召唤等级越高你的召唤物伤害，击退越高，并获得额外召唤栏\n召唤武器熟练度(最高12500): ",
						            str1,
						            "\n召唤等级(最高15): ",
						            str2,
						            "\n召唤物伤害提升: ",
						            str3,
						            "\n召唤物击退提升: ",
						            str4,
						            "\n召唤栏增加: ",
						            str5
					            });
                            }
				        }
			        }
                }
            }
        }
	}
}