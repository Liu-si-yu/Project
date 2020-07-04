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
namespace Family_Tree
{
    public partial class zhuce : Form
    {
        public zhuce()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = SC-201912241309; Initial Catalog = ZP; User ID = sa; Password = 123456";
            string sql = @"INSERT INTO 账户信息(姓名,账号,密码) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("账号生成成功！");
            }
            catch (Exception msg)
            {
                MessageBox.Show("出问题了！\n出错原因：" + msg.Message);
            }
            conn.Close();
        }
    }
}
