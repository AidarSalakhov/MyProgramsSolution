﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6._3_Zubchatie_massivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[4];
            myArray[2] = new int[6];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
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
