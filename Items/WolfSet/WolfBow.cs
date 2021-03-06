using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ToT.Items.WolfSet
{
//1.4
    public class WolfBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fang Bow");
            Tooltip.SetDefault("Wooden arrows go back to their origin...");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(silver: 80);
            Item.maxStack = 1;

            Item.damage = 31;
            Item.autoReuse = true;
            Item.useTime = 24;
            Item.useAnimation = 24;
            Item.useStyle = 5;
            Item.UseSound = SoundID.Item5;
            Item.knockBack = 2;
            Item.DamageType = DamageClass.Ranged;
            Item.noMelee = true;
            Item.shoot = Item.shoot = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            Item.shootSpeed = 4f;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
        }
        public override void AddRecipes()
		{
			CreateRecipe()
                .AddIngredient<Items.WolfSet.WolfFang> (4)
                .AddIngredient(ItemID.WoodenBow, 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
        public override bool Shoot(Player player, ProjectileSource_Item_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            }
            return true;
        }
    }
}
