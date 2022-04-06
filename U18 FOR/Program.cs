using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0, j = 5; i <= 5; i++, j--)
            //{

            //    Console.WriteLine("i: " + i);
            //    Console.WriteLine("j: " + j);

            //}


            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i == 10)
            //    {
            //        break;
            //    }
            //}


            //for (int i = 0; i < 100; i++)
            //{
            //    string msg = Console.ReadLine();

            //    if (msg == "exit")
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}


            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
