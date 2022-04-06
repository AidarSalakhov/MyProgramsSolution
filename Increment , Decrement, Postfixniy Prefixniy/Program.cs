using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment___Decrement__Postfixniy_Prefixniy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            a = a++ + a++ * a++;
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
