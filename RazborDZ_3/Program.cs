using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazborDZ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double USDtoRUB = 99.0, USD;     
            Console.WriteLine("Введите количество долларов: ");
            USD = double.Parse(Console.ReadLine());
            Console.WriteLine(USD + " долларов = " + USD * USDtoRUB + " рублей");
            Console.ReadLine();

        }
    }
}
