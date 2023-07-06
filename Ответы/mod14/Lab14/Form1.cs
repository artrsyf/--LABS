using System;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Solve(int n)
        {
            BigInteger res = 1;
            for (int i = 1; i <= n; ++i) res *= i;
            return res.ToString();
        }
        async private Task<string> SolveAs(int n)
        {
            return await Task.Run(() => 
            {
                BigInteger res = 1;
                for (int i = 1; i <= n; ++i) res *= i;
                return res.ToString();
            });
        }
        async private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int n = int.Parse(textBox1.Text);
            string s = await SolveAs(n);
            textBox2.Text = s;
        }
    }
}
