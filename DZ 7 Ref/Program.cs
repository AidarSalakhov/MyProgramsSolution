using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7_Ref
{
    internal class Program
    {
        static int[] ResizeArray(ref int[] myArray, ref int arraySize)
        {
            int[] myArray2 = myArray;

            myArray = new int[arraySize];

            RandomizeArray(ref myArray);

            if (myArray2.Length < myArray.Length)
            {
                for (int i = 0; i < myArray2.Length; i++)
                    myArray[i] = myArray2[i];
            }
            else
            {
                for (int i = 0; i < myArray.Length; i++)
                    myArray[i] = myArray2[i];
            }

            return myArray;
        }

        static int[] RandomizeArray(ref int[] myArray)
        {
            myArray ??= new int[0];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(100);

            return myArray;
        }

        static void PrintlineArray(int[] myArray)
        {
            Console.Write("Ваш массив myArray[] = ");

            for (int i = 0; i < myArray.Length; i++)
                Console.Write("[" + myArray[i] + "]");

            Console.WriteLine();
        }


        static void Main(string[] args)
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

            Console.WriteLine("Введите размер вашего массива:");

            int arraySize;

            try
            {
                arraySize = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Введены неверные данные");
                return;
            }

            int[] myArray = new int[arraySize];

            RandomizeArray(ref myArray);

            PrintlineArray(myArray);

            Console.WriteLine("Измените размер вашего массива:");

            try
            {
                arraySize = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Введены неверные данные");
                return;
            }

            ResizeArray(ref myArray, ref arraySize);

            PrintlineArray(myArray);
        }
    }
}
