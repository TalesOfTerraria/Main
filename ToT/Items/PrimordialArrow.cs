using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items
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

            item.damage = 12;
            item.ranged = true;
            item.width = 14;
            item.height = 32;
            item.maxStack = 999;
            item.consumable = true; 
            item.knockBack = 0.5f;
            item.value = Item.sellPrice(silver: 1);
            item.rare = 2;
            item.shoot = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            item.notAmmo = false;
            item.shootSpeed = 6f;
            item.ammo = AmmoID.Arrow;
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