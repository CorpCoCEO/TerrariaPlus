using Terraria.ModLoader;
using Terraria.ID;

namespace TerrariaPlus
{
	class TerrariaPlus : Mod
	{
		//whatup, it me
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.Acorn);
            recipe.AddRecipe();
        }

		public TerrariaPlus()
		{

		}
	}
}
