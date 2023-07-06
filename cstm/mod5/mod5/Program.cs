using System.Net.Http.Headers;
using static System.Math;

namespace Program
{
    class Starter
    {
        static void Main(string[] args)
        {
            Star simple_object = new Star();
            Test test_class = new Test();
            test_class.Ret = 87;
            Test another = new Test(34, 56) { a = 12, b = 87 };
            Console.WriteLine(another.a.ToString() + " " + another.b.ToString());
        }
    }
    class Star
    {
        public int a { get; private set; } = 7;
        static public int static_var { get; private set; }

        public Star()
        {
            a = 5;
        }

        static Star()
        {
            static_var = 12;
        }
    }
    class Test
    {
        public int a, b;
        public int ret;
        public int Ret { get; set; }
        public Test() { }
        public Test(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
    }
}