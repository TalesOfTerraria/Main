using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items
{
    public class WolfBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fang Bow");
            Tooltip.SetDefault("Wooden arrows go back to their origin...");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(silver: 80);
            item.maxStack = 1;

            item.damage = 31;
            item.shoot = item.shoot = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            item.autoReuse = true;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.UseSound = SoundID.Item5;
            item.knockBack = 2;
            item.ranged = true;
            item.noMelee = true;
            item.shootSpeed = 8f;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<WolfFang>(), 2);
            recipe.AddIngredient(ItemID.WoodenBow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            }
            return true;
        }
        public override void HoldItem(Player player)
        {
            player.armorPenetration = player.armorPenetration + 8;
        }
    }
}
