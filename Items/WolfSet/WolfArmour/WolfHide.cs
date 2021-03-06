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
            Item.height = 27;
            Item.width = 33;
            Item.defense = 7;
            Item.rare = ItemRarityID.Blue;
            Item.value = 1000;
        }
        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<WolfModPlayer>().FrostBurnRanged = true;
            player.GetDamage(DamageClass.Summon) += 0.15f;
        }
    }
}