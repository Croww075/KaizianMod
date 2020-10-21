using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaizianMod.Tiles
{
    public class PurpurhydriumOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = true; // ???
            Main.tileBlockLight[Type] = false; // Emits Light

            drop = mod.ItemType("PurpurhydriumOre"); // What item drops after destorying the tile
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Purpurhydrium Ore");
            AddMapEntry(new Color(243, 36, 226), name); // Colour of Tile on Map
            minPick = 50; // What power pick minimum is needed to mine this block.
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.95f;
            g = 0.14f;
            b = 0.88f;
        }
    }
}