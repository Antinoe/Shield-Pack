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

			Item.width = 36;
			Item.height = 42;
			Item.value = 123450;
			Item.rare = 8;
			Item.defense = 8;

			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Turtle Shield");
			Tooltip.SetDefault("The less health, the more defense.\n" + "Defense is tripled when this shield is at its maximum potential.");
		}


		public override void UpdateAccessory(Player Player, bool hideVisual)

		{
			Player.statDefense += Player.statLifeMax / Player.statLife * 5;
			
			/*
			if (player.statLife < 50)
			{
				player.statDefense = (int)(player.statDefense * 3f);
			}
			if (player.statLife < 100)
			{
				player.statDefense = (int)(player.statDefense * 2.5f);
			}
			if (player.statLife < 200)
			{
				player.statDefense = (int)(player.statDefense * 2f);
			}*/
			//^ Old method.
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.ChlorophyteBar, 20)
				.AddIngredient(ItemID.TurtleShell, 2)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
