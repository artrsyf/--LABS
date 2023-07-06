using System;
using System.Drawing;
using static System.Math;

namespace Geometry
{
    class Circle : Figure
    {
        private struct CircleFdata
        {
            public float radius { get; set; }
            public Color color { get; set; }
            public float x { get; set; }
            public float y { get; set; }
            public const string type = "Circle";
        }
        CircleFdata fd;
        public Circle()
        {
            fd.radius = 5;
            fd.color = Color.Black;
            fd.x = 0;
            fd.y = 0;
        }
        public Circle(float _radius, Color _color, float _x, float _y)
        {
            fd.radius = _radius;
            fd.color = _color;
            fd.x = _x;
            fd.y = _y;
        }
        public float Area()
        {
            return (float)(PI * Pow(fd.radius, 2));
        }
        public void Move(int dx, int dy)
        {
            fd.x += dx;
            fd.y += dy;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Figure type is: " + CircleFdata.type);
            Console.WriteLine("Radius = " +
                fd.radius + "; Color = " + fd.color +
                "; X = " + fd.x + "; Y = " + fd.y);
        }
    }
}
