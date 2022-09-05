using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class CopperTowerShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = ShieldPackConfig.Instance.shieldDefenseCopperTowerShield;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Tower Shield");
		}

		public override void UpdateEquip(Player Player)
		{
			if (ShieldPackConfig.Instance.shieldWeight)
			{
				Player.velocity.X *= ShieldPackConfig.Instance.shieldWeightCopperTowerShield;
			}
		}

		public override void AddRecipes()
		{
			if (ShieldPackConfig.Instance.recipeCopperTowerShield)
			{
				CreateRecipe(1)
					.AddIngredient(ItemID.CopperBar, 60)
					.AddTile(TileID.Anvils)
					.Register();
			}
		}
	}
}