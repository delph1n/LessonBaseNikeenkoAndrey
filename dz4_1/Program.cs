// Андрей Никеенко
// 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.

using System;

namespace dz4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new();
            int count = 0;

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10000, 10001);
                Console.WriteLine("{0,6}", array[i]);
            }

            Console.WriteLine("\nПары чисел:");

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i] % 3 == 0) ^ (array[i - 1] % 3 == 0))
                {
                    Console.WriteLine("{0,6} {1,6}", array[i - 1], array[i]);
                    count += 1;
                }
                
            }

            Console.WriteLine($"\nВсего таких пар: {count}");

            Console.ReadKey();
        }
    }
}
