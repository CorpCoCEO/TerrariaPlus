using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Buffs
{
	public class ShatteredThree : ModBuff
	{
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.defense -= 5;
		}
	}
}