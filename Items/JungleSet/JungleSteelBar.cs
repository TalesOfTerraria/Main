using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JungleExpansion.Items
{
	public class JungleSteelBar  : ModItem
	{
		public override void SetDefaults() 
		{
			Item.width = 40;
 			Item.height = 40;
			Item.maxStack = 999;
		}

        public override void AddRecipes()
        {
		    CreateRecipe(1)
  			.AddIngredient(ModContent.ItemType<JungleSteelOre>(), 4)
  			.AddTile(TileID.Furnaces)
  			.Register();

		}
	}
}	