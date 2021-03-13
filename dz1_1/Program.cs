//Андрей Никеенко
//1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) *используя вывод со знаком $.

using System;

namespace dz1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа \"Анкета\". Введите ваши данные.\n\nИмя:");
            var name = Console.ReadLine();
            Console.WriteLine("\nФамилия:");
            var surname = Console.ReadLine();
            Console.WriteLine("\nВозраст:");
            var age = Console.ReadLine();
            Console.WriteLine("\nРост:");
            var height = Console.ReadLine();
            Console.WriteLine("\nВес:");
            var weight = Console.ReadLine();

            Console.WriteLine("\n" + name + " " + surname + ", " + age + " лет, " + height + "см, " + weight + "кг");
            Console.WriteLine("\n{0} {1}, {2} лет, {3}см, {4}кг", name, surname, age, height, weight);
            Console.WriteLine($"\n{name} {surname}, {age} лет, {height}см, {weight}кг");

            Console.ReadKey();
        }
    }
}
