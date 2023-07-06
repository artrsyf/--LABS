using System;
using System.Runtime.CompilerServices;
using System.Threading;
class Program
{
    static async Task Main(string[] args)
    {
        //Console.WriteLine("Program begins");
        //var result = CalcAsync();
        //Thread.Sleep(4000);
        //Console.WriteLine("Program ends");
        //await result;
        Publisher obj = new Publisher();
        Subscriber obj2 = new Subscriber();
        Subscriber obj3 = new Subscriber();
        void F(object a, string b) => Console.WriteLine(b + "for obj_func");
        obj.Ev_u += (obj2, some_string) => Console.WriteLine(some_string + "for obj2");
        obj.Ev_u += (obj3, some_string) => Console.WriteLine(some_string + "for obj3");
        obj.Ev_u += F;
        string my_message = "My message ";
        obj.Handler(my_message);

    }
    
    static void Calc(double param)
    {
        Thread.Sleep(5000);
        Console.WriteLine(param);
    }
    static async Task CalcAsync()
    {
        Console.WriteLine("Async method begins");
        await Task.Run(() => Calc(2.212));
        Console.WriteLine("Async method ends");
    }
}

class Publisher
{
    public delegate void Event(object sender, string Message);
    public event Event? Ev_u;
    virtual public void Handler(string message)
    {
        if (Ev_u != null) Ev_u.Invoke(this, message);
    }
}
class Subscriber
{

}
