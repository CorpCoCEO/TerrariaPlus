using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.NPCs
{
	public class MyGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}

		public bool ShatteredOne = false;
		public bool ShatteredTwo = false;
		public bool ShatteredThree = false;

		public override void ResetEffects(NPC npc)
		{
			ShatteredOne = false;
			ShatteredTwo = false;
			ShatteredThree = false;
		}

		public override void NPCLoot(NPC npc)
		{
			//if(npc.type == NPCID.GreenSlime)
			//{
				//if (Main.rand.Next(2) == 0)
				//{ 
				Item.NewItem(npc.getRect(), ItemID.DirtBlock);
				//}
			//}
		}
	}
}
