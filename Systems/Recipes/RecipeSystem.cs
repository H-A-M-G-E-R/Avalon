using Avalon.Common.Players;
using Avalon.Items.Accessories.PreHardmode;
using Avalon.Items.Consumables.Critters;
using Avalon.Items.Food;
using Avalon.Items.Material.Bars;
using Avalon.Items.Material.Herbs;
using Avalon.Items.Placeable.Crafting;
using Avalon.Items.Placeable.Furniture;
using Avalon.Items.Placeable.Furniture.BleachedEbony;
using Avalon.Items.Placeable.Furniture.Coughwood;
using Avalon.Items.Placeable.Furniture.Gem;
using Avalon.Items.Placeable.Furniture.Heartstone;
using Avalon.Items.Placeable.Furniture.OrangeDungeon;
using Avalon.Items.Placeable.Furniture.PurpleDungeon;
using Avalon.Items.Placeable.Furniture.ResistantWood;
using Avalon.Items.Placeable.Furniture.YellowDungeon;
using Avalon.Items.Placeable.Tile;
using Avalon.Items.Tools.PreHardmode;
using Avalon.Items.Weapons.Magic.Wands;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Avalon.Systems.Recipes;
public class RecipeSystem : ModSystem
{
	//public override void PostAddRecipes()
	//{
	//	for (int i = 0; i < Recipe.numRecipes; i++)
	//	{
	//		Recipe recipe = Main.recipe[i];
	//		if (recipe.TryGetIngredient(ItemID.RottenChunk, out var chunk) && !Data.Sets.Recipe.RottenChunkOnlyItem[recipe.createItem.type])
	//		{
	//			recipe.AddRecipeGroup("RottenChunk", chunk.stack);
	//			recipe.RemoveIngredient(chunk);
	//		}
	//	}
	//}
	public override void AddRecipeGroups()
    {
        string any = Language.GetTextValue("LegacyMisc.37");

		RecipeGroups.Wood.ValidItems.Add(ModContent.ItemType<ApocalyptusWood>());
		RecipeGroups.Wood.ValidItems.Add(ModContent.ItemType<Coughwood>());
		RecipeGroups.Wood.ValidItems.Add(ModContent.ItemType<BleachedEbony>());
		RecipeGroups.Wood.ValidItems.Add(ModContent.ItemType<ResistantWood>());

		RecipeGroups.Fruit.ValidItems.Add(ModContent.ItemType<Blackberry>());
		RecipeGroups.Fruit.ValidItems.Add(ModContent.ItemType<Durian>());
		RecipeGroups.Fruit.ValidItems.Add(ModContent.ItemType<Mangosteen>());
		RecipeGroups.Fruit.ValidItems.Add(ModContent.ItemType<Medlar>());
		RecipeGroups.Fruit.ValidItems.Add(ModContent.ItemType<Raspberry>());

		RecipeGroups.GemCritter.ValidItems.Add(ModContent.ItemType<PeridotBunny>());
		RecipeGroups.GemCritter.ValidItems.Add(ModContent.ItemType<PeridotSquirrel>());
		RecipeGroups.GemCritter.ValidItems.Add(ModContent.ItemType<TourmalineBunny>());
		RecipeGroups.GemCritter.ValidItems.Add(ModContent.ItemType<TourmalineSquirrel>());
		RecipeGroups.GemCritter.ValidItems.Add(ModContent.ItemType<ZirconBunny>());
		RecipeGroups.GemCritter.ValidItems.Add(ModContent.ItemType<ZirconSquirrel>());

		List<int> JukeboxTracks = new List<int>
        {
            ItemID.MusicBoxOverworldDay,
            ItemID.MusicBoxEerie,
            ItemID.MusicBoxNight,
            ItemID.MusicBoxTitle,
            ItemID.MusicBoxUnderground,
            ItemID.MusicBoxBoss1,
            ItemID.MusicBoxJungle,
            ItemID.MusicBoxCorruption,
            ItemID.MusicBoxTheHallow,
            ItemID.MusicBoxUndergroundCorruption,
            ItemID.MusicBoxBoss2,
            ItemID.MusicBoxUndergroundHallow,
            ItemID.MusicBoxBoss3,
            ItemID.MusicBoxSnow,
            ItemID.MusicBoxSpace,
            ItemID.MusicBoxCrimson,
            ItemID.MusicBoxBoss4,
            ItemID.MusicBoxAltOverworldDay,
            ItemID.MusicBoxRain,
            ItemID.MusicBoxIce,
            ItemID.MusicBoxDesert,
            ItemID.MusicBoxOcean,
            ItemID.MusicBoxDungeon,
            ItemID.MusicBoxPlantera,
            ItemID.MusicBoxBoss5,
            ItemID.MusicBoxTemple,
            ItemID.MusicBoxEclipse,
            ItemID.MusicBoxMushrooms,
            ItemID.MusicBoxPumpkinMoon,
            ItemID.MusicBoxAltUnderground,
            ItemID.MusicBoxFrostMoon,
            ItemID.MusicBoxUndergroundCrimson,
            ItemID.MusicBoxLunarBoss,
            ItemID.MusicBoxMartians,
            ItemID.MusicBoxPirates,
            ItemID.MusicBoxHell,
            ItemID.MusicBoxTowers,
            ItemID.MusicBoxGoblins,
            ItemID.MusicBoxSandstorm,
            ItemID.MusicBoxDD2,
            ItemID.MusicBoxSpaceAlt,
            ItemID.MusicBoxOceanAlt,
            ItemID.MusicBoxWindyDay,
            ItemID.MusicBoxTownDay,
            ItemID.MusicBoxTownNight,
            ItemID.MusicBoxSlimeRain,
            ItemID.MusicBoxDayRemix,
            ItemID.MusicBoxTitleAlt,
            ItemID.MusicBoxStorm,
            ItemID.MusicBoxGraveyard,
            ItemID.MusicBoxUndergroundJungle,
            ItemID.MusicBoxJungleNight,
            ItemID.MusicBoxQueenSlime,
            ItemID.MusicBoxEmpressOfLight,
            ItemID.MusicBoxDukeFishron,
            ItemID.MusicBoxMorningRain,
            ItemID.MusicBoxConsoleTitle,
            ItemID.MusicBoxUndergroundDesert,
            ItemID.MusicBoxOWRain,
            ItemID.MusicBoxOWDay,
            ItemID.MusicBoxOWNight,
            ItemID.MusicBoxOWUnderground,
            ItemID.MusicBoxOWDesert,
            ItemID.MusicBoxOWOcean,
            ItemID.MusicBoxOWMushroom,
            ItemID.MusicBoxOWDungeon,
            ItemID.MusicBoxOWSpace,
            ItemID.MusicBoxOWUnderworld,
            ItemID.MusicBoxOWSnow,
            ItemID.MusicBoxOWCorruption,
            ItemID.MusicBoxOWUndergroundCorruption,
            ItemID.MusicBoxOWCrimson,
            ItemID.MusicBoxOWUndergroundCrimson,
            ItemID.MusicBoxOWUndergroundSnow,
            ItemID.MusicBoxOWUndergroundHallow,
            ItemID.MusicBoxOWBloodMoon,
            ItemID.MusicBoxOWBoss2,
            ItemID.MusicBoxOWBoss1,
            ItemID.MusicBoxOWInvasion,
            ItemID.MusicBoxOWTowers,
            ItemID.MusicBoxOWMoonLord,
            ItemID.MusicBoxOWPlantera,
            ItemID.MusicBoxOWJungle,
            ItemID.MusicBoxOWWallOfFlesh,
            ItemID.MusicBoxOWHallow,
            ItemID.MusicBoxCredits,
            ItemID.MusicBoxDeerclops,
            ItemID.MusicBoxShimmer,
        };
        List<int> boxesList = JukeboxTracks;
        boxesList.AddRange(AvalonJukeboxPlayer.AvalonTracks);
        int[] boxes = boxesList.ToArray();

		var groupMusicBoxes = RecipeGroup.Register(
			"MusicBoxes",
			"Music Box",
			[.. boxes]
		);

		#region Balloons
		var groupFartBalloons = RecipeGroup.Register(
			"Avalon:FartBalloons",
			"Fart Balloon",
			ItemID.FartInABalloon,
            ItemID.BalloonHorseshoeFart
        );
        var groupRocketBalloons = RecipeGroup.Register(
			"Avalon:RocketBalloons",
			"Rocket Balloon",
			ModContent.ItemType<Items.Accessories.Hardmode.RocketinaBalloon>(),
            ModContent.ItemType<Items.Accessories.Hardmode.RocketHorseshoeBalloon>()
        );
        var groupSharkronBalloons = RecipeGroup.Register(
			"Avalon:SharkronBalloons",
			"Sharkron Balloon",
			ItemID.SharkronBalloon,
            ItemID.BalloonHorseshoeSharkron
        );
		#endregion Balloons

		#region evil groups
		//var groupRottenChunks = new RecipeGroup(() => $"{any} Rotten Chunk",
		//[
		//	ItemID.RottenChunk,
		//	ItemID.Vertebrae,
		//	ModContent.ItemType<Items.Material.YuckyBit>()
		//]);
		//RecipeGroup.RegisterGroup("RottenChunk", groupRottenChunks);

		#endregion

		var groupGemStaves = RecipeGroup.Register(
			"Avalon:GemStaves",
			"Gem Staff",
			ItemID.RubyStaff,
            ItemID.AmberStaff,
            ItemID.TopazStaff,
            ItemID.EmeraldStaff,
            ItemID.SapphireStaff,
            ItemID.AmethystStaff,
            ItemID.DiamondStaff,
            ModContent.ItemType<PeridotStaff>(),
            ModContent.ItemType<TourmalineStaff>(),
            ModContent.ItemType<ZirconStaff>()
        );

        List<int> banners = new();
        for (int i = 0; i < NPCLoader.NPCCount; i++)
        {
            NPC npc = new NPC();
            npc.SetDefaults(i);
            if (NPCLoader.GetNPC(i) is ModNPC modnpc)
            {
				if (modnpc.BannerItem != ItemID.None)
				{
					banners.Add(modnpc.BannerItem);
				}
            }
            else
            {
                if (BannerSystem.NPCtoBanner(npc.BannerID()) > 0)
                {
                    int bannerID = ClassExtensions.BannerPlaceStyleToItemID(BannerSystem.NPCtoBanner(npc.BannerID()));
                    if (bannerID > 0)
                    {
                        banners.Add(bannerID);
                    }
                }
            }
        }
        int[] bannerArray = banners.ToArray();
		var groupBanners = RecipeGroup.Register(
			"Avalon:Banners",
			"Monster Banner",
			[.. bannerArray]
		);
        //{
        //    ItemID.RedBanner,
        //    ItemID.YellowBanner,
        //    ItemID.GreenBanner,
        //    ItemID.BlueBanner,
        //    ItemID.MarchingBonesBanner,
        //    ItemID.NecromanticSign,
        //    ItemID.RustedCompanyStandard,
        //    ItemID.RaggedBrotherhoodSigil,
        //    ItemID.MoltenLegionFlag,
        //    ItemID.DiabolicSigil,
        //    ItemID.WorldBanner,
        //    ItemID.SunBanner,
        //    ItemID.GravityBanner,
        //    ItemID.HellboundBanner,
        //    ItemID.HellHammerBanner,
        //    ItemID.HelltowerBanner,
        //    ItemID.LostHopesofManBanner,
        //    ItemID.ObsidianWatcherBanner,
        //    ItemID.LavaEruptsBanner,
        //    ItemID.AnkhBanner,
        //    ItemID.SnakeBanner,
        //    ItemID.OmegaBanner
        //});

		var groupGoldPickaxe = RecipeGroup.Register(
			nameof(ItemID.GoldPickaxe),
			"ItemName.GoldPickaxe",
			ItemID.GoldPickaxe,
			ItemID.PlatinumPickaxe,
			ModContent.ItemType<BismuthPickaxe>()
		);

		var groupTombstones = RecipeGroup.Register(
			"Tombstones",
			"ItemName.Tombstone",
			ItemID.Gravestone,
            ItemID.Tombstone,
            ItemID.CrossGraveMarker,
            ItemID.Obelisk,
            ItemID.Headstone,
            ItemID.GraveMarker,
            ItemID.RichGravestone1,
            ItemID.RichGravestone2,
            ItemID.RichGravestone3,
            ItemID.RichGravestone4,
            ItemID.RichGravestone5
        );

        var groupDungeonBricks = RecipeGroup.Register(
			"DungeonBrick",
			"Dungeon Brick",
			ItemID.PinkBrick,
            ModContent.ItemType<OrangeBrick>(),
            ModContent.ItemType<YellowBrick>(),
            ItemID.GreenBrick,
            ItemID.BlueBrick,
            ModContent.ItemType<PurpleBrick>()
        );

        //RecipeGroup.RegisterGroup("MagicStorage:AnyTombstone", groupTombstones);

        var groupWings = RecipeGroup.Register(
			"Wings",
			"Wings",
			ItemID.DemonWings,
            ItemID.AngelWings,
            ItemID.ButterflyWings,
            ItemID.FairyWings,
            ItemID.HarpyWings,
            ItemID.BoneWings,
            ItemID.FlameWings,
            ItemID.FrozenWings,
            ItemID.GhostWings,
            ItemID.LeafWings,
            ItemID.BatWings,
            ItemID.BeeWings,
            ItemID.TatteredFairyWings,
            ItemID.SpookyWings,
            ItemID.FestiveWings,
            ItemID.BeetleWings,
            ItemID.FinWings,
            ItemID.FishronWings,
            ItemID.WingsNebula,
            ItemID.WingsSolar,
            ItemID.WingsStardust,
            ItemID.WingsVortex,
            ItemID.FinWings,
            ItemID.MothronWings,
            ItemID.BetsyWings,
            ItemID.SteampunkWings,
            ItemID.RainbowWings//,
            //ModContent.ItemType<ContagionWings>(),
            //ModContent.ItemType<CrimsonWings>(),
            //ModContent.ItemType<CorruptionWings>(),
            //ModContent.ItemType<HolyWings>(),
            //ModContent.ItemType<EtherealWings>()
        );
        var groupWorkBenches = RecipeGroup.Register(
			"WorkBenches",
			"ItemName.WorkBench",
			ItemID.WorkBench,
            ItemID.EbonwoodWorkBench,
            ItemID.BlueDungeonWorkBench,
            ItemID.SteampunkWorkBench,
            ItemID.SpookyWorkBench,
            ItemID.SlimeWorkBench,
            ItemID.SkywareWorkbench,
            ItemID.ShadewoodWorkBench,
            ItemID.RichMahoganyWorkBench,
            ItemID.PumpkinWorkBench,
            ItemID.PinkDungeonWorkBench,
            ItemID.PearlwoodWorkBench,
            ItemID.PalmWoodWorkBench,
            ItemID.ObsidianWorkBench,
            ItemID.MushroomWorkBench,
            ItemID.MeteoriteWorkBench,
            ItemID.MartianWorkBench,
            ItemID.MarbleWorkBench,
            ItemID.LivingWoodWorkBench,
            ItemID.LihzahrdWorkBench,
            ItemID.HoneyWorkBench,
            ItemID.GreenDungeonWorkBench,
            ItemID.GraniteWorkBench,
            ItemID.GoldenWorkbench,
            ItemID.GlassWorkBench,
            ItemID.FrozenWorkBench,
            ItemID.FleshWorkBench,
            ItemID.DynastyWorkBench,
            ItemID.CrystalWorkbench,
            ItemID.CactusWorkBench,
            ItemID.BorealWoodWorkBench,
            ItemID.BoneWorkBench,
            ItemID.GothicWorkBench,
            ItemID.AshWoodWorkbench,
            ItemID.BalloonWorkbench,
            ItemID.CoralWorkbench,
            ItemID.SandstoneWorkbench,
            ItemID.BambooWorkbench,
            ItemID.SpiderWorkbench,
            ItemID.LesionWorkbench,
            ItemID.SolarWorkbench,
            ItemID.NebulaWorkbench,
            ItemID.StardustWorkbench,
            ItemID.VortexWorkbench,
            ModContent.ItemType<CoughwoodWorkBench>(),
            ModContent.ItemType<BleachedEbonyWorkBench>(),
            ModContent.ItemType<Items.Placeable.Furniture.WildMushroom.WildMushroomWorkBench>(),
            //ModContent.ItemType<Items.Placeable.Crafting.DarkSlimeWorkBench>(),
            ModContent.ItemType<HeartstoneWorkBench>(),
            ModContent.ItemType<OrangeDungeonWorkBench>(),
            ModContent.ItemType<PurpleDungeonWorkbench>(),
            ModContent.ItemType<YellowDungeonWorkBench>(),
            ModContent.ItemType<ResistantWoodWorkBench>()//,
            //ModContent.ItemType<Items.Placeable.Crafting.VertebraeWorkBench>()
        );

		var groupHerbs = RecipeGroup.Register(
			"Herbs",
			"Herb",
			ItemID.Blinkroot,
			ItemID.Fireblossom,
			ItemID.Deathweed,
			ItemID.Shiverthorn,
			ItemID.Waterleaf,
			ItemID.Moonglow,
			ItemID.Daybloom,
			ModContent.ItemType<Bloodberry>(),
			ModContent.ItemType<Sweetstem>(),
			ModContent.ItemType<Barfbush>(),
			ModContent.ItemType<Holybird>()//,
			//ModContent.ItemType<Items.TwilightPlume>(),
		);

		var groupTier1Watch = RecipeGroup.Register(
			nameof(ItemID.CopperWatch),
			"ItemName.CopperWatch",
			ItemID.CopperWatch,
			ItemID.TinWatch,
			ModContent.ItemType<BronzeWatch>()
		);

		var groupTier2Watch = RecipeGroup.Register(
			nameof(ItemID.SilverWatch),
			"ItemName.SilverWatch",
			ItemID.SilverWatch,
			ItemID.TungstenWatch,
			ModContent.ItemType<ZincWatch>()
		);

		var groupTier3Watch = RecipeGroup.Register(
			nameof(ItemID.GoldWatch),
			"ItemName.GoldWatch",
			ItemID.GoldWatch,
			ItemID.PlatinumWatch,
			ModContent.ItemType<BismuthWatch>()
		);

		var groupGoldBar = RecipeGroup.Register(
			nameof(ItemID.GoldBar),
			"ItemName.GoldBar",
			ItemID.GoldBar,
			ItemID.PlatinumBar,
			ModContent.ItemType<BismuthBar>()
		);

		var groupEvilBar = RecipeGroup.Register(
			nameof(ItemID.DemoniteBar),
			"ItemName.DemoniteBar",
			ItemID.DemoniteBar,
			ItemID.CrimtaneBar,
			ModContent.ItemType<BacciliteBar>()
		);

		RecipeGroups.IronBar.ValidItems.Add(ModContent.ItemType<NickelBar>());

		var groupCopperBar = RecipeGroup.Register(
			nameof(ItemID.CopperBar),
			"ItemName.CopperBar",
			ItemID.CopperBar,
			ItemID.TinBar,
			ModContent.ItemType<BronzeBar>()
		);

		var groupSilverBar = RecipeGroup.Register(
			nameof(ItemID.SilverBar),
			"ItemName.SilverBar",
			ItemID.SilverBar,
			ItemID.TungstenBar,
			ModContent.ItemType<ZincBar>()
		);

		#region thorium stuff
		RecipeGroups.CobaltBar.ValidItems.Add(ModContent.ItemType<DurataniumBar>());

		RecipeGroups.MythrilBar.ValidItems.Add(ModContent.ItemType<NaquadahBar>());

		RecipeGroups.AdamantiteBar.ValidItems.Add(ModContent.ItemType<TroxiniumBar>());
		#endregion
	}
}
