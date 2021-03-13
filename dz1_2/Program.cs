//Андрей Никеенко
//2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах

using System;

namespace dz1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для расчета индекса массы тела введите ваши данные.\n\nРост в см:");
            var h = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("\nВес в кг:");
            var m = Convert.ToDouble(Console.ReadLine());

            var l = m / (h * h);

            Console.WriteLine($"\nВаш ИМТ: {l:F2}");

            if (l <= 18.4)
            {
                Console.WriteLine("У вас сильный недостаток веса!");
            }
            else if (l <= 24.9)
            {
                Console.WriteLine("У вас нормальный вес!");
            }
            else
            {
                Console.WriteLine("У вас избыточный вес!");
            }

            Console.ReadKey();
        }
    }
}
