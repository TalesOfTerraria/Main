﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;


namespace ToT.Items.WolfSet
{
	// This is an example showing how to create a weapon that fires custom ammunition
	// The most important property is "Item.useAmmo". It tells you which item to use as ammo.
	// You can see the description of other parameters in the ExampleGun class and at https://github.com/tModLoader/tModLoader/wiki/Item-Class-Documentation
	public class PrimordialArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Primordial Arrow");
			Tooltip.SetDefault("Hunting made easy");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 14; // The width of item hitbox
			Item.height = 32; // The height of item hitbox

			Item.autoReuse = true;  // Whether or not you can hold click to automatically use it again.
			Item.damage = 12; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			Item.DamageType = DamageClass.Ranged; // What type of damage does this item affect?
			Item.knockBack = 0.5f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			Item.noMelee = true; // So the item's animation doesn't do damage.
			Item.rare = ItemRarityID.Green; // The color that the item's name will be in-game.
			Item.shootSpeed = 6f; // The speed of the projectile (measured in pixels per frame.)
			Item.useAnimation = 35; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			Item.useTime = 35; // The item's use time in ticks (60 ticks == 1 second.)
			Item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, shoot, etc.)
			Item.value = Item.buyPrice(silver: 37); // The value of the weapon in copper coins

			// Custom ammo and shooting homing projectiles
			Item.shoot = ModContent.ProjectileType<Projectiles.PrimordialArrow>();
			Item.useAmmo = ModContent.ItemType<PrimordialArrow>(); // Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Items.WolfSet.WolfFang>()
				.AddIngredient(ItemID.Wood, 10)
				.Register();
		}
	}
}