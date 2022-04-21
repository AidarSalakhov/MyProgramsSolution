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
            int[] myArray = new int[2];
            int[] myArray2 = { 2, 5, 6, 7 };
            int[,] myArray3 = new int[2, 3];
            int[,] myArray4 =
            {
                {1,4,4 },
                {2,4,4 },
                {2,4,5 }
            };

            int[,,] myArray5 = new int[2, 4, 5];
            int[,,] myArray6 =
            {
               {
                 { 1, 4, 4},
                 {2,4,4},
                 {2,5,6},
               },
               {
                 {1,4,4},
                 {2,4,4},
                 {2,5,6},
               },
               {
                 {1,4,4},
                 {2,4,4},
                 {2,5,6},
               }
            };
         
        }
    }
}
