using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class HePT3An : Form
    {
        public HePT3An()
        {
            InitializeComponent();
        }
        string temp = "a1";
        private void Dip(string s)
        {
            if (temp == "a1")
            {
                a1.Text = a1.Text + s;

            }
            else if (temp == "b1")
            {
                b1.Text = b1.Text + s;
            }
            else if (temp == "c1")
            {
                c1.Text = c1.Text + s;
            }
            else if (temp == "a2")
            {
                a2.Text = a2.Text + s;
            }
            else if (temp == "b2")
            {
                b2.Text = b2.Text + s;
            }
            else if (temp == "c2")
            {
                c2.Text = c2.Text + s;
            }
            else if (temp == "a3")
            {
                a3.Text = a3.Text + s;
            }
            else if (temp == "b3")
            {
                b3.Text = b3.Text + s;
            }
            else if (temp == "c3")
            {
                c3.Text = c3.Text + s;
            }
            else if (temp == "d1")
            {
                d1.Text = d1.Text + s;
            }
            else if (temp == "d2")
            {
                d2.Text = d2.Text + s;
            }
            else if (temp == "d3")
            {
                d3.Text = d3.Text + s;
            }
        }

        #region Solution
        private void He3()
        {
            #region initial var
            var ta1 = Compute(a1.Text);
            var tb1 = Compute(b1.Text);
            var tc1 = Compute(c1.Text);
            var ta2 = Compute(a2.Text);
            var tb2 = Compute(b2.Text);
            var tc2 = Compute(c2.Text);
            var ta3 = Compute(a3.Text);
            var tb3 = Compute(b3.Text);
            var tc3 = Compute(c3.Text);
            var td1 = Compute(d1.Text);
            var td2 = Compute(d2.Text);
            var td3 = Compute(d3.Text);
            double A1 = double.Parse(ta1.ToString());
            double A2 = double.Parse(ta2.ToString());
            double A3 = double.Parse(ta3.ToString());
            double B1 = double.Parse(tb1.ToString());
            double B2 = double.Parse(tb2.ToString());
            double B3 = double.Parse(tb3.ToString());
            double C1 = double.Parse(tc1.ToString());
            double C2 = double.Parse(tc2.ToString());
            double C3 = double.Parse(tc3.ToString());
            double D1 = double.Parse(td1.ToString());
            double D2 = double.Parse(td2.ToString());
            double D3 = double.Parse(td3.ToString());
            #endregion
            double[,] A =
            {
                {A1, B1, C1, D1 },
                {A2, B2, C2, D2 },
                {A3, B3, C3, D3 },
            };
            #region Gauss method
            int n = (int)Math.Sqrt(A.Length);
            double[] X = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                if (A[i, i] == 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (A[j, i] != 0)
                        {
                            for (int k = 0; k < n + 1; k++)
                            {
                                double temp = A[i, k];
                                A[i, k] = A[j, k];
                                A[j, k] = temp;
                            }
                            break;
                        }
                    }
                }

                for (int j = i + 1; j < n; j++)
                {
                    double temp = A[j, i] / A[i, i];
                    for (int k = 0; k <= n; k++)
                        A[j, k] = A[j, k] - temp * A[i, k];
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                X[i] = A[i, n];

                for (int j = i + 1; j < n; j++)
                    X[i] = X[i] - A[i, j] * X[j];

                X[i] = X[i] / A[i, i];
            }
            #endregion
            result.Text = "X = " + X[0].ToString() + ";Y = " + X[1].ToString() + ";Z = " + X[2].ToString(); 
        }
        public object Compute(string txt)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(txt, "");
            return v;
        }
        private void zero_Click(object sender, EventArgs e)
        {
            Dip("0");
        }
        private void three_Click(object sender, EventArgs e)
        {
            Dip("3");
        }
        private void two_Click(object sender, EventArgs e)
        {
            Dip("2");
        }
        private void one_Click(object sender, EventArgs e)
        {
            Dip("1");
        }
        private void four_Click(object sender, EventArgs e)
        {
            Dip("4");
        }
        private void five_Click(object sender, EventArgs e)
        {
            Dip("5");
        }
        private void six_Click(object sender, EventArgs e)
        {
            Dip("6");
        }
        private void seven_Click(object sender, EventArgs e)
        {
            Dip("7");
        }
        private void eight_Click(object sender, EventArgs e)
        {
            Dip("8");
        }
        private void nine_Click(object sender, EventArgs e)
        {
            Dip("9");
        }
        private void add_Click(object sender, EventArgs e)
        {
            Dip("+");
        }
        private void sub_Click(object sender, EventArgs e)
        {
            Dip("-");
        }
        private void mul_Click(object sender, EventArgs e)
        {
            Dip("*");
        }
        private void div_Click(object sender, EventArgs e)
        {
            Dip("/");
        }
        private void equal_Click(object sender, EventArgs e)
        {
            if (temp == "a1")
            {
                this.SelectNextControl(a1, true, true, true, true);
                temp = "b1";
            }
            else if (temp == "b1")
            {
                this.SelectNextControl(b1, true, true, true, true);
                temp = "c1";
            }
            else if (temp == "c1")
            {
                this.SelectNextControl(c1, true, true, true, true);
                temp = "d1";
            }
            else if (temp == "d1")
            {
                this.SelectNextControl(d1, true, true, true, true);
                temp = "a2";
            }
            else if (temp == "a2")
            {
                this.SelectNextControl(a2, true, true, true, true);
                temp = "b2";
            }
            else if (temp == "b2")
            {
                this.SelectNextControl(b2, true, true, true, true);
                temp = "c2";
            }
            else if (temp == "c2")
            {
                this.SelectNextControl(c2, true, true, true, true);
                temp = "d2";
            }
            else if (temp == "d2")
            {
                this.SelectNextControl(d2, true, true, true, true);
                temp = "a3";
            }
            else if (temp == "a3")
            {
                this.SelectNextControl(a3, true, true, true, true);
                temp = "b3";
            }
            else if (temp == "b3")
            {
                this.SelectNextControl(b3, true, true, true, true);
                temp = "c3";
            }
            else if (temp == "c3")
            {
                this.SelectNextControl(c3, true, true, true, true);
                temp = "d3";
            }
            else if (temp == "d3")
            {
                this.SelectNextControl(b1, false, true, true, true);
                temp = "a1";
                He3();
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Dip(".");
        }
        #endregion
        #region Jump
        private void cơBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Basic();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void bâc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new PTBac2();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void bâc3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new PTBac3();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void ânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HePT2An();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void sôPhưcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CMPLX();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        #endregion
        #region KeyUp
        private void a1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(a1, true, true, true, true);
                result.Text = "B1 = ";
            }
        }
        private void b1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(b1, true, true, true, true);
                result.Text = "C1 = ";
            }
        }
        private void c1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(c1, true, true, true, true);
                result.Text = "D1 = ";
            }
        }
        private void d1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(d1, true, true, true, true);
                result.Text = "A2 = ";
            }
        }
        private void a2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(a2, true, true, true, true);
                result.Text = "B2 = ";
            }
        }
        private void b2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(b2, true, true, true, true);
                result.Text = "C2 = ";
            }
        }
        private void c2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(c2, true, true, true, true);
                result.Text = "D2 = ";
            }
        }
        private void d2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(d2, true, true, true, true);
                result.Text = "A3 = ";
            }
        }
        private void a3_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(a3, true, true, true, true);
                result.Text = "B3 = ";
            }
        }
        private void b3_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(b3, true, true, true, true);
                result.Text = "C3 = ";
            }
        }
        private void c3_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(c3, true, true, true, true);
                result.Text = "D3 = ";
            }
        }
        private void d3_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(b1, false, true, true, true);
                result.Text = "A1 = ";
            }
        }
        #endregion
        private void a1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
