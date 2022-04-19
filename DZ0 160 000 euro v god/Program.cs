using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ0_160_000_euro_v_god
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                [-1,2,5,8], k=7 [2,5]
                [-3,-1,0,2,6], k=6 [0,6]
                [2,4,5], k=8 []
                [-2,-1,1,2], k=0 [-2,2]
            В заданных массивах найти 2 числа, которые в сумме дают k и вывести на экран эти числа.
            */

            Console.WriteLine("Введите длину одномерного массива:");
            int length = int.Parse(Console.ReadLine());

            int[] myArray = new int[length];
            int[] resultArray = new int[2];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Введите элемент массива " + i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваш k = " + k + ", Ваш массив: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("[" + myArray[i] + "]");
            }
            Console.WriteLine();

            Console.WriteLine("Элементы массива, сумма которых равна k:");

            resultArray = Sum(myArray, k);

            for (int i = 0; i < 2; i++)
            {
                Console.Write("[" + resultArray[i] + "]");
            }
            Console.WriteLine();
        }

        public static int[] Sum(int[] myArray, int k)
        {
            int[] resultArray = new int[2];

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        continue;
                    }
                    else if (myArray[i] + myArray[j] == k)
                    {
                        resultArray[0] = myArray[i];
                        resultArray[1] = myArray[j];
                        return resultArray;
                    }
                }
            }
            return resultArray;
        }
    }
}
