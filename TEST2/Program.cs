using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST2
{
    internal class Program
    {
        static ref int Foo(int [] numbers)
        {
            return ref numbers[0];
        }


        static void Main(string[] args)
        {
        int[] arr = { 1, 2, 3 };
        ref int b = ref Foo(arr);
        b = -5;
        }

    }
}
