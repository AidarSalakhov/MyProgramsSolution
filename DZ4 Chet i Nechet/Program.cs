using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Chet_i_Nechet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Программа, которая подсчитывает сумму и количество чётных и нечётных целых чисел, в том диапозоне который укажет пользователь
            */

            int chet = 0, nechet = 0, chetcount = 0, nechetcount = 0, firstValue, secondValue;

            try
            {
                Console.WriteLine("Введите первое число диапозона");
                firstValue = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число диапозона");
                secondValue = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Неверные данные! Введите целые числа");
                return;
            }

            if (secondValue < firstValue)
            {
                Console.WriteLine("Неверные данные! Введите числа от меньшего к большему");
                return;
            }
                                  
            while (firstValue <= secondValue)
            {
                if (firstValue % 2 == 0)
                {
                  chet = chet + firstValue;
                    chetcount++;
                    firstValue++;
                }
                else
                {
                   nechet = nechet + firstValue;
                    nechetcount++;
                    firstValue++;
                }
            }
            Console.WriteLine("Сумма чётных: " + chet);
            Console.WriteLine("Сумма нечётных: " + nechet);
            Console.WriteLine("Количество чётных: " + chetcount);
            Console.WriteLine("Количество нечётных: " + nechetcount);

        }
    }
}
