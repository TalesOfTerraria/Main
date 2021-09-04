using Terraria;
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
    }
}