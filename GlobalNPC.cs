using calamityVanillaItemRecipeChanges.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges
{
	class MyGlobalNPC : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			if (npc.type == NPCID.Vulture)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DesertFeather>(), 2, 1, 2));
			}

			if (npc.type == NPCID.BloodZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.Drippler)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.TheBride)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.TheGroom)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.Clown)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.Zombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieElf)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieElfBeard)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieElfGirl)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieEskimo)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieMushroom)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieMushroomHat)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombiePixie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieRaincoat)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieSuperman)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieSweater)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ZombieXmas)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ArmedZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ArmedZombieCenx)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ArmedZombieEskimo)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ArmedZombiePincussion)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ArmedZombieSlimed)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ArmedZombieSwamp)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.ArmedZombieTwiggy)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BaldZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigBaldZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigFemaleZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigPincushionZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigRainZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigSlimedZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigSwampZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigTwiggyZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BigZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.FemaleZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.PincushionZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SlimedZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallBaldZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallFemaleZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallPincushionZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallRainZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallSlimedZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallSwampZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallTwiggyZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SmallZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SwampZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.TwiggyZombie)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.DemonEye)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.DemonEye2)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.CataractEye)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.CataractEye2)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SleepyEye)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.SleepyEye2)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.DialatedEye)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.DialatedEye2)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.GreenEye)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.GreenEye2)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.PurpleEye)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.PurpleEye2)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.DemonEyeOwl)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.DemonEyeSpaceship)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsBloodMoonAndNotFromStatue(), ModContent.ItemType<BloodOrb>(), 2, 1, 1));
			}

			if (npc.type == NPCID.BoneSerpentBody)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<DemonicBoneAsh>(), 2, 4));
			}

			if (npc.type == NPCID.Demon)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<DemonicBoneAsh>(), 2, 4));
			}

			if (npc.type == NPCID.VoodooDemon)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<DemonicBoneAsh>(), 2, 4));
			}

			if (npc.type == NPCID.RedDevil)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<DemonicBoneAsh>(), 2, 4));
			}

			if (npc.type == NPCID.Arapaima)
			{
				//new CommonDrop(ModContent.ItemType<MurkyPaste>(), 3333, 1, 1, 10000));
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<MurkyPaste>(), 4, 3));
			}

			if (npc.type == NPCID.SpikedJungleSlime)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<MurkyPaste>(), 4, 3));
			}

			if (npc.type == NPCID.Derpling)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<BeetleJuice>(), 4, 3));
			}

			if (npc.type == NPCID.WanderingEye)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BlightedLens>(), 2, 1, 2));
			}

			if (npc.type == NPCID.Skeleton)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<AncientBoneDust>(), 5, 3));
			}

			if (npc.type == NPCID.GreekSkeleton)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<AncientBoneDust>(), 5, 3));
			}

			if (npc.type == NPCID.ArmoredSkeleton)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<AncientBoneDust>(), 5, 3));
			}

			if (npc.type == NPCID.SkeletonArcher)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<AncientBoneDust>(), 5, 3));
			}

			if (npc.type == NPCID.IceTortoise)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<EssenceOfEleum>(), 3, 2));
			}

			if (npc.type == NPCID.IcyMerman)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<EssenceOfEleum>(), 3, 2));
			}

			if (npc.type == NPCID.IceElemental)
			{
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<EssenceOfEleum>(), 3, 2));
			}

			if (npc.type == NPCID.IceGolem)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EssenceOfEleum>(), 1, 1, 2));
			}
		}
	}
}
