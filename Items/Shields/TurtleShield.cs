using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class TurtleShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 20;
			Item.value = 4500;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = ShieldPackConfig.Instance.shieldDefenseTurtleShield;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Turtle Shield");
			Tooltip.SetDefault("The less health, the more defense.\nDefense is tripled when this shield is at its maximum potential.");
		}

		public override void UpdateEquip(Player Player)
		{
			if (ShieldPackConfig.Instance.shieldWeight)
			{
				Player.velocity.X *= ShieldPackConfig.Instance.shieldWeightTurtleShield;
			}
		}

		public override void UpdateAccessory(Player Player, bool hideVisual)
		{
			Player.statDefense += Player.statLifeMax / Player.statLife * 5;
			
			/*
			if (player.statLife < 50)
			{
				player.statDefense = (int)(player.statDefense * 10f);
			}
			if (player.statLife < 100)
			{
				player.statDefense = (int)(player.statDefense * 5f);
			}
			if (player.statLife < 200)
			{
				player.statDefense = (int)(player.statDefense * 2.5f);
			}*/
			//^ Old method.
		}

		public override void AddRecipes()
		{
			if (ShieldPackConfig.Instance.recipeTurtleShield)
			{
				CreateRecipe(1)
				.AddIngredient(ItemID.ChlorophyteBar, 20)
				.AddIngredient(ItemID.TurtleShell, 2)
				.AddTile(TileID.Anvils)
					.Register();
			}
		}
	}
}