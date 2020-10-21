using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using KaizianMod.Tiles;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace KaizianMod.Items.Armour
{
    [AutoloadEquip(EquipType.Head)]
    public class PurpurhydriumMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Reforged and fused, its true nature comes to life" +
                "\nIncreased melee speed by 15%" +
                "\nIncreased melee damage by 10%");

        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice( gold: 1, silver : 10 );
            item.rare = 2;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PurpurhydriumBreastplate") && legs.type  == mod.ItemType("PurpurhydriumLeggings");
        }

        public override void UpdateArmorSet (Player player)
        {
            player.meleeCrit += 10;
            player.statDefense += 2;
            player.statLifeMax2 += 100;
            player.buffImmune[BuffID.OnFire] = true;
            player.setBonus = "Increased melee critical chance by 10%" +
                "\nIncreased defense by 2" +
                "\nIncreased max health by 100" +
                "\nImmunity to On Fire";
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.15f;
            player.meleeDamageMult += 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.MoltenHelmet);
            r.AddIngredient(null, "PurpurhydriumBar", 3);
            r.AddRecipeGroup("KaizianMod:EvilGutsGroup", 15);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}