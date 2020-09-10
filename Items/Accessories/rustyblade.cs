﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Expressories.Items.Accessories
{
	public class rustyblade : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Rogue projectiles deal stacking damage overtime (max 10)");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 3);
			item.rare = ItemRarityID.Yellow;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<exPlayer>().rustyknifebool = true;
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
