using System;

namespace Infineon
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle1 = new RealTriangle(1, 2, 3, 4, 5, 6);
            Triangle triangle2 = null;


            //In case without using null object
            if (triangle1 != null)
            {
                triangle1.PrintTriangle();

            }
            if (triangle2 != null)
            {
                triangle2.PrintTriangle();
            }

            
            // with using null object
            Triangle triangle3 = new RealTriangle(1, 2, 3, 4, 5, 6);
            Triangle triangle4 = new NullTriangle();

            triangle3.PrintTriangle();
            triangle4.PrintTriangle();



        }
    }

    class Point
    {
        public int x;
        public int y;

        public String ToString()
        {
            String returnValue = "(" + this.x + "," + this.y + ")";
            return returnValue;
        }
    }


    abstract class Triangle
    {
        public abstract void PrintTriangle();
 
    }

    class RealTriangle : Triangle
    {
        Point A = new Point();
        Point B = new Point();
        Point C = new Point();

        public RealTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.A.x = x1;
            this.A.y = y1;

            this.B.x = x2;
            this.B.y = y2;

            this.C.x = x3;
            this.C.y = y3;
        }

        public override void PrintTriangle()
        {
            Console.Write("\nA:" + this.A.ToString());
            Console.Write("B:" + this.B.ToString());
            Console.Write("C:" + this.C.ToString());
        }
    }

    class NullTriangle : Triangle
    {
        public NullTriangle()
        {

        }

        public override void PrintTriangle()
        {

        }
    }
}
