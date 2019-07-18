using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Weapons
{
	public class IvyStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ivy Staff");
			Tooltip.SetDefault("Creates a mana producing plant ");
		}
		public override void SetDefaults()
		{
			item.summon = true;
			item.damage = 0;
			item.mana = 6;
			item.noMelee = true;

			item.width = 22;
			item.height = 22;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 1;
			item.knockBack = 0;
			item.rare = 2;
			item.UseSound = SoundID.Item44;
			item.autoReuse = false;
			item.value = Item.buyPrice(0, 2, 0, 0);
			item.useTurn = false;

			item.shoot = mod.ProjectileType("IvyStaffSummon");
			item.shootSpeed = 10f;

			//item.buffType = mod.BuffType("IvyStaffBuff");
			//item.buffTime = 3600;
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
