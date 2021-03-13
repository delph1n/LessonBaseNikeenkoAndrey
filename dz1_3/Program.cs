//Андрей Никеенко
//3.
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

using System;

namespace dz1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте считать расстояние между точками! Введите координаты.\n\nx1:");
            var x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\ny1:");
            var y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nx2:");
            var x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\ny2:");
            var y2 = Convert.ToInt32(Console.ReadLine());

            double r = Distance(x1, y1, x2, y2);

            Console.WriteLine($"\nРасстояние между точками равно: {r:F2}");

            Console.ReadKey();
        }

        private static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
