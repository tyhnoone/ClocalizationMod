using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace ZZLocalizationMod.Buff
{
	public class CalamityGlobalBuff : GlobalBuff
	{
		public override void ModifyBuffTip(int type, ref string tip, ref int rare)
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Chinese && ModLoader.GetMod("CalamityMod") != null)
			{
				if (type == 179)
				{
					tip = "增加7.5%伤害";
				}
				if (type == 180)
				{
					tip = "增加15%伤害";
				}
				if (type == 181)
				{
					tip = "增加22.5%伤害";
				}
				if (type == 71 || type == 73 || type == 74 || type == 75 || type == 76 || type == 77 || type == 78 || type == 79)
				{
					tip = "盗贼和" + tip;
				}
				if (type == 62)
				{
					tip = "受到伤害减少15%";
				}
				if (type == 88)
				{
					string tipch = ". 所有受到的伤害增加25%";
					string tipresult = tip.Replace(". All damage taken increased by 25%", tipch);
					tip = tipresult;
				}
				if (type == 69)
				{
					string tipch1 = "减少20防御";
					string tipch2 = ". 所有受到的伤害增加25%";
					string tipresult1 = tip.Replace("Defense reduced by 20", tipch1);
					string tipresult2 = tipresult1.Replace(". All damage taken increased by 25%", tipch2);
					tip = tipresult2;
				}
				if (type == 39)
				{
					string tipch = ". 所有受到的伤害增加20%";
					string tipresult = tip.Replace(". All damage taken increased by 20%", tipch);
					tip = tipresult;
				}
				if (type == ModLoader.GetMod("CalamityMod").BuffType("AdrenalineMode"))
				{
					string tipch1 = "增加150%伤害. 筋疲力竭后会降至49.5%. ";
					string tipch2 = "增加500%伤害. 筋疲力竭后会降至165%. ";
					string tipresult1 = tip.Replace("150% damage boost. Can burnout down to 49.5%.", tipch1);
					string tipresult2 = tipresult1.Replace("500% damage boost. Can burnout down to 165%.", tipch2);
					tip = tipresult2;
				}
				if (type == ModLoader.GetMod("CalamityMod").BuffType("BrimstoneFlames"))
				{
					string tipch = "大量生命流失";
					string tipresult = tip.Replace("Rapid health loss", tipch);
					tip = "大量生命流失";
				}
			}
		}
	}
}
