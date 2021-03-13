//Андрей Никеенко
//5.
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y)

using System;

namespace dz1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Андрей Никеенко, Москва";
            var x = (Console.WindowWidth / 2) - (text.Length / 2);
            var y = Console.WindowHeight / 2;

            Print(text, x, y);
            Console.ReadKey();
        }

        private static void Print(string text, int x, int y)
        {
            // вывод текста в указанных координатах
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
