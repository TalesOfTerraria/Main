using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace Tot.Items.StarfuryMeowmereTree
{
	public class TrueStarwrath : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A legendary sword, crafted from the belongings of a godly being" +
				"Only for those who are worthy");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 42;
			Item.scale = 1.3f;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 300;
			Item.knockBack = 8;
			Item.crit = 6;

			Item.value = Item.buyPrice(gold: 5);
			Item.rare = 9;
			Item.UseSound = SoundID.Item105;

			Item.shoot = Item.shoot = ModContent.ProjectileType<ToT.Projectiles.TrueStarwrathProjectile1>(); // ID of the projectiles the sword will shoot
			Item.shootSpeed = 8f; // Speed of the projectiles the sword will shoot
		}
		// This method gets called when firing your weapon/sword.
		public override bool Shoot(Player player, ProjectileSource_Item_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			Vector2 target = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			// Loop these functions 3 times.
			for (int i = 0; i < 3; i++)
			{
				position = player.Center - new Vector2(Main.rand.NextFloat(401) * player.direction, 600f);
				position.Y -= 100 * i;
				Vector2 heading = target - position;

				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}

				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}

				heading.Normalize();
				heading *= velocity.Length();
				heading.Y += Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(source, position, heading, type, damage * 2, knockback, player.whoAmI, 0f, ceilingLimit);
			}

			return false;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				//Emit dusts when the sword is swung
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<ToT.Dusts.TrueStarWrathDust>());
			}
		}
		public override void AddRecipes()
        {
			CreateRecipe()
				.AddIngredient(ItemID.LunarBar, 8)
				.AddIngredient(ItemID.StarWrath, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
				
        }
    }
}