using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int x = 4;

            for (int i = 0; i < 5; i++)
            {
                a += x;
            }

            Console.WriteLine(a);

        }
    }
}
