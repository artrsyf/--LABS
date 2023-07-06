class Program
{
    static void Main(string[] args)
    {
        Box[] arr = { new Box(1, 2), new Box(4, 5), new Box(7, 5) };
        foreach (Box box in arr) 
        {
            Console.WriteLine(box);
        }
    }
}

public interface IWork
{
    void paint();
}

class MyClass : IWork
{
    public void paint()
    {
        Console.WriteLine("qq");
    }
}

class Another
{
    private int a, b;
    public Another()
    {
        a = 1;
        b = 2;
        Console.WriteLine("Default construct");
    }
    public Another(int _a, int _b)
    {
        a = _a;
        b = _b;
        Console.WriteLine("Defined construct");
    }
    ~Another()
    {
        System.Diagnostics.Trace.WriteLine("First's finalizer is called.");
    }
}

public interface IMath
{
    void AddOne();
}
class Star : IMath
{
    public int num;
    public void AddOne() { ++num; }
}

interface A
{

}

struct B : A
{

}

class Box
{
    public int a, b;
    public Box(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public override string ToString()
    {
        return this.a.ToString() + " " + this.b.ToString();
    }
}