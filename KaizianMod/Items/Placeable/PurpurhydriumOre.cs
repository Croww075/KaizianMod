using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KaizianMod.Items.Placeable
{
    public class PurpurhydriumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purpurhydrium Ore");
            Tooltip.SetDefault("Glowing with a faint pink color");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = Item.sellPrice(silver: 8);
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("PurpurhydriumOreTile");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}