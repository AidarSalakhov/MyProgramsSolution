using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U59_Konstruktor
{
    class Gun
    {
        public Gun(bool isLoaded)
        {
            //this.isLoaded = isLoaded;
            _isLoaded = isLoaded;
        }

        private bool _isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");

            _isLoaded = true;

            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Не заряжено!");

                Reload();
            }

            Console.WriteLine("Пыщь-Пыщь");

            _isLoaded = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: true);

            gun.Shoot();
        }
    }
}
