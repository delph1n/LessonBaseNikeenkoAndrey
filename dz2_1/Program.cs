// Андрей Никеенко
// 1.	Написать метод, возвращающий минимальное из трёх чисел.

using System;

namespace dz2_1
{
    class Program
    {
        static private double MinNumber(double[] num)
        {
            var min = num[0];

            if (num[1] < num[0] && num[1] < num[2])
            {
                min = num[1];
            }
            else if (num[2] < num[0])
            {
                min = num[2];
            }

            return min;
        }
        static void Main(string[] args)
        {
            int count = 3;
            double[] Numbers = new double[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите {i + 1} число:");
                Numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            var min = MinNumber(Numbers);
            Console.WriteLine($"Минимальное число: {min}");

            Console.ReadKey();
        }
    }
}
