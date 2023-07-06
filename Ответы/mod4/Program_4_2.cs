using System.Text;

namespace System
{
    class Program
    {
        public static string IntToBinary(int num)
        {
            StringBuilder sb = new StringBuilder(35,48);

            for (int i = 0; i < 32; i++)
            {
                sb.Insert(0,((num & 1) == 1) ? 1 : 0);
                num >>= 1;
                if (i == 7 || i == 15 || i == 23) sb.Insert(0,' ');
            }
            return sb.ToString();
        }
        static void Main(string []args)
        {
            Console.WriteLine(IntToBinary(7));
        }
    }
}
