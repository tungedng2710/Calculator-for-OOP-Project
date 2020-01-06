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
    public partial class CMPLX : Form
    {
        public CMPLX()
        {
            InitializeComponent();
        }
        #region Button Click
        private void add_Click(object sender, EventArgs e)
        {
            op.Text = "+";
        }
        private void sub_Click(object sender, EventArgs e)
        {
            op.Text = "-";
        }
        private void mul_Click(object sender, EventArgs e)
        {
            op.Text = "*";
        }
        private void div_Click(object sender, EventArgs e)
        {
            op.Text = "/";
        }
        //AC
        private void button4_Click(object sender, EventArgs e)
        {
            Rez1.Clear();
            Rez2.Clear();
            Imz1.Clear();
            Imz2.Clear();
            result.Text = "Re(z1) = ";
            op.Clear();
            this.Select(true, true);
        }
        private void equal_Click(object sender, EventArgs e)
        {
            CmplxCal();
        }
        private void CmplxCal()
        {
            double rez1 = double.Parse(Rez1.Text);
            double rez2 = double.Parse(Rez2.Text);
            double imz1 = double.Parse(Imz1.Text);
            double imz2 = double.Parse(Imz2.Text);
            Complex z1 = new Complex(rez1, imz1);
            Complex z2 = new Complex(rez2, imz2);
            if (op.Text == "+")
            {
                Complex z = z1 + z2;
                result.Text = z1.ToString() + "+" + z2.ToString() + "=" + z.ToString();
            }
            else if (op.Text == "-")
            {
                Complex z = z1 - z2;
                result.Text = z1.ToString() + "-" + z2.ToString() + "=" + z.ToString();

            }
            else if (op.Text == "*")
            {
                Complex z = z1 * z2;
                result.Text = z1.ToString() + "*" + z2.ToString() + "=" + z.ToString();
            }
            else if (op.Text == "/")
            {
                Complex z = z1 / z2;
                result.Text = z1.ToString() + "/" + z2.ToString() + "=" + z.ToString();
            }

        }
        #endregion
        #region Jump
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
        private void bâc3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new PTBac3();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        //he 2 an
        private void ânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HePT2An();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        //He 3 an
        private void ânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HePT3An();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        #endregion
        #region Event
        private void Rez1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(Rez1, true, true, true, true);
                result.Text = " Im(z1) = ";
            }
        }
        private void Imz1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(Imz1, true, true, true, true);
                result.Text = "Re(z2) = ";
            }
        }
        private void Rez2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(Rez2, true, true, true, true);
                result.Text = "Im(z2) = ";
            }
        }
        private void Imz2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl(Imz1, false, true, true, true);
            }
        }
        private void Rez1_TextChanged(object sender, EventArgs e)
        {
            result.Text = result.Text + Rez1.Text;
        }
        private void Imz1_TextChanged(object sender, EventArgs e)
        {
            result.Text = result.Text + Imz1.Text;
        }
        private void Rez2_TextChanged(object sender, EventArgs e)
        {
            result.Text = result.Text + Rez2.Text;
        }

        private void Imz2_TextChanged(object sender, EventArgs e)
        {
            result.Text = result.Text + Imz2.Text;
        }
        #endregion


    }
    //Complex Number class
    class Complex
    {
        private double re;
        private double im;
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public Complex()
        {

        }
        public static Complex operator +(Complex z1, Complex z2)
        {
            double r, i;
            r = z1.re + z2.re;
            i = z1.im + z2.im;
            Complex z = new Complex(r, i);
            return z;
        }
        public static Complex operator -(Complex z1, Complex z2)
        {
            double r, i;
            r = z1.re - z2.re;
            i = z1.im - z2.im;
            Complex z = new Complex(r, i);
            return z;
        }
        public static Complex operator *(Complex z1, Complex z2)
        {
            double r, i;
            r = z1.re * z2.re - z1.im * z2.im;
            i = z1.im * z2.re + z1.re * z2.im;
            Complex z = new Complex(r, i);
            return z;
        }
        public static Complex operator /(Complex z1, Complex z2)
        {
            double r, i;
            r = (z1.re * z2.re + z1.im * z2.im) / (Complex.Abs(z2) * Complex.Abs(z2));
            i = (z1.im * z2.re - z1.re * z2.im) / (Complex.Abs(z2) * Complex.Abs(z2));
            Complex z = new Complex(r, i);
            return z;
        }
        public static Complex Pow(Complex z, int n)
        {
            Complex z1 = new Complex(1, 0);
            for (int i = 1; i <= n; i++)
            {
                z1 = z1 * z;
            }
            return z1;
        }
        public static double Abs(Complex z)
        {
            return Math.Sqrt(z.re * z.re + z.im * z.im);
        }
        public override string ToString()
        {
            if (this.im < 0)
                return string.Format("({0} - {1}i)", this.re, Math.Abs(this.im));
            else if (this.im == 0)
                return string.Format("{0}", this.re);
            else
                return string.Format("({0} + {1}i)", this.re, this.im);
        }
    }
}
