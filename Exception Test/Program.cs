﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                if (name == null || name.Length < 2)
                {
                    throw new Exception("Длина имени меньше 2 символов");
                }
                else
                {
                    Console.WriteLine($"Ваше имя: {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}
