﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}
