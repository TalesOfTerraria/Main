using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ToT.Items.WolfSet.WolfArmour
{
    public class WolfModPlayer : ModPlayer
    {
        public bool FrostBurnRanged;
        public override void ResetEffects()
        {
            FrostBurnRanged = false;
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
}