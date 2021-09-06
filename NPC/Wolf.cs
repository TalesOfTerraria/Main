using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework.Graphics;
using System.Text;

namespace ToT.Items.WolfSet
{
	public class Wolf : GlobalNPC
	{
		public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.player.ZoneSnow && !Main.hardMode)
			{
				pool.Add(NPCID.Wolf, 0.05f);
			}
		}
		public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Wolf)
            {
				if (Main.rand.Next(1, 3) == 1)
                {
					Item.NewItem(npc.getRect(), ModContent.ItemType<WolfFang>());
				}

			}
        }
	}
}



