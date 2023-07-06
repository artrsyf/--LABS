class Publisher
{
    // Delegate defines type of subscribers (functions)
    public delegate void MyEvent(object sender, string message);
    // Nullable event definition
    public event MyEvent? Ev1;
    public virtual void Handler() // Starter/Event handler
    {
        // If subscriber count doesn't equal 0 =>
        // make a distribution for all subscribers
        if (Ev1 != null) Ev1.Invoke(this, "some string");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Publisher pub = new Publisher(); // Publisher definition
        Methods obj = new Methods(); // Subscription definition
        pub.Ev1 += (obj, s) => Console.WriteLine("First " + s); // Subscription
        pub.Handler(); // Beginning of sending
        //Methods.Del a = obj.Method1;
        //Func<int, int> b = x => { Console.WriteLine(x * x); return x * x; };
        //a += obj.Method2;
        //a.Invoke("qq");
        //b.Invoke(21);
    
    }
}

class Methods { 
    public void Method1 (string message)
    {
        Console.WriteLine("First message: " + message);
    }
    public void Method2(string message)
    {
        Console.WriteLine("Second message: " + message);
    }
    public delegate void Del(string message);
}
