using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U62_Static
{
    class MyClass
    {
        //public int a;

        public static int b;

        public void SetB(int b)
        {
            MyClass.b = b;
        }

        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //MyClass myClass1 = new MyClass();
            //myClass1.a = 44;

            //MyClass myClass2 = new MyClass();
            //myClass2.a = 22;

            //MyClass.b = 6;

            MyClass myClass1 = new MyClass();
            myClass1.SetB(1);

            MyClass MyClass2 = new MyClass();
            MyClass2.PrintB();

        }
    }
}
