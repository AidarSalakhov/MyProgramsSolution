using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7._3_Ref_Razbor
{
    internal class Program
    {
        static void DeleteFromAnywhere(ref int []myArray, int index)
        {
            int [] myArray2 = new int[myArray.Length-1];

            for (int i = 0; i < index; i++)
                myArray2[i] = myArray[i];

            for (int i = index; i < myArray2.Length; i++)
                myArray2[i] = myArray[i+1];

            myArray = myArray2;
        }

        static void DeleteFromStart(ref int[]myArray)
        {
            DeleteFromAnywhere(ref myArray, 0);
        }

        static void DeleteFromEnd(ref int[]myArray)
        {
            DeleteFromAnywhere(ref myArray, myArray.Length-1);
        }

        static void Main(string[] args)
        {
            int []myArray = {1,2,3,4,5};

            DeleteFromEnd(ref myArray);
        }
    }
}
