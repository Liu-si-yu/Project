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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = SC-201912241309; Initial Catalog = ZP; User ID = sa; Password = 123456";
            string id = textBox1.Text;
            string mi = textBox2.Text;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql = @"SELECT * FROM 账户信息 WHERE 账号='" + textBox1.Text + "'";
            string sq2 = @"SELECT * FROM 账户信息 WHERE 密码='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sq2, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show(id + "账号错误！");
                return;
            }
            dr.Close();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (!dr2.Read())
            {
                MessageBox.Show(id + "密码错误！");
                return;
            }
            else
            {
                normol n = new normol();
                n.Show();
            }
            conn.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            zhuce ss = new zhuce();
            ss.Show();
            
        }
    }
}
