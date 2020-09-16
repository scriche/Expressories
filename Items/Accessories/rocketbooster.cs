using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Expressories.Items.Accessories
{
	public class rocketbooster : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rocket Booster");
			Tooltip.SetDefault("pshoooo\nincreased rogue projectile speed by 45% ");
		}

		public override void SetDefaults() {
			item.width = 24;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = 9;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			//player.GetModPlayer<exPlayer>().barbed = true;
			player.thrownVelocity += 0.45f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.LifeCrystal, 2);
			//recipe.AddIngredient(ItemID.ManaCrystal, 2);
			//recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
