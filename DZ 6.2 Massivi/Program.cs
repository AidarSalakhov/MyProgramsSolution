using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6._2_Massivi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[,] myArray = new int[3,3];

            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(" Y: " + i + " X: " + j);
            //        myArray[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.Write(myArray[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}




            Random random = new Random();

            int[,] myArray = new int[10, 5];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
