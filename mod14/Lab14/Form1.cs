using System;
using System.Numerics;
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
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            textBox2.Text = Solve(n);
        }
    }
}
