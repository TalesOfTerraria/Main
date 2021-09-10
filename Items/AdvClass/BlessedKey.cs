using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ToT.Items.AdvClass
{
	public class BlessedKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blessed Key");
			Tooltip.SetDefault("It can be used to bless something"); // The (English) text shown below your Item's name
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; // How many Items are needed in order to research duplication of this Item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on Item type.
		}

		public override void SetDefaults()
		{
			Item.width = 12; // The Item texture's width
			Item.height = 26; // The Item texture's height

			Item.maxStack = 1; // The Item's max stack value
			Item.value = Item.buyPrice(gold: 7); // The value of the Item in copper coins. Item.buyPrice & Item.sellPrice are helper methods that returns costs in copper coins based on platinum/gold/silver/copper arguments provided to it.
		}
	}
}