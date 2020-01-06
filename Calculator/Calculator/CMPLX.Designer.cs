namespace Calculator
{
    partial class CMPLX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phươngTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bâc2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bâc3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hêPhươngTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sôPhưcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bpi = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Rez1 = new System.Windows.Forms.TextBox();
            this.Imz2 = new System.Windows.Forms.TextBox();
            this.op = new System.Windows.Forms.TextBox();
            this.Imz1 = new System.Windows.Forms.TextBox();
            this.Rez2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.result.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(0, 39);
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.result.Size = new System.Drawing.Size(493, 53);
            this.result.TabIndex = 100;
            this.result.Text = "Re(z1) = ";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.UseWaitCursor = true;
            this.result.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 36);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mODEToolStripMenuItem
            // 
            this.mODEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mODEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.phươngTrinhToolStripMenuItem,
            this.hêPhươngTrinhToolStripMenuItem,
            this.sôPhưcToolStripMenuItem});
            this.mODEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mODEToolStripMenuItem.Name = "mODEToolStripMenuItem";
            this.mODEToolStripMenuItem.Size = new System.Drawing.Size(84, 32);
            this.mODEToolStripMenuItem.Text = "MODE";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.basicToolStripMenuItem.Text = "Cơ bản";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click);
            // 
            // phươngTrinhToolStripMenuItem
            // 
            this.phươngTrinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bâc2ToolStripMenuItem,
            this.bâc3ToolStripMenuItem});
            this.phươngTrinhToolStripMenuItem.Name = "phươngTrinhToolStripMenuItem";
            this.phươngTrinhToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.phươngTrinhToolStripMenuItem.Text = "Phương trình";
            // 
            // bâc2ToolStripMenuItem
            // 
            this.bâc2ToolStripMenuItem.Name = "bâc2ToolStripMenuItem";
            this.bâc2ToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.bâc2ToolStripMenuItem.Text = "Bậc 2";
            this.bâc2ToolStripMenuItem.Click += new System.EventHandler(this.bâc2ToolStripMenuItem_Click);
            // 
            // bâc3ToolStripMenuItem
            // 
            this.bâc3ToolStripMenuItem.Name = "bâc3ToolStripMenuItem";
            this.bâc3ToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.bâc3ToolStripMenuItem.Text = "Bậc 3";
            this.bâc3ToolStripMenuItem.Click += new System.EventHandler(this.bâc3ToolStripMenuItem_Click);
            // 
            // hêPhươngTrinhToolStripMenuItem
            // 
            this.hêPhươngTrinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ânToolStripMenuItem,
            this.ânToolStripMenuItem1});
            this.hêPhươngTrinhToolStripMenuItem.Name = "hêPhươngTrinhToolStripMenuItem";
            this.hêPhươngTrinhToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.hêPhươngTrinhToolStripMenuItem.Text = "Hệ phương trình";
            // 
            // ânToolStripMenuItem
            // 
            this.ânToolStripMenuItem.Name = "ânToolStripMenuItem";
            this.ânToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.ânToolStripMenuItem.Text = "2 ẩn";
            this.ânToolStripMenuItem.Click += new System.EventHandler(this.ânToolStripMenuItem_Click);
            // 
            // ânToolStripMenuItem1
            // 
            this.ânToolStripMenuItem1.Name = "ânToolStripMenuItem1";
            this.ânToolStripMenuItem1.Size = new System.Drawing.Size(131, 32);
            this.ânToolStripMenuItem1.Text = "3 ẩn";
            this.ânToolStripMenuItem1.Click += new System.EventHandler(this.ânToolStripMenuItem1_Click);
            // 
            // sôPhưcToolStripMenuItem
            // 
            this.sôPhưcToolStripMenuItem.Name = "sôPhưcToolStripMenuItem";
            this.sôPhưcToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.sôPhưcToolStripMenuItem.Text = "Số phức";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Coral;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(201, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 38);
            this.button5.TabIndex = 37;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(296, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 38);
            this.button4.TabIndex = 36;
            this.button4.Text = "AC";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bpi
            // 
            this.bpi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpi.Location = new System.Drawing.Point(200, 387);
            this.bpi.Name = "bpi";
            this.bpi.Size = new System.Drawing.Size(89, 38);
            this.bpi.TabIndex = 111;
            this.bpi.Text = "π";
            this.bpi.UseVisualStyleBackColor = false;
            this.bpi.Visible = false;
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.SandyBrown;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(391, 255);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(89, 170);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(105, 387);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(89, 38);
            this.button20.TabIndex = 109;
            this.button20.Text = ".";
            this.button20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Visible = false;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(11, 387);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(89, 38);
            this.zero.TabIndex = 108;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Visible = false;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(11, 343);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(89, 38);
            this.one.TabIndex = 107;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Visible = false;
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(106, 343);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(89, 38);
            this.two.TabIndex = 106;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Visible = false;
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(201, 343);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(89, 38);
            this.three.TabIndex = 105;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Visible = false;
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(11, 299);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(89, 38);
            this.four.TabIndex = 104;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Visible = false;
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(106, 299);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(89, 38);
            this.five.TabIndex = 103;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Visible = false;
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(201, 299);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(89, 38);
            this.six.TabIndex = 102;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Visible = false;
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(11, 255);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(89, 38);
            this.seven.TabIndex = 101;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Visible = false;
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(106, 255);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(89, 38);
            this.eight.TabIndex = 100;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Visible = false;
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(201, 255);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(89, 38);
            this.nine.TabIndex = 99;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Visible = false;
            // 
            // Rez1
            // 
            this.Rez1.Location = new System.Drawing.Point(52, 98);
            this.Rez1.Name = "Rez1";
            this.Rez1.Size = new System.Drawing.Size(100, 22);
            this.Rez1.TabIndex = 0;
            this.Rez1.TextChanged += new System.EventHandler(this.Rez1_TextChanged);
            this.Rez1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Rez1_KeyUp);
            // 
            // Imz2
            // 
            this.Imz2.Location = new System.Drawing.Point(212, 126);
            this.Imz2.Name = "Imz2";
            this.Imz2.Size = new System.Drawing.Size(100, 22);
            this.Imz2.TabIndex = 3;
            this.Imz2.TextChanged += new System.EventHandler(this.Imz2_TextChanged);
            this.Imz2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Imz2_KeyUp);
            // 
            // op
            // 
            this.op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op.Location = new System.Drawing.Point(391, 126);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(89, 30);
            this.op.TabIndex = 100;
            this.op.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Imz1
            // 
            this.Imz1.Location = new System.Drawing.Point(52, 126);
            this.Imz1.Name = "Imz1";
            this.Imz1.Size = new System.Drawing.Size(100, 22);
            this.Imz1.TabIndex = 1;
            this.Imz1.TextChanged += new System.EventHandler(this.Imz1_TextChanged);
            this.Imz1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Imz1_KeyUp);
            // 
            // Rez2
            // 
            this.Rez2.Location = new System.Drawing.Point(212, 98);
            this.Rez2.Name = "Rez2";
            this.Rez2.Size = new System.Drawing.Size(100, 22);
            this.Rez2.TabIndex = 2;
            this.Rez2.TextChanged += new System.EventHandler(this.Rez2_TextChanged);
            this.Rez2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Rez2_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 114;
            this.label1.Text = "Rez1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Imz1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Rez2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Imz2";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(296, 255);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 38);
            this.add.TabIndex = 121;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(296, 299);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(89, 38);
            this.sub.TabIndex = 120;
            this.sub.Text = "−";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(296, 343);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(89, 38);
            this.mul.TabIndex = 119;
            this.mul.Text = "×";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(296, 387);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(89, 38);
            this.div.TabIndex = 118;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 122;
            this.label5.Text = "Operator";
            // 
            // CMPLX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.div);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rez2);
            this.Controls.Add(this.Imz1);
            this.Controls.Add(this.op);
            this.Controls.Add(this.Imz2);
            this.Controls.Add(this.Rez1);
            this.Controls.Add(this.bpi);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.result);
            this.Name = "CMPLX";
            this.Text = "CMPLX";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mODEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phươngTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bâc2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bâc3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hêPhươngTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sôPhưcToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bpi;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.TextBox Rez1;
        private System.Windows.Forms.TextBox Imz2;
        private System.Windows.Forms.TextBox op;
        private System.Windows.Forms.TextBox Imz1;
        private System.Windows.Forms.TextBox Rez2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label label5;
    }
}