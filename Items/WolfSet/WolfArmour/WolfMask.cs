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
            Item.height = 39;
            Item.width = 39;
            Item.defense = 5;
            Item.rare = ItemRarityID.Blue;

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<WolfHide>() && legs.type == ModContent.ItemType<WolfChausses>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Ranged and summon damage increased by 15%" +
                "\n60% increased mining speed";
            player.GetDamage(DamageClass.Ranged) += 0.15f;
            player.GetDamage(DamageClass.Summon) += 0.15f;
            player.pickSpeed += 0.6f;
        }
        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Frostburn] = true;
            player.GetDamage(DamageClass.Ranged) += 0.1f;
            player.maxMinions += 1;
        }
    }
}