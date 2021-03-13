using System;

namespace Lesson2
{
    class Program
    {
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        static void Main(string[] args)
        {
            //Console.Write("Введите день недели: ");
            //var day = Console.ReadLine();
            //var title = String.Empty;

            //switch (day)
            //{
            //    case "1": title = "пн"; break;
            //    case "2": title = "вт"; break;
            //    case "3": title = "ср"; break;
            //    case "4": title = "чт"; break;
            //    case "5": title = "пт"; break;
            //    case "6": title = "сб"; break;
            //    case "7": title = "вс"; break;
            //    default: title = "такого дня нет"; break;
            //}

            //Console.WriteLine(title);

            int f = 0;
            int s = 0;
            int t = 0;

            Random random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                var res = random.Next(1, 4);

                if (res == 1) f++;
                if (res == 2) s++;
                if (res == 3) t++;
            }

            Console.WriteLine($"f {f}  s {s}  t {t}");


            int a = 100;
            int b = 200;
            int max = a > b ? a : b;
            Console.WriteLine(max);


            Days day = Days.Mon;
            Console.WriteLine(day);


            Console.ReadKey();
        }
        static void Loop(int a, int b)
        {
            Console.Write("{0,4} ", a);
            if (a < b) Loop(a + 1, b);
        }
    }
}
