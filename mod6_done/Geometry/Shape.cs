using System;


namespace Geometry
{
    abstract class Shape
    {
        abstract public double Area();
        virtual public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        abstract public void PrintInfo();
        protected Fdata fd;
    }
}
