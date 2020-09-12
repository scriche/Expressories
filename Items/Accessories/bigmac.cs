using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Expressories.Items.Accessories
{
	public class bigmac : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Emir is with you\nGain +50 hp");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.accessory = true;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = -12;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			//player.GetModPlayer<exPlayer>().barbed = true;
			player.statLifeMax2 += 50;
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
