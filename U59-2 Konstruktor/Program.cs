using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U59_2_Konstruktor
{
    class Point
    {
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}, Y: {_y}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(6, 12);

            point.Print();
        }
    }
}
