using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST4
{
    internal class Program
    {
        static void Funky(in int a, in int b, out int c)
        {
            c = a+b;
        }

        static void Main(string[] args)
        {
            int a=5;
            int b=7;
            int c=10;

            Funky(in a, in b, out c);
            Console.WriteLine(c);

        }
    }
}
