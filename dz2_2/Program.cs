// Андрей Никеенко
// 2.	Написать метод подсчета количества цифр числа.

using System;

namespace dz2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var str = Console.ReadLine();
            var count = str.Length;

            var a = Convert.ToDouble(str);
            if (a < 0) count -= 1;
            if (a % 1 != 0) count -= 1;

            Console.WriteLine($"Число {a} состоит из {count} цифр.");

            Console.ReadKey();
        }
    }
}
