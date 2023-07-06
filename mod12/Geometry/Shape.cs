using System;

namespace Geometry
{
    abstract class Shape
    {
        protected Fdata fd;

        public Shape(Fdata fd)
        {
            this.fd = fd;
        }
        public abstract double Area();
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public virtual void PrintInfo()
        {
            Console.Write(fd.type+":"+fd.x0+","+fd.y0+" color="+fd.color);
        }
    }
}
