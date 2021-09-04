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
                "\nRanged attacks have a chance to inflict 'Frostburn' debuff" +
                "\n15% increased summon damage");
        }
        public override void SetDefaults()
        {
            item.height = 9;
            item.width = 11;
            item.defense = 7;
            item.rare = ItemRarityID.Blue;
            item.value = 1000;
        }
        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<WolfModPlayer>().FrostBurnRanged = true;
            player.minionDamage += 0.15f;
        }
    }
}