using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Projectiles
{
    public class PrimordialArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Primordial Arrow");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.arrow = true;
            Projectile.height = 12;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ranged = true;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 1000;
            Projectile.light = 0f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 1;

            aiType = ProjectileID.WoodenArrowFriendly;
        }
      
        public override void AI()
        {
            if (projectile.owner == Main.myPlayer && Main.rand.Next(4) == 0)
            {
                Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, 116, Projectile.oldVelocity.X * 0.1f, Projectile.oldVelocity.Y * 0.1f);
            }
        }


        public override void Kill(int timeLeft)
        {
            Main.PlaySound(0, (int)Projectile.position.X, (int)Projectile.position.Y, 1, 1f, 0f);
            for (int k = 0; k < 5; k++)
            {
                Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, 0, Projectile.oldVelocity.X * 0.1f, Projectile.oldVelocity.Y * 0.1f);
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 120, false);
        }
    }
}
