using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace KaizianMod.Items.Placeable
{
    public class PurpurhydriumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purpurhydrium Bar");
            Tooltip.SetDefault("Glowing with a faint pink color");
        }

        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = Item.sellPrice(silver : 61); // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("PurpurhydriumBarTile");
            item.maxStack = 99; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemType<PurpurhydriumOre>(), 3);
            r.AddIngredient(ItemID.HellstoneBar, 1);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}