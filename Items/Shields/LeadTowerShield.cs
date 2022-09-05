using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class LeadTowerShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = ShieldPackConfig.Instance.shieldDefenseLeadTowerShield;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lead Tower Shield");
		}

		public override void UpdateEquip(Player Player)
		{
			if (ShieldPackConfig.Instance.shieldWeight)
			{
				Player.velocity.X *= ShieldPackConfig.Instance.shieldWeightLeadTowerShield;
			}
		}

		public override void AddRecipes()
		{
			if (ShieldPackConfig.Instance.recipeLeadTowerShield)
			{
				CreateRecipe(1)
					.AddIngredient(ItemID.LeadBar, 60)
					.AddTile(TileID.Anvils)
					.Register();
			}
		}
	}
}