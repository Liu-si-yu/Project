using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 族谱
{
    public partial class 添加族谱信息 : Form
    {
        public 添加族谱信息()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("您输入的家族信息是：");
            sb.Append("\n ID：" + textID.Text); ;
            sb.Append("\n 家族名称：" + textMC.Text);
            sb.Append("\n 家族姓氏：" + textXS.Text);
            sb.Append("\n 家族简介：" + textJJ.Text);
            sb.Append("\n 家训：" + textJX.Text);
            sb.Append("\n 字辈顺序：" + textZBSS.Text);
            sb.Append("\n 大事件：" + textDSJ.Text);
            MessageBox.Show(sb.ToString(), "请检查",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            string connString = @"Data Source=DESKTOP-IM75SVJ; Initial Catalog = mybook; User ID = aa; Password = 123456";
            string sql = @"INSERT INTO zupu VALUES('" + textID.Text + "','" + textMC.Text + "','" + textXS.Text + "','" + textJJ.Text + "','" + textJX.Text + "','" + textZBSS.Text + "','" + textDSJ.Text + "')";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("信息录入成功！");
            }
            catch (Exception msg)
            {
                MessageBox.Show("信息录入出现错误" + msg.Message);
            }
            conn.Close();


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
