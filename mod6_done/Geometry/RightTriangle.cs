using System;

namespace Geometry
{
    class RightTriangle : Shape
    {

        public double a
        {
            get { return fd.a; }
            set { fd.a = value; }
        }
        public double b
        {
            get { return fd.b; }
            set { fd.b = value; }
        }
        public double c
        {
            get { return Math.Sqrt(a*a + b*b); }
        }
        public RightTriangle(Fdata fd)
        {
            this.fd = fd;
            this.fd.type = Figures.RightTriangle;
        }

        public override double Area()
        {
            return 0.5*a*b;
        }
        public override void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            Console.WriteLine(" a=" + a + " b=" + b);
        }
    }
}
