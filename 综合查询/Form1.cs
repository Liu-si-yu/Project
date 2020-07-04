using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 综合查询
{
    public partial class 查询 : Form
    {
        public 查询()
        {
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cahxun1 n = new cahxun1();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cahxun2 ss = new cahxun2();
            ss.Show();
        }
    }
}
