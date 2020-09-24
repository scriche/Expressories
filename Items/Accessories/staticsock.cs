using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Expressories.Items.Accessories
{
	public class staticsock : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Static Sock");
			Tooltip.SetDefault("They look used\nGain increased rogue damage by 8% when moving");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.accessory = true;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = 2;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<exPlayer>().socked = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			recipe.AddIngredient(calamityMod.ItemType("PurifiedGel"), 8);
			recipe.AddIngredient(ItemID.HermesBoots, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
