using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CalamityMod;
using CalamityMod.CalPlayer;
using CalamityMod.Items.TreasureBags;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.NPCs.NormalNPCs;
using CalamityMod.World;
using Expressories.NPCs;
using static Terraria.ModLoader.ModContent;


namespace Expressories
{
	public class exPlayer : ModPlayer
	{

		public bool rustyknifebool;
		public int rustycount;

		public static exPlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<exPlayer>();
        }

		public override void Initialize()
		{
			rustyknifebool = false;
		}
		
	}
}
