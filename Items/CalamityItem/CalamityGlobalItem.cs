using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	public class CalamityGlobalItem : GlobalItem
	{	
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == 3032)
				{
					foreach (TooltipLine tooltipLine2 in tooltips)
					{
						if (tooltipLine2.mod == "Terraria" && tooltipLine2.Name == "Tooltip0")
						{
							tooltipLine2.text = "能够吸收无穷无尽的水\n不能在深渊中使用";
						}
					}
				}
				if (item.type == 205)
				{
					foreach (TooltipLine tooltipLine3 in tooltips)
					{
						if (tooltipLine3.mod == "Terraria" && tooltipLine3.Name == "Defense")
						{
							tooltipLine3.text = "1防御力\n不能在深渊中使用";
						}
					}
				}
				if (item.type == 3062)
				{
					foreach (TooltipLine tooltipLine4 in tooltips)
					{
						if (tooltipLine4.mod == "Terraria" && tooltipLine4.Name == "Tooltip0")
						{
							tooltipLine4.text = "召唤一颗心脏来提供照明\n在深渊中提供少量光照";
						}
					}
				}
				if (item.type == 115)
				{
					foreach (TooltipLine tooltipLine5 in tooltips)
					{
						if (tooltipLine5.mod == "Terraria" && tooltipLine5.Name == "Tooltip0")
						{
							tooltipLine5.text = "一个发出微光的魔法小球\n在深渊中提供少量光照";
						}
					}
				}
				if (item.type == 3043)
				{
					foreach (TooltipLine tooltipLine6 in tooltips)
					{
						if (tooltipLine6.mod == "Terraria" && tooltipLine6.Name == "Tooltip0")
						{
							tooltipLine6.text = "召唤用来显露附近宝藏的魔法灯笼\n在深渊中提供少量光照";
						}
					}
				}
				if (item.type == 1861)
				{
					foreach (TooltipLine tooltipLine7 in tooltips)
					{
						if (tooltipLine7.mod == "Terraria" && tooltipLine7.Name == "Tooltip1")
						{
							tooltipLine7.text = "在水下提供照明, 并额外增加冰块上的灵活性\n在深渊中提供少量光照\n中等降低深渊中的呼吸流失";
						}
					}
				}
				if (item.type == 1303)
				{
					foreach (TooltipLine tooltipLine8 in tooltips)
					{
						if (tooltipLine8.mod == "Terraria" && tooltipLine8.Name == "Tooltip0")
						{
							tooltipLine8.text = "在水下提供照明\n在深渊中提供少量光照";
						}
					}
				}
				if (item.type == 1860)
				{
					foreach (TooltipLine tooltipLine9 in tooltips)
					{
						if (tooltipLine9.mod == "Terraria" && tooltipLine9.Name == "Tooltip1")
						{
							tooltipLine9.text = "在水下提供照明\n在深渊中提供少量光照";
						}
					}
				}
				if (item.type == 425)
				{
					foreach (TooltipLine tooltipLine10 in tooltips)
					{
						if (tooltipLine10.mod == "Terraria" && tooltipLine10.Name == "Tooltip0")
						{
							tooltipLine10.text = "召唤魔法精灵\n在深渊中提供中等光照";
						}
					}
				}
				if (item.type == 3856)
				{
					foreach (TooltipLine tooltipLine11 in tooltips)
					{
						if (tooltipLine11.mod == "Terraria" && tooltipLine11.Name == "Tooltip0")
						{
							tooltipLine11.text = "召唤一宠物闪烁烛芯来提供光源\n在深渊中提供中等光照";
						}
					}
				}
				if (item.type == 298)
				{
					foreach (TooltipLine tooltipLine12 in tooltips)
					{
						if (tooltipLine12.mod == "Terraria" && tooltipLine12.Name == "BuffTime")
						{
							tooltipLine12.text = "5分钟持续时间\n在深渊中提供中等光照";
						}
					}
				}
				if (item.type == 1183)
				{
					foreach (TooltipLine tooltipLine13 in tooltips)
					{
						if (tooltipLine13.mod == "Terraria" && tooltipLine13.Name == "Tooltip0")
						{
							tooltipLine13.text = "召唤瓶子里的小精灵来为你提供照明\n在深渊中提供大量光照";
						}
					}
				}
				if (item.type == 3577)
				{
					foreach (TooltipLine tooltipLine14 in tooltips)
					{
						if (tooltipLine14.mod == "Terraria" && tooltipLine14.Name == "Tooltip1")
						{
							tooltipLine14.text = "“我知道你在想什么...”\n在深渊中提供大量光照";
						}
					}
				}
				if (item.type == 291)
				{
					foreach (TooltipLine tooltipLine15 in tooltips)
					{
						if (tooltipLine15.mod == "Terraria" && tooltipLine15.Name == "BuffTime")
						{
							tooltipLine15.text = "2分钟持续时间\n极大降低深渊中的呼吸流失";
						}
					}
				}
				if (item.type == 268)
				{
					foreach (TooltipLine tooltipLine16 in tooltips)
					{
						if (tooltipLine16.mod == "Terraria" && tooltipLine16.Name == "Tooltip0")
						{
							tooltipLine16.text = "大大延长水下呼吸时间\n中等降低深渊中的呼吸流失";
						}
					}
				}
				if (item.type == 497)
				{
					foreach (TooltipLine tooltipLine17 in tooltips)
					{
						if (tooltipLine17.mod == "Terraria" && tooltipLine17.Name == "Tooltip0")
						{
							tooltipLine17.text = "入水时将变成人鱼\n极大降低深渊中的呼吸流失";
						}
					}
				}
				if (item.type == 861)
				{
					foreach (TooltipLine tooltipLine18 in tooltips)
					{
						if (tooltipLine18.mod == "Terraria" && tooltipLine18.Name == "Tooltip0")
						{
							tooltipLine18.text = "在晚上你将变成狼人,入水时将变成人鱼,你已经超...已经不是人了\n极大降低深渊中的呼吸流失";
						}
					}
				}
				if (item.type == 3110)
				{
					foreach (TooltipLine tooltipLine19 in tooltips)
					{
						if (tooltipLine19.mod == "Terraria" && tooltipLine19.Name == "Tooltip1")
						{
							tooltipLine19.text = "小幅度提升所有属性\n极大降低深渊中的呼吸流失";
						}
					}
				}
				if (item.type == 3224)
				{
					foreach (TooltipLine tooltipLine20 in tooltips)
					{
						if (tooltipLine20.mod == "Terraria" && tooltipLine20.Name == "Tooltip0")
						{
							tooltipLine20.text = "减少10%所受伤害";
						}
					}
				}
				if (item.type == 1503)
				{
					foreach (TooltipLine tooltipLine21 in tooltips)
					{
						if (tooltipLine21.mod == "Terraria" && tooltipLine21.Name == "Tooltip0")
						{
							tooltipLine21.text = "减少20%魔法伤害";
						}
					}
				}
				if (item.type == 3797)
				{
					foreach (TooltipLine tooltipLine22 in tooltips)
					{
						if (tooltipLine22.mod == "Terraria" && tooltipLine22.Name == "Tooltip0")
						{
							tooltipLine22.text = "增加炮台召唤栏, 减少10%法力消耗\n增加30%召唤伤害";
						}
					}
				}
				if (item.type == 3798)
				{
					foreach (TooltipLine tooltipLine23 in tooltips)
					{
						if (tooltipLine23.mod == "Terraria" && tooltipLine23.Name == "Tooltip0")
						{
							tooltipLine23.text = "增加10%魔法伤害";
						}
					}
				}
				if (item.type == 3799)
				{
					foreach (TooltipLine tooltipLine24 in tooltips)
					{
						if (tooltipLine24.mod == "Terraria" && tooltipLine24.Name == "Tooltip0")
						{
							tooltipLine24.text = "增加20%移动速度";
						}
					}
				}
				if (item.type == 3800)
				{
					foreach (TooltipLine tooltipLine25 in tooltips)
					{
						if (tooltipLine25.mod == "Terraria" && tooltipLine25.Name == "Tooltip0")
						{
							tooltipLine25.text = "增加炮台召唤栏,增加生命再生速度\n增加30%召唤伤害和20%近战暴击率";
						}
					}
				}
				if (item.type == 3801)
				{
					foreach (TooltipLine tooltipLine26 in tooltips)
					{
						if (tooltipLine26.mod == "Terraria" && tooltipLine26.Name == "Tooltip0")
						{
							tooltipLine26.text = "增加15%召唤伤害";
						}
					}
				}
				if (item.type == 3802)
				{
					foreach (TooltipLine tooltipLine27 in tooltips)
					{
						if (tooltipLine27.mod == "Terraria" && tooltipLine27.Name == "Tooltip0")
						{
							tooltipLine27.text = "增加20%移动速度";
						}
					}
				}
				if (item.type == 3803)
				{
					foreach (TooltipLine tooltipLine28 in tooltips)
					{
						if (tooltipLine28.mod == "Terraria" && tooltipLine28.Name == "Tooltip0")
						{
							tooltipLine28.text = "增加炮台召唤栏,增加10%远程暴击率\n增加30%召唤伤害";
						}
					}
				}
				if (item.type == 3804)
				{
					foreach (TooltipLine tooltipLine29 in tooltips)
					{
						if (tooltipLine29.mod == "Terraria" && tooltipLine29.Name == "Tooltip0")
						{
							tooltipLine29.text = "增加20%远程伤害";
						}
					}
				}
				if (item.type == 3805)
				{
					foreach (TooltipLine tooltipLine30 in tooltips)
					{
						if (tooltipLine30.mod == "Terraria" && tooltipLine30.Name == "Tooltip0")
						{
							tooltipLine30.text = "增加20%移动速度";
						}
					}
				}
				if (item.type == 3806)
				{
					foreach (TooltipLine tooltipLine31 in tooltips)
					{
						if (tooltipLine31.mod == "Terraria" && tooltipLine31.Name == "Tooltip0")
						{
							tooltipLine31.text = "增加炮台召唤栏,增加20%近战伤害\n增加30%召唤伤害并且增加10%近战暴击率";
						}
					}
				}
				if (item.type == 3807)
				{
					foreach (TooltipLine tooltipLine32 in tooltips)
					{
						if (tooltipLine32.mod == "Terraria" && tooltipLine32.Name == "Tooltip0")
						{
							tooltipLine32.text = "增加20%近战伤害";
						}
					}
				}
				if (item.type == 3808)
				{
					foreach (TooltipLine tooltipLine33 in tooltips)
					{
						if (tooltipLine33.mod == "Terraria" && tooltipLine33.Name == "Tooltip0")
						{
							tooltipLine33.text = "增加20%移动速度";
						}
						if (tooltipLine33.mod == "Terraria" && tooltipLine33.Name == "Tooltip1")
						{
							tooltipLine33.text = "";
						}
					}
				}
				if (item.type == 3874)
				{
					foreach (TooltipLine tooltipLine34 in tooltips)
					{
						if (tooltipLine34.mod == "Terraria" && tooltipLine34.Name == "Tooltip1")
						{
							tooltipLine34.text = "增加60%召唤伤害以及25%魔法伤害和暴击率";
						}
					}
				}
				if (item.type == 3875)
				{
					foreach (TooltipLine tooltipLine35 in tooltips)
					{
						if (tooltipLine35.mod == "Terraria" && tooltipLine35.Name == "Tooltip0")
						{
							tooltipLine35.text = "";
						}
					}
				}
				if (item.type == 3876)
				{
					foreach (TooltipLine tooltipLine36 in tooltips)
					{
						if (tooltipLine36.mod == "Terraria" && tooltipLine36.Name == "Tooltip0")
						{
							tooltipLine36.text = "";
						}
					}
				}
				if (item.type == 3880)
				{
					foreach (TooltipLine tooltipLine37 in tooltips)
					{
						if (tooltipLine37.mod == "Terraria" && tooltipLine37.Name == "Tooltip0")
						{
							tooltipLine37.text = "提升你的哨兵召唤上限\n提升20%近战伤害, 速度和暴击率以及60%召唤伤害";
						}
					}
				}
				if (item.type == 3881)
				{
					foreach (TooltipLine tooltipLine38 in tooltips)
					{
						if (tooltipLine38.mod == "Terraria" && tooltipLine38.Name == "Tooltip0")
						{
							tooltipLine38.text = "";
						}
					}
				}
				if (item.type == 3882)
				{
					foreach (TooltipLine tooltipLine39 in tooltips)
					{
						if (tooltipLine39.mod == "Terraria" && tooltipLine39.Name == "Tooltip0")
						{
							tooltipLine39.text = "增加20%移动速度";
						}
					}
				}
				if (item.type == 3877)
				{
					foreach (TooltipLine tooltipLine40 in tooltips)
					{
						if (tooltipLine40.mod == "Terraria" && tooltipLine40.Name == "Tooltip1")
						{
							tooltipLine40.text = "增加60%召唤伤害和10%远程暴击率\n增加25%远程伤害";
						}
					}
				}
				if (item.type == 3878)
				{
					foreach (TooltipLine tooltipLine41 in tooltips)
					{
						if (tooltipLine41.mod == "Terraria" && tooltipLine41.Name == "Tooltip0")
						{
							tooltipLine41.text = "";
						}
					}
				}
				if (item.type == 3879)
				{
					foreach (TooltipLine tooltipLine42 in tooltips)
					{
						if (tooltipLine42.mod == "Terraria" && tooltipLine42.Name == "Tooltip0")
						{
							tooltipLine42.text = "增加20%移动速度";
						}
					}
				}
				if (item.type == 3871)
				{
					foreach (TooltipLine tooltipLine43 in tooltips)
					{
						if (tooltipLine43.mod == "Terraria" && tooltipLine43.Name == "Tooltip0")
						{
							tooltipLine43.text = "增加炮台召唤栏,并增加60%召唤伤害\n增加20%近战暴击率";
						}
					}
				}
				if (item.type == 3872)
				{
					foreach (TooltipLine tooltipLine44 in tooltips)
					{
						if (tooltipLine44.mod == "Terraria" && tooltipLine44.Name == "Tooltip0")
						{
							tooltipLine44.text = "大幅度增加生命再生速度";
						}
					}
				}
				if (item.type == 3873)
				{
					foreach (TooltipLine tooltipLine45 in tooltips)
					{
						if (tooltipLine45.mod == "Terraria" && tooltipLine45.Name == "Tooltip0")
						{
							tooltipLine45.text = "增加30%移动速度";
						}
					}
				}
				if (item.type == 288)
				{
					foreach (TooltipLine tooltipLine46 in tooltips)
					{
						if (tooltipLine46.mod == "Terraria" && tooltipLine46.Name == "Tooltip0")
						{
							tooltipLine46.text = "免疫岩浆的直接接触伤害\n暂时免疫岩浆的灼伤\n减少岩浆对你的伤害";
						}
					}
				}
				if (item.type == 1323)
				{
					foreach (TooltipLine tooltipLine47 in tooltips)
					{
						if (tooltipLine47.mod == "Terraria" && tooltipLine47.Name == "Tooltip0")
						{
							tooltipLine47.text = "免疫岩浆的直接接触伤害\n极大减少岩浆对你的伤害";
						}
					}
				}
				if (item.type == 123 || item.type == 124 || item.type == 125)
				{
					foreach (TooltipLine tooltipLine48 in tooltips)
					{
						if (tooltipLine48.mod == "Terraria" && tooltipLine48.Name == "SetBonus")
						{
							tooltipLine48.text = "套装奖励: 减少空间枪50%的魔法消耗";
						}
					}
				}
				if (item.type == 89 || item.type == 80 || item.type == 76)
				{
					foreach (TooltipLine tooltipLine49 in tooltips)
					{
						if (tooltipLine49.mod == "Terraria" && tooltipLine49.Name == "SetBonus")
						{
							tooltipLine49.text = "套装奖励: +2防御力并增加15%挖掘速度";
						}
					}
				}
				if (item.type == 687 || item.type == 688 || item.type == 689)
				{
					foreach (TooltipLine tooltipLine50 in tooltips)
					{
						if (tooltipLine50.mod == "Terraria" && tooltipLine50.Name == "SetBonus")
						{
							tooltipLine50.text = "套装奖励: +2防御力并增加10%挖掘速度";
						}
					}
				}
				if (item.type == 90 || item.type == 81 || item.type == 77)
				{
					foreach (TooltipLine tooltipLine51 in tooltips)
					{
						if (tooltipLine51.mod == "Terraria" && tooltipLine51.Name == "SetBonus")
						{
							tooltipLine51.text = "套装奖励: +2防御力并增加25%挖掘速度";
						}
					}
				}
				if (item.type == 690 || item.type == 691 || item.type == 692)
				{
					foreach (TooltipLine tooltipLine52 in tooltips)
					{
						if (tooltipLine52.mod == "Terraria" && tooltipLine52.Name == "SetBonus")
						{
							tooltipLine52.text = "套装奖励: +3防御力并增加20%挖掘速度";
						}
					}
				}
				if (item.type == 91 || item.type == 82 || item.type == 78)
				{
					foreach (TooltipLine tooltipLine53 in tooltips)
					{
						if (tooltipLine53.mod == "Terraria" && tooltipLine53.Name == "SetBonus")
						{
							tooltipLine53.text = "套装奖励: +3防御力并增加35%挖掘速度";
						}
					}
				}
				if (item.type == 693 || item.type == 694 || item.type == 695)
				{
					foreach (TooltipLine tooltipLine54 in tooltips)
					{
						if (tooltipLine54.mod == "Terraria" && tooltipLine54.Name == "SetBonus")
						{
							tooltipLine54.text = "套装奖励: +3防御力并增加30%挖掘速度";
						}
					}
				}
				if (item.type == 92 || item.type == 83 || item.type == 79)
				{
					foreach (TooltipLine tooltipLine55 in tooltips)
					{
						if (tooltipLine55.mod == "Terraria" && tooltipLine55.Name == "SetBonus")
						{
							tooltipLine55.text = "套装奖励: +3防御力并增加45%挖掘速度";
						}
					}
				}
				if (item.type == 696 || item.type == 697 || item.type == 698)
				{
					foreach (TooltipLine tooltipLine56 in tooltips)
					{
						if (tooltipLine56.mod == "Terraria" && tooltipLine56.Name == "SetBonus")
						{
							tooltipLine56.text = "套装奖励: +4防御力并且提升40%挖掘速度";
						}
					}
				}
				if (item.type == 3187)
				{
					foreach (TooltipLine tooltipLine57 in tooltips)
					{
						if (tooltipLine57.mod == "Terraria" && tooltipLine57.Name == "Defense")
						{
							tooltipLine57.text = "4防御力\n增加5%盗贼伤害";
						}
					}
				}
				if (item.type == 3188)
				{
					foreach (TooltipLine tooltipLine58 in tooltips)
					{
						if (tooltipLine58.mod == "Terraria" && tooltipLine58.Name == "Defense")
						{
							tooltipLine58.text = "7防御力\n增加5%盗贼暴击率";
						}
					}
				}
				if (item.type == 3189)
				{
					foreach (TooltipLine tooltipLine59 in tooltips)
					{
						if (tooltipLine59.mod == "Terraria" && tooltipLine59.Name == "Defense")
						{
							tooltipLine59.text = "5防御力\n增加5%盗贼投掷速度";
						}
					}
				}
				if (item.type == 3266)
				{
					foreach (TooltipLine tooltipLine60 in tooltips)
					{
						if (tooltipLine60.mod == "Terraria" && tooltipLine60.Name == "Defense")
						{
							tooltipLine60.text = "4防御力\n增加5%盗贼伤害";
						}
					}
				}
				if (item.type == 3267)
				{
					foreach (TooltipLine tooltipLine61 in tooltips)
					{
						if (tooltipLine61.mod == "Terraria" && tooltipLine61.Name == "Defense")
						{
							tooltipLine61.text = "5防御力\n增加5%盗贼暴击率";
						}
					}
				}
				if (item.type == 3268)
				{
					foreach (TooltipLine tooltipLine62 in tooltips)
					{
						if (tooltipLine62.mod == "Terraria" && tooltipLine62.Name == "Defense")
						{
							tooltipLine62.text = "4防御力\n增加5%盗贼投掷速度";
						}
					}
				}
				if (item.type == 1321)
				{
					foreach (TooltipLine tooltipLine63 in tooltips)
					{
						if (tooltipLine63.mod == "Terraria" && tooltipLine63.Name == "Tooltip0")
						{
							tooltipLine63.text = "增加10%弓箭伤害,大大增加弓箭速度";
						}
					}
				}
				if (item.type == 493 || item.type == 492)
				{
					foreach (TooltipLine tooltipLine64 in tooltips)
					{
						if (tooltipLine64.mod == "Terraria" && tooltipLine64.Name == "Tooltip0")
						{
							tooltipLine64.text = "允许飞行和滑翔\n水平飞行速度: 6.25\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 100";
						}
					}
				}
				if (item.type == 748)
				{
					foreach (TooltipLine tooltipLine65 in tooltips)
					{
						if (tooltipLine65.mod == "Terraria" && tooltipLine65.Name == "Tooltip0")
						{
							tooltipLine65.text = "允许飞行和滑翔\n水平飞行速度: 6.5\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 115";
						}
					}
				}
				if (item.type == 749 || item.type == 761 || item.type == 1515)
				{
					foreach (TooltipLine tooltipLine66 in tooltips)
					{
						if (tooltipLine66.mod == "Terraria" && tooltipLine66.Name == "Tooltip0")
						{
							tooltipLine66.text = "允许飞行和滑翔\n水平飞行速度: 6.75\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 130";
						}
					}
				}
				if (item.type == 785 || item.type == 786)
				{
					foreach (TooltipLine tooltipLine67 in tooltips)
					{
						if (tooltipLine67.mod == "Terraria" && tooltipLine67.Name == "Tooltip0")
						{
							tooltipLine67.text = "允许飞行和滑翔\n水平飞行速度: 7\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 140";
						}
					}
				}
				if (item.type == 821 || item.type == 822 || item.type == 823 || item.type == 2280)
				{
					foreach (TooltipLine tooltipLine68 in tooltips)
					{
						if (tooltipLine68.mod == "Terraria" && tooltipLine68.Name == "Tooltip0")
						{
							tooltipLine68.text = "允许飞行和滑翔\n水平飞行速度: 7.5\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 160";
						}
					}
				}
				if (item.type == 2494)
				{
					foreach (TooltipLine tooltipLine69 in tooltips)
					{
						if (tooltipLine69.mod == "Terraria" && tooltipLine69.Name == "Tooltip0")
						{
							tooltipLine69.text = "允许飞行和滑翔\n水平飞行速度: 0\n加速倍率: 0\n普通的垂直飞行速度\n飞行时间: 100";
						}
					}
				}
				if (item.type == 2609)
				{
					foreach (TooltipLine tooltipLine70 in tooltips)
					{
						if (tooltipLine70.mod == "Terraria" && tooltipLine70.Name == "Tooltip0")
						{
							tooltipLine70.text = "允许飞行和滑翔\n水平飞行速度: 8\n加速倍率: 2\n不错的垂直飞行速度\n飞行时间: 180";
						}
					}
				}
				if (item.type == 948)
				{
					foreach (TooltipLine tooltipLine71 in tooltips)
					{
						if (tooltipLine71.mod == "Terraria" && tooltipLine71.Name == "Tooltip0")
						{
							tooltipLine71.text = "允许飞行和滑翔\n水平飞行速度: 7.75\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 180";
						}
					}
				}
				if (item.type == 1162)
				{
					foreach (TooltipLine tooltipLine72 in tooltips)
					{
						if (tooltipLine72.mod == "Terraria" && tooltipLine72.Name == "Tooltip0")
						{
							tooltipLine72.text = "允许飞行和滑翔\n水平飞行速度: 6.75\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 160";
						}
					}
				}
				if (item.type == 1165)
				{
					foreach (TooltipLine tooltipLine73 in tooltips)
					{
						if (tooltipLine73.mod == "Terraria" && tooltipLine73.Name == "Tooltip0")
						{
							tooltipLine73.text = "允许飞行和滑翔\n水平飞行速度: 0\n加速倍率: 0\n普通的垂直飞行速度\n飞行时间: 140";
						}
					}
				}
				if (item.type == 3580 || item.type == 3582 || item.type == 3588 || item.type == 3592 || item.type == 3924 || item.type == 3928 || item.type == 3228 || item.type == 665 || item.type == 1583 || item.type == 1584 || item.type == 1585 || item.type == 1586)
				{
					foreach (TooltipLine tooltipLine74 in tooltips)
					{
						if (tooltipLine74.mod == "Terraria" && tooltipLine74.Name == "Tooltip0")
						{
							tooltipLine74.text = "'非常适合伪装成开发者!'\n水平飞行速度: 7\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 150";
						}
					}
				}
				if (item.type == 1797 || item.type == 1830)
				{
					foreach (TooltipLine tooltipLine75 in tooltips)
					{
						if (tooltipLine75.mod == "Terraria" && tooltipLine75.Name == "Tooltip0")
						{
							tooltipLine75.text = "允许飞行和滑翔\n水平飞行速度: 7.5\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 180";
						}
					}
				}
				if (item.type == 1866)
				{
					foreach (TooltipLine tooltipLine76 in tooltips)
					{
						if (tooltipLine76.mod == "Terraria" && tooltipLine76.Name == "Tooltip0")
						{
							tooltipLine76.text = "允许飞行和滑翔\n水平飞行速度: 6.25\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 170";
						}
					}
				}
				if (item.type == 1871)
				{
					foreach (TooltipLine tooltipLine77 in tooltips)
					{
						if (tooltipLine77.mod == "Terraria" && tooltipLine77.Name == "Tooltip0")
						{
							tooltipLine77.text = "允许飞行和滑翔\n水平飞行速度: 7.5\n加速倍率: 1\n普通的垂直飞行速度\n飞行时间: 170";
						}
					}
				}
				if (item.type == 2770)
				{
					foreach (TooltipLine tooltipLine78 in tooltips)
					{
						if (tooltipLine78.mod == "Terraria" && tooltipLine78.Name == "Tooltip0")
						{
							tooltipLine78.text = "允许飞行和滑翔\n水平飞行速度: 0\n加速倍率: 0\n普通的垂直飞行速度\n飞行时间: 160";
						}
					}
				}
				if (item.type == 3468 || item.type == 3471)
				{
					foreach (TooltipLine tooltipLine79 in tooltips)
					{
						if (tooltipLine79.mod == "Terraria" && tooltipLine79.Name == "Tooltip0")
						{
							tooltipLine79.text = "允许飞行和滑翔\n水平飞行速度: 9\n加速倍率: 2.5\n极好的垂直飞行速度\n飞行时间: 180";
						}
					}
				}
				if (item.type == 3469 || item.type == 3470)
				{
					foreach (TooltipLine tooltipLine80 in tooltips)
					{
						if (tooltipLine80.mod == "Terraria" && tooltipLine80.Name == "Tooltip0")
						{
							tooltipLine80.text = "允许飞行和滑翔\n水平飞行速度: 6.5\n加速倍率: 1.5\n不错的垂直飞行速度\n飞行时间: 160";
						}
					}
				}
				if (item.type == 3883)
				{
					foreach (TooltipLine tooltipLine81 in tooltips)
					{
						if (tooltipLine81.mod == "Terraria" && tooltipLine81.Name == "Equipable")
						{
							tooltipLine81.text = "可装备\n允许飞行和滑翔\n水平飞行速度: 6\n加速倍率: 2.5\n不错的垂直飞行速度\n飞行时间: 150";
						}
					}
				}
				if (item.accessory)
				{
					if (item.prefix == 67)
					{
						foreach (TooltipLine tooltipLine82 in tooltips)
						{
							if (tooltipLine82.mod == "Terraria" && tooltipLine82.Name == "PrefixAccCritChance")
							{
								tooltipLine82.text = "增加1%暴击率";
							}
						}
					}
					if (item.prefix == 68)
					{
						foreach (TooltipLine tooltipLine83 in tooltips)
						{
							if (tooltipLine83.mod == "Terraria" && tooltipLine83.Name == "PrefixAccCritChance")
							{
								tooltipLine83.text = "增加2%暴击率";
							}
						}
					}
					if (item.prefix == 62)
					{
						foreach (TooltipLine tooltipLine84 in tooltips)
						{
							if (tooltipLine84.mod == "Terraria" && tooltipLine84.Name == "PrefixAccDefense")
							{
								tooltipLine84.text = "+1防御力\n增加0.25%伤害减免";
							}
						}
					}
					if (item.prefix == 63)
					{
						foreach (TooltipLine tooltipLine85 in tooltips)
						{
							if (tooltipLine85.mod == "Terraria" && tooltipLine85.Name == "PrefixAccDefense")
							{
								tooltipLine85.text = "+2防御力\n增加0.5%伤害减免";
							}
						}
					}
					if (item.prefix == 64)
					{
						foreach (TooltipLine tooltipLine86 in tooltips)
						{
							if (tooltipLine86.mod == "Terraria" && tooltipLine86.Name == "PrefixAccDefense")
							{
								tooltipLine86.text = "+3防御力\n增加0.75%伤害减免";
							}
						}
					}
					if (item.prefix == 65)
					{
						foreach (TooltipLine tooltipLine87 in tooltips)
						{
							if (tooltipLine87.mod == "Terraria" && tooltipLine87.Name == "PrefixAccDefense")
							{
								tooltipLine87.text = "+4防御力\n增加1%伤害减免";
							}
						}
					}
				}
			}
		}
	}
}
