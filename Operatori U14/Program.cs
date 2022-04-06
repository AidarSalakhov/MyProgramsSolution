using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori_U14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bool isInfected = true;

            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров!");
            }
            else
            {
                Console.WriteLine("Персонаж инфецирован!");
            }
            */

            /*
            int fanSpeed = 0;
            bool isHighTemperature = false;
            bool hasNoCooling = fanSpeed <= 0;

            */

            /*
            bool isHighTemperature = true;
            bool hasNoCooling = true;

            if (isHighTemperature & hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процессора!");
            }

            */

            int a=5,b=3,c;
            c = a | b;
            Console.WriteLine(c);
        }
    }
}
