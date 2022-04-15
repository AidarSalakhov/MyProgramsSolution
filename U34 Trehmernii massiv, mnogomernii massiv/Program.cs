using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U34_Trehmernii_massiv__mnogomernii_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,,] myArray =

            {
                {
                    {2, 3, 5 },
                    {69, 7, 4 }
                },
                {
                    {2, 3, 5 },
                    {69, 7, 4 }
                },
                {
                    {2, 3, 5 },
                    {69, 7, 4 }
                }
            };
            */

            /*
            Random random = new Random();

            int[,,] myArray = new int[4,3,5];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page #: " + (i + 1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + " "); 
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("========");
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
                Console.WriteLine("Book#: " + (i + 1));
                Console.WriteLine();
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Page#: " + (j + 1));
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
                Console.WriteLine("========");
            }
            */

            //Texmernii zubchatii massiv


            Random random = new Random();

            int[][][] myArray = new int[random.Next(3, 6)][][];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[random.Next(2, 6)][];

                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = new int[random.Next(2, 6)];

                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        myArray[i][j][k] = random.Next(100);
                    }
                }
            }

            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Page #: " + (i + 1));

                for (int j = 0; j < myArray[i].Length; j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}
