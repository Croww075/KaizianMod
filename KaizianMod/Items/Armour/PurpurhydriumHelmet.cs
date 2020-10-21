using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using KaizianMod.Tiles;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace KaizianMod.Items.Armour
{
    [AutoloadEquip(EquipType.Head)]
    public class PurpurhydriumHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fused and reforged, its abilities are born anew" +
                "\nIncreased ranged and thrown damage by 15%" +
                "\nIncreased ranged and thrown critical chance by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 1, silver: 10);
            item.rare = 2;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PurpurhydriumBreastplate") && legs.type == mod.ItemType("PurpurhydriumLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.moveSpeed += 0.12f;
            player.ammoCost80 = true;
            player.thrownCost33 = true;
            player.thrownVelocity += 0.15f;
            player.buffImmune[BuffID.OnFire] = true;
            player.setBonus = "Increased movement speed by 12%" +
                "\n20% chance to not consume ammo" +
                "\n33% chance to not consume thrown item" +
                "\nIncreasedd thrown item velocity by 15%" +
                "\nImmunity to On Fire";
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamageMult += 0.15f;
            player.rangedCrit += 10;
            player.thrownDamageMult += 0.15f;
            player.thrownCrit += 10;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.MoltenHelmet);
            r.AddIngredient(null, "PurpurhydriumBar", 3);
            r.AddIngredient(ItemID.Lens, 5);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}