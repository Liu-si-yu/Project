using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 族谱
{
    public partial class 族谱信息管理 : Form
    {
        public 族谱信息管理()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            添加族谱信息 regist = new 添加族谱信息();
            regist.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            查看和删除族谱信息 re = new 查看和删除族谱信息();
            re.ShowDialog();
        }
    }
}
