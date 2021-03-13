// Андрей Никеенко
// 4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;

namespace dz2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            bool logon = false;

            do
            {
                Console.WriteLine("Login:");
                var login = Console.ReadLine();

                Console.WriteLine("Password:");
                var pass = Console.ReadLine();

                if (login == "root" && pass == "GeekBrains")
                {
                    Console.WriteLine("Success! Welcome.\n");
                    logon = true;
                    break;
                }
                else if (i < 3)
                {
                    Console.WriteLine("Access denied! Try again.\n");
                }
                else
                {
                    Console.WriteLine("Access denied! Good bye.\n");
                }
                
                i++;
            }
            while (i <= 3);

            Console.WriteLine($"Logon: {logon}");

            Console.ReadKey();
        }
    }
}
