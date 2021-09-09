using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace ToT.Items.WolfSet.WolfArmour
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Legs value here will result in TML expecting a X_Legs.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Legs)]
	public class WolfChausses : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Harness your ancient instincts");
			Tooltip.SetDefault("Harness your ancient instincts");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
			Item.sellPrice(silver: 49); // How many coins the item is worth
			Item.rare = ItemRarityID.Blue; // The rarity of the item
			Item.defense = 2; // The amount of defense the item will give when equipped
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Items.WolfSet.WolfFang>(2)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}