using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        private string _password;

        public User(string userName, string email)
        {
            UserName = userName;
            Email = email;
            _password = string.Empty;
        }

        public void SetPassword(string newPassword)
        {
            _password = newPassword;
        }

        public bool Authenticate(string inputPassword)
        {
            return _password == inputPassword;
        }

        public virtual void DisplayInfo()
        {
            Console.Write($"Ім'я: {UserName} | Email: {Email}");
        }
    }

}
