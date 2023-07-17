using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
	public class youAreCheatingArentYou : ModItem
	{

		public override void AddRecipes() 
		{

			//	ACCESSORIES
			
			Recipe.Create(ItemID.MagicQuiver)
				.AddIngredient(ItemID.EndlessQuiver)
				.AddIngredient(ItemID.PixieDust, 10)
				.AddIngredient(ModContent.ItemType<BlightedLens>(), 5)
				.AddIngredient(ItemID.SoulofLight, 8)
				.AddTile(TileID.CrystalBall)
				.Register();

			Recipe.Create(ItemID.GuideVoodooDoll)
				.AddIngredient(ItemID.Leather, 2)
				.AddIngredient(ItemID.ViciousPowder, 10)
				.AddTile(TileID.Hellforge)
				.Register();

			Recipe.Create(ItemID.GuideVoodooDoll)
				.AddIngredient(ItemID.Leather, 2)
				.AddIngredient(ItemID.VilePowder, 10)
				.AddTile(TileID.Hellforge)
				.Register();

			Recipe.Create(ItemID.LavaFishingHook)
				.AddIngredient(ItemID.Seashell)
				.AddIngredient(ItemID.HellstoneBar, 10)
				.AddTile(TileID.Hellforge)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.IceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.IceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.PurpleIceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.PurpleIceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.RedIceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.RedIceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.PinkIceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.PinkIceBlock, 2)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.Aglet)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Aglet)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.AnkletoftheWind)
				.AddIngredient(ItemID.JungleSpores, 15)
				.AddIngredient(ItemID.Cloud, 15)
				.AddIngredient(ItemID.PinkGel, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Bezoar)
				.AddIngredient(ItemID.Stinger, 15)
				.AddIngredient(ModContent.ItemType<MurkyPaste>())
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.BlizzardinaBottle)
				.AddIngredient(ItemID.Feather, 4)
				.AddIngredient(ItemID.Bottle)
				.AddIngredient(ItemID.SnowBlock, 50)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.CloudinaBottle)
				.AddIngredient(ItemID.Feather, 2)
				.AddIngredient(ItemID.Bottle)
				.AddIngredient(ItemID.Cloud, 25)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.FeralClaws)
				.AddIngredient(ItemID.Leather, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.FrogLeg)
				.AddIngredient(ItemID.Frog, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.LavaCharm)
				.AddIngredient(ItemID.LavaBucket, 5)
				.AddIngredient(ItemID.Obsidian, 25)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.LavaCharm)
				.AddIngredient(ItemID.LavaBucket, 5)
				.AddIngredient(ItemID.Obsidian, 25)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.LuckyHorseshoe)
				.AddIngredient(ItemID.SunplateBlock, 10)
				.AddIngredient(ItemID.Cloud, 10)
				.AddIngredient(ItemID.GoldBar, 5)
				.Register();

			Recipe.Create(ItemID.LuckyHorseshoe)
				.AddIngredient(ItemID.SunplateBlock, 10)
				.AddIngredient(ItemID.Cloud, 10)
				.AddIngredient(ItemID.PlatinumBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.ObsidianRose)
				.AddIngredient(ItemID.JungleRose)
				.AddIngredient(ItemID.Obsidian, 10)
				.AddIngredient(ItemID.Hellstone, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Radar)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Radar)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.SandstorminaBottle)
				.AddIngredient(ModContent.ItemType<DesertFeather>(), 10)
				.AddIngredient(ItemID.Feather, 6)
				.AddIngredient(ItemID.Bottle)
				.AddIngredient(ItemID.SandBlock, 70)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.WaterWalkingBoots)
				.AddIngredient(ItemID.WaterWalkingPotion, 8)
				.AddIngredient(ItemID.Leather, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.FlameWakerBoots)
				.AddIngredient(ItemID.Silk, 8)
				.AddIngredient(ItemID.Obsidian, 2)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.BandofRegeneration)
				.AddIngredient(ItemID.Shackle)
				.AddIngredient(ItemID.LifeCrystal)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.FlowerBoots)
				.AddIngredient(ItemID.Silk, 7)
				.AddIngredient(ItemID.JungleRose)
				.AddIngredient(ItemID.JungleGrassSeeds, 5)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.HandWarmer)
				.AddIngredient(ItemID.Silk, 5)
				.AddIngredient(ItemID.Shiverthorn)
				.AddIngredient(ItemID.SnowBlock, 10)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.HermesBoots)
				.AddIngredient(ItemID.Silk, 10)
				.AddIngredient(ItemID.SwiftnessPotion, 2)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.AdhesiveBandage)
				.AddIngredient(ItemID.Silk, 10)
				.AddIngredient(ItemID.Gel, 50)
				.AddIngredient(ItemID.GreaterHealingPotion)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.ArmorPolish)
				.AddIngredient(ItemID.Bone, 50)
				.AddIngredient(ModContent.ItemType<AncientBoneDust>(), 3)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.Blindfold)
				.AddIngredient(ItemID.Silk, 30)
				.AddIngredient(ItemID.SoulofNight, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.CelestialMagnet)
				.AddIngredient(ItemID.FallenStar, 20)
				.AddIngredient(ItemID.SoulofMight, 10)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddIngredient(ItemID.SoulofNight, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.CobaltShield)
				.AddIngredient(ItemID.CobaltBar, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.CobaltShield)
				.AddIngredient(ItemID.PalladiumBar, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.FastClock)
				.AddIngredient(ItemID.Timer1Second)
				.AddIngredient(ItemID.PixieDust, 15)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.FlyingCarpet)
				.AddIngredient(ItemID.AncientCloth, 10)
				.AddIngredient(ItemID.SoulofNight, 10)
				.AddIngredient(ItemID.SoulofLight, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.FrozenTurtleShell)
				.AddIngredient(ItemID.TurtleShell, 3)
				.AddIngredient(ModContent.ItemType<EssenceOfEleum>(), 9)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.Megaphone)
				.AddIngredient(ItemID.Wire, 10)
				.AddIngredient(ItemID.HallowedBar, 5)
				.AddIngredient(ItemID.Ruby, 3)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.MetalDetector)
				.AddIngredient(ItemID.Wire, 10)
				.AddIngredient(ItemID.GoldDust, 5)
				.AddIngredient(ItemID.SpelunkerGlowstick, 5)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.MetalDetector)
				.AddIngredient(ItemID.Wire, 10)
				.AddIngredient(ItemID.GoldDust, 5)
				.AddIngredient(ItemID.SpelunkerGlowstick, 5)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.Nazar)
				.AddIngredient(ItemID.SoulofNight, 20)
				.AddIngredient(ItemID.Lens, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.PocketMirror)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.GoldBar, 4)
				.AddIngredient(ItemID.CrystalShard, 2)
				.AddIngredient(ItemID.SoulofNight, 2)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.PocketMirror)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.PlatinumBar, 4)
				.AddIngredient(ItemID.CrystalShard, 2)
				.AddIngredient(ItemID.SoulofNight, 2)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.TrifoldMap)
				.AddIngredient(ItemID.Silk, 20)
				.AddIngredient(ItemID.SoulofLight, 3)
				.AddIngredient(ItemID.SoulofNight, 3)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.Vitamins)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ItemID.Waterleaf, 5)
				.AddIngredient(ItemID.Blinkroot, 5)
				.AddIngredient(ItemID.Daybloom, 5)
				.AddIngredient(ModContent.ItemType<BeetleJuice>(), 3)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.ShinyRedBalloon)
				.AddIngredient(ItemID.Gel, 80)
				.AddIngredient(ItemID.Cloud, 40)
				.AddIngredient(ItemID.WhiteString)
				.AddTile(TileID.Solidifier)
				.Register();

			Recipe.Create(ItemID.BrainOfConfusion)
				.AddIngredient(ItemID.WormScarf)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.WormScarf)
				.AddIngredient(ItemID.BrainOfConfusion)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.CrimsonHeart)
				.AddIngredient(ItemID.ShadowOrb)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.ShadowOrb)
				.AddIngredient(ItemID.CrimsonHeart)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
				.Register();

			//	AMMUNITION

			Recipe.Create(ItemID.RocketI, 20)
				.AddIngredient(ItemID.EmptyBullet, 20)
				.AddIngredient(ItemID.ExplosivePowder, 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.RocketII, 20)
				.AddIngredient(ItemID.EmptyBullet, 20)
				.AddIngredient(ItemID.ExplosivePowder, 2)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			//	ARMOR

			Recipe.Create(ItemID.PharaohsMask)
				.AddIngredient(ItemID.AncientCloth, 3)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.PharaohsRobe)
				.AddIngredient(ItemID.AncientCloth, 4)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.EskimoHood)
				.AddIngredient(ItemID.Silk, 4)
				.AddIngredient(ItemID.Leather)
				.AddIngredient(ItemID.BorealWood, 12)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.EskimoCoat)
				.AddIngredient(ItemID.Silk, 8)
				.AddIngredient(ItemID.Leather)
				.AddIngredient(ItemID.BorealWood, 18)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.EskimoPants)
				.AddIngredient(ItemID.Silk, 6)
				.AddIngredient(ItemID.Leather)
				.AddIngredient(ItemID.BorealWood, 15)
				.AddTile(TileID.Loom)
				.Register();

			//	CONSUMABLES

			Recipe.Create(ItemID.BloodMoonStarter)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddIngredient(ItemID.CopperBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.BloodMoonStarter)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddIngredient(ItemID.TinBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.TruffleWorm)
				.AddIngredient(ItemID.Worm)
				.AddIngredient(ItemID.GlowingMushroom, 15)
				.AddTile(TileID.Autohammer)
				.Register();

			Recipe.Create(ItemID.LifeCrystal)
				.AddIngredient(ItemID.Bone, 5)
				.AddIngredient(ItemID.PinkGel)
				.AddIngredient(ItemID.HealingPotion)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.SnowGlobe)
				.AddIngredient(ItemID.SnowBlock, 50)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.SoulofLight, 3)
				.AddIngredient(ItemID.SoulofNight, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.LihzahrdPowerCell)
				.AddIngredient(ItemID.LihzahrdBrick, 15)
				.AddTile(TileID.LihzahrdFurnace)
				.Register();

			Recipe.Create(ItemID.QueenSlimeCrystal)
				.AddIngredient(ItemID.CrystalShard, 20)
				.AddIngredient(ItemID.PinkGel, 10)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.Solidifier)
				.Register();

			//	CRAFTING MATERIALS

			Recipe.Create(ItemID.BlackLens)
				.AddIngredient(ItemID.Lens)
				.AddIngredient(ItemID.BlackDye)
				.AddTile(TileID.DyeVat)
				.Register();

			Recipe.Create(ItemID.Leather)
				.AddIngredient(ItemID.Vertebrae, 5)
				.AddTile(TileID.WorkBenches)
				.Register();

			// CRAFTING STATIONS

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.IceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.IronBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.IceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.LeadBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.PurpleIceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.IronBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.PurpleIceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.LeadBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.RedIceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.IronBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.RedIceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.LeadBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.PinkIceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.IronBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMachine)
				.AddIngredient(ItemID.PinkIceBlock, 25)
				.AddIngredient(ItemID.SnowBlock, 15)
				.AddIngredient(ItemID.LeadBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.SkyMill)
				.AddIngredient(ItemID.SunplateBlock, 10)
				.AddIngredient(ItemID.Cloud, 5)
				.AddIngredient(ItemID.RainCloud, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.LivingLoom)
				.AddIngredient(ItemID.Loom)
				.AddIngredient(ItemID.Vine, 2)
				.AddTile(TileID.Sawmill)
				.Register();

			//  PLACEABLES

			Recipe.Create(ItemID.CatBast)
				.AddIngredient(ItemID.IronBar, 7)
				.AddIngredient(ItemID.GoldBar, 3)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.CatBast)
				.AddIngredient(ItemID.LeadBar, 7)
				.AddIngredient(ItemID.GoldBar, 3)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.CatBast)
				.AddIngredient(ItemID.IronBar, 7)
				.AddIngredient(ItemID.PlatinumBar, 3)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.CatBast)
				.AddIngredient(ItemID.LeadBar, 7)
				.AddIngredient(ItemID.PlatinumBar, 3)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
				.Register();

			//	POTIONS

			Recipe.Create(ItemID.AmmoReservationPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.ArcheryPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.BattlePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.BuilderPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.CalmingPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.CratePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.TrapsightPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.EndurancePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.FeatherfallPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.FishingPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.FlipperPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.GenderChangePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.GillsPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.GravitationPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.HeartreachPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.LuckPotionGreater)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.HunterPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.InfernoPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.InvisibilityPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.IronskinPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.LuckPotionLesser)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.LifeforcePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.LovePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.LuckPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.MagicPowerPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.ManaRegenerationPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.MiningPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.NightOwlPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.ObsidianSkinPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.PotionOfReturn)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.RagePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.RegenerationPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.ShinePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.SonarPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.SpelunkerPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.StinkPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.SummoningPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.SwiftnessPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.TeleportationPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.ThornsPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.TitanPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.WarmthPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.WaterWalkingPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.WormholePotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.WrathPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			Recipe.Create(ItemID.BiomeSightPotion)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ModContent.ItemType<BloodOrb>(), 10)
				.AddTile(TileID.AlchemyTable)
				.Register();

			//	TOOLS

			Recipe.Create(ItemID.DemonConch)
				.AddIngredient(ModContent.ItemType<DemonicBoneAsh>())
				.AddIngredient(ItemID.HellstoneBar, 4)
				.AddTile(TileID.Hellforge)
				.Register();

			Recipe.Create(ItemID.BugNet)
				.AddIngredient(ItemID.IronBar, 3)
				.AddIngredient(ItemID.Cobweb, 30)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.BugNet)
				.AddIngredient(ItemID.LeadBar, 3)
				.AddIngredient(ItemID.Cobweb, 30)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.DesertMinecart)
				.AddIngredient(ItemID.SandstoneBrick, 20)
				.AddIngredient(ItemID.GoldBar, 6)
				.AddIngredient(ItemID.IronBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.DesertMinecart)
				.AddIngredient(ItemID.SandstoneBrick, 20)
				.AddIngredient(ItemID.GoldBar, 6)
				.AddIngredient(ItemID.LeadBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.DesertMinecart)
				.AddIngredient(ItemID.SandstoneBrick, 20)
				.AddIngredient(ItemID.PlatinumBar, 6)
				.AddIngredient(ItemID.IronBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.DesertMinecart)
				.AddIngredient(ItemID.SandstoneBrick, 20)
				.AddIngredient(ItemID.PlatinumBar, 6)
				.AddIngredient(ItemID.LeadBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.EncumberingStone)
				.AddIngredient(ItemID.StoneBlock, 100)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.IceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.IceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.PurpleIceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.PurpleIceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.RedIceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.RedIceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.PinkIceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.IceMirror)
				.AddIngredient(ItemID.PinkIceBlock, 20)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.MagicMirror)
				.AddIngredient(ItemID.IronBar, 10)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.MagicMirror)
				.AddIngredient(ItemID.LeadBar, 10)
				.AddIngredient(ItemID.Glass, 10)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.MoneyTrough)
				.AddIngredient(ItemID.PiggyBank)
				.AddIngredient(ItemID.Feather, 2)
				.AddIngredient(ModContent.ItemType<BloodOrb>())
				.AddIngredient(ItemID.GoldCoin, 15)
				.AddIngredient(ItemID.GoldBar, 8)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.MoneyTrough)
				.AddIngredient(ItemID.PiggyBank)
				.AddIngredient(ItemID.Feather, 2)
				.AddIngredient(ModContent.ItemType<BloodOrb>())
				.AddIngredient(ItemID.GoldCoin, 15)
				.AddIngredient(ItemID.PlatinumBar, 8)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.ShadowKey)
				.AddIngredient(ItemID.GoldenKey)
				.AddIngredient(ItemID.Obsidian, 20)
				.AddIngredient(ItemID.Bone, 5)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.RodofDiscord)
				.AddIngredient(ItemID.SoulofLight, 30)
				.AddIngredient(ItemID.ChaosFish, 5)
				.AddIngredient(ItemID.PixieDust, 50)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.LeafWand)
				.AddIngredient(ItemID.Wood, 30)
				.AddTile(TileID.LivingLoom)
				.Register();

			Recipe.Create(ItemID.LivingMahoganyLeafWand)
				.AddIngredient(ItemID.RichMahogany, 30)
				.AddTile(TileID.LivingLoom)
				.Register();

			Recipe.Create(ItemID.LivingWoodWand)
				.AddIngredient(ItemID.Wood, 30)
				.AddTile(TileID.LivingLoom)
				.Register();

			Recipe.Create(ItemID.LivingMahoganyWand)
				.AddIngredient(ItemID.RichMahogany, 30)
				.AddTile(TileID.LivingLoom)
				.Register();

			Recipe.Create(ItemID.Umbrella)
				.AddIngredient(ItemID.CopperBar, 2)
				.AddIngredient(ItemID.Silk, 5)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.Umbrella)
				.AddIngredient(ItemID.TinBar, 2)
				.AddIngredient(ItemID.Silk, 5)
				.AddTile(TileID.Loom)
				.Register();

			Recipe.Create(ItemID.TendonHook)
				.AddIngredient(ItemID.WormHook)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.WormHook)
				.AddIngredient(ItemID.TendonHook)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.StaffofRegrowth)
				.AddIngredient(ItemID.RichMahogany, 10)
				.AddIngredient(ItemID.JungleSpores, 5)
				.AddIngredient(ItemID.JungleRose)
				.AddTile(TileID.WorkBenches)
				.Register();

			//	WEAPONS

			Recipe.Create(ItemID.WaterBolt)
				.AddIngredient(ItemID.SpellTome)
				.AddIngredient(ItemID.Waterleaf, 3)
				.AddIngredient(ItemID.WaterCandle)
				.AddTile(TileID.Bookcases)
				.Register();

			Recipe.Create(ItemID.IceBoomerang)
				.AddIngredient(ItemID.IceBlock, 20)
				.AddIngredient(ItemID.SnowBlock, 10)
				.AddIngredient(ItemID.Shiverthorn)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceBoomerang)
				.AddIngredient(ItemID.PurpleIceBlock, 20)
				.AddIngredient(ItemID.SnowBlock, 10)
				.AddIngredient(ItemID.Shiverthorn)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceBoomerang)
				.AddIngredient(ItemID.RedIceBlock, 20)
				.AddIngredient(ItemID.SnowBlock, 10)
				.AddIngredient(ItemID.Shiverthorn)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.IceBoomerang)
				.AddIngredient(ItemID.PinkIceBlock, 20)
				.AddIngredient(ItemID.SnowBlock, 10)
				.AddIngredient(ItemID.Shiverthorn)
				.AddTile(TileID.IceMachine)
				.Register();

			Recipe.Create(ItemID.FlareGun)
				.AddIngredient(ItemID.CopperBar, 5)
				.AddIngredient(ItemID.Torch, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.FlareGun)
				.AddIngredient(ItemID.TinBar, 5)
				.AddIngredient(ItemID.Torch, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Muramasa)
				.AddIngredient(ItemID.CobaltBar, 15)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Muramasa)
				.AddIngredient(ItemID.PalladiumBar, 15)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.BouncingShield)
				.AddIngredient(ItemID.CobaltBar, 12)
				.AddIngredient(ItemID.SoulofLight, 4)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.BouncingShield)
				.AddIngredient(ItemID.PalladiumBar, 12)
				.AddIngredient(ItemID.SoulofLight, 4)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Shuriken, 50)
				.AddIngredient(ItemID.IronBar)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Shuriken, 50)
				.AddIngredient(ItemID.LeadBar)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.SlimeStaff)
				.AddIngredient(ItemID.Wood, 6)
				.AddIngredient(ItemID.Gel, 40)
				.AddIngredient(ItemID.PinkGel, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Starfury)
				.AddIngredient(ItemID.GoldBroadsword)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.Starfury)
				.AddIngredient(ItemID.PlatinumBroadsword)
				.AddIngredient(ItemID.FallenStar, 10)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.ThrowingKnife, 50)
				.AddIngredient(ItemID.IronBar)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.ThrowingKnife, 50)
				.AddIngredient(ItemID.LeadBar)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.WandofSparking)
				.AddIngredient(ItemID.Wood, 5)
				.AddIngredient(ItemID.Torch, 3)
				.AddIngredient(ItemID.FallenStar)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.BallOHurt)
				.AddIngredient(ItemID.TheRottedFork)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.TheRottedFork)
				.AddIngredient(ItemID.BallOHurt)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.ChainGuillotines)
				.AddIngredient(ItemID.FetidBaghnakhs)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.FetidBaghnakhs)
				.AddIngredient(ItemID.ChainGuillotines)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.ClingerStaff)
				.AddIngredient(ItemID.SoulDrain)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.SoulDrain)
				.AddIngredient(ItemID.ClingerStaff)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.DartPistol)
				.AddIngredient(ItemID.DartRifle)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.DartRifle)
				.AddIngredient(ItemID.DartPistol)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.Musket)
				.AddIngredient(ItemID.TheUndertaker)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.TheUndertaker)
				.AddIngredient(ItemID.Musket)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.CrimsonRod)
				.AddIngredient(ItemID.Vilethorn)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.Vilethorn)
				.AddIngredient(ItemID.CrimsonRod)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
				.Register();

			Recipe.Create(ItemID.PulseBow)
				.AddIngredient(ItemID.ShroomiteBar, 16)
				.AddTile(TileID.MythrilAnvil)
				.Register();

			Recipe.Create(ItemID.WoodenBoomerang)
				.AddIngredient(ItemID.Wood, 7)
				.AddTile(TileID.WorkBenches)
				.Register();

			Recipe.Create(ItemID.EnchantedSword)
				.AddIngredient(ItemID.GoldBar, 8)
				.AddIngredient(ItemID.Diamond)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.EnchantedSword)
				.AddIngredient(ItemID.PlatinumBar, 8)
				.AddIngredient(ItemID.Diamond)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.EnchantedBoomerang)
				.AddIngredient(ItemID.GoldBar, 8)
				.AddIngredient(ItemID.WoodenBoomerang)
				.AddTile(TileID.Anvils)
				.Register();

			Recipe.Create(ItemID.EnchantedBoomerang)
				.AddIngredient(ItemID.PlatinumBar, 8)
				.AddIngredient(ItemID.WoodenBoomerang)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}