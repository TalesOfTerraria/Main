﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items.WolfSet.WolfArmour
{
    [AutoloadEquip(EquipType.Legs)]
    public class WolfChausses : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("20% increased arrow velocity" +
                "\n+15% minion damage");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.height = 7;
            Item.width = 9;
            Item.defense = 3;
            Item.rare = ItemRarityID.Blue;
            Item.value = 1000;
        }
        public override void UpdateEquip(Player player)
        {
            base.UpdateEquip(player);
            player.GetModPlayer<WolfModPlayer>().LegsVelocity = true;
        }
    }
}