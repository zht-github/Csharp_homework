namespace widget_calculator
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
            this.CALbotton = new System.Windows.Forms.Button();
            this.para1 = new System.Windows.Forms.TextBox();
            this.para2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CALbotton
            // 
            this.CALbotton.Location = new System.Drawing.Point(525, 140);
            this.CALbotton.Name = "CALbotton";
            this.CALbotton.Size = new System.Drawing.Size(75, 23);
            this.CALbotton.TabIndex = 0;
            this.CALbotton.Text = "=";
            this.CALbotton.UseVisualStyleBackColor = true;
            this.CALbotton.Click += new System.EventHandler(this.CALbotton_Click);
            // 
            // para1
            // 
            this.para1.Location = new System.Drawing.Point(49, 140);
            this.para1.Name = "para1";
            this.para1.Size = new System.Drawing.Size(100, 28);
            this.para1.TabIndex = 1;
            // 
            // para2
            // 
            this.para2.Location = new System.Drawing.Point(369, 140);
            this.para2.Name = "para2";
            this.para2.Size = new System.Drawing.Size(100, 28);
            this.para2.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(657, 140);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(44, 18);
            this.result.TabIndex = 3;
            this.result.Text = "null";
            // 
            // op
            // 
            this.op.FormattingEnabled = true;
            this.op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.op.Location = new System.Drawing.Point(196, 140);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(121, 26);
            this.op.TabIndex = 4;
            this.op.Text = "请选择操作数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "参数1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "选择运算符";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "参数2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "结果";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(49, 212);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(79, 31);
            this.reset.TabIndex = 9;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "运算符";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(652, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.Enabled = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            this.label6.Text = "计算结束后以上控件会被锁定，请点击reset按钮重启。以下展示历史记录:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.op);
            this.Controls.Add(this.result);
            this.Controls.Add(this.para2);
            this.Controls.Add(this.para1);
            this.Controls.Add(this.CALbotton);
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CALbotton;
        private System.Windows.Forms.TextBox para1;
        private System.Windows.Forms.TextBox para2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox op;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
    }
}

