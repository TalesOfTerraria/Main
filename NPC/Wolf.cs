using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.UI.Chat;

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
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Wolf)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<WolfFang>(), 1, 2, 4));
            }
        }
	
	}
}
