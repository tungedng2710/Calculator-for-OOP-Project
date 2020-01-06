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
    public partial class PTBac2 : Form
    {
        private string temp = "A";
        public PTBac2()
        {
            InitializeComponent();
        }
        #region Jump
        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Basic();
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
        private void bâc3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new PTBac3();
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
        }
        #region Button Click

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
        // .
        private void button20_Click(object sender, EventArgs e)
        {
            Dip(".");

        }
        private void bpi_Click(object sender, EventArgs e)
        {
            Dip("3.141592654");
        }
        private void div_Click(object sender, EventArgs e)
        {
            Dip("/");
        }
        private void mul_Click(object sender, EventArgs e)
        {
            Dip("*");
        }
        private void add_Click(object sender, EventArgs e)
        {
            Dip("+");
        }
        private void sub_Click(object sender, EventArgs e)
        {
            Dip("-");
        }
        private void result_TextChanged(object sender, EventArgs e)
        {

        }
        //AC
        private void button4_Click(object sender, EventArgs e)
        {
            result.Clear();
            A.Clear();
            B.Clear();
            C.Clear();
            B.SelectNextControl(B, false, true, true, true);
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void bsin_Click(object sender, EventArgs e)
        {

        }
        private void bcos_Click(object sender, EventArgs e)
        {

        }
        private void btan_Click(object sender, EventArgs e)
        {

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
                Solve2();
        }
        #endregion

        //Move to next Box by pressing Enter
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
                this.SelectNextControl(B, false, true, true, true);
                temp = "A";
            }
        }
        //Solution
        private void Solve2()
        {
            var ta = Compute(A.Text);
            var tb = Compute(B.Text);
            var tc = Compute(C.Text);
            double a = double.Parse(ta.ToString());
            double b = double.Parse(tb.ToString());
            double c = double.Parse(tc.ToString());
            double x1, x2;
            double d = b * b - 4 * a * c;
            if (a == 0)
            {
                result.Text = "Math Error";
            }
            else
            {
                if (d == 0)
                {
                    x1 = (-b) / (2 * a);
                    result.Text = "x = " + x1.ToString();
                }
                else if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    result.Text = "x1 = " + Math.Round(x1, 5).ToString() + "; x2 = " + Math.Round(x2, 5).ToString();
                }
                else
                {
                    string imx1 = Math.Round((-b / (2 * a)), 5).ToString() + "+" + (Math.Round(Math.Sqrt((Math.Abs(d)) / (2 * a)), 5).ToString()) + "i";
                    string imx2 = Math.Round((-b / (2 * a)), 5).ToString() + "-" + (Math.Round(Math.Sqrt((Math.Abs(d)) / (2 * a)), 5).ToString()) + "i";
                    result.Text = "x1 = " + imx1 + ";    x2 = " + imx2;
                }
            }
        }
        
        private void PTBac2_Load(object sender, EventArgs e)
        {

        }
        //Display on result textBox
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
            result.Text = "C = " + C.Text;
        }
        //press Enter to solve
        private void C_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13: equal.PerformClick(); break; //13 = ENTER
            }
        }
        private void PTBac2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)46: equal.PerformClick(); break; //13 = ENTER
            }
        }

        public object Compute(string txt)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(txt, "");
            return v;
        }
    }
}
