using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.ID;

namespace Terraria.ModLoader
{
    public class ModGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        
        public override void SetDefaults(Item item)
        {
            if (item.type == 27)
            {
                item.ammo = 4000;
            }
            if (item.type == 1294)
            {
                item.useTime = 1;
                item.useAnimation = 12;
            }
        }
    }
}