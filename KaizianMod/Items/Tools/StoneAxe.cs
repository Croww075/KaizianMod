using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KaizianMod.Items.Tools
{
	public class StoneAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 27;
			item.axe = 9;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.sellPrice(copper: 50);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 4);
			recipe.AddIngredient(ItemID.StoneBlock, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
