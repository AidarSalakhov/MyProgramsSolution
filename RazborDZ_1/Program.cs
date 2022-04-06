using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazborDZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, result;
            Console.WriteLine("Введите первое число:");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            secondValue = double.Parse(Console.ReadLine());
            result = (firstValue + secondValue) / 2;
            Console.WriteLine("Среднее арифметическое = " + result);
            Console.ReadLine();

        }
    }
}
