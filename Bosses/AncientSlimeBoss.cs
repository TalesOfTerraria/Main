using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace ToT.Bosses
{
    [AutoloadBossHead]
    public class AncientSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 2;
            NPCID.Sets.DebuffImmunitySets.Add(Type, new NPCDebuffImmunityData
            {
                SpecificallyImmuneTo = new int[]
                {
                    BuffID.Frostburn,
                    BuffID.Confused,
                    BuffID.Frozen
                }
            });
        public override void SetDefaults()
        {
            NPC.width = 70;
            NPC.height = 40;
        }
    }
    }
}