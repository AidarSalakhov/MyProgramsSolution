using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U55_Class
{
    enum Color
    {
        Black,
        White
    }

    class Person
    {
        public const string type = "Person";

        public int id = 0;
        public string name = "";
        public int? age = null;
        public string city = "";
        public Color color;

        public void Print()
        {
            Console.WriteLine($"{type} with id {id}, named {name}, with age {age}, living in {city}, color {color}");
        }
    }
}
