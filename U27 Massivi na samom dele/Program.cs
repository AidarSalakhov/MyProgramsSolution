using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U27_Massivi_na_samom_dele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 1 };
            Console.WriteLine(myArray.Max());
            Console.WriteLine(myArray.Sum());
            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());

            int[] result = myArray.Distinct().ToArray(); //уникальные элементы массива в новый массив

            int[] result2 = myArray.OrderBy(i => i).ToArray(); //сортировка массива по возрастанию

            int[] result3 = myArray.OrderByDescending(i => i).ToArray(); //сортировка массива по возрастанию

            Array.Sort(myArray); //сортировка массива

            Array.Find(myArray, i => i < 70); //самый первый элемент массива который меньше 70

            Array.FindLast(myArray, i => i < 70); //самый первый с конца элемент массива который меньше 70

            int[] result4 = Array.FindAll(myArray, i => i < 70); //возвращает массив элементы которого меньше 70

            int result5 = Array.FindIndex(myArray, i => i == 77); //найти индекс элемента 77

            int result6 = Array.FindLastIndex(myArray, i => i == 111); //если несклько одинаковых элементов массива, то можно из конца в начало

            Array.Reverse(myArray); //расположить элементы массива в обратном порядке

            int[] result7 = myArray.Where(i => i < 70).ToArray(); // все элементы массива, которые меньше 70, используя Linq

            int result8 = myArray.Where(i => i < 70).First(); // первое число, которое меньше 70, с помощью Linq

            int result9 = myArray.Where(i => i < 0).FirstOrDefault(); //возвращает дефолтное число для своего типа данных

            Console.WriteLine();


        }
    }
}
