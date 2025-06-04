namespace Lab2
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Створення користувачів ===");

            User admin = CreateUserInput("Адміністратор");
            User mod = CreateUserInput("Модератор");
            User user = CreateUserInput("Звичайний користувач");

            List<User> users = new List<User> { user, mod, admin };

            Console.WriteLine("=== Інформація про користувачів ===");
            foreach (User u in users)
            {
                u.DisplayInfo();
            }

            Console.WriteLine("=== Тестування методів ===");
            foreach (User u in users)
            {
                if (u is RegularUser ru)
                    ru.PostComment();
                else if (u is Moderator m)
                    m.ModerateContent();
                else if (u is Admin a)
                    a.BlockUser(user);
            }


            Console.WriteLine("=== Перевірка аутентифікації ===");
            foreach (User u in users)
            {
                Console.Write($"{u.UserName}, введіть пароль для аутентифікації: ");
                string input = Console.ReadLine() ?? "";
                bool success = u.Authenticate(input);
                Console.WriteLine($"{u.UserName}: {(success ? "Успішна аутентифікація" : "Невірний пароль")}");
            }
        }

        static User CreateUserInput(string roleName)
        {
            Console.WriteLine($"--- {roleName} ---");
            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Введіть email: ");
            string email = Console.ReadLine() ?? "";

            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine() ?? "";

            User user;

            if (roleName == "Адміністратор")
                user = new Admin(name, email);
            else if (roleName == "Модератор")
                user = new Moderator(name, email);
            else if (roleName == "Звичайний користувач")
                user = new RegularUser(name, email);
            else
                throw new Exception("Невідома роль.");

            user.SetPassword(password);
            return user;
        }

    }

}
