using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Items
{
	// Token: 0x02000036 RID: 54
	public class CalamityPlaceableItem : GlobalItem
	{
		// Token: 0x0600007B RID: 123 RVA: 0x0000ED68 File Offset: 0x0000CF68
		public override void SetDefaults(Item item)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AbyssGravel"))
				{
					item.SetNameOverride("深渊砾石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerialiteBrick"))
				{
					item.SetNameOverride("天蓝砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerialiteBrickWall"))
				{
					item.SetNameOverride("天蓝砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerialiteOre"))
				{
					item.SetNameOverride("天蓝矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstrageldonTrophy"))
				{
					item.SetNameOverride("白金之星荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBar"))
				{
					item.SetNameOverride("炫星锭");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBrick"))
				{
					item.SetNameOverride("炫星砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralBrickWall"))
				{
					item.SetNameOverride("炫星砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralChest"))
				{
					item.SetNameOverride("炫星箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralChest"))
				{
					item.SetNameOverride("炫星箱");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralDirt"))
				{
					item.SetNameOverride("星幻土");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralDirtWall"))
				{
					item.SetNameOverride("星幻土墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralGrassWall"))
				{
					item.SetNameOverride("星幻石墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralIce"))
				{
					item.SetNameOverride("星幻晶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralIceWall"))
				{
					item.SetNameOverride("星幻冰晶墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralMonolith"))
				{
					item.SetNameOverride("炫星巨木");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralMonolithWall"))
				{
					item.SetNameOverride("炫星巨木墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralOre"))
				{
					item.SetNameOverride("炫星矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralSand"))
				{
					item.SetNameOverride("星幻沙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralSandstone"))
				{
					item.SetNameOverride("星幻砂岩");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralSandstoneWall"))
				{
					item.SetNameOverride("星幻砂岩墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralStone"))
				{
					item.SetNameOverride("慧星石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralStoneWall"))
				{
					item.SetNameOverride("慧星石墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstrumDeusTrophy"))
				{
					item.SetNameOverride("星神游龙荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricOre"))
				{
					item.SetNameOverride("圣金源矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueBrickWallUnsafe"))
				{
					item.SetNameOverride("蓝地牢砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueSlabWallUnsafe"))
				{
					item.SetNameOverride("蓝地牢板墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueTiledWallUnsafe"))
				{
					item.SetNameOverride("蓝地牢瓷墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneElementalTrophy"))
				{
					item.SetNameOverride("硫磺火元素荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneSlag"))
				{
					item.SetNameOverride("硫磺火石砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BrimstoneSlagWall"))
				{
					item.SetNameOverride("硫磺火石砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BumblebirbTrophy"))
				{
					item.SetNameOverride("嗡嗡蜂鸟荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CalamitasTrophy"))
				{
					item.SetNameOverride("灾厄之影荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CataclysmTrophy"))
				{
					item.SetNameOverride("灾祸荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CatastropheTrophy"))
				{
					item.SetNameOverride("灾难荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CeaselessVoidTrophy"))
				{
					item.SetNameOverride("无尽虚空荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaosCandle"))
				{
					item.SetNameOverride("混乱蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaoticBrick"))
				{
					item.SetNameOverride("混乱砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaoticBrickWall"))
				{
					item.SetNameOverride("混乱砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaoticOre"))
				{
					item.SetNameOverride("混乱矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CharredOre"))
				{
					item.SetNameOverride("焦炭矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Cinderplate"))
				{
					item.SetNameOverride("狱烬石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CinderplateWall"))
				{
					item.SetNameOverride("狱烬石墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrabulonTrophy"))
				{
					item.SetNameOverride("蘑菇蟹荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryogenTrophy"))
				{
					item.SetNameOverride("极地之灵荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryonicBrick"))
				{
					item.SetNameOverride("寒元砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryonicBrickWall"))
				{
					item.SetNameOverride("寒元砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryonicOre"))
				{
					item.SetNameOverride("寒元矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DesertScourgeTrophy"))
				{
					item.SetNameOverride("荒漠灾虫荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DevourerofGodsTrophy"))
				{
					item.SetNameOverride("神明吞噬者荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonsForge"))
				{
					item.SetNameOverride("嘉登熔炉");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicSand"))
				{
					item.SetNameOverride("富营养沙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicSandWall"))
				{
					item.SetNameOverride("富营养沙墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicSandWallSafe"))
				{
					item.SetNameOverride("富营养沙墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ExodiumClusterOre"))
				{
					item.SetNameOverride("起源之簇");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreenBrickWallUnsafe"))
				{
					item.SetNameOverride("绿地牢砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreenSlabWallUnsafe"))
				{
					item.SetNameOverride("绿地牢板墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreenTiledWallUnsafe"))
				{
					item.SetNameOverride("绿地牢瓷墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HardenedAstralSand"))
				{
					item.SetNameOverride("硬化星幻沙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HardenedAstralSandWall"))
				{
					item.SetNameOverride("硬化星幻沙墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HiveMindTrophy"))
				{
					item.SetNameOverride("腐巢意志荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LeviathanTrophy"))
				{
					item.SetNameOverride("利维坦荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Navystone"))
				{
					item.SetNameOverride("沉沦渊石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NavystoneWall"))
				{
					item.SetNameOverride("沉沦渊石墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NavystoneWallSafe"))
				{
					item.SetNameOverride("沉沦渊石墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerennialBrick"))
				{
					item.SetNameOverride("亘青砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerennialBrickWall"))
				{
					item.SetNameOverride("亘青砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerennialOre"))
				{
					item.SetNameOverride("亘青矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerforatorTrophy"))
				{
					item.SetNameOverride("血肉宿主荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkBrickWallUnsafe"))
				{
					item.SetNameOverride("粉地牢砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkSlabWallUnsafe"))
				{
					item.SetNameOverride("粉地牢板墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkTiledWallUnsafe"))
				{
					item.SetNameOverride("粉地牢瓷墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlaguebringerGoliathTrophy"))
				{
					item.SetNameOverride("瘟疫使者歌莉娅荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PlantyMush"))
				{
					item.SetNameOverride("植物混融块");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PolterghastTrophy"))
				{
					item.SetNameOverride("噬魂幽花荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PrismShard"))
				{
					item.SetNameOverride("棱晶碎片");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProvidenceTrophy"))
				{
					item.SetNameOverride("亵渎天神荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RavagerTrophy"))
				{
					item.SetNameOverride("毁灭魔像荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SeaPrism"))
				{
					item.SetNameOverride("海棱晶");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SignusTrophy"))
				{
					item.SetNameOverride("西格纳斯荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SlimeGodTrophy"))
				{
					item.SetNameOverride("史莱姆神荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SulphurousSand"))
				{
					item.SetNameOverride("硫磺沙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Tenebris"))
				{
					item.SetNameOverride("黑渊石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TranquilityCandle"))
				{
					item.SetNameOverride("宁静蜡烛");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UelibloomBrick"))
				{
					item.SetNameOverride("龙蒿砖");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UelibloomBrickWall"))
				{
					item.SetNameOverride("龙蒿砖墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UelibloomOre"))
				{
					item.SetNameOverride("龙蒿矿");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Voidstone"))
				{
					item.SetNameOverride("寂渊石");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("VoidstoneWall"))
				{
					item.SetNameOverride("寂渊石墙");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("WeaverTrophy"))
				{
					item.SetNameOverride("风暴编织者荣耀之证");
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YharonTrophy"))
				{
					item.SetNameOverride("亚戎荣耀之证");
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000FB78 File Offset: 0x0000DD78
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
			{
				ModTile tilename = TileLoader.GetTile(item.createTile);
				if (tilename != null && tilename.minPick > 0)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + tilename.minPick + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 25 || item.createTile == 203 || item.createTile == 25 || item.createTile == 203
				|| item.createTile == 117 || item.createTile == 404 || item.createTile == 56 || item.createTile == 58)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 65 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 22 || item.createTile == 204)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 55 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 211)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 200 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 37)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 50 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 226 || item.createTile == 237)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 210 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 107 || item.createTile == 221)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 100 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 108 || item.createTile == 222)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 110 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if(item.createTile == 111 || item.createTile == 223)
				{
					tooltips.Insert(1, new TooltipLine(base.mod, "minpick", "挖掘镐力需求：" + 150 + "%")
					{
						overrideColor = new Color?(Color.Goldenrod)
					});
				}
				if (ModLoader.GetMod("CalamityMod") != null)
				{
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueBrickWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "BlueBrickWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueSlabWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "BlueSlabWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlueTiledWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "BlueTiledWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaosCandle"))
					{
						foreach (TooltipLine ChaosCandletooltip in tooltips)
						{
							if (ChaosCandletooltip.Name == "Tooltip0")
							{
								ChaosCandletooltip.text = "这个蜡烛的存在大大激怒了附近的敌人";
							}
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Cinderplate"))
					{
						foreach (TooltipLine Cinderplatetooltip in tooltips)
						{
							if (Cinderplatetooltip.Name == "Tooltip0")
							{
								Cinderplatetooltip.text = "其上回响着异界之能量";
							}
						}
						tooltips.Insert(1, new TooltipLine(base.mod, "Cinderplate", "生成条件：随地图生成")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "Cinderplate", "生成位置：最大的小行星正中，红色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraedonsForge"))
					{
						foreach (TooltipLine DraedonsForgetooltip in tooltips)
						{
							if (DraedonsForgetooltip.Name == "Tooltip0")
							{
								DraedonsForgetooltip.text = "用来打造超级装备";
							}
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("EutrophicSandWallSafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "EutrophicSandWallSafe", "(可用于建筑npc居所)")
						{
							overrideColor = new Color?(Color.GreenYellow)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ExodiumClusterOre"))
					{
						foreach (TooltipLine ExodiumClusterOretooltip in tooltips)
						{
							if (ExodiumClusterOretooltip.Name == "Tooltip0")
							{
								ExodiumClusterOretooltip.text = "来自未知的冰冷奇物";
							}
						}
						tooltips.Insert(1, new TooltipLine(base.mod, "ExodiumClusterOre", "生成条件：击败月球领主")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "ExodiumClusterOre", "生成位置：小行星，黑色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreenBrickWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "GreenBrickWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreenSlabWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "GreenSlabWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GreenTiledWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "GreenTiledWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkBrickWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "PinkBrickWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkSlabWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "PinkSlabWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PinkTiledWallUnsafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "PinkTiledWallUnsafe", "(可构筑地牢环境)")
						{
							overrideColor = new Color?(Color.Pink)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NavystoneWallSafe"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "NavystoneWallSafe", "(可用于建筑npc居所)")
						{
							overrideColor = new Color?(Color.GreenYellow)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TranquilityCandle"))
					{
						foreach (TooltipLine DraedonsForgetooltip2 in tooltips)
						{
							if (DraedonsForgetooltip2.Name == "Tooltip0")
							{
								DraedonsForgetooltip2.text = "这个蜡烛的存在令附近敌人冷静了不少";
							}
						}
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AerialiteOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "AerialiteOre", "生成条件：击败血肉宿主/腐巢意志")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "AerialiteOre", "生成位置：地下，天蓝色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AstralOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "AstralOre", "生成条件：击败血肉之墙")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "AstralOre", "生成位置：彗星地，炫彩色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("AuricOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "AuricOre", "生成条件：击败丛林龙犽戎")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "AuricOre", "生成位置：洞穴层，金色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ChaoticOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "ChaoticOre", "生成条件：随地图生成")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "ChaoticOre", "生成位置：深渊浮岛，红色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CharredOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "CharredOre", "生成条件：随地图生成")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "CharredOre", "生成位置：地狱灾厄之地(硫磺火之崖、亵渎之涯)，红色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryonicOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "CryonicOre", "生成条件：击败极地之灵")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "CryonicOre", "生成位置：雪地地下，蓝白色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("PerennialOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "PerennialOre", "生成条件：击败世纪之花")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "PerennialOre", "生成位置：洞穴层，碧绿色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
						tooltips.Insert(1, new TooltipLine(base.mod, "usedname", "永恒矿")
						{
							overrideColor = new Color?(Color.SteelBlue)
						});
					}
					if (item.type == ModLoader.GetMod("CalamityMod").ItemType("UelibloomOre"))
					{
						tooltips.Insert(1, new TooltipLine(base.mod, "UelibloomOre", "生成条件：击败亵渎天神")
						{
							overrideColor = new Color?(Color.LightGreen)
						});
						tooltips.Insert(2, new TooltipLine(base.mod, "UelibloomOre", "生成位置：丛林地下，黄色")
						{
							overrideColor = new Color?(Color.LightBlue)
						});
					}
				}
			}
		}
	}
}
