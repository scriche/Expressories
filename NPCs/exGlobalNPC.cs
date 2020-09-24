using Expressories.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityMod;
using static Terraria.ModLoader.ModContent;

namespace Expressories.NPCs
{
	public class exGlobalNPC : GlobalNPC
	{
		exPlayer playr = new exPlayer(); 
		public override bool InstancePerEntity => true;
		
		public bool Tetnis;
		public int rustycount = 0;
		public bool yharonswrath;
		
		public override void ResetEffects(NPC npc) {
			Tetnis = false;
			yharonswrath = false;
		}

		public override void UpdateLifeRegen(NPC npc, ref int damage) {
			if (Tetnis)
			{
				if (npc.lifeRegen > 0) {
					npc.lifeRegen = 0;
				}

				//npc.lifeRegen -= playr.rustycount;
				npc.lifeRegen -= rustycount * 3;
				damage = rustycount;

            } else {
				rustycount = 0;
			}

			if (yharonswrath)
			{
				if (npc.lifeRegen > 0) {
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 200;
				damage = 1;
			}
		}
	

		public override void NPCLoot(NPC npc) {
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			// See BossBags.OpenVanillaBag to see how to handle adding items to the boss bags used in expert mode. You'll want to do both for most items added to boss drops.
			if (npc.type == NPCID.Mimic) {
				if (Main.rand.Next(5) == 0) {
					Item.NewItem(npc.getRect(), ItemType<Items.Accessories.luckypenny>(), 1);
				}
			}

			if (npc.type == NPCID.Plantera && !Main.expertMode) {
				if (Main.rand.Next(4) == 0) {
					Item.NewItem(npc.getRect(), ItemType<Items.Accessories.rocketbooster>(), 1);
				}
			}

			if (npc.type == (calamityMod.NPCType("JungleDragonYharon")) && !Main.expertMode) {
				if (Main.rand.Next(5) == 0) {
					Item.NewItem(npc.getRect(), ItemType<Items.Accessories.luckypenny>(), 1);
				}
			}

			if (npc.type == 269 || npc.type == 270 || npc.type == 271 || npc.type == 272) {
				if (Main.rand.Next(6) == 0) {
					Item.NewItem(npc.getRect(), ItemType<Items.Accessories.rustyblade>(), 1);
				}
			}
		}

		public override void DrawEffects(NPC npc, ref Color drawColor) {
			if (yharonswrath) {
				if (Main.rand.Next(4) < 3) {
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, 6, npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.NextBool(4)) {
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
				Lighting.AddLight(npc.position, 0.1f, 0.2f, 0.7f);
			}
		}

		public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns) {
			/**if (player.GetModPlayer<ExamplePlayer>().ZoneExample) {
				spawnRate = (int)(spawnRate * 5f);
				maxSpawns = (int)(maxSpawns * 5f);
			}**/
		}

		public override void SetupShop(int type, Chest shop, ref int nextSlot) {
			/**if (type == NPCID.Dryad) {
				shop.item[nextSlot].SetDefaults(ItemType<CarKey>());
				nextSlot++;

				// We can use shopCustomPrice and shopSpecialCurrency to support custom prices and currency. Usually a shop sells an item for item.value. 
				// Editing item.value in SetupShop is an incorrect approach.
				shop.item[nextSlot].SetDefaults(ItemType<CarKey>());
				shop.item[nextSlot].shopCustomPrice = 2;
				shop.item[nextSlot].shopSpecialCurrency = CustomCurrencyID.DefenderMedals; // omit this line if shopCustomPrice should be in regular coins. 
				nextSlot++;

				shop.item[nextSlot].SetDefaults(ItemType<CarKey>());
				shop.item[nextSlot].shopCustomPrice = 3;
				shop.item[nextSlot].shopSpecialCurrency = ExampleMod.FaceCustomCurrencyId;
				nextSlot++;
			    }
			}**/
		}

		// Make any NPC with a chat complain to the player if they have the stinky debuff.
		public override void GetChat(NPC npc, ref string chat) {
			/**if (Main.LocalPlayer.HasBuff(BuffID.Stinky)) {
				switch (Main.rand.Next(3)) {
					case 0:
						chat = "Eugh, you smell of rancid fish!";
						break;
					case 1:
						chat = "What's that horrid smell?!";
						break;
					default:
						chat = "Get away from me, i'm not doing any business with you.";
						break;
				}
			}**/
		}
	}
}
