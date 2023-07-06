using System;
using System.Numerics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async Task<string> SolveAsync(int n)
        {
            return await Task.Run(() => Solve(n));
        }
        private string Solve(int n)
        {
            BigInteger res = 1;
            for (int i = 1; i <= n; ++i) res *= i;
            return res.ToString();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            string result = await SolveAsync(n);
            textBox2.Text = result; // Threads are the same
        }
    }
}
