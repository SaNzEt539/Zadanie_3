using System;

namespace consoleTask_3_1
{
    class Program
    {
        static double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
        static double d(double a, double b, double c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a, b, c;
            Console.Write("Введите x1: ");
            try
            {
                x1 = Double.Parse(Console.ReadLine());
                Console.Write("Введите y1: ");
                y1 = Double.Parse(Console.ReadLine());
                Console.Write("Введите x2: ");
                x2 = Double.Parse(Console.ReadLine());
                Console.Write("Введите y2: ");
                y2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Длина отрезка: {0}\n", f(x1, y1, x2, y2));
                Console.Write("Введите a: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Double.Parse(Console.ReadLine());
                Console.Write("Введите c: ");
                c = Double.Parse(Console.ReadLine());
                Console.WriteLine("Периметр: {0}", d(a, b, c));
                
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
