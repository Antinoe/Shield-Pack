using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class IronBucklerShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Buckler Shield");
			Tooltip.SetDefault("+10 Weight.");
		}

		public override void UpdateEquip(Player Player)
		{
			Player.velocity.X *= 0.990f;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
