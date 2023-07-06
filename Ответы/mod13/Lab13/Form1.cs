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

        private delegate string Mydel(int n); 
        private void SolveEnd(IAsyncResult ar)
        {
            Mydel del = (Mydel)ar.AsyncState;
            string s=del.EndInvoke(ar);
            textBox2.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            //синхронный вызов
            //textBox2.Text = Solve(n);

            //асинхронный вызов Solve
            Mydel del = Solve;
            del.BeginInvoke(n, SolveEnd, del);
        }
    }
}
