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
    public partial class PTBac3 : Form
    {
        public PTBac3()
        {
            InitializeComponent();
        }
        public object Compute(string txt)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(txt, "");
            return v;
        }
        string temp = "A";
        #region Button Click
        private void Dip(string s)
        {
            if (temp == "A")
            {
                A.Text = A.Text + s;

            }
            else if (temp == "B")
            {
                B.Text = B.Text + s;
            }
            else if (temp == "C")
            {
                C.Text = C.Text + s;
            }
            else if(temp == "D")
            {
                D.Text = D.Text + s;
            }
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
        private void equal_Click(object sender, EventArgs e)
        {
            if (temp == "A")
            {
                this.SelectNextControl(A, true, true, true, true);
                temp = "B";
                //result.Text = A.Text;
            }
            else if (temp == "B")
            {
                //result.Text = B.Text;
                this.SelectNextControl(B, true, true, true, true);
                temp = "C";
            }
            else if (temp == "C")
            {
                this.SelectNextControl(C, true, true, true, true);
                temp = "D";
            }
            else if (temp == "D")
            {
                Solve3();
            }
        }
        private void sub_Click(object sender, EventArgs e)
        {
            Dip("-");
        }
        private void add_Click(object sender, EventArgs e)
        {
            Dip("+");
        }
        private void mul_Click(object sender, EventArgs e)
        {
            Dip("*");
        }
        private void div_Click(object sender, EventArgs e)
        {
            Dip("/");
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Dip(".");
        }
        //AC
        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "A = ";
            A.Clear();
            B.Clear();
            C.Clear();
            D.Clear();
            B.SelectNextControl(B, false, true, true, true);
        }
        #endregion
        //Solve
        private void Solve3()
        {
            var ta = Compute(A.Text);
            var tb = Compute(B.Text);
            var tc = Compute(C.Text);
            var td = Compute(D.Text);
            double a = double.Parse(ta.ToString());
            double b = double.Parse(tb.ToString());
            double c = double.Parse(tc.ToString());
            double d = double.Parse(td.ToString());
            double k, delta;
            double x1, x2, x3;

            delta = b * b - 3 * a * c;
            if (delta > 0)
            {
                k = (9 * a * b * c - 2 * b * b * b - 27 * a * a * delta) / (2 * Math.Sqrt(Math.Pow(Math.Sqrt(delta), 3)));
                if (Math.Abs(k) <= 1)
                {
                    x1 = (2 * Math.Sqrt(delta) * Math.Cos((Math.Acos(k)) / 3) - b) / (3 * a);
                    x2 = (2 * Math.Sqrt(delta) * Math.Cos((Math.Acos(k) - 2 * Math.PI) / 3) - b) / (3 * a);
                    x3 = (2 * Math.Sqrt(delta) * Math.Cos((Math.Acos(k) + 2 * Math.PI) / 3) - b) / (3 * a);
                    x1 = Math.Round(x1, 3);
                    x2 = Math.Round(x2, 3);
                    x3 = Math.Round(x3, 3);
                    result.Text = "X1 = " + x1.ToString() + ";X2 = " + x2.ToString() + ";X3 =" + x2.ToString();
                }
                else
                {
                    double t1 = (Math.Sqrt(delta) * Math.Abs(k)) / (3 * a * k);
                    double t2 = Math.Pow(Math.Abs(k) + Math.Sqrt(k * k - 1), 1 / 3) + Math.Pow(Math.Abs(k) - Math.Sqrt(k * k - 1), 1 / 3);
                    x1 = t1 * t2 - b / (3 * a);
                    result.Text = "X = " + x1.ToString();
                }
            }
            else if (delta == 0)
            {
                if ((b*b*b -27*a*a* delta) == 0)
                {
                    x1 = (-b) / (3 * a);
                }
                else
                {
                    x1 = (-b + Math.Pow(b * b * b - 27 * a * a * delta, 1 / 3)) / (3 * a);
                }
                result.Text = "X = " + x1.ToString();
            }
            else
            {
                k = (9 * a * b * c - 2 * b * b * b - 27 * a * a * delta) / (2 * Math.Sqrt(Math.Pow(Math.Sqrt(delta), 3)));
                double t1 = Math.Sqrt(Math.Abs(delta)) / (3 * a);
                double t2 = Math.Pow(Math.Abs(k) + Math.Sqrt(k * k - 1), 1 / 3) + Math.Pow(Math.Abs(k) - Math.Sqrt(k * k - 1), 1 / 3);
                x1 = t1 * t2 - b / (3 * a);
                result.Text = "X = " + x1.ToString();

            }
        }
        #region Event
        private void A_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(A, true, true, true, true);
                temp = "B";
                result.Text = "B = ";
            }
        }
        private void B_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(B, true, true, true, true);
                temp = "C";
                result.Text = "C = ";
            }
        }
        private void C_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(C, true, true, true, true);
                temp = "D";
                result.Text = "D = ";
            }
        }
        private void D_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(B, false, true, true, true);
            }
        }
        private void A_TextChanged(object sender, EventArgs e)
        {
            result.Text = "A = " + A.Text;
        }
        private void B_TextChanged(object sender, EventArgs e)
        {
            result.Text = "B = " + B.Text;
        }
        private void C_TextChanged(object sender, EventArgs e)
        {
            result.Text = "B = " + C.Text;
        }
        private void D_TextChanged(object sender, EventArgs e)
        {
            result.Text = "D = " + D.Text;
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void ânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HePT2An();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void D_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13: equal.PerformClick(); break;
            }
        }
        #endregion

        
    }
}
