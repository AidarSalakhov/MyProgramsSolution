using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U32_Zapolnenie_dvumernogo_massiva_s_klavi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] myArray = new int[2, 3];

            //Random random = new Random();


            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        myArray[i, j] = random.Next(100);
            //    }

            //}


            //for (int y = 0; y < myArray.GetLength(0); y++)
            //{
            //    for (int x = 0; x < myArray.GetLength(1); x++)
            //    {
            //        Console.Write(myArray[y, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}






            //int[,] myArray = new int[2, 3];

            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Y: " + i + " X: " + j);
            //        myArray[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}

            //Console.WriteLine();

            //for (int y = 0; y < myArray.GetLength(0); y++)
            //{
            //    for (int x = 0; x < myArray.GetLength(1); x++)
            //    {
            //        Console.Write(myArray[y, x] + "\t");
            //    }
            //    Console.WriteLine();

            //}






            string[,] myArray = new string[2, 3];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + " X: " + j);
                    myArray[i, j] = Console.ReadLine();
                }

            }

            Console.WriteLine();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();

            }

        }
    }
}       
