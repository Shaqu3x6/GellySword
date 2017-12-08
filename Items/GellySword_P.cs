using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GellySword.Items
{
	public class GellySword_P : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink GellySword");
			Tooltip.SetDefault("It's just a Pink Gelly Sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item16;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PinkGel, 20);
            recipe.AddIngredient(ItemID.PlatinumBar, 2);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
