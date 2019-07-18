using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Buffs
{
	public class ShatteredTwo : ModBuff
	{
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.defense -= 5;
		}
	}
}
