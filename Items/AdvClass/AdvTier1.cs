using Terraria.ID;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using ToT.DamageClasses;
using Microsoft.Xna.Framework;

namespace ToT.Items.AdvClass
{
	public class AdvTier1 : ModItem
	{
		public override void SetStaticDefaults() {
		    DisplayName.SetDefault("Advancement Grimoire");
			Tooltip.SetDefault("The first advancement grimoire");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 14;
			Item.DamageType = ModContent.GetInstance<AdvancementDamage>();
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 20; // 60 frames is a second
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
			Item.crit = 11; // The percent chance at hitting an enemy with a crit, plus the default amount of 4.
		}

		// How can I choose between several projectiles randomly?
		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			// Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
			type = Main.rand.Next(new int[] { type, ProjectileID.CursedDart });
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Items.AdvClass.CursedAdv>()
				.AddIngredient<Items.AdvClass.BlessedKey>()
				.AddTile(TileID.Bookcases)
				.Register();
		}

	}
}