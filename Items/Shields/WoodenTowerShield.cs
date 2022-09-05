using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class WoodenTowerShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = ShieldPackConfig.Instance.shieldDefenseWoodenTowerShield;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Tower Shield");
		}

		public override void UpdateEquip(Player Player)
		{
			if (ShieldPackConfig.Instance.shieldWeight)
			{
				Player.velocity.X *= ShieldPackConfig.Instance.shieldWeightWoodenTowerShield;
			}
		}

		public override void AddRecipes()
		{
			if (ShieldPackConfig.Instance.recipeWoodenTowerShield)
			{
				CreateRecipe(1)
					.AddRecipeGroup(RecipeGroupID.Wood, 60)
					.AddTile(TileID.WorkBenches)
					.Register();
			}
		}
	}
}