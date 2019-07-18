using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.Projectiles
{
	public class AcornBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Acorn Bullet");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 2;
			projectile.height = 2 ;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.timeLeft = 600;
			projectile.alpha = 255;
			projectile.ignoreWater = false;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = ProjectileID.Bullet;
		}

		public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height); //makes dust based on tile
            Main.PlaySound(SoundID.Item10, projectile.position); //plays impact sound
        }
	}
}