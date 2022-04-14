using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U29_Dvumernii_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
            {
                {2,45,12,51,51 },
                {6,7,8,3,1 },
                {1,2,3,4,5 },
                {1,3,4,5,6 }
            };

            //foreach (var item in myArray)
            //{
            //    Console.Write(item + " ");
            //}



            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
