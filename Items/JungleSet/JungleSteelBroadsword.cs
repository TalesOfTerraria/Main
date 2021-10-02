using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JungleExpansion.Items
{
	public class JungleSteelBroadsword  : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("WoodenSwordMC"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The New Jungle sword.");
		}

		public override void SetDefaults() 
		{
			Item.damage = 17;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 13000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;	
            }
            public override void AddRecipes()
            {
		CreateRecipe(1)
  			.AddIngredient(ModContent.ItemType<JungleSteelOre>(), 14)
  			.AddTile(TileID.Anvils)
  			.Register();
        }
    }
}
