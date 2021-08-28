using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items.WolfSet.WolfArmour
{
    [AutoloadEquip(EquipType.Body)]
    public class WolfHide : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("Harness your primitive instincts" +
                "\n Ranged attacks have a chance to inflict 'Frozen' debuff" +
                "\n `15% increased summon damage")
        }
        public override void SetDefaults()
        {
            
        }
    }
}