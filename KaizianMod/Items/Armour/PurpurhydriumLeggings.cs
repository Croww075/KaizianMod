using KaizianMod.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace KaizianMod.Items.Armour
{
    [AutoloadEquip(EquipType.Legs)]
    public class PurpurhydriumLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fused and reforged, its true potential awakens." 
                + "\n8% increased movement speed");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice( silver: 80 );
            item.rare = 2;
            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.08f;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.MoltenGreaves);
            r.AddIngredient(null, "PurpurhydriumBar", 4);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}