using Terraria.ID;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using ToT.DamageClasses;

namespace ToT.Items.AdvClass
{
	public class AdvTier1 : ModItem
	{
		public override void SetStaticDefaults() {
		    DisplayName.SetDefault("Advancement Book");
			Tooltip.SetDefault("This is an example magic weapon");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 14;
			Item.DamageType = ModContent.GetInstance<AdvancementDamage>();
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot; // Makes the player use a 'Shoot' use style for the Item.
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.knockBack = 12;
			Item.value = Item.buyPrice(silver: 38);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.PinkLaser; 
			Item.shootSpeed = 8; // How fast the item shoots the projectile.
			Item.crit = 32; // The percent chance at hitting an enemy with a crit, plus the default amount of 4.
		}
	}
}