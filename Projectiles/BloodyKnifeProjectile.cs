﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NoxiumMod.Projectiles
{
	public class BloodyKnifeProjectile : ModProjectile
	{


		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 42;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.tileCollide = true;
			projectile.aiStyle = 1;
		}

		public float Timer
		{
			get => projectile.ai[0];
			set => projectile.ai[0] = value;
		}

		int timer;
		public override void AI()
		{
			timer++;
			if (timer >= 10)
			{
				timer = 0;
				if (projectile.owner == Main.myPlayer)
				{
					int num421 = (int)(projectile.position.X + 4f + Main.rand.Next(projectile.width - 6));
					int num422 = (int)(projectile.position.Y + projectile.height + 4f);
					Projectile.NewProjectile(num421, num422, 0f, 4f, ProjectileID.BloodRain, projectile.damage, 0f, projectile.owner);
				}
			}
		}



	}

}
