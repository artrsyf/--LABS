using System;
using System.Drawing;
using System.Linq;

namespace Geometry
{
     abstract class Figure
    {
        public abstract void PrintInfo();
    }
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            Circle circle = new Circle(_radius:14, _color: Color.Brown, 10, 32);
            circle.Move(3, 2);
            circle.PrintInfo();
            Console.WriteLine(circle.Area());


            object[] data = {rect, rt, circle};

            Console.WriteLine("Inner data array: ");
            foreach(object obj in data)
            {
                Figure a = (Figure)obj;
                a.PrintInfo();
            }
        }

        public static void Print(object[] data)
        {

        }
    }
}
