using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U58_Incapsulyaciya
{
    class Gun
{
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");

            isLoaded = true;

            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Не заряжено!");

                Reload();
            }

            Console.WriteLine("Пыщь-Пыщь");

            isLoaded= false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();

            gun.Shoot();
        }
    }
}
