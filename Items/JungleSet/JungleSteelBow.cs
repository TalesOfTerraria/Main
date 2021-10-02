using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JungleExpansion.Items
{
      public class JungleSteelBow : ModItem
      {
      public override void SetStaticDefaults()
      {
            DisplayName.SetDefault("JungleSteelBow");
            Tooltip.SetDefault("A jungle bow? Yay!.");
            }

            public override void SetDefaults()
            {
                  Item.damage = 15;
                  Item.DamageType = DamageClass.Ranged;
                  Item.width = 12;
                  Item.height = 38;
                  Item.maxStack = 1;
                  Item.useTime = 28;
                  Item.useAnimation = 28;
                  Item.useStyle = 5;
                  Item.knockBack = 2;
                  Item.value = 12000;
                  Item.rare = 2;
                  Item.UseSound = SoundID.Item5;
                  Item.noMelee = true;
                  Item.shoot = 1;
                  Item.useAmmo = AmmoID.Arrow;
                  Item.shootSpeed = 10f;
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
