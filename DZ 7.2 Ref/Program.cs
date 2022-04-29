using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7._2_Ref
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

        static int[] ValueToEnd(ref int[] myArray, ref int newValue)
        {
            int[] myArray2 = myArray;

            myArray = new int[myArray.Length + 1];

            for (int i = 0; i < myArray2.Length; i++)
                myArray[i] = myArray2[i];

            myArray[myArray2.Length] = newValue;

            return myArray;
        }  
        
        static int[] ValueToStart(ref int[] myArray, ref int newValue)
        {
            int[] myArray2 = myArray;

            myArray = new int[myArray.Length + 1];

            for (int i = 0; i < myArray2.Length; i++)
                myArray[i+1] = myArray2[i];

            myArray[0] = newValue;

            return myArray;
        }

        static int[] ValueToAnywhere(ref int[] myArray, int newValue, int index)
        {
            int[] myArray2 = myArray;

            myArray = new int[myArray.Length + 1];

            for (int i = 0, j = 0; i < myArray.Length; i++, j++)
            {
                if (i == index)
                {
                    myArray[i] = newValue;
                    j--;
                    continue;
                }
                myArray[i] = myArray2[j];
            }
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6};

            int arraySize = myArray.Length;

            int newValue = 555;

            int index = 6;

            ValueToEnd(ref myArray, ref newValue);

            ValueToStart(ref myArray, ref newValue);

            ValueToAnywhere(ref myArray, newValue, index);

            PrintlineArray(myArray);

        }
    }
}
