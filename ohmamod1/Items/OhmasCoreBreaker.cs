using Terraria.ID;
using Terraria.ModLoader;

namespace ohmamod1.Items
{
	public class OhmasCoreBreaker : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Core Breaker"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Corrupted sword of the deceased.");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.crit = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 7;
			item.shoot = 132;
			item.shootSpeed = 10;
			item.UseSound = SoundID.Item38;
			item.autoReuse = true;
		}

		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}