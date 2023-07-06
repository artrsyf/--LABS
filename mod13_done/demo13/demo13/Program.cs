using System;
using System.Threading;

namespace demo13
{
    class Program
    {
        //delegate int Mydel(int a, int b);

        static int Solve(int a, int b)
        {

            Thread.Sleep(3000);
            return a + b;
        }
        ////static void SolveRes(IAsyncResult ar)
        ////{
        ////    Mydel del =(Mydel) ar.AsyncState;
        ////    int n = del.EndInvoke(ar);
        ////    Console.WriteLine(n);
        ////}
        static void Main(string[] args)
        {
            int n = 0;
            n = Solve(2, 5);
            Console.WriteLine(n);

            //Mydel del = Solve;
            //IAsyncResult ar=del.BeginInvoke(2, 7, null, null);
            //n=del.EndInvoke(ar);
            //Console.WriteLine(n);

            ////Mydel del = Solve;
            ////del.BeginInvoke(2, 7, new AsyncCallback(SolveRes), del);

            Console.WriteLine("end of Main...");
        }
    }
}
