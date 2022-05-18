using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8._1_Recursiya
{
    internal class Program
    {

        // 1. Реализовать вывод массива с помощью рекурсии. 
        // 2. Найти сумму элементов массива с помощью рекурсии.
        // 3. Найти сумму цифр числа с помощью рекурсии. 561 = 12


        static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        static void PrintArrayWithRecursion(int[] myArray, int i = 0)
        {
            Console.WriteLine(myArray[i]);

            i++;

            if (i >= myArray.Length)
            {
                return;
            }

            PrintArrayWithRecursion(myArray, i);
        }

        static void SumArrayValueWithRecursion(int[] myArray, int sum = 0, int i = 0)
        {
            sum += myArray[i];

            i++;

            if (i >= myArray.Length)
            {
                Console.WriteLine(sum);
                return;
            }

            SumArrayValueWithRecursion(myArray, sum, i);
        }

        static int SumArrayWithRecursion(int[] myArray, int sum = 0, int i = 0)
        {
            if (i >= myArray.Length)
            {
                return sum;
            }
            else
            {
                sum += myArray[i];

                i++;

                return SumArrayWithRecursion(myArray, sum, i);
            }
        }

        static void SumElementsOfValue(int value, int i = 0, int z = 0)
        {
            string newvalue = Convert.ToString(value);

            char x = newvalue[i];

            int y = x - '0';

            z += y;

            i++;

            if (i >= newvalue.Length)
            {
                Console.WriteLine(z);
                return;
            }

            SumElementsOfValue(value, i , z);

        }

        static int SumElementsOfValueIfElse(int value, int sum = 0, int i = 0)
        {
            string newvalue = Convert.ToString(value);

            if (i >= newvalue.Length)
            {
                return sum;
            }
            else
            {
                char x = newvalue[i];

                int y = x - '0';

                sum += y;

                i++;

                return SumElementsOfValueIfElse(value, sum, i);
            }
        }

        static int SumSimpleCode(int[] myArray,int i = 0)
        {
            if (i >= myArray.Length)
                return 0;
                    
            return myArray[i] + SumSimpleCode(myArray, i + 1);
        }

        static int SumValueSimpleCode(int value, int i = 0)
        {
            string newvalue = Convert.ToString(value);

            if (i >= newvalue.Length)
                return 0;

            return Convert.ToInt32(newvalue[i] - '0') + SumValueSimpleCode(value, i + 1);
        }

        static int SumValueSimpleCode2(int value)
        {
            if (value < 10)
                return value;

            return (value % 10) + SumValueSimpleCode2(value / 10);
        }

        static int SumValueWithLoop(int value)
        {
            int sum = 0;

            int value2 = 0;

            do
            {
                value2 = value % 10;

                sum = value2 + (value / 10);

            } while ((value / 10) > 10);
            
            return sum;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };

            Console.WriteLine(SumValueWithLoop(455));
        }
    }
}
