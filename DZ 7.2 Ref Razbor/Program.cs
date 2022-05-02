using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7._2_Ref_Razbor
{
    internal class Program
    {
        static void ValueToAnywhere(ref int[] myArray, int value, int index)
        {
            int[] myArray2 = new int[myArray.Length + 1];

            myArray2[index] = value;

            for (int i = 0; i < index; i++)
                myArray2[i] = myArray[i];

            for (int i = index; i < myArray.Length; i++)
                myArray2[i + 1] = myArray[i];

            myArray = myArray2;
        }

        static void ValueToStart(ref int[] myArray, int value)
        {
            ValueToAnywhere(ref myArray, value, 0);
        }

        static void ValueToEnd(ref int[] myArray, int value)
        {
            ValueToAnywhere(ref myArray, value, myArray.Length);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };

            ValueToEnd(ref myArray, -5);
        }
    }
}
