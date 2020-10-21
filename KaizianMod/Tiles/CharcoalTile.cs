using Terraria;
using Terraria.ObjectData;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaizianMod.Tiles
{
    public class CharcoalTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; //Is Tile Solid?
            Main.tileShine[Type] = 0; //???
            Main.tileSolidTop[Type] = false; //Solid Top ???
            Main.tileFrameImportant[Type] = true; //???

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = true;
            TileObjectData.addTile(Type);

            drop = mod.ItemType("Charcoal");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Charcoal");
            AddMapEntry(new Color(22, 27, 46), name);
            minPick = 0;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.0f;
            g = 0.0f;
            b = 0.0f;
        }
    }
}