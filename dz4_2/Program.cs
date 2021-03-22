// Андрей Никеенко
// 2.	Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
// в)**Добавьте обработку ситуации отсутствия файла на диске.

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace dz4_1
{
    /// <summary>
    /// Это статический класс
    /// </summary>
    public static class StaticClass
    {
        /// <summary>
        /// Считывание массива из файла
        /// </summary>
        /// <returns></returns>
        public static int[] ArrayFromFile()
        {
            try
            {
                int[] array = File.ReadAllText("Array.txt", Encoding.Default).Split(' ').Select(x => int.Parse(x)).ToArray();
                return array;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("\nФайла Array.txt нет.");
                return null;
            }
        }

        /// <summary>
        /// Нахождение пар чисел массива, в которых только одно число делится на 3
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns></returns>
        public static int Pairs(int[] array)
        {
            int count = 0;

            Console.WriteLine("\nПары чисел:");

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i] % 3 == 0) ^ (array[i - 1] % 3 == 0))
                {
                    Console.WriteLine("{0,6} {1,6}", array[i - 1], array[i]);
                    count += 1;
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new();

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10000, 10001);
                Console.WriteLine("{0,6}", array[i]);
            }

            int count = StaticClass.Pairs(array);

            Console.WriteLine($"\nВсего таких пар: {count}");

            if (StaticClass.ArrayFromFile() != null)
            {
                Console.WriteLine($"\nСчитанный из файла массив:");
                int[] array2 = StaticClass.ArrayFromFile();
                foreach (int s in array2)
                    Console.WriteLine(s);
            }
               
            Console.ReadKey();
        }
    }
}
