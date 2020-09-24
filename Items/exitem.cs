using CalamityMod.Items.TreasureBags;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Expressories.Items
{
	public class BossBags : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
        {
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			// This method shows adding items to Fishrons boss bag. 
			// Typically you'll also want to also add an item to the non-expert boss drops, that code can be found in ExampleGlobalNPC.NPCLoot. Use this and that to add drops to bosses.
			if (context == "bossBag" && arg == ItemID.PlanteraBossBag)
            {
				if (Main.rand.Next(4) == 0) {
					player.QuickSpawnItem(ItemType<Items.Accessories.rocketbooster>(), 1);
				}
            }

            if (context == "bossBag" && arg == calamityMod.ItemType("YharonBag"))
            {
				if (Main.rand.Next(2) == 0) {
					player.QuickSpawnItem(ItemType<Items.Accessories.yharonstalon>(), 1);
				}
            }
        }
		
	}
}
