using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KaizianMod.Items
{
    public class Gunpowder : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very Explosive");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 10);
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddRecipeGroup("KaizianMod:CoalGroup", 3);
            r.AddRecipeGroup("IronBar");
            r.AddTile(TileID.Anvils);
            r.SetResult(this, 5);
            r.AddRecipe();
        }
    }
}