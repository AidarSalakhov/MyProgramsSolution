using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5_Treugolniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Нарисовать треугольники (стороны 10х10, диагональ корень 200) , только с помощью вложенных циклов (без IF ELSE)

            int linelength = 0;
            int linelength2 = 10;

            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= linelength; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength++;
            }
            Console.WriteLine();


            Console.WriteLine();
            for (int k = 1; k <= 10; k++)
            {
                for (int l = 0; l < linelength2; l++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength2--;
            }
            Console.WriteLine();


            Console.WriteLine();
            for (int h = 1; h <= 10; h++)
            {
                for (int g = 2; g <= linelength; g++)
                {
                    Console.Write(" ");
                }
                linelength--;

                for (int f = 0; f <= linelength2; f++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength2++;
            }
            Console.WriteLine();


            Console.WriteLine();
            for (int d = 1; d <= 10; d++)
            {
                for (int s = 2; s <= linelength; s++)
                {
                    Console.Write(" ");
                }
                linelength++;

                for (int a = 0; a <= linelength2; a++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength2--;
            }
            Console.WriteLine();
             


            Console.ReadLine();


        }
    }
}
