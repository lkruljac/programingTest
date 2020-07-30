using System;

namespace Infineon
{
    class Program
    {
        static void Main(string[] args)
        {
            //existing objects
            Rectangle rectangle = new Rectangle(1, 2, 3, 4, 5, 6, 7, 8);
            Triangle triangle = new Triangle(1, 2, 3, 4, 5, 6);
            //using in way described in interface
            new RectangleAdapter(rectangle).PrintPoints();
            new TriangleAdapter(triangle).PrintPoints();
        }
    }
    class Point
    {
        public int x;
        public int y;
        public String ToString()
        {
            return "(" + this.x + "," + this.y + ")";
        }
    }
    interface GeomtricFigure
    {
        void PrintPoints()
        {
        }
    }
    class RectangleAdapter : GeomtricFigure
    {
        Rectangle rectangle;
        public RectangleAdapter(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
        public void PrintPoints()
        {
            this.rectangle.PrintRectangle();
        }
    }
    class TriangleAdapter : GeomtricFigure
    {
        Triangle triangle;
        public TriangleAdapter(Triangle triangle)
        {
            this.triangle = triangle;
        }
        public void PrintPoints()
        {
            this.triangle.PrintTriangle();
        }
    }
    class Rectangle
    {
        Point A = new Point();
        Point B = new Point();
        Point C = new Point();
        Point D = new Point();
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.A.x = x1;
            this.A.y = y1;
            this.B.x = x2;
            this.B.y = y2;
            this.C.x = x3;
            this.C.y = y3;
            this.D.x = x4;
            this.D.y = y4;
        }
        public void PrintRectangle()
        {
            Console.Write("\nA:" + this.A.ToString());
            Console.Write("B:" + this.B.ToString());
            Console.Write("C:" + this.C.ToString());
            Console.Write("D:" + this.D.ToString());
        }
    }
    class Triangle
    {
        Point A = new Point();
        Point B = new Point();
        Point C = new Point();
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.A.x = x1;
            this.A.y = y1;
            this.B.x = x2;
            this.B.y = y2;
            this.C.x = x3;
            this.C.y = y3;
        }
        public void PrintTriangle()
        {
            Console.Write("\nA:" + this.A.ToString());
            Console.Write("B:" + this.B.ToString());
            Console.Write("C:" + this.C.ToString());
        }
    }
}
