using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Admin : User
    {
        public Admin(string userName, string email) : base(userName, email) { }

        public void BlockUser(User user)
        {
            Console.WriteLine($"Користувача {user.UserName} заблоковано.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(" | Роль: Адміністратор");
        }
    }
}
