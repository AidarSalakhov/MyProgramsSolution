using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6._4_Mnogomernie_massivi__mnogomernie_zubchatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Вывести на экран трёхмерный массив рандомных чисел
            // 2. Вывести на экран четырёхмерыный массив рандомных чисел
            // 3. Вывести на экран двухмерный зубчатый массив
            // 4. Вывести на экран зубчатый массив рандомной размерности с рандомными числами

            /*
            Random random = new Random();

            int[,,] myArray = new int[3,3,3];


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i,j,k] = random.Next(100);
                    }
                }

            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i,j,k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */



            /*
            Random random = new Random();

            int[,,,] myArray = new int[3, 3, 3, 3];


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < myArray.GetLength(3); l++)
                        {
                            myArray[i, j, k, l] = random.Next(100);
                        }
                    }
                }

            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Book #" + (i +1) + "=======");
                Console.WriteLine();
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Page #" + (j+1));
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < myArray.GetLength(3); l++)
                        {
                            Console.Write(myArray[i, j, k, l] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            */


            Random random = new Random();

            int[][] myArray = new int[3][];
            myArray[0] = new int[random.Next(2, 8)];
            myArray[1] = new int[random.Next(2, 8)];
            myArray[2] = new int[random.Next(2, 8)];


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
