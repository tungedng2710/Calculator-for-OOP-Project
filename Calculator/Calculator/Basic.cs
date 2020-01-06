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
    public partial class Basic : Form
    {
        string text = "";
        string sign;
        double val1;
        double val2;
        public Basic()
        {
            InitializeComponent();
        }
        public object Compute(string txt)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(txt, "");
            return v;
        }
        private double fac(double number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
            {
                return number * fac(number - 1);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Button Click
        private void Dip(string s)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = s;
                label2.Text = s;
            }
            else
            {
                result.Text = result.Text + s;
                label2.Text = s;
            }
        }
        //nut 0
        private void button19_Click(object sender, EventArgs e)
        {
            Dip("0");
        }
        //nut 1
        private void button18_Click(object sender, EventArgs e)
        {
            Dip("1");
        }
        //nut 2
        private void button17_Click(object sender, EventArgs e)
        {
            Dip("2");
        }
        //nut 3
        private void button16_Click(object sender, EventArgs e)
        {
            Dip("3");
        }
        //nut 4
        private void button13_Click(object sender, EventArgs e)
        {
            Dip("4");
        }
        //nut 5
        private void button12_Click(object sender, EventArgs e)
        {
            Dip("5");
        }
        //nut 6
        private void button11_Click(object sender, EventArgs e)
        {
            Dip("6");
        }
        //nut 7
        private void button8_Click(object sender, EventArgs e)
        {
            Dip("7");
        }
        //nut 8
        private void button7_Click(object sender, EventArgs e)
        {
            Dip("8");
        }
        //nut 9
        private void button6_Click(object sender, EventArgs e)
        {
            Dip("9");
        }
        //nut +
        private void button15_Click(object sender, EventArgs e)
        {
            sign = "+";
            label2.Text = "+";
            val1 = double.Parse(result.Text);
            result.Text = "0";
            textBox2.Text = "+";
        }
        //nut - 
        private void button14_Click(object sender, EventArgs e)
        {
            sign = "-";
            label2.Text = "-";
            val1 = double.Parse(result.Text);
            result.Text = "0";
            textBox2.Text = "-";
        }
        //nut x
        private void button10_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(result.Text);
            result.Text = "0";
            label2.Text = "×";
            textBox2.Text = "×";
        }
        //nut /
        private void button9_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(result.Text);
            result.Text = "0";
            label2.Text = "÷";
            textBox2.Text = "÷";
        }
        // nut !
        private void button1_Click(object sender, EventArgs e)
        {
            sign = "!";
            string txt = result.Text;
            val1 = double.Parse(result.Text);
            if (txt.Contains('.') || val1 < 0)
            {
                result.Text = "Math Error";
            }
            else
            {
                val2 = fac(val1);
                result.Text = result.Text + "!";
                textBox2.Text = "!";
            }
        }
        //nut sqrt
        private void button3_Click(object sender, EventArgs e)
        {
            sign = "sqrt";
            string txt = result.Text;
            if (txt[0] == '√')
            {
                txt = txt.Substring(1, txt.Length - 1);
            }
            else
            {
                val1 = double.Parse(result.Text);
                txt = "√" + txt;
            }
            result.Text = txt;
            textBox2.Text = "√";
        }
        //nut .
        private void button20_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ".";
        }
        //nut AC
        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            text = "";
            sign = "";
            textBox2.Clear();
        }
        //nut C
        private void button5_Click(object sender, EventArgs e)
        {
            string s = result.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            result.Text = s;
            text = result.Text;
        }
        //nut +/-
        private void button21_Click(object sender, EventArgs e)
        {
            string txt = result.Text;
            if (txt[0] == '-')
            {
                txt = txt.Substring(1, txt.Length - 1);
            }
            else
                txt = "-" + txt;
            result.Text = txt;
        }
        //pi
        private void bpi_Click(object sender, EventArgs e)
        {
            Dip("3.141592654");
        }
        //sin
        private void bsin_Click(object sender, EventArgs e)
        {
            val2 = 0;
            val1 = double.Parse(result.Text);
            string s = result.Text;
            result.Text = "sin(" + s + ")";
            sign = "sin";
            textBox2.Text = "sin";

        }
        //cos
        private void bcos_Click(object sender, EventArgs e)
        {
            val2 = 0;
            val1 = double.Parse(result.Text);
            string s = result.Text;
            result.Text = "cos(" + s + ")";
            sign = "cos";
            textBox2.Text = "cos";
        }
        //tan
        private void btan_Click(object sender, EventArgs e)
        {
            val2 = 0;
            val1 = double.Parse(result.Text);
            string s = result.Text;
            result.Text = "tan(" + s + ")";
            sign = "tan";
            textBox2.Text = "tan";
        }
        //sqr
        private void sqr_Click(object sender, EventArgs e)
        {
            sign = "sqr";
            //string txt = result.Text;
            //if (txt.Contains('^'))
            //{
            //    txt = txt.Substring(0, txt.Length - 2);
            //}
            //else
            //{
            //    val1 = double.Parse(result.Text);
            //    txt = txt + "^2";
            //}
            //result.Text = txt;
            textBox2.Text = "^";
            result.Text = result.Text + "^";
            
        }
        //nut =
        private void button23_Click(object sender, EventArgs e)
        {
            if (result.Text[0] == '.')
                result.Text = "0" + result.Text;
            if (sign == "+")
            {
                val2 = double.Parse(result.Text);
                double r = val1 + val2;
                result.Text = r.ToString();
                val1 = r;
                sign = "";
            }
            else if (sign == "-")
            {
                val2 = double.Parse(result.Text);
                double r = val1 - val2;
                result.Text = r.ToString();
                val1 = r;
                sign = "";
            }
            else if (sign == "*")
            {
                val2 = double.Parse(result.Text);
                double r = val1 * val2;
                result.Text = r.ToString();
                val1 = r;
                sign = "";
            }
            else if (sign == "/")
            {
                val2 = double.Parse(result.Text);
                int v2;
                if (val2 == 0)
                {
                    v2 = 0;
                    int v1 = (int)val1;
                    double r = 0;
                    try
                    {
                        r = v1 / v2;
                    }
                    catch (DivideByZeroException ex)
                    {
                        string expt = ex.ToString();
                        MessageBox.Show(expt);
                    }
                    result.Text = r.ToString();
                }
                else if (val2 != 0)
                {
                    double r = val1 / val2;
                    result.Text = r.ToString();
                }
                sign = "";
            }
            else if (sign == "!")
            {
                if (result.Text.Length > 4)
                    result.Text = "Math Error";
                else
                {
                    string kq = result.Text;
                    string str = kq.Substring(0, kq.IndexOf('!'));
                    var t = Compute(str);
                    double v = double.Parse(t.ToString());
                    if (v < 0 || str.Contains('.'))
                        result.Text = "Math Error";
                    else if (v == 0)
                        result.Text = "1";
                    else
                    {
                        v = fac(v);
                        result.Text = v.ToString();
                    }
                }
                sign = "";
            }
            else if (sign == "sqrt")
            {
                if (val1 < 0)
                    this.result.Text = "Math Error";
                else
                {
                    double r = Math.Round(Math.Sqrt(val1), 15);
                    this.result.Text = r.ToString();
                }
                sign = "";
            }
            else if (sign == "sqr")
            {
                string[] str = result.Text.Split('^');
                //val1 = double.Parse(str[0]);
                //val2 = double.Parse(str[1]);
                //double r = Math.Round(Math.Pow(val1, val2), 15);
                //this.result.Text = r.ToString();
                string kq = result.Text;
                string str1 = kq.Substring(0, kq.IndexOf('^'));
                string str2 = kq.Substring(kq.IndexOf('^') + 1, kq.Length - kq.IndexOf('^') - 1);
                var t1 = Compute(str1);
                var t2 = Compute(str2);
                double v1 = double.Parse(t1.ToString());
                double v2 = double.Parse(t2.ToString());
                double r = Math.Pow(v1, v2);
                result.Text = r.ToString();
                sign = "";
            }
            else if (sign == "sin")
            {
                double r = Math.Round(Math.Sin(val1), 10);
                this.result.Text = r.ToString();
                sign = "";
            }
            else if (sign == "cos")
            {
                double r = Math.Round(Math.Cos(val1), 10);
                this.result.Text = r.ToString();
                sign = "";
            }
            else if (sign == "tan")
            {
                double r = Math.Round(Math.Tan(val1), 15);
                this.result.Text = r.ToString();
                sign = "";
            }
            if (textBox2.Text == "")
            {
                string txt = result.Text;
                var r = Compute(txt);
                result.Text = r.ToString();
                sign = "";
            }
        }
        #endregion
        #region Jump
        private void bâc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new PTBac2();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyễn Tùng 20173597", "MINI PROJECT: CALCULATOR");
        }
        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void bâc2ToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        private void ânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HePT3An();
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
        private void sôPhưcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CMPLX();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        #endregion

        private void Basic_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13: equal.PerformClick(); break;
            }

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (result.Text.Contains("^"))
            {
                textBox2.Text = "sqr";
            }
        }
        private void result_TextChanged(object sender, EventArgs e)
        {
            if (result.Text.Contains("^"))
            {
                sign = "sqr";
                textBox2.Text = "sqr";
            }
            if (result.Text.Contains("!"))
            {
                sign = "!";
            }
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyen Tung 20173597 " +
                "\nMini project for OOP class", "Basic Calculator");
        }
    }
}
