using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class CopperParmaShield : ModItem
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
			DisplayName.SetDefault("Copper Parma Shield");
			Tooltip.SetDefault("+15 Weight.");
		}

		public override void UpdateEquip(Player Player)
		{
			Player.velocity.X *= 0.985f;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Wood, 20)
				.AddIngredient(ItemID.CopperBar, 10)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
