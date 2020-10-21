using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaizianMod.Tiles
{
    public class CoalOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = false; // Emits Light
            Main.tileBlockLight[Type] = false; // Blocks Light
            Main.tileStone[Type] = true;
            

            drop = mod.ItemType("Coal"); // What item drops after destorying the tile
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Coal");
            AddMapEntry(new Color(22, 27, 46), name); // Colour of Tile on Map
            minPick = 0; // What power pick minimum is needed to mine this block.
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.0f;
            g = 0.0f;
            b = 0.0f;
        }
    }
}