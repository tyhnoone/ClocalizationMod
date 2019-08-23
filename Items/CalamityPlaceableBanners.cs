using CLocalizationMod;
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

namespace CLocalizationMod.Items
{
    public class CalamityPlaceableBanners : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
			if(LanguageManager.Instance.ActiveCulture == GameCulture.Chinese)
            {
            if(ModLoader.GetMod("CalamityMod") != null)
            {
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AeroSlimeBanner")))
                {
                    item.SetNameOverride("天蓝史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AmberCrawlerBanner")))
                {
                    item.SetNameOverride("琥珀爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AmethystCrawlerBanner")))
                {
                    item.SetNameOverride("紫水晶爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AngryDogBanner")))
                {
                    item.SetNameOverride("愤怒的雪狗旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AquaticAberrationBanner")))
                {
                    item.SetNameOverride("渊海吞食者旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AquaticParasiteBanner")))
                {
                    item.SetNameOverride("渊海寄生虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AquaticSeekerBanner")))
                {
                    item.SetNameOverride("渊海追魂虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AquaticUrchinBanner")))
                {
                    item.SetNameOverride("渊海海胆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AriesBanner")))
                {
                    item.SetNameOverride("白羊座旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ArmoredDiggerBanner")))
                {
                    item.SetNameOverride("装甲掘地虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AstralachneaBanner")))
                {
                    item.SetNameOverride("星幻蛛旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AstralProbeBanner")))
                {
                    item.SetNameOverride("幻星探测器旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AstralSlimeBanner")))
                {
                    item.SetNameOverride("幻星史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("AtlasBanner")))
                {
                    item.SetNameOverride("擎星者旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BigSightseerBanner")))
                {
                    item.SetNameOverride("大监星眼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BlightedEyeBanner")))
                {
                    item.SetNameOverride("枯萎之眼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BlindedAnglerBanner")))
                {
                    item.SetNameOverride("盲眼鮟鱇旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BloatfishBanner")))
                {
                    item.SetNameOverride("肿胀翻车鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BloomSlimeBanner")))
                {
                    item.SetNameOverride("龙蒿史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BobbitWormBanner")))
                {
                    item.SetNameOverride("博比特虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BOHLDOHRBanner")))
                {
                    item.SetNameOverride("BOHLDOHR旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("BoxJellyfishBanner")))
                {
                    item.SetNameOverride("灯水母旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CalamityEyeBanner")))
                {
                    item.SetNameOverride("小灾厄眼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CatfishBanner")))
                {
                    item.SetNameOverride("鲶鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ChaoticPufferBanner")))
                {
                    item.SetNameOverride("混乱渊豚旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CharredSlimeBanner")))
                {
                    item.SetNameOverride("焦炭史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ClamBanner")))
                {
                    item.SetNameOverride("大蛤旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CloudElementalBanner")))
                {
                    item.SetNameOverride("雨云元素旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CnidrionBanner")))
                {
                    item.SetNameOverride("卧龙海马旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ColossalSquidBanner")))
                {
                    item.SetNameOverride("巨像乌贼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CosmicElementalBanner")))
                {
                    item.SetNameOverride("宇宙元素旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CrimulanBlightSlimeBanner")))
                {
                    item.SetNameOverride("血腥枯萎史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CryonBanner")))
                {
                    item.SetNameOverride("冰人旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CryoSlimeBanner")))
                {
                    item.SetNameOverride("寒元史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CrystalCrawlerBanner")))
                {
                    item.SetNameOverride("水晶爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CultistAssassinBanner")))
                {
                    item.SetNameOverride("邪教刺客旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("CuttlefishBanner")))
                {
                    item.SetNameOverride("红乌贼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("DespairStoneBanner")))
                {
                    item.SetNameOverride("绝望之石旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("DevilFishBanner")))
                {
                    item.SetNameOverride("恶魔鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("DiamondCrawlerBanner")))
                {
                    item.SetNameOverride("钻石爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EarthElementalBanner")))
                {
                    item.SetNameOverride("地元魔魂旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EbonianBlightSlime")))
                {
                    item.SetNameOverride("黑檀枯萎史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EidolistBanner")))
                {
                    item.SetNameOverride("幻妖灵巫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EidolonWyrmJuvenileBanner")))
                {
                    item.SetNameOverride("幻海妖龙旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EmeraldCrawlerBanner")))
                {
                    item.SetNameOverride("绿宝石爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("EutrophicRayBanner")))
                {
                    item.SetNameOverride("沉沦渊鳐旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("FlounderBanner")))
                {
                    item.SetNameOverride("比目鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("FrogfishBanner")))
                {
                    item.SetNameOverride("躄鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("FusionFeederBanner")))
                {
                    item.SetNameOverride("融食鲨旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("GhostBellBanner")))
                {
                    item.SetNameOverride("幽铃水母旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("GhostBellSmallBanner")))
                {
                    item.SetNameOverride("小幽铃水母旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("GiantClamBanner")))
                {
                    item.SetNameOverride("巨像蛤旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("GiantSquidBanner")))
                {
                    item.SetNameOverride("巨大乌贼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("GnasherBanner")))
                {
                    item.SetNameOverride("噬咬龟旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("GreatSandSharkBanner")))
                {
                    item.SetNameOverride("旱海狂鲨旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("GulperEelBanner")))
                {
                    item.SetNameOverride("大嘴鳗旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("HadarianBanner")))
                {
                    item.SetNameOverride("哈德安翼龙旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("HeatSpiritBanner")))
                {
                    item.SetNameOverride("热能之魂旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("HiveBanner")))
                {
                    item.SetNameOverride("星幻巢旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("IceClasperBanner")))
                {
                    item.SetNameOverride("食魂冰虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ImpiousImmolator")))
                {
                    item.SetNameOverride("亵渎献祭者旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("IrradiatedSlimeBanner")))
                {
                    item.SetNameOverride("辐射史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("LaserfishBanner")))
                {
                    item.SetNameOverride("激光鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("LuminousCorvinaBanner")))
                {
                    item.SetNameOverride("流光石首鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MantisBanner")))
                {
                    item.SetNameOverride("星幻螳螂旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MantisShrimpBanner")))
                {
                    item.SetNameOverride("螳螂虾旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MaulerBanner")))
                {
                    item.SetNameOverride("轰鲨旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MirageJellyBanner")))
                {
                    item.SetNameOverride("幻海水母旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("MorayEelBanner")))
                {
                    item.SetNameOverride("海鳝旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("NovaBanner")))
                {
                    item.SetNameOverride("新星旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OarfishBanner")))
                {
                    item.SetNameOverride("桨鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("OverloadedSoldierBanner")))
                {
                    item.SetNameOverride("过载装甲骷髅旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ParaseaBanner")))
                {
                    item.SetNameOverride("海蠕虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PerennialSlimeBanner")))
                {
                    item.SetNameOverride("永恒史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PestilentSlimeBanner")))
                {
                    item.SetNameOverride("鸩毒史莱姆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PhantomDebrisBanner")))
                {
                    item.SetNameOverride("幻影骸虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PhantomSpiritBanner")))
                {
                    item.SetNameOverride("幻魂旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PitbullBanner")))
                {
                    item.SetNameOverride("血犬旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PlaguebringerBanner")))
                {
                    item.SetNameOverride("瘟疫使者旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PlagueChargerBanner")))
                {
                    item.SetNameOverride("瘟疫蜜蜂旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PlagueshellBanner")))
                {
                    item.SetNameOverride("瘟疫鬼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("PrismTurtleBanner")))
                {
                    item.SetNameOverride("晶背龟旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ProfanedEnergyBanner")))
                {
                    item.SetNameOverride("亵渎能量旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ReaperSharkBanner")))
                {
                    item.SetNameOverride("猎魂鲨旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("RubyCrawlerBanner")))
                {
                    item.SetNameOverride("红宝石爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SandTortoiseBanner")))
                {
                    item.SetNameOverride("沙漠乌龟旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SapphireCrawlerBanner")))
                {
                    item.SetNameOverride("蓝宝石爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ScornEaterBanner")))
                {
                    item.SetNameOverride("吞食魔旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ScryllarBanner")))
                {
                    item.SetNameOverride("恶魔仆从旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SeaFloatyBanner")))
                {
                    item.SetNameOverride("海蜉虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SeaMinnowBanner")))
                {
                    item.SetNameOverride("渊米诺鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SeaSerpentBanner")))
                {
                    item.SetNameOverride("沉沦渊蟒旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SeaUrchinBanner")))
                {
                    item.SetNameOverride("海胆旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ShockstormShuttleBanner")))
                {
                    item.SetNameOverride("风暴飞碟旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SmallSightseerBanner")))
                {
                    item.SetNameOverride("小监星眼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SoulSlurperBanner")))
                {
                    item.SetNameOverride("灵魂饮食者旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StellarCulexBanner")))
                {
                    item.SetNameOverride("星幻蚊旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("StormlionBanner")))
                {
                    item.SetNameOverride("风暴蚁狮旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SunBatBanner")))
                {
                    item.SetNameOverride("太阳蝙蝠旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("SunskaterBanner")))
                {
                    item.SetNameOverride("寻阳鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("TopazCrawlerBanner")))
                {
                    item.SetNameOverride("黄玉爬虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ToxicMinnowBanner")))
                {
                    item.SetNameOverride("剧毒米诺鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("TrasherBanner")))
                {
                    item.SetNameOverride("捣鳄旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("ViperfishBanner")))
                {
                    item.SetNameOverride("蝰蛇鱼旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("VirulingBanner")))
                {
                    item.SetNameOverride("毒飞虫旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("WulfrumDroneBanner")))
                {
                    item.SetNameOverride("钨钢土行者旗帜");
                }
                if (item.type ==(ModLoader.GetMod("CalamityMod").ItemType("WulfrumSlimeBanner")))
                {
                    item.SetNameOverride("钨钢史莱姆旗帜");
                }
            }
			}
        } 
	}
}