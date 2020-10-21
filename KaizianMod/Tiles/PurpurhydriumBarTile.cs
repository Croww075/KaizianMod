using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace KaizianMod.Tiles
{
    public class PurpurhydriumBarTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; //Is Tile Solid?
            Main.tileShine[Type] = 1100; //???
            Main.tileSolidTop[Type] = true; //Solid Top ???
            Main.tileFrameImportant[Type] = true; //???

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1); //Copy a 1x1 tile, like bars
            TileObjectData.newTile.StyleHorizontal = true; //???
            TileObjectData.newTile.LavaDeath = false; //Death by Lava
            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("PurpurhydriumBar"); //Name on Map
            AddMapEntry(new Color(243, 36, 226), name); //Map Colour

            drop = mod.ItemType("PurpurhydriumBar"); //what it drops

            minPick = 50; //Minimum Pickaxe power required to mine it
        }
    }
}