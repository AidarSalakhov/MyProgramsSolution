using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7_Funkcii_i_Metodi
{
    internal class Program
    {   
        static string PrintLine(string symbol, int value)
        {

            string result = "";

            for (int i = 0; i < value; i++)
            {
                 result = result + symbol;
            }
            
            return result;
        }

        public static int IndexOf(int[] myArray, int value)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            /*   1. Написать метод который выводит на экран строку.
             *   Символы из которых состоит строка и их количество вводятся пользователем.
             *   (например человек вводит "!" и "5" - вывестись должно !!!!!)
             * 
             *   2. Написать метод для поиска индекса элемента массива (тип элементов в массиве - int),
             *   метод должен вернуть индекс первого найденного элемента (если он будет найден).
             * 
             */

            /*
            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Введите количество сиволов: ");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintLine(symbol, value));
            */

            Random random = new Random();

            int[] myArray = { random.Next(100), random.Next(100), random.Next(100), random.Next(100), random.Next(100)};

            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nИндекс какого числа этого массива вам интересен?");

            int value = int.Parse(Console.ReadLine());


            if (IndexOf(myArray, value) == -1)
            {
                Console.WriteLine("Ошибка! Такого элемента массива не существует.");
            }
            else
            {
                Console.WriteLine("Индекс вашего элемента: " + IndexOf(myArray, value));
            }
        }

        
    }
}
