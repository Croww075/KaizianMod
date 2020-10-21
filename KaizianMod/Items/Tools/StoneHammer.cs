using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KaizianMod.Items.Tools
{
	public class StoneHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 32;
			item.useAnimation = 32;
			item.hammer = 50;  //How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.sellPrice(copper: 60); 
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
