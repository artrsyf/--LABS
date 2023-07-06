using System;
using System.Threading;

namespace mod13_async
{
    class Program
    {
        public delegate int SolveAsync(double d);
        public static int Solve(double d)
        {
            Thread.Sleep(5000);
            return 121;
        }
        public static void EndSolve(IAsyncResult ar)
        {
            SolveAsync Del = (SolveAsync)ar.AsyncState;
            int function_result = Del.EndInvoke(ar);
            Console.WriteLine(function_result);
        }
        static void Main(string[] args)
        {
            SolveAsync Del = Solve;
            // Got crushed
            //Console.WriteLine("Starting with BeginInvoke");
            //var result = Del.BeginInvoke(2, EndSolve, Del);
            //Console.WriteLine("Another action");
            //var ret = Del.EndInvoke(result); // taking return
            //

            //
            Console.WriteLine("Starting with Task.Run");
            var workTask = Task.Run(() => Del.Invoke(2));
            var followUpTask = workTask.ContinueWith(t => Thread.Sleep(3000)); // ?
            Console.WriteLine("Waiting on work...");
            var ret = await workTask; // ...
            await followUpTask; // ...
            //
        }
    }
}
