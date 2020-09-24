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
	public class bloodyglove : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bloody Glove");
			Tooltip.SetDefault("Decreases rogue damage by 30%\nRogue weapon critical hit now heal for a small percent of damage delt");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 28;
			item.accessory = true;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Red;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<exPlayer>().bloody = true;
			player.thrownDamage -= 0.30f;
			var calamityPlayer = player.Calamity();
			Mod otherMod = ModLoader.GetMod("CalamityMod");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			recipe.AddIngredient(ItemID.MechanicalGlove, 1);
			recipe.AddIngredient(ItemID.Leather, 10);
			recipe.AddIngredient(calamityMod.ItemType("BloodstainedGlove"), 1);
			recipe.AddIngredient(calamityMod.ItemType("Bloodstone"), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
