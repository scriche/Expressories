using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Expressories.Items.Accessories
{
	public class barbedbracelet : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Rogue projectile critical hits do x3 damage");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Lime;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<exPlayer>().barbed = true;
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
