using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Items.WolfSet
{
    public class WolfFang : ModItem
    {
        public override void SetStaticDefaults()
        {
           // Tooltip.SetDefault("Charged with the blood of an icy creature");
           Tooltip.SetDefault("Lets not Talk about how you got it...");
        }
        public override void SetDefaults()
        {
            Item.height = 16;
            Item.width = 16;
            Item.rare = 2;
            Item.value = Item.sellPrice(gold: 2);
            Item.useStyle = 1;
            Item.noMelee = true;
            Item.maxStack = 999;
        }
    }
}
