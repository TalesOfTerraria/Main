using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace ToT.Items.WolfSet.WolfArmour
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Head value here will result in TML expecting a X_Head.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Head)]
	public class WolfHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Werewolf Helmet");
			Tooltip.SetDefault("Increase your defence by 2");

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

		// IsArmorSet determines what armor pieces are needed for the setbonus to take effect
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<WolfBreastplate>() && legs.type == ModContent.ItemType<WolfLeggings>();
		}

		// UpdateArmorSet allows you to give set bonuses to the armor.
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases ranger damage by 7% and defence by 4."; // This is the setbonus tooltip
			player.GetDamage(DamageClass.Ranged) += 0.07f;
			player.statDefense += 4;
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
