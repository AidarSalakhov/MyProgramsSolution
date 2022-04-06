using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            double number1, number2, result;
            char operation;

            Console.WriteLine("Enter first number");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation type");
            operation = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            number2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Result of operation = " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Result of operation = " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Result of operation = " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Result of operation = " + result);
                    break;
                case ':':
                    result = number1 / number2;
                    Console.WriteLine("Result of operation = " + result);
                    break;
                default:
                    break;
            */


            while (true)
            {   
                Console.Clear();
                double number1, number2, result;
                char operation;

                try
                {
                    number1 = double.Parse(Console.ReadLine());
                    operation = char.Parse(Console.ReadLine());
                    number2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибочные данные!");
                    Console.ReadLine();
                    continue;
                }

                switch (operation)
                {
                    case '+':
                        result = number1 + number2;
                        Console.WriteLine("=");
                        Console.WriteLine(result);
                        break;
                    case '-':
                        result = number1 - number2;
                        Console.WriteLine("=");
                        Console.WriteLine(result);
                        break;
                    case '*':
                        result = number1 * number2;
                        Console.WriteLine("=");
                        Console.WriteLine(result);
                        break;
                    case '/':
                        if (number2 == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                        }
                        else
                        {
                            result = number1 / number2;
                            Console.WriteLine("=");
                            Console.WriteLine(result);  
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибочная операция!");
                        break;
                }
                Console.ReadLine();
            }

            /*

            double number1, number2, result;
            char operation;

            number1 = double.Parse(Console.ReadLine());

            operation = char.Parse(Console.ReadLine());

            number2 = double.Parse(Console.ReadLine());


            if (operation == '+')
            {
                result = number1 + number2;
                Console.WriteLine("=");
                Console.WriteLine(result);
            }
            else if (operation == '-')
            {
                result = number1 - number2;
                Console.WriteLine("=");
                Console.WriteLine(result);
            }
            else if (operation == '*')
            {
                result = number1 * number2;
                Console.WriteLine("=");
                Console.WriteLine(result);
            }
            else if (operation == '/')
            {
                result = number1 / number2;
                Console.WriteLine("=");
                Console.WriteLine(result);
            }
            else if (operation == ':')
            {
                result = number1 / number2;
                Console.WriteLine("=");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Неверные символы!");
            }


            */

        }

    }
}

