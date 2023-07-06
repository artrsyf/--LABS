using System.Numerics;

namespace System
{
   class Program
   {
        public static bool factorial(int n, out long fac)
        {
            fac = 1;

            try {
                for (int i = 1; i <= n; ++i)
                    checked {
                        fac *= i;
                    }
                return true;
            }
            catch (OverflowException) { return false; }
        }

        public static BigInteger bigFactorial(int n)
        {
            BigInteger res = 1;
            for (int i = 1; i <= n; res*=i, ++i);    
            return res;
        }

        static void Main(string[] args)
        {
            long fac;

            if (factorial(5,out fac))  Console.WriteLine(fac);
            Console.WriteLine(bigFactorial(2016));
        }
    }
}
