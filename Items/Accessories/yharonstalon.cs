using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Expressories.Items.Accessories
{
	public class yharonstalon : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Yharon's Talon");
			Tooltip.SetDefault("The slightest touch makes you bleed\n15% increased rogue damage and velocity\nInflict Yharon's wrath on hit");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 30;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 3);
			item.rare = 10;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<exPlayer>().ywrath = true;
			player.thrownDamage += 0.15f;
			player.thrownVelocity += 0.15f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.LifeCrystal, 2);
			//recipe.AddIngredient(ItemID.ManaCrystal, 2);
			//recipe.AddTile(TileID.Anvils);
			//recipe.SetResult(this);
			//recipe.AddRecipe();
		}
	}
}
