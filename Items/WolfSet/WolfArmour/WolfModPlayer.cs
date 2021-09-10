using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace ToT.Items.WolfSet.WolfArmour
{
    public class WolfModPlayer : ModPlayer
    {
        public bool FrostBurnRanged;
        public bool LegsVelocity;
        public override void ResetEffects()
        {
            FrostBurnRanged = false;
            LegsVelocity = false;
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (FrostBurnRanged == true)
            {
                if (proj.CountsAsClass(DamageClass.Ranged) && FrostBurnRanged && !proj.noEnchantments)
                {
                    target.AddBuff(BuffID.Frostburn, 60 * Main.rand.Next(5, 15), false);
                }
            }
        }
    }
    public class ArrowVelocity : GlobalItem
    {
   
        public override bool Shoot(Item Item, Player player, ProjectileSource_Item_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (player.GetModPlayer<WolfModPlayer>().LegsVelocity == true)
            {
                if (Item.useAmmo == AmmoID.Arrow)
                {
                    Item.shootSpeed += 0.1f;
                }
            }
            return base.Shoot(Item, player, source, position, velocity, type, damage, knockback);
        }
    }
}