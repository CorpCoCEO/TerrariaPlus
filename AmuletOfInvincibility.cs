using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Items
{
	public class AmuletOfInvincibility : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amulet of Invincibility");
			Tooltip.SetDefault("You're Invincible! ");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 26;
			item.rare = 5;
			item.accessory = true;
			item.defense = 999;
			item.lifeRegen = 250;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statDefense += 999;
			player.lifeRegen = 250;
		}
	}
}