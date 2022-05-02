using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ0_ulivt.ru8082
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 , 4, 5, 6};

            int a = Array.IndexOf(myArray, 7);
            Console.WriteLine(a);
        }
    }
}
