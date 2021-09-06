using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

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
                if (((proj.ranged)) && FrostBurnRanged && !proj.noEnchantments)
                {
                    // If all those checks pass, we apply FrostBurn for some random duration.
                    target.AddBuff(BuffID.Frostburn, 60 * Main.rand.Next(5, 15), false);
                }
            }
        }
    }
    public class ArrowVelocity : GlobalItem
    {
        public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.GetModPlayer<WolfModPlayer>().LegsVelocity == true)
            {
                

            }
            return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
    }
}