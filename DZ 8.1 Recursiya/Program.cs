﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8._1_Recursiya
{
    internal class Program
    {

        // 1. Реализовать вывод массива с помощью рекурсии. 
        // 2. Найти сумму элементов массива с помощью рекурсии.
        // 3. Найти сумму цифр числа с помощью рекурсии. 561 = 12


        static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        static void PrintArrayWithRecursion(int[] myArray, int i = 0)
        {

            Console.WriteLine(myArray[i]);

            i++;

            if (i >= myArray.Length)
            {
                return;
            }

            PrintArrayWithRecursion(myArray, i);
        }

        //static int SumArrayValueWithRecursion(int[] myArray,  int sum = 0, int i = 0)
        //{
        //    sum += myArray[i];

        //    i++;

        //    if (i >= myArray.Length)
        //    {
        //        return sum;
        //    }

        //    SumArrayValueWithRecursion(myArray, sum, i);

        //    return sum;
        //}


        static void SumArrayValueWithRecursion(int[] myArray, int sum = 0, int i = 0)
        {
            sum += myArray[i];

            i++;

            if (i >= myArray.Length)
            {
                Console.WriteLine(sum);
                return;
            }

            SumArrayValueWithRecursion(myArray, sum, i);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };

            
            SumArrayValueWithRecursion(myArray);

        }
    }
}
