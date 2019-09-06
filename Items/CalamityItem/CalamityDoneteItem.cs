using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ZZLocalizationMod.Items
{
	public class CalamityDoneteItem : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				String text = "灾厄感谢物品：";
				String text2 = "\n感谢人：";
				int write = 0;
				for (int k = 0; k < tooltips.Count; k++)
				{
					TooltipLine tooltip = tooltips[k];
					if (tooltip.Name == "Sell")
					{
						write = k+1;
						break;
					}
					if (tooltip.Name == "buy")
					{
						write = k-1;
						break;
					}
					if (tooltip.Name == "dropNPC")
					{
						write = k-1;
						break;
					}
				}
				if(write == 0) write = tooltips.Count;
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("YateveoBloom"))
				{
					text += "众筹捐赠者";
					text2 += "Lilith Saintclaire";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CorpusAvertorMelee"))
				{
					text += "众筹捐赠者";
					text2 += "breadcrumbs";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CryogenicStaff"))
				{
					text += "开发者";
					text2 += "Cooper";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Keelhaul"))
				{
					text += "众筹捐赠者";
					text2 += "Braden Hajer";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("KelvinCatalyst"))
				{
					text += "众筹捐赠者";
					text2 += "Random Weeb";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Plaguenade"))
				{
					text += "众筹捐赠者";
					text2 += "Ben Shapiro";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ResurrectionButterfly"))
				{
					text += "众筹捐赠者";
					text2 += "Chipbeam";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Roxcalibur"))
				{
					text += "众筹捐赠者";
					text2 += "Javyz";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Animus"))
				{
					text += "开发者";
					text2 += "MountainDrew/Fabsol";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Apotheosis"))
				{
					text += "硬核神长直长矛比赛/开发者";
					text2 += "Terry N. Muse";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Ataraxia"))
				{
					text += "众筹捐赠者";
					text2 += "Faye";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Azathoth"))
				{
					text += "开发者";
					text2 += "MountainDrew/Fabsol";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Contagion"))
				{
					text += "开发者";
					text2 += "Tri";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Judgement"))
				{
					text += "开发者";
					text2 += "RandomZachOfKindness";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DarkSpark"))
				{
					text += "众筹捐赠者";
					text2 += "Vorbis";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DeepSeaDumbbell"))
				{
					text += "众筹捐赠者";
					text2 += "Chaotic Reks";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DevilsSunrise"))
				{
					text += "众筹捐赠者";
					text2 += "Lompl Allimath";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DivineRetribution"))
				{
					text += "众筹捐赠者";
					text2 += "Pixlgray";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DodusHandcannon"))
				{
					text += "众筹捐赠者";
					text2 += "Dodu";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DraconicDestruction"))
				{
					text += "开发者";
					text2 += "Amadis";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DragonPow"))
				{
					text += "众筹捐赠者";
					text2 += "Buildmonger";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Drataliornus"))
				{
					text += "复仇模式无伤";
					text2 += "Sygilin";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Earth"))
				{
					text += "开发者";
					text2 += "Earth";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Fabstaff"))
				{
					text += "开发者";
					text2 += "MountainDrew/Fabsol";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FaceMelter"))
				{
					text += "众筹捐赠者";
					text2 += "Krankwagon";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HalibutCannon"))
				{
					text += "已逝Youtuber/游戏评论人";
					text2 += "TotalBiscuit/TotalHalibut";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("HandheldTank"))
				{
					text += "众筹捐赠者";
					text2 += "Hannes Holmlund";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RoyalKnives"))
				{
					text += "开发者";
					text2 += "Phantasmal Deathray";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Karasawa"))
				{
					text += "众筹捐赠者";
					text2 += "Rosalie Stella";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TheLastMourning"))
				{
					text += "众筹捐赠者";
					text2 += "Mister Winchester";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("LightGodsBrilliance"))
				{
					text += "众筹捐赠者";
					text2 += "Profoundmango69";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("MadAlchemistsCocktailGlove"))
				{
					text += "众筹捐赠者";
					text2 += "Arti";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Nadir"))
				{
					text += "众筹捐赠者";
					text2 += "Arti";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NanoblackReaperRogue"))
				{
					text += "开发者";
					text2 += "Ozzatron";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Oracle"))
				{
					text += "众筹捐赠者";
					text2 += "Arkhine";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ThePack"))
				{
					text += "众筹捐赠者";
					text2 += "Hans Volter";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RedSun"))
				{
					text += "开发者";
					text2 += "Spoopyro";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ScarletDevil"))
				{
					text += "开发者";
					text2 += "Phupperbat";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SomaPrime"))
				{
					text += "开发者";
					text2 += "Tri";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlushieStaff"))
				{
					text += "开发者";
					text2 += "Blushiemagic";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BlushieStaff"))
				{
					text += "开发者";
					text2 += "Blushiemagic";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Svantechnical"))
				{
					text += "开发者";
					text2 += "Svante";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TimeBolt"))
				{
					text += "众筹捐赠者";
					text2 += "GlitchOut";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TriactisTruePaladinianMageHammerofMight"))
				{
					text += "开发者";
					text2 += "Triactis";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Megafleet"))
				{
					text += "开发者";
					text2 += "DarkTiny";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CrystylCrusher"))
				{
					text += "开发者";
					text2 += "Graydee";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NormalityRelocator"))
				{
					text += "众筹捐赠者";
					text2 += "Gibb50";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("NormalityRelocator"))
				{
					text += "众筹捐赠者";
					text2 += "Gibb50";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeHelm"))
				{
					text += "开发者";
					text2 += "Shadowspec";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeBreastplate"))
				{
					text += "开发者";
					text2 += "Shadowspec";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeGreaves"))
				{
					text += "开发者";
					text2 += "Shadowspec";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("DemonshadeGreaves"))
				{
					text += "开发者";
					text2 += "Shadowspec";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ApronOfAffection"))
				{
					text += "众筹捐赠者";
					text2 += "Jack M Sargent";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ForgottenDragonEgg"))
				{
					text += "众筹捐赠者";
					text2 += "Frederik Henschel";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BearEye"))
				{
					text += "开发者";
					text2 += "Lilac Vrt Olligoci";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CharredRelic"))
				{
					text += "开发者";
					text2 += "Phupperbat";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("CosmicPlushie"))
				{
					text += "复仇模式无伤/开发者";
					text2 += "Terry N. Muse";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("TrashmanTrashcan"))
				{
					text += "开发者";
					text2 += "Uncle Danny";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("FoxDrive"))
				{
					text += "开发者";
					text2 += "RandomZachOfKindness";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("RomajedaOrchid"))
				{
					text += "开发者";
					text2 += "LordMetarex";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Levi"))
				{
					text += "开发者";
					text2 += "Leviathan";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("BloodyVein"))
				{
					text += "众筹捐赠者";
					text2 += "Larry";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("IbarakiBox"))
				{
					text += "开发者";
					text2 += "Mrrp";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Fabsol"))
				{
					text += "开发者";
					text2 += "MountainDrew/Fabsol";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Brimrose"))
				{
					text += "开发者";
					text2 += "Phupperbat";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("GazeOfCrysthamyr"))
				{
					text += "众筹捐赠者";
					text2 += "Crysthamyr";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SquishyBeanMount"))
				{
					text += "开发者";
					text2 += "Ziggums";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("Popo"))
				{
					text += "开发者";
					text2 += "Popo";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ProfanedSoulArtifact"))
				{
					text += "众筹捐赠者";
					text2 += "MishiroUsui";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensHeartAlt"))
				{
					text += "开发者";
					text2 += "gamagamer64";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("SirensHeart"))
				{
					text += "开发者";
					text2 += "gamagamer64";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
				if (item.type == ModLoader.GetMod("CalamityMod").ItemType("ShadowspecBar"))
				{
					text += "开发者";
					text2 += "Shadowspec";
					TooltipLine line = new TooltipLine(base.mod, "DedicatedItems", text + text2);
					line.overrideColor = Color.HotPink;
					tooltips.Insert(write, line);
				}
			}
		}
	}
}
