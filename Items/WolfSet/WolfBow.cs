using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items.WolfSet
{
//1.4
    public class WolfBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fang Bow");
            Tooltip.SetDefault("Wooden arrows go back to their origin..." +
                "\n+10 armour penetration");
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
            Item.shoot = item.shoot = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            Item.shootSpeed = 8f;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
        }
        public override void AddRecipes()
		{
			CreateRecipe()
				..AddIngredient<ModContent.ItemType<WolfFang>, 4()
				.AddIngredient(ItemID.WoodenBow)
				.AddTile(TileID.Anvils)
				.Register();
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
