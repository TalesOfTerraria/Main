using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ToT.Items.WolfSet.WolfArmour
{
    [AutoloadEquip(EquipType.Head)]
    public class WolfMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Wolf Mask");
            Tooltip.SetDefault("Harness your primitive instincts"
                + "\nImmunity to 'Frostburn' debuff"
                + "\n+1 max minion and 10% increased ranged damage");
        }
        public override void SetDefaults()
        {
            item.height = 13;
            item.width = 13;
            item.defense = 5;
            item.rare = ItemRarityID.Blue;

        }
    }
}