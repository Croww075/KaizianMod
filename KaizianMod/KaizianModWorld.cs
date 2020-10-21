using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;

namespace KaizianMod
{
    public class KaizianModWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Kaziain Mod Ores", delegate (GenerationProgress progress)
                {
                    progress.Message = "Generating Purpurhydrium";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                    {
                        WorldGen.TileRunner
                        (
                            WorldGen.genRand.Next(0, Main.maxTilesX), //X Coord of the tile
                            WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), //Y Coord of the tile
                            (double)WorldGen.genRand.Next(2, 3), //Strength ( higher = more )
                            WorldGen.genRand.Next(2, 3), //Steps
                            mod.TileType("PurpurhydriumOreTile"), //Tile type to be spawned
                            false,
                            0f,
                            0f,
                            false,
                            true
                         );
                    }

                    progress.Message = "Adding Coal";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                    {
                        WorldGen.TileRunner
                        (
                            WorldGen.genRand.Next(0, Main.maxTilesX),
                            WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY),
                            (double)WorldGen.genRand.Next(3, 9),
                            WorldGen.genRand.Next(3, 9),
                            mod.TileType("CoalOreTile"),
                            false,
                            0f,
                            0f,
                            false,
                            true
                        );
                    }
                }));
            }
        }
    }
}
