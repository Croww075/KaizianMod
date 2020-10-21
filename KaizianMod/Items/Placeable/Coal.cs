using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KaizianMod.Items.Placeable
{
    public class Coal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very flammable");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = Item.sellPrice(silver: 10);
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("CoalTile");
            item.maxStack = 999;
        }
    }
}