using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JungleExpansion.Items
{
      public class JungleSteelArrow : ModProjectile
      {

            public override void SetDefaults()
            {
                  Projectile.width = 14;
                  Projectile.height = 32;
                  Projectile.aiStyle = 1;
                  Projectile.friendly = true;
                  Projectile.hostile = false;
                  Projectile.penetrate = 2;
                  Projectile.timeLeft = 600;
                  Projectile.ignoreWater = false;
                  Projectile.tileCollide = true;
            }
      }
}