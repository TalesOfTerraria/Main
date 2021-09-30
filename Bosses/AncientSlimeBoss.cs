using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ToT.Bosses
{
    [AutoloadBossHead]
    public class AncientSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 2;
            NPCDebuffImmunityData debuffData = new NPCDebuffImmunityData
            {
                SpecificallyImmuneTo = new int[]
                {
                    BuffID.Frostburn,
                    BuffID.Confused,
                    BuffID.Frozen
                }
            };
            NPCID.Sets.DebuffImmunitySets.Add(Type, debuffData);
            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                CustomTexturePath = "ExampleMod/Assets/Textures/Bestiary/MinionBoss_Preview",
                PortraitScale = 0.6f, // Portrait refers to the full picture when clicking on the icon in the bestiary
                PortraitPositionYOverride = 0f,
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);
            NPCID.Sets.MPAllowedEnemies[Type] = true;
            NPCID.Sets.BossBestiaryPriority.Add(Type);
        }
        public override void SetDefaults()
        {
            NPC.width = 70;
            NPC.height = 40;
            NPC.aiStyle = -1;
            NPC.damage = 35;
            NPC.lifeMax = 6000;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0f;
            NPC.noGravity = false;
            NPC.value = Item.buyPrice(gold: 5);
            NPC.boss = true;
            NPC.npcSlots = 10f;
            int bossMusic = Main.rand.Next(1, 3);
            if (bossMusic == 1)
            {
                Music = MusicID.Boss1;
            }
            else
            {
                Music = MusicID.Boss2;
            }

            NPC.BossBar = ModContent.GetInstance<AncientSlimeBossBar>();
            BossBag = ModContent.ItemType<AncientSlimeBossBag>();
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary
            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement> {
                new MoonLordPortraitBackgroundProviderBestiaryInfoElement(), // Plain black background
				new FlavorTextBestiaryInfoElement("Summoned from the depth of the ice itself, the Ancient Slime returns to destroy its puny challenger.")
            });
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            //will do later, cba now
        }
        public override void AddRecipes()
        {

        }
    }
}