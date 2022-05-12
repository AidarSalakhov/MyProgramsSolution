using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U49_Recursiya
{
    internal class Program
    {
        static void Foo()
        {
            Console.WriteLine("Lol");

            Foo();
        }

        static void Main(string[] args)
        {
            Foo();

        }
    }
}
