using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using System;
using System.IO;
using System.Collections.Generic;
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
	public class exProjectile : GlobalProjectile
	{

        //exGlobalNPC rust = new exGlobalNPC();

        public static exPlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<exPlayer>();
        }

        public override void OnHitNPC(Projectile proj, NPC target, int damage, float knockback, bool crit)
		{
            
			Player player = Main.player[proj.owner];
            var calamityProj = proj.Calamity();

			if (calamityProj.rogue && player.GetModPlayer<exPlayer>().rustyknifebool && !proj.noEnchantments)
			{
				
				target.AddBuff(BuffType<Buffs.Tetnis>(), 300);
                player.GetModPlayer<exPlayer>().rustycount += 1;
				//rust.rustycount += 1;
			}
		}
		public override void ModifyHitNPC(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{

			Player player = Main.player[proj.owner];
            var calamityProj = proj.Calamity();

			
			if (calamityProj.rogue && player.GetModPlayer<exPlayer>().barbed)
			{
				if (crit)
				{
					damage = (int)((double)damage * 1.5);
				}
			}
			
		}
		
	
	}

}
