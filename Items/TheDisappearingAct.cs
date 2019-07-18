using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items
{
	public class TheDisappearingAct : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Disappearing Act");
			Tooltip.SetDefault("Negates the damage of a powerful attack every once in a while.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 26;
			item.rare = 3;
			item.accessory = true;
      
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			//if statement concerning if player does not have the debuff
			player.endurance = 1;
			//if statement concerning getting hit
      			//player.AddBuff(mod.BuffType("DisappearingRecharge"), 3600);
			//player.AddBuff(mod.BuffType("Invisibility"), 300);
		}
		
		public override void AddRecipes()
		{
			ModRecipe goldRecipe = new ModRecipe(mod);
			goldRecipe.AddIngredient(ItemID.GoldWatch);
			goldRecipe.AddIngredient(ItemID.Glass, 5);
			goldRecipe.AddIngredient(ItemID.Bone, 5);
			goldRecipe.AddTile(TileID.Anvils);
			goldRecipe.SetResult(this);
			goldRecipe.AddRecipe();
			
			ModRecipe platinumRecipe = new ModRecipe(mod);
			platinumRecipe.AddIngredient(ItemID.PlatinumWatch);
			platinumRecipe.AddIngredient(ItemID.Glass, 5);
			platinumRecipe.AddIngredient(ItemID.Bone, 5);
			platinumRecipe.AddTile(TileID.Anvils);
			platinumRecipe.SetResult(this);
			platinumRecipe.AddRecipe();
		}
	}
}
