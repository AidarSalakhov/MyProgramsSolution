using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_5
{
    internal class Program
    {
        static void Foo(int a, params object[]myArray)
        {
            foreach (var item in myArray)
            {
                Console.WriteLine("Тип объекта {0}, значение {1}", item.GetType(), item);
            }
        }

        static void Main(string[] args)
        {
            Foo(10, 10, "xyi", '#', true);
        }
    }
}
