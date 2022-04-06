using System;
using System.Globalization;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
          
            };
            string a, b;
            double x, z, result;
            Console.WriteLine("Программа вычисления среднего арифметического. Введите первое число: ");
            a = Console.ReadLine();
            x = Convert.ToDouble(a, numberFormatInfo);
            Console.WriteLine("Введите второе число: ");
            b = Console.ReadLine();
            z = Convert.ToDouble (b, numberFormatInfo);
            result = (z + x) / 2;
            Console.WriteLine("Результат: " + result);
            Console.ReadLine();
           
        }
    }
}
