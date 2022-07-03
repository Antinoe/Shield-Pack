using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class WoodenParmaShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Parma Shield");
			Tooltip.SetDefault("+15 Weight.");
		}

		public override void UpdateEquip(Player Player)
		{
			//Player.moveSpeed -= 0.15f;
			Player.velocity.X *= 0.985f;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Wood, 30)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
