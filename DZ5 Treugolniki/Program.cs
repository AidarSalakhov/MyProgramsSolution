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

            int linelength = 1;
            int linelength2 = 1;

            Console.WriteLine();
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j < linelength; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength++;
            }
            Console.WriteLine();



            Console.WriteLine();
            for (int k = 0; k <= 9; k++)
            {
                
                for (int l = 1; l < linelength; l++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength--;
            }
            Console.WriteLine();



            linelength = 10;



            Console.WriteLine();
            for (int h = 0; h <= 9; h++)
            {

                for (int g = 1; g < linelength; g++)
                {
                    Console.Write(" ");
                }
                linelength--;

                for (int f = 0; f < linelength2; f++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength2++;
            }
            Console.WriteLine();




            Console.WriteLine();
            for (int h = 0; h <= 9; h++)
            {

                for (int g = 1; g < linelength; g++)
                {
                    Console.Write(" ");
                }
                linelength--;

                for (int f = 0; f < linelength2; f++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                linelength2++;
            }
            Console.WriteLine();




            Console.ReadLine();


        }
    }
}
