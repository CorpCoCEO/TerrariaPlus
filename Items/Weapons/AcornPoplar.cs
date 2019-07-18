using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Weapons
{
	public class AcornPoplar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Acorn Poplar");
			Tooltip.SetDefault("Uses Acorns as Ammo ");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 38;
			item.height = 28;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("AcornBullet");
			item.shootSpeed = 16f;
			item.useAmmo = 4000;
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