using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40_NULL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "test";

            //str = "1";

            //Console.WriteLine(str ?? "Нет данных");


            /*
            string str = null;

            string result = str ?? string.Empty;

            Console.WriteLine("Количество символов в строке " + result.Length);

            */


            /*
            string str = null;

            string result = str ??= "xyi";

            Console.WriteLine("Количество символов в строке " + result);
            */

            string str = "test";

            str = null;

            Console.WriteLine(str ??= "Нет данных");

        }
    }
}
