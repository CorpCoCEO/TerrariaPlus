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

		// Put all your debuffs that go on enemies here (always set to false)

		public bool ShatteredOne = false;
		public bool ShatteredTwo = false;
		public bool ShatteredThree = false;

		public override void ResetEffects(NPC npc)
		{
			// Put em here too

			ShatteredOne = false;
			ShatteredTwo = false;
			ShatteredThree = false;
		}

		public override void NPCLoot(NPC npc)
		{
			// Changes what NPCs drop when killed

			//if(npc.type == NPCID.GreenSlime)
			//{
				//if (Main.rand.Next(2) == 0)
				//{ 
				Item.NewItem(npc.getRect(), ItemID.Loom);
				//}
			//}
		}
	}
}