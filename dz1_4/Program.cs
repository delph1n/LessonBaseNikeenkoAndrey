//Андрей Никеенко
//4.Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

using System;

namespace dz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = -1.5;
            var b = 8.9;
            Console.WriteLine($"{a}  {b}");

            // с использованием третьей
            var c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a}  {b}");
            Console.ReadKey();

            //без использования третьей (только для чисел)
            //a += b;
            //b = a - b;
            //a -= b;
            //Console.WriteLine($"{a}  {b}");
            //Console.ReadKey();
        }
    }
}
