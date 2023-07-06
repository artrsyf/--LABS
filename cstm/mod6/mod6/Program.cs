using System.ComponentModel;
using System.Net.Mail;

class Star
{
    public int a;
    public Star()
    {
        a = 1;
    }
    public Star(int _a)
    {
        a = _a;
    }
}

class Star3D : Star
{
    public int b;
    public Star3D() : base()
    {
        b = 2;
    }
    public Star3D(int _a, int _b) : base(_a)
    {
        b = _b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Star star1 = new Star3D();
        Star3D s3d = (Star3D)star1;
        Console.WriteLine(s3d.b);

        Star star2 = new Star();
        Star3D s3d2 = (Star3D)star2;
        Console.WriteLine(s3d2.a);
    }
}