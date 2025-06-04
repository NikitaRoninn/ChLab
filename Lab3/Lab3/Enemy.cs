using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Enemy : IDamageable
    {
        private int health = 100;

        public void TakeDamage(int amount)
        {
            health -= amount;
            Console.WriteLine($"Ворог отримав {amount} шкоди. Здоров'я: {health}");

            if (health <= 0)
                Console.WriteLine("Ворог знищений!");
        }
    }
}
