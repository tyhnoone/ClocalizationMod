using System;
using Terraria;
using Terraria.ModLoader;

namespace ZZLocalizationMod.Buff
{
	public class CalamityGlobalBuff : GlobalBuff
	{
		public override void ModifyBuffTip(int type, ref string tip, ref int rare)
		{
			if (type == 179)
			{
				tip = "增加7.5%伤害";
				return;
			}
			if (type == 180)
			{
				tip = "增加15%伤害";
				return;
			}
			if (type == 181)
			{
				tip = "增加22.5%伤害";
				return;
			}
			if (type == 71 || type == 73 || type == 74 || type == 75 || type == 76 || type == 77 || type == 78 || type == 79)
			{
				tip = "盗贼和" + tip;
			}
		}
	}
}
