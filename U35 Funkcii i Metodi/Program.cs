using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U35_Funkcii_i_Metodi
{
    internal class Program
    {
        static int Sum(int value_1, int value_2) 
        {
            
            return value_1 + value_2;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = 5;
            Console.WriteLine(Sum(a, b));
        }
    }
}
