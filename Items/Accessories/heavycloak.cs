using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using CalamityMod;
using CalamityMod.CalPlayer;
using CalamityMod.Items.TreasureBags;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.NPCs.NormalNPCs;
using CalamityMod.World;

namespace Expressories.Items.Accessories
{
	public class heavycloak : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increase the stealth genereation by 50%\nreduce movement speed by 25%");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 36;
			item.accessory = true;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Lime;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			//player.GetModPlayer<exPlayer>().barbed = true;
			player.moveSpeed -= 0.25f;//(player.moveSpeed * 0.25f);
			var calamityPlayer = player.Calamity();
			Mod otherMod = ModLoader.GetMod("CalamityMod");
			calamityPlayer.stealthAcceleration += 1f;
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
