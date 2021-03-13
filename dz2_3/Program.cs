// Андрей Никеенко
// 3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

using System;

namespace dz2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double str;
            double sum = 0;
            Console.WriteLine("Вводите любые числа. Для окончания ввода введите 0.");

            while (true)
            {
                str = Convert.ToDouble(Console.ReadLine());

                if (str == 0) break;
                else if (str > 0 && str % 1 == 0 && str % 2 != 0) sum += str;
            }

            Console.WriteLine($"Сумма нечетных положительных чисел равна: {sum}");

            Console.ReadKey();
        }
    }
}
