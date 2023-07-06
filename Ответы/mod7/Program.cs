using System.Reflection;
using System.IO;

namespace System
{
  class Program
    {
        ~Program()
        {
            File.AppendAllText("test.txt","destruction ");
        }

        static void Main(string[] args)
        {
            string s = string.Empty;

            Type t1=s.GetType();
            Type t2=Type.GetType("System.String");

            //singleton
            if (object.ReferenceEquals(t1, t2)) Console.WriteLine("=");

            MethodInfo []mi = t1.GetMethods();
            foreach (MethodInfo m in mi)
                Console.WriteLine(m);

            //class Convert
            bool flag=Convert.ToBoolean(3);
            Console.WriteLine(flag);

            //Destruction
            Program p1 = new Program();
            Program p2 = new Program();
        }
    }
}
