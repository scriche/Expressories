using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Expressories.NPCs;

namespace Expressories.Buffs
{
	public class Tetnis : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Tetnis");
			Description.SetDefault("Welp");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(NPC npc, ref int buffIndex) {
			npc.GetGlobalNPC<exGlobalNPC>().Tetnis = true;
		}
	}
}
