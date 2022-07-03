using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class IronTowerShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Tower Shield");
			Tooltip.SetDefault("+25 Weight.");
		}

		public override void UpdateEquip(Player Player)
		{
			Player.velocity.X *= 0.975f;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Wood, 45)
				.AddIngredient(ItemID.IronBar, 15)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
