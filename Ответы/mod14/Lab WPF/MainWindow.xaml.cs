using System;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows;

namespace Lab13
{
    public partial class MainWindow : Window
    {
        public MainWindow()
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
        delegate string Mydel(int n);
        private void SolveEnd(IAsyncResult ar)
        {
            Mydel del = (Mydel)ar.AsyncState;
            String s = del.EndInvoke(ar);
            textBlock.Text = s;
        }
        private void doClick(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
            int n = int.Parse(textBox.Text);
            textBlock.Text = Solve(n);

            //Mydel del = Solve;
            //del.BeginInvoke(n, SolveEnd, del);
        }
        //async private void doClick(object sender, RoutedEventArgs e)
        //{
        //    textBlock.Text = "";
        //    int n = int.Parse(textBox.Text);
        //    textBlock.Text = await SolveAs(n);
        //}
    }
}
