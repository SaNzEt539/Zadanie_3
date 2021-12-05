using System;

namespace consoleTask_3_2_
{
    class Program
    {
        public static void Func(double a, double b, double h)
        {
            for (double x = a; x <= b; x += h)
            {
                if ((x - 1) < 1)
                {
                    Console.WriteLine("f({0}) = 1", x);
                }
                else if ((x - 1) == 1)
                {
                    Console.WriteLine("f({0}) = 0", x);
                }
                else
                {
                    Console.WriteLine("f({0}) = -1", x);
                }
            }
        }
        public static void Func(double x, out double y)
        {
            if ((x - 1) < 1)
            {
                y = 1;
            }
            else if ((x - 1) == 1)
            {
                y = 0;
            }
            else
            {
                y = -1;
            }
        }
        static void Main(string[] args)
        {
            double a, b, h;
            try 
            {
                Console.Write("Введите a: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Double.Parse(Console.ReadLine());
                Console.Write("Введите h: ");
                h = Double.Parse(Console.ReadLine());
                Func(a, b, h);

                Console.WriteLine("Часть 3");                
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    Func(x, out y);
                    Console.Write("{0} ", y);
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }
    }
}
