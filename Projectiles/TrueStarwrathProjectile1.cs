using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ToT.Projectiles
{
    public class TrueStarWrathProjectile1 : ModProjectile
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
            Projectile.aiStyle = ProjectileID.StarWrath;
            Projectile.DamageType = DamageClass.Melee;
        }
        public override void OnTileCollide()
        {
            Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 81);
            dust.position = (dust.position + projectile.Center) / 2f;
            dust.velocity += rotVector * 2f;
            dust.velocity *= 0.5f;
            dust.noGravity = true;
            usePos -= rotVector * 8f;
        }
    }
}