using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ToT.Projectiles
{
    public class TrueStarwrathProjectile1 : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 18;
            Projectile.height = 41;
            Projectile.damage = 300;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.light = 0.7f;
            Projectile.friendly = true; 
            Projectile.hostile = false;
            Projectile.aiStyle = 5;
            Projectile.DamageType = DamageClass.Melee;     
        }
        public override void AI()
        {
            int dustType = ModContent.DustType<Dusts.TrueStarWrathProjectileDust>();
            int dustIndex = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, dustType);
        }
        public override void Kill(int timeLeft)
        {
            for (int d = 0; d < 23; d++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<Dusts.TrueStarWrathProjectileDust>(), 0f, 0f, 150, default(Color), 1.5f);
            }
        }
    }
}