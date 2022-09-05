using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class CopperBucklerShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = ShieldPackConfig.Instance.shieldDefenseCopperBucklerShield;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Buckler");
		}

		public override void UpdateEquip(Player Player)
		{
			if (ShieldPackConfig.Instance.shieldWeight)
			{
				Player.velocity.X *= ShieldPackConfig.Instance.shieldWeightCopperBucklerShield;
			}
		}

		public override void AddRecipes()
		{
			if (ShieldPackConfig.Instance.recipeCopperBucklerShield)
			{
				CreateRecipe(1)
					.AddIngredient(ItemID.CopperBar, 15)
					.AddTile(TileID.Anvils)
					.Register();
			}
		}
	}
}