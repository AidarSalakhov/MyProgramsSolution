using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40_Dva_Voprosa_NULL
{
    internal class Program
    {
        static int[] Arr()
        {
            int[] myArray = null;

            return myArray;
        }
            

        static void Main(string[] args)
        {
            /*
            string str = "test";

            str = "1";

            Console.WriteLine(str ?? "Нет данных");
            */


            /*
            string str = null;

            string result = str ?? string.Empty;

            Console.WriteLine("Количество символов в строке " + result.Length);
            */


            /*
            string str = null;

            string result = str;

            Console.WriteLine(result ??= "Нет данных");
            */


            int [] myArray = Arr();

            myArray ??= new int[0];

            Console.WriteLine(myArray.Length);

        }
    }
}
