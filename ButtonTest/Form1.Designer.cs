namespace ButtonTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userButton6 = new ButtonTest.UserButton();
            this.userButton5 = new ButtonTest.UserButton();
            this.userButton4 = new ButtonTest.UserButton();
            this.userButton3 = new ButtonTest.UserButton();
            this.userButton2 = new ButtonTest.UserButton();
            this.userButton1 = new ButtonTest.UserButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(178, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // userButton6
            // 
            this.userButton6.BackColor = System.Drawing.Color.Transparent;
            this.userButton6.Checked = false;
            this.userButton6.CheckStyleX = ButtonTest.CheckStyle.style6;
            this.userButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton6.Location = new System.Drawing.Point(45, 111);
            this.userButton6.Name = "userButton6";
            this.userButton6.Size = new System.Drawing.Size(87, 27);
            this.userButton6.TabIndex = 5;
            // 
            // userButton5
            // 
            this.userButton5.BackColor = System.Drawing.Color.Transparent;
            this.userButton5.Checked = false;
            this.userButton5.CheckStyleX = ButtonTest.CheckStyle.style5;
            this.userButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton5.Location = new System.Drawing.Point(45, 186);
            this.userButton5.Name = "userButton5";
            this.userButton5.Size = new System.Drawing.Size(87, 27);
            this.userButton5.TabIndex = 4;
            // 
            // userButton4
            // 
            this.userButton4.BackColor = System.Drawing.Color.Transparent;
            this.userButton4.Checked = false;
            this.userButton4.CheckStyleX = ButtonTest.CheckStyle.style4;
            this.userButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton4.Location = new System.Drawing.Point(45, 12);
            this.userButton4.Name = "userButton4";
            this.userButton4.Size = new System.Drawing.Size(87, 27);
            this.userButton4.TabIndex = 3;
            // 
            // userButton3
            // 
            this.userButton3.BackColor = System.Drawing.Color.Transparent;
            this.userButton3.Checked = false;
            this.userButton3.CheckStyleX = ButtonTest.CheckStyle.style3;
            this.userButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton3.Location = new System.Drawing.Point(45, 45);
            this.userButton3.Name = "userButton3";
            this.userButton3.Size = new System.Drawing.Size(87, 27);
            this.userButton3.TabIndex = 2;
            // 
            // userButton2
            // 
            this.userButton2.BackColor = System.Drawing.Color.Transparent;
            this.userButton2.Checked = false;
            this.userButton2.CheckStyleX = ButtonTest.CheckStyle.style2;
            this.userButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton2.Location = new System.Drawing.Point(45, 78);
            this.userButton2.Name = "userButton2";
            this.userButton2.Size = new System.Drawing.Size(87, 27);
            this.userButton2.TabIndex = 1;
            // 
            // userButton1
            // 
            this.userButton1.BackColor = System.Drawing.Color.Transparent;
            this.userButton1.Checked = false;
            this.userButton1.CheckStyleX = ButtonTest.CheckStyle.style1;
            this.userButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton1.Location = new System.Drawing.Point(45, 146);
            this.userButton1.Name = "userButton1";
            this.userButton1.Size = new System.Drawing.Size(87, 27);
            this.userButton1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userButton6);
            this.Controls.Add(this.userButton5);
            this.Controls.Add(this.userButton4);
            this.Controls.Add(this.userButton3);
            this.Controls.Add(this.userButton2);
            this.Controls.Add(this.userButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserButton userButton1;
        private UserButton userButton2;
        private UserButton userButton3;
        private UserButton userButton4;
        private UserButton userButton5;
        private UserButton userButton6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}

