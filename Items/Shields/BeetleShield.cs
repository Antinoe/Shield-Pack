using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShieldPack.Items.Shields
{
	[AutoloadEquip(EquipType.Shield)]
	public class BeetleShield : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 24;
			Item.value = 123110;
			Item.rare = 8;
			Item.defense = 12;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Beetle Shield");
			Tooltip.SetDefault("The less health, the more defense\nMaximum life increased by 100");
		}


		public override void UpdateAccessory(Player Player, bool hideVisual)

		{
			Player.statDefense += Player.statLifeMax / Player.statLife * 5;
			Player.statLifeMax2 += 100;
			
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
			CreateRecipe(1)
				.AddIngredient(null, "TurtleShield", 1)
				.AddIngredient(ItemID.BeetleHusk, 10)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
