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
    public partial class HePT2An : Form
    {
        string temp = "A1";
        public object Compute(string txt)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(txt, "");
            return v;
        }
        public HePT2An()
        {
            InitializeComponent();
        }
        #region Button click
        private void Dip(string s)
        {
            if (temp == "A1")
            {
                a1.Text = a1.Text + s;

            }
            else if (temp == "B1")
            {
                b1.Text = b1.Text + s;
            }
            else if (temp == "C1")
            {
                c1.Text = c1.Text + s;
            }
            else if (temp == "A2")
            {
                a2.Text = a2.Text + s;
            }
            else if (temp == "B2")
            {
                b2.Text = b2.Text + s;
            }
            else if (temp == "C2")
            {
                c2.Text = c2.Text + s;
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
        //AC
        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "A1 = ";
            a1.Clear();
            a2.Clear();
            b1.Clear();
            b2.Clear();
            c1.Clear();
            c2.Clear();
            this.Select(true, true);
        }
        private void equal_Click(object sender, EventArgs e)
        {
            if (temp == "A1")
            {
                this.SelectNextControl(a1, true, true, true, true);
                temp = "B1";
            }
            else if (temp == "B1")
            {
                this.SelectNextControl(b1, true, true, true, true);
                temp = "C1";
            }
            else if(temp == "C1")
            {
                this.SelectNextControl(c1, true, true, true, true);
                temp = "A2";
            }
            else if (temp == "A2")
            {
                this.SelectNextControl(a2, true, true, true, true);
                temp = "B2";
            }
            else if (temp == "B2")
            {
                this.SelectNextControl(b2, true, true, true, true);
                temp = "C2";
            }
            else if (temp == "C2")
            {
                HePT();
            }
        }
        #endregion
        #region Event
        //solution
        private void HePT()
        {
            #region var
            var ta1 = Compute(a1.Text);
            var ta2 = Compute(a2.Text);
            var tb1 = Compute(b1.Text);
            var tb2 = Compute(b2.Text);
            var tc1 = Compute(c1.Text);
            var tc2 = Compute(c2.Text);
            double aone = double.Parse(ta1.ToString());
            double bone = double.Parse(tb1.ToString());
            double cone = double.Parse(tc1.ToString());
            double atwo = double.Parse(ta2.ToString());
            double btwo = double.Parse(tb2.ToString());
            double ctwo = double.Parse(tc2.ToString());
            
            double[,] A =
            {
                {aone, bone, cone },
                {atwo, btwo, ctwo },
            };
            double D = aone * btwo - atwo * bone;
            double Dx = cone * btwo - bone * ctwo;
            double Dy = aone * ctwo - atwo * cone;
            double x, y;
            #endregion
            if (D == 0)
            {
                if (Dx != 0 || Dy != 0)
                    result.Text = "No-Solution";
                else
                    result.Text = "Infinity-Sol";
            }
            else
            {
                x = Dx / D; y = Dy / D;
                result.Text = "X = " + Math.Round(x, 5).ToString() + ";  Y = " + Math.Round(y, 5).ToString();
            }
        }
        
        //Jump to another mode
        private void ânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
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
        private void sôPhưcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CMPLX();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void ânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HePT3An();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        // press Enter to move
        private void a1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(a1, true, true, true, true);
                temp = "B1";
                result.Text = "B1 = ";
            }
        }
        private void b1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(b1, true, true, true, true);
                temp = "C1";
                result.Text = "C1 = ";
            }
        }
        private void c1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(c1, true, true, true, true);
                temp = "A2";
                result.Text = "A2 = ";
            }
        }
        private void a2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(a2, true, true, true, true);
                temp = "B2";
                result.Text = "B2 = ";
            }
        }
        private void b2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(b2, true, true, true, true);
                temp = "C2";
                result.Text = "C2 = ";
            }
        }
        private void c2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(b1, false, true, true, true);
                temp = "A1";
            }
        }
        //Display on result textBox
        private void a1_TextChanged(object sender, EventArgs e)
        {
            result.Text = "A1 = " + a1.Text;
        }
        private void b1_TextChanged(object sender, EventArgs e)
        {
            result.Text = "B1 = " + b1.Text;
        }
        private void c1_TextChanged(object sender, EventArgs e)
        {
            result.Text = "C1 = " + c1.Text;

        }
        private void a2_TextChanged(object sender, EventArgs e)
        {
            result.Text = "A2 = " + a2.Text;
        }
        private void b2_TextChanged(object sender, EventArgs e)
        {
            result.Text = "B2 = " + b2.Text;
        }
        private void c2_TextChanged(object sender, EventArgs e)
        {
            result.Text = "C2 = " + c2.Text;
        }
        //press Enter to solve
        private void c2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13: equal.PerformClick(); break;
            }
        }


        #endregion

        
    }
}
