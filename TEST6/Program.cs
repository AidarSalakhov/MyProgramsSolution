using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST6
{
    internal class Program
    {
        static int Sum(int a, int b, int c=0)
        {
            c = a + b;

            return c;
        }

        static void Main(string[] args)
        {
            ;
            Console.WriteLine(Sum(b: 25, a: 35));
        }
    }
}
