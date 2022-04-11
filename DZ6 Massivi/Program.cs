using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_Massivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Заполнить массив с клавиатуры
            //2. Вывести массив в обратном обратном;
            //3. Найти сумму чётных чисел в массиве
            //4. Найти наименьшее число в массиве

            int arrayLenght;
            int arrayEvenSumm = 0;
            int arrayMin;
                        
            try
            {
                Console.WriteLine("Введите размерность массива: ");
                arrayLenght = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Неверные данные. Введите целое число! ");
                return;
            }

            int[] myArray = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                try
                {
                    Console.WriteLine("Число массива " + (i + 1) + ":");
                    myArray[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверные данные. Введите целое число! ");
                    return;
                }
            }

            Console.WriteLine("\nМассив в порядке заполнения: ");
            for (int j = 0; j < arrayLenght; j++)
            {
                Console.Write( "[" + myArray[j] + "]"); 
            }

            Console.WriteLine("\nМассив в обратном порядке: ");
            for (int k = (arrayLenght-1); k >= 0; k--)
            {
                Console.Write("[" + myArray[k] + "]");
            }

            
            for (int l = 0; l < arrayLenght; l++)
            {
                if (myArray[l] % 2 == 0)
                {
                    arrayEvenSumm = arrayEvenSumm + myArray[l];
                }
            }
            Console.WriteLine("\nСумма чётных чисел в массиве: \n" + arrayEvenSumm);

            //Console.WriteLine("Минимальное число в массиве: \n" + myArray.Min());


            arrayMin = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[0] > myArray[i])
                {
                    arrayMin = myArray[i];
                }
            }
            Console.WriteLine("Минимальное число в массиве: \n" + arrayMin);
        }
    }
}
