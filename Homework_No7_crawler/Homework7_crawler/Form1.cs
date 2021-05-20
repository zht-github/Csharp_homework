using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7_crawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UriTxt.Text.Equals("")) new Crawler(@"http://www.baidu.com/", richTxt);
            else new Crawler(UriTxt.Text, richTxt);
        }
    }
}
