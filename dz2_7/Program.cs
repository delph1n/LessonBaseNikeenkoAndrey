// Андрей Никеенко
// 7.	a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//      б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


using System;

namespace dz2_7
{
    class Program
    {
        static void Numbers(int a, int b, int sum)
        {
            if (a <= b)
            {
                Console.Write($"{a} ");
                sum += a;
                Numbers(a + 1, b, sum);
            }
            else
            {
                Console.WriteLine($"\nСумма чисел равна: {sum}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            do
            {
                Console.WriteLine("Введите число b (больше, чем a):");
                b = Convert.ToInt32(Console.ReadLine());
                if (a >= b) Console.WriteLine("Так не пойдет. Число b должно быть больше.");
                else break;
            }
            while (true);

            Console.WriteLine("\n");

            Numbers(a, b, 0);

            Console.ReadKey();
        }
    }
}
