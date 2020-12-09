using System;

namespace Andreev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от языка системы дробные числа с точкой не конвертируются из строк
            //поэтому точки вручную заменяем на запятые
            //.Replace(".", ",")

            Console.WriteLine("Введите x0: ");
            double x0 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите xk: ");
            double xk = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите dx: ");
            double dx = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите a: ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите b: ");
            double b = double.Parse(Console.ReadLine().Replace(".", ","));

            double chisl = 2.48 + Math.Cos(Math.Pow(a * a + b, 1 / 3.0) + Math.Sin(b));

            for (double x = x0; x <= xk; x += dx)
            {
                double A = chisl / (Math.Pow(Math.E, a / b) + x * x * x + Math.Pow(x, a));
                Console.WriteLine($"A({x:F2}) = {A:F2}");
            }
        }
    }
}