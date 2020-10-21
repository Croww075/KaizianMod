using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using KaizianMod.Tiles;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace KaizianMod.Items.Armour
{
    [AutoloadEquip(EquipType.Head)]
    public class PurpurhydriumHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Reforged and fused, its arcane properties come to life." +
                "\nIncreased magical damage by 15%" +
                "\nReduced mana usage by 10%." +
                "\nIncreased maximum mana by 40." +
                "\nIncreased minion damage by 10%.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 1, silver: 10);
            item.rare = 2;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PurpurhydriumBreastplate") && legs.type == mod.ItemType("PurpurhydriumLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.15f;
            player.manaCost -= 0.1f;
            player.statManaMax2 += 40;
            player.minionDamage += 0.1f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.statManaMax2 += 40;
            player.magicCrit += 10;
            player.maxMinions += 2;
            player.minionDamageMult += 0.1f;
            player.buffImmune[BuffID.OnFire] = true;
            player.setBonus = "Increased max mana by 40" +
                "\nIncrerased magical critical strike chance by 10%" +
                "\nIncreased max number of minions" +
                "\nIncreased minion damage by 10%" +
                "\nImmunity to On Fire";
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.MoltenHelmet);
            r.AddIngredient(null, "PurpurhydriumBar", 3);
            r.AddIngredient(ItemID.Silk, 20);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}