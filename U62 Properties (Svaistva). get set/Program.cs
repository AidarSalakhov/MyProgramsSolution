using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U62_Properties__Svaistva_.get_set
{
    class Point
    {
        public int x;

        public void SetX(int x)
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }

            if (x > 10)
            {
                this.x = 10;
                return;
            }

            this.x = x;

        }

        public int GetX()
        {
            return x;
        }


        private int y;

        public int Y
        {
            get
            {
                return y;
            }

            set 
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }

                if (value > 5)
                {
                    y = 5;
                    return;
                }

                y = value;
            }
        }

        //private int z;

        //public int Z
        //{
        //    get { return z; }
        //    set { z = value; }
        //}



        //public int Z { get; set; }


        //public int Z { get; private set; }


        public int Z { get; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            //point.SetX(14);

            //Console.WriteLine(point.GetX());

            point.Y = 111;

            Console.WriteLine(point.Y);


            Console.WriteLine(point.Z);

        }
    }
}
