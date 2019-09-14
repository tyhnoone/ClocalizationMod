
using Terraria.ModLoader;
using Terraria.Localization;

namespace ZZLocalizationMod.ZZItems
{
	public class CerberusPic : ModItem
	{
		 public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cerberus");
			Tooltip.SetDefault("The young hell gate guardian\n-Cerberus");
			DisplayName.AddTranslation(GameCulture.Chinese, "刻耳柏洛斯");
            Tooltip.AddTranslation(GameCulture.Chinese, "“年幼的刻耳柏洛斯把守着地狱的大门”\n-Cerberus");
        }
		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
            item.rare = 1;
            item.useStyle = 1;
			item.consumable = true;
			item.value = 50000;
            item.rare = 2;
			item.createTile = mod.TileType("CerberusPictile");
		}
	}
}