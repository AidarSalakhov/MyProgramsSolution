using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U22_Vlozhennie_cikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("Cikl 1 Iteraciya " + i);

            //    for (int j = 1; j <= 2; j++)
            //    {
            //        Console.WriteLine("\tCikl 2 Iteraciya " + j);

            //        for (int k = 0; k <= 2; k++)
            //        {
            //            Console.WriteLine("\t\tCikl 3 Iteraciya " + k);
            //        }
            //    }
            //}
            //Console.ReadLine();


            Console.WriteLine("Vvedite visoty pryamougolnika");
            int heigh = int.Parse(Console.ReadLine());

            Console.WriteLine("Vvedite shirinu pryamougolnika");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < heigh; j++)
            {

                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
