using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST7
{
    internal class Program
    {

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int a = int.MaxValue;

            int b = 1;

            int c = 0;


            try
            {
                    c = checked(a + b);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка"); ;
            }

            Console.WriteLine(c);
        }
    }
}
