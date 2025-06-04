using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Moderator : User
    {
        public Moderator(string userName, string email) : base(userName, email) { }

        public void ModerateContent()
        {
            Console.WriteLine("Контент модеровано.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(" | Роль: Модератор");
        }
    }

}
