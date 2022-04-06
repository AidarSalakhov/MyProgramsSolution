using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_U13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, проверяющую число, введенное с клавиатуры на чётность.

            /*

            bool isInfected = true;

            if (isInfected)
            {
                Console.WriteLine("Персонаж инфецирован!");
            }
            else
            {
                Console.WriteLine("Персонаж здоров!");
            }
            */

            int a;
            bool b;
            Console.WriteLine("Проверка на чётность. Введите число: ");
            a = int.Parse(Console.ReadLine());

            b = (a % 2) == 0;

            if (b)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }


        }
    }
}
