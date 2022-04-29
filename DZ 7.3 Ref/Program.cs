using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7._3_Ref
{
    internal class Program
    {
        /*
           Все ДЗ с использованием ref

           1. Написать метод Resize изменяющий количество элементов
           массива (метод должен иметь возможность увеличить или
           уменьшить количество элементов массива).

           2. Написать методы для добавления элемента в начало массива, в
           конец массива и по указанному индексу.

           3. Написать методы для удаления первого элемента массива,
           последнего элемента массива и элемента по указанному индексу.

           */
        static void PrintlineArray(int[] myArray)
        {
            Console.Write("Ваш массив myArray[] = ");

            for (int i = 0; i < myArray.Length; i++)
                Console.Write("[" + myArray[i] + "]");

            Console.WriteLine();
        }

        static int[] ValueDeleteFromEnd(ref int[] myArray)
        {
            int a = myArray?.Length ?? 0;

            if (a == 0)
                myArray = null;

            myArray ??= new int[1];

            int[] myArray2 = myArray;

            myArray = new int[myArray.Length - 1];

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = myArray2[i];

            return myArray;
        }

        static int[] ValueDeleteFromStart(ref int[] myArray)
        {
            int a = myArray?.Length ?? 0;

            if (a == 0)
                myArray = null;

            myArray ??= new int[1];

            int[] myArray2 = myArray;

            myArray = new int[myArray.Length - 1];

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = myArray2[i + 1];

            return myArray;
        }

        static int[] ValueDeleteFromAnywhere(ref int[] myArray, int index)
        {
            int a = myArray?.Length ?? 0;

            if (a == 0)
                myArray = null;

            myArray ??= new int[1];

            int[] myArray2 = myArray;

            myArray = new int[myArray.Length - 1];

            for (int i = 0, j = 0; i < myArray.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                myArray[i] = myArray2[j];
            }
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };

            int arraySize = myArray?.Length ?? 0;

            int index = 2;

            ValueDeleteFromEnd(ref myArray);

            ValueDeleteFromStart(ref myArray);

            ValueDeleteFromAnywhere(ref myArray, index);

            PrintlineArray(myArray);
        }
    }
}
