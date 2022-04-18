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

            string result = symbol;

            for (int i = 0; i < value - 1; i++)
            {
                 result = result + symbol;
            }
            
            return result;
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


            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Введите количество сиволов: ");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintLine(symbol, value));


        }
    }
}
