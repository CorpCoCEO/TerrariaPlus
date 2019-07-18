using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items.Weapons
{
	public class ShatteringScimitar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shattering Scimitar");
			Tooltip.SetDefault("Inflicts a defense down debuff, which stacks up to 3 times ");
		}
		public override void SetDefaults()
		{
			item.melee = true;
			item.damage = 12;

			item.width = 20;
			item.height = 20;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 0;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.value = Item.buyPrice(0, 2, 0, 0);
			item.useTurn = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			if (target.FindBuffIndex(mod.BuffType("ShatteredTwo")) >= 1)
			{
				target.AddBuff(mod.BuffType("ShatteredThree"), 120);
			}
			if (target.FindBuffIndex(mod.BuffType("ShatteredOne")) >= 1)
			{
				target.AddBuff(mod.BuffType("ShatteredTwo"), 120);
			}
			// Add Onfire buff to the NPC for 1 second
			// 60 frames = 1 second
			target.AddBuff(mod.BuffType("ShatteredOne"), 3600);
		}
	}
}
