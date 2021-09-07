using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items.WolfSet
{
    public class PrimordialArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Primordial Arrow");
            Tooltip.SetDefault("Hunting made easy");
        }

        public override void SetDefaults()
        {

            Item.damage = 12;
            Item.ranged = true;
            Item.width = 14;
            Item.height = 32;
            Item.maxStack = 999;
            Item.consumable = true; 
            Item.knockBack = 0.5f;
            Item.value = Item.sellPrice(silver: 1);
            Item.rare = 2;
            Item.shoot = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            Item.notAmmo = false;
            Item.shootSpeed = 6f;
            Item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<WolfFang>(), 1);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.SetResult(this, 200);
            recipe.AddRecipe();
        }
    }
}