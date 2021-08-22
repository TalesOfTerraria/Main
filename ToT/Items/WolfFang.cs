using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items
{
    public class WolfFang : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Charged with the blood of an icy creature");
        }
        public override void SetDefaults()
        {
            item.height = 16;
            item.width = 16;
            item.rare = 2;
            item.value = Item.sellPrice(gold: 2);
            item.useStyle = 1;
            item.noMelee = true;
            item.maxStack = 999;
        }
    }
}
