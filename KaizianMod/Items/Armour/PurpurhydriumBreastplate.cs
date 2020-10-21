using KaizianMod.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace KaizianMod.Items.Armour
{
    [AutoloadEquip(EquipType.Body)]
    public class PurpurhydriumBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pink energy overflows, as its potential is unleashed." +
                "");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice( silver: 80 );
            item.rare = 2;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player) //buffs and whatnot
        {
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.MoltenBreastplate);
            r.AddIngredient(null, "PurpurhydriumBar", 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}