using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazborDZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double firstValue, secondValue, thirdValue, resultSum, resultMult;
            Console.WriteLine("Введите первое число:");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            thirdValue = double.Parse(Console.ReadLine());
            resultSum = firstValue + secondValue + thirdValue;
            resultMult = firstValue * secondValue * thirdValue;
            Console.WriteLine("Сумма = " + resultSum);
            Console.WriteLine("Произведение = " + resultMult);
            Console.ReadLine();
        }
    }
}
