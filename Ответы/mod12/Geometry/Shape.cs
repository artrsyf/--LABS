using System;
using System.Text;

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

        public static bool operator == (Shape sh1, Shape sh2)
        {
            // Если оба null, или это один объект, return true.
            if (System.Object.ReferenceEquals(sh1, sh2))        return true;

            // Если один равен null, return false.
            if (((object)sh1 == null) || ((object)sh2 == null)) return false;

            // Если они разных типов, return false.
            if (sh1.GetType() != sh2.GetType()) return false;

            return sh1.fd.Equals(sh2.fd);
        }
        public static bool operator !=(Shape sh1, Shape sh2)
        {
            return !(sh1==sh2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return this==(Shape)obj;
        }
        public override int GetHashCode()
        {

            StringBuilder s = new StringBuilder();
            s.Append(fd.a).Append(fd.b).Append(fd.color).
                Append(fd.type).Append(fd.x0).Append(fd.y0);
            return s.ToString().GetHashCode();
        }
    }
}
