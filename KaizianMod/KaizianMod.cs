using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;

namespace KaizianMod
{
	public class KaizianMod : Mod
	{
		public KaizianMod()
		{
		}

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Jellyfish Banner", new int[]
            {
                ItemID.GreenJellyfishBanner,
                ItemID.JellyfishBanner
            });
            RecipeGroup.RegisterGroup("KaizianMod:JellyfishBannerGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Copper Bar", new int[]
            {
                ItemID.CopperBar,
                ItemID.TinBar
            });
            RecipeGroup.RegisterGroup("KaizianMod:CopperBarGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Copper Ore", new int[]
            {
                ItemID.CopperOre,
                ItemID.TinOre
            });
            RecipeGroup.RegisterGroup("KaizianMod:CopperOreGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver Ore", new int[]
            {
                ItemID.SilverOre,
                ItemID.TungstenOre
            });
            RecipeGroup.RegisterGroup("KaizianMod:SilverOreGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver Bar", new int[]
            {
                ItemID.SilverBar,
                ItemID.TungstenBar
            });
            RecipeGroup.RegisterGroup("KaizianMod:SilverBarGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold Ore", new int[]
            {
                ItemID.GoldOre,
                ItemID.PlatinumOre
            });
            RecipeGroup.RegisterGroup("KaizianMod:GoldTierOre", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold Bar", new int[]
            {
                ItemID.GoldBar,
                ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("KaizianMod:GoldBarGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Block", new int[]
            {
                ItemID.EbonstoneBlock,
                ItemID.CrimstoneBlock
            });
            RecipeGroup.RegisterGroup("KaizianMod:EvilBlockGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Impure Block", new int[]
            {
                ItemID.EbonstoneBlock,
                ItemID.CrimstoneBlock,
                ItemID.PearlstoneBlock
            });
            RecipeGroup.RegisterGroup("KaizianMod:ImpureBlockGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Bar", new int[]
            {
                ItemID.DemoniteBar,
                ItemID.CrimtaneBar,
            });
            RecipeGroup.RegisterGroup("KaizianMod:EvilBarGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Ore", new int[]
            {
                ItemID.DemoniteOre,
                ItemID.CrimtaneOre,
            });
            RecipeGroup.RegisterGroup("KaizianMod:EvilOreGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Tissue", new int[]
            {
                ItemID.ShadowScale,
                ItemID.TissueSample
            });
            RecipeGroup.RegisterGroup("KaizianMod:EvilTissueGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Guts", new int[]
            {
                ItemID.RottenChunk,
                ItemID.Vertebrae
            });
            RecipeGroup.RegisterGroup("KaizianMod:EvilGutsGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt Ore", new int[]
            {
                ItemID.CobaltOre,
                ItemID.PalladiumOre
            });
            RecipeGroup.RegisterGroup("KaizianMod:CobaltOreGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt Bar", new int[]
            {
                ItemID.CobaltBar,
                ItemID.PalladiumOre
            });
            RecipeGroup.RegisterGroup("KaizianMod:CobaltBarGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril Ore", new int[]
            {
                ItemID.MythrilOre,
                ItemID.OrichalcumOre
            });
            RecipeGroup.RegisterGroup("KaizianMod:MythrilOreGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril Bar", new int[]
            {
                ItemID.MythrilBar,
                ItemID.OrichalcumBar,
            });
            RecipeGroup.RegisterGroup("KaizianMod:MythrilBarGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Titanium Ore", new int[]
            {
                ItemID.TitaniumOre,
                ItemID.AdamantiteOre
            });
            RecipeGroup.RegisterGroup("KaizianMod:TitaniumOreGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Titanium Bar", new int[]
            {
                ItemID.TitaniumBar,
                ItemID.AdamantiteBar
            });
            RecipeGroup.RegisterGroup("KaizianMod:TitaniumBarGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Coal", new int[]
            {
                ItemType("Charcoal"),
                ItemType("Coal")
            });
            RecipeGroup.RegisterGroup("KaizianMod:CoalGroup", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Wings", new int[]
            {
                ItemID.AngelWings,
                ItemID.DemonWings,  
                ItemID.FinWings,
                ItemID.Jetpack,
                ItemID.BeeWings,
                ItemID.ButterflyWings,
                ItemID.FairyWings,
                ItemID.BatWings,
                ItemID.HarpyWings,
                ItemID.BoneWings,
                ItemID.WillsWings,
                ItemID.CrownosWings,
                ItemID.DTownsWings,
                ItemID.CenxsWings,
                ItemID.Yoraiz0rWings,
                ItemID.LokisWings,
                ItemID.JimsWings,
                ItemID.SkiphsWings,
                ItemID.RedsWings,
                ItemID.ArkhalisWings,
                ItemID.LeinforsWings,
                ItemID.MothronWings,
                ItemID.LeafWings,
                ItemID.FrozenWings,
                ItemID.FlameWings,
                ItemID.GhostWings,
                ItemID.BeetleWings,
                ItemID.Hoverboard,
                ItemID.FestiveWings,
                ItemID.SpookyWings,
                ItemID.TatteredFairyWings,
                ItemID.SteampunkWings,
                ItemID.BetsyWings,
                ItemID.FishronWings,
                ItemID.WingsNebula,
                ItemID.WingsVortex,
                ItemID.WingsStardust,
                ItemID.WingsSolar
            });
            RecipeGroup.RegisterGroup("KaizianMod:AnyWingsGroup", group);
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(this);
            r.AddRecipeGroup("IronBar", 5);
            r.AddIngredient(ItemID.Glass, 10);
            r.AddIngredient(ItemID.RecallPotion, 5);
            r.AddIngredient(ItemID.FallenStar, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(ItemID.MagicMirror);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.IceBlock, 60);
            r.AddIngredient(ItemID.Glass, 10);
            r.AddIngredient(ItemID.RecallPotion, 5);
            r.AddIngredient(ItemID.FallenStar, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(ItemID.IceMirror);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Vertebrae, 5);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(ItemID.Leather);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddRecipeGroup("IronBar", 3);
            r.AddIngredient(ItemID.Gel, 5);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(ItemID.Aglet);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Vine, 20);
            r.AddIngredient(ItemID.PinkGel, 5);
            r.AddIngredient(ItemID.Cloud, 10);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(ItemID.AnkletoftheWind);

            r = new ModRecipe(this);
            r.AddRecipeGroup("KaizianMod:GoldBarGroup", 5);
            r.AddIngredient(ItemID.FallenStar, 5);
            r.AddIngredient(ItemID.FeatherfallPotion, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(ItemID.LuckyHorseshoe);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Goldfish, 3);
            r.AddRecipeGroup("IronBar", 5);
            r.AddIngredient(ItemID.FlipperPotion, 3);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(ItemID.Flipper);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.SharkFin, 20);
            r.AddIngredient(ItemID.FlipperPotion, 10);
            r.AddRecipeGroup("IronBar", 20);
            r.AddIngredient(ItemID.SharkBanner);
            r.AddTile(TileID.Anvils);
            r.SetResult(ItemID.DivingHelmet);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Glowstick, 300);
            r.AddRecipeGroup("KaizianMod:JellyfishBannerGroup");
            r.AddTile(TileID.WorkBenches);
            r.SetResult(ItemID.JellyfishNecklace);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Leather, 5);
            r.AddIngredient(ItemID.IceBlock, 20);
            r.AddRecipeGroup("IronBar", 5);
            r.AddTile(TileID.IceMachine);
            r.SetResult(ItemID.IceSkates);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.CloudinaBottle);
            r.AddIngredient(ItemID.IceBlock, 30);
            r.AddTile(TileID.SkyMill);
            r.SetResult(ItemID.BlizzardinaBottle);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Bottle);
            r.AddIngredient(ItemID.SnowBlock, 50);
            r.AddIngredient(ItemID.IceBlock, 50);
            r.AddIngredient(ItemID.Feather, 5);
            r.AddTile(TileID.IceMachine);
            r.SetResult(ItemID.BlizzardinaBottle);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.CloudinaBottle);
            r.AddIngredient(ItemID.WaterBucket, 10);
            r.AddTile(TileID.SkyMill);
            r.SetResult(ItemID.TsunamiInABottle);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Bottle);
            r.AddIngredient(ItemID.WaterBucket, 10);
            r.AddIngredient(ItemID.Feather, 5);
            r.needWater = true;
            r.SetResult(ItemID.TsunamiInABottle);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.CloudinaBottle);
            r.AddIngredient(ItemID.SandBlock, 50);
            r.AddTile(TileID.SkyMill);
            r.SetResult(ItemID.SandstorminaBottle);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.SandBlock, 60);
            r.AddIngredient(ItemID.Sandstone, 60);
            r.AddIngredient(ItemID.Feather, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(ItemID.SandstorminaBottle);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Cloud, 30);
            r.AddIngredient(ItemID.Bottle);
            r.AddIngredient(ItemID.Feather, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(ItemID.CloudinaBottle);
            r.AddRecipe();


            r = new ModRecipe(this);
            r.AddIngredient(ItemID.SunplateBlock, 25);
            r.AddIngredient(ItemID.WorkBench);
            r.AddIngredient(ItemID.Cloud, 10);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(ItemID.SkyMill);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.Cloud, 30);
            r.AddIngredient(ItemID.StoneBlock, 25);
            r.AddIngredient(ItemID.FallenStar);
            r.needWater = true;
            r.SetResult(ItemID.SkyMill);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddRecipeGroup("Wood", 30);
            r.AddIngredient(ItemID.IllegalGunParts);
            r.AddIngredient(null, "Gunpowder", 10);
            r.AddTile(TileID.MythrilAnvil);
            r.SetResult(ItemID.Shotgun);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddRecipeGroup("Wood", 30);
            r.AddIngredient(ItemID.IllegalGunParts);
            r.AddIngredient(null, "Gunpowder", 5);
            r.AddIngredient(ItemID.JungleSpores, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(ItemID.Boomstick);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.BrainOfConfusion);
            r.AddTile(TileID.DemonAltar);
            r.SetResult(ItemID.WormScarf);
            r.AddRecipe();

            r = new ModRecipe(this);
            r.AddIngredient(ItemID.WormScarf);
            r.AddTile(TileID.DemonAltar);
            r.SetResult(ItemID.BrainOfConfusion);
            r.AddRecipe();
        }
    }
}