using System;
using System.Runtime.Remoting.Messaging;

namespace Geometry
{
    enum Figures { Romb, Rect, RightTriangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }


    class Program
    {
        static float calc_square(Figures type, float side_len, float angle = 0)
        {
            switch (type)
            {
                case Figures.Circle:
                    return (float)Math.PI * side_len * side_len;
                    break;
                case Figures.Rect:
                    return side_len * side_len;
                    break;
                case Figures.Romb:
                    return side_len * side_len * (float)Math.Sin(angle);
                    break;
                case Figures.RightTriangle:
                    return side_len * side_len * 1 / 4;
                    break;
                default:
                    return 0;
                    break;
            }

        }
        static long GetFactorialCycle(int a)
        {
            int res = 1;
            for (int i = 1; i <= a; i++)
                res *= i;

            return res;
        }

        static long GetFactorialRec(int a)
        {
            if (a < 1) { return 1; }
            else { return a* GetFactorialRec(a - 1); }

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(GetFactorialRec(4));
            Console.ReadKey();
        }
    }
}
