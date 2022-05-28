using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U55_Class
{
    class Person
    {
        public const string type = "Person";

        public static int id;
        public static string name;
        public static int age;
        public static int city;

        public static void Print()
        {
            Console.WriteLine($"{type} with id {id}, named {name}, with {age}, living in {city}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
