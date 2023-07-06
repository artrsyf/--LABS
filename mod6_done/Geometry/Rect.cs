using System;

namespace Geometry
{
    class Rect : Shape
    {

        public double a {
            get { return fd.a; }
            set { fd.a = value;}
        }
        public double b
        {
            get { return fd.b; }
            set { fd.b = value; }
        }
        public Rect(Fdata fd)
        {
            this.fd = fd;
            this.fd.type = Figures.Rect;
        }

        public override double Area()
        {
            return a * b; 
        }
        public override void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            Console.WriteLine(" a="+a+" b="+b);
        }
    }
}
