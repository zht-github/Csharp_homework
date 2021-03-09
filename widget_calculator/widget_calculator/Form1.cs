using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace widget_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CALbotton_Click(object sender, EventArgs e)
        {
            int op = this.op.SelectedIndex;
            
            switch (op)
            {
                case 0: result.Text = (double.Parse(para1.Text) + double.Parse(para2.Text)).ToString(); break;
                case 1: result.Text = (double.Parse(para1.Text) - double.Parse(para2.Text)).ToString(); break;
                case 2: result.Text = (double.Parse(para1.Text) * double.Parse(para2.Text)).ToString(); break;
                case 3: result.Text = (double.Parse(para1.Text) / double.Parse(para2.Text)).ToString(); break;
            }
            this.op.Enabled = false;
            this.para1.Enabled = false;
            this.para2.Enabled = false;
            this.richTextBox1.AppendText(para1.Text + this.op.Text + para2.Text + "=" + result.Text+"\n"); 
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.op.Text = "请选择操作数";
            this.para1.Text = "";
            this.para2.Text = "";
            this.result.Text = "null";

            this.op.Enabled = true;
            this.para1.Enabled = true;
            this.para2.Enabled = true;
        }

    }
}
