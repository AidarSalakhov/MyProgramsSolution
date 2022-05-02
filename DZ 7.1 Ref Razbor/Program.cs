using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7._1_Ref_Razbor
{
    internal class Program
    {
        static void Resize<T>(ref T[] myArray, int sizeOf)
        {
            T[] myArray2 = new T[sizeOf];

            for (int i = 0; i < myArray2.Length && i < myArray.Length ; i++)
            {
                myArray2[i]=myArray[i];
            }

            myArray = myArray2;
        }

        static void Main(string[] args)
        {
            string[] myArray = { "petya", "petr", "petrovich"};

            int sizeOf = 4;

            Resize(ref myArray, sizeOf);
        }
    }
}
