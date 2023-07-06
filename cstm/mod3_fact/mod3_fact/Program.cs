using System.IO.Pipes;
using System.Linq.Expressions;

class Solution
{
    static void Main(String[] args)
    {
        int simple_number = 6;
        Console.WriteLine("Cycle: " + fact_cycle(simple_number));
        Console.WriteLine("Rec: " + fact_rec(simple_number));
    }
    static int fact_cycle(int expr)
    {
        int ans = 1;
        for (int i = 1; i <= expr; i++)
        {
            ans *= i;
        }
        return ans;
    }
    static int fact_rec(int expr)
    {
        if (expr == 1) return 1;
        return expr * fact_rec(expr - 1);
    }
}