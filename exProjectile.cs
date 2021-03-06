﻿using Microsoft.Xna.Framework;
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
			var calamityPlayer = player.Calamity();

			if (calamityProj.rogue && player.GetModPlayer<exPlayer>().rustyknifebool && !proj.noEnchantments)
			{
				
				target.AddBuff(BuffType<Buffs.Tetnis>(), 125);
				if (target.GetGlobalNPC<exGlobalNPC>().rustycount < 10)
				{
                	target.GetGlobalNPC<exGlobalNPC>().rustycount += 1;
				}//rust.rustycount += 1;
			}

			if (calamityProj.rogue && player.GetModPlayer<exPlayer>().ywrath && !proj.noEnchantments)
			{
				
				target.AddBuff(BuffType<Buffs.yharonwrath>(), 50);
			}

			if (calamityProj.rogue && player.GetModPlayer<exPlayer>().bloody)
			{
				if (crit)
				{

					//Bruh idk im to tired to fix this	
					float totalcrit = (player.thrownCrit)+(calamityPlayer.throwingCrit);
					float idk = totalcrit / 100;
					int currentcrit = (int)((float)damage / idk);
					int letssee = currentcrit / 30;
					player.statLife += letssee;
					player.HealEffect(letssee); /// (player.thrownCrit)+(calamityPlayer.throwingCrit));
				}
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
