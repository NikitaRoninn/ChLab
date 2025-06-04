using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   public class BreakableWall : IDamageable
    {
        private int durability = 50;

        public void TakeDamage(int amount)
        {
            durability -= amount;
            Console.WriteLine($"Стіна отримала {amount} шкоди. Міцність: {durability}");

            if (durability <= 0)
                Console.WriteLine("Стіна зруйнована!");
        }
    }
}
