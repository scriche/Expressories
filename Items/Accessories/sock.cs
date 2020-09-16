﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Expressories.Items.Accessories
{
	public class sock : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sock");
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
			//player.GetModPlayer<exPlayer>().barbed = true;
			if (player.velocity.X > 0.0f && player.velocity.Y > 0.0f)
			{
				player.thrownDamage += 0.08f;
			}
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
