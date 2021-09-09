using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ToT.Items.WolfSet
{
    public class PrimordialArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Primordial Arrow");
            Tooltip.SetDefault("Hunting made easy");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 200;
        }

        public override void SetDefaults()
        {

            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 14;
            Item.height = 32;
            Item.maxStack = 999;
            Item.consumable = true; 
            Item.knockBack = 0.5f;
            Item.value = Item.sellPrice(silver: 1);
            Item.rare = ItemRarityID.Green;
            Item.shoot = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
            Item.notAmmo = false;
            Item.shootSpeed = 2f;
            Item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Items.WolfSet.WolfFang>(1)
                .AddIngredient(ItemID.Wood)
                .Register();
        }
    }
}