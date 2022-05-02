using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string a = Console.ReadLine();
            
            switch (a)
            {
                case "Aidar":

                    Console.WriteLine("Your name is Aidar");
                        break;
                case "Vlad":
                    Console.WriteLine("Your name is Vlad");
                    break;
                default:
                    Console.WriteLine("Your name is not or Vlad or Aidar");
                        break;
            }


        }
    }
}
