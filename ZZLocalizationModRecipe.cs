using System;
using Terraria.ModLoader;

namespace ZZLocalizationMod
{

	public class ZZLocalizationModRecipe
	{

		private static ModRecipe GetNewRecipe()
		{
			return new ModRecipe(ZZLocalizationMod.instance);
		}
	}
}
