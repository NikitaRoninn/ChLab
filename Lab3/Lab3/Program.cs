
using System.Net.Sockets;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDamageable enemy = new Enemy();
            IDamageable wall = new BreakableWall();

            Projectile bullet = new Bullet(20);

            bullet.HitTarget(enemy);
            bullet.HitTarget(wall);



        }
    }
}
