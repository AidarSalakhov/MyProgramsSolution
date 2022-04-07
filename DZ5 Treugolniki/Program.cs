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

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < linelength; j++)
                {
                    Console.Write("#");
                    
                }
                Console.WriteLine();
                linelength++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
