using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5_Razbor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heigh = 5;

            for (int i = 0; i < heigh; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int i = 0; i < heigh; i++)
            {
                for (int j = heigh; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int i = 0; i < heigh; i++)
            {
                for (int j = heigh; j > i; j--)
                {
                    Console.Write(" ");
                }


                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();


            }
            Console.WriteLine();

            //for (int i = 0; i < heigh; i++)
            //{
            //    Console.SetCursorPosition(heigh - i, i + 1);
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();

            //}

            for (int i = 0; i < heigh; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = heigh; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
            Console.WriteLine();


        }
    }
}
