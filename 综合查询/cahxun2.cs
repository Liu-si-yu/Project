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

namespace 综合查询
{
    public partial class cahxun2 : Form
    {
        public cahxun2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flag;
            string num;
            string ss;
            string ss1;
            string connString = @"Data Source = LAPTOP-38KTM6R7; Initial Catalog = ZUPUDB; User ID = sa; Password = 123456";
            SqlConnection conn1 = new SqlConnection(connString);
            conn1.Open();
            string sql2 = @"SELECT [id of dad] FROM member WHERE id ='" + textBox1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn1);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (!dr2.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            num = dr2[0].ToString();
            dr2.Close();
            string sql3 = @"SELECT name FROM member WHERE id ='" + num + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, conn1);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (!dr3.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            label3.Text = dr3[0].ToString();
            dr3.Close();
            string sql4 = @"SELECT 配偶id FROM member WHERE id ='" + num + "'";
            SqlCommand cmd4 = new SqlCommand(sql4, conn1);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (!dr4.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            ss = dr4[0].ToString();
            dr4.Close();
            string sql5 = @"SELECT name FROM member WHERE id ='" + ss + "'";
            SqlCommand cmd5 = new SqlCommand(sql5, conn1);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (!dr5.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            label5.Text = dr5[0].ToString();
            dr5.Close();

            string sql6 = @"SELECT 配偶id FROM member WHERE id ='" + textBox1.Text + "'";
            SqlCommand cmd6 = new SqlCommand(sql6, conn1);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (!dr6.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            ss1 = dr6[0].ToString();
            dr6.Close();


            string sql7 = @"SELECT name FROM member WHERE id ='" + ss1 + "'";
            SqlCommand cmd7 = new SqlCommand(sql7, conn1);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (!dr7.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            label7.Text = dr7[0].ToString();
            dr7.Close();

            string sql8 = @"SELECT [son 1] FROM member WHERE id ='" + textBox1.Text + "'";
            SqlCommand cmd8 = new SqlCommand(sql8, conn1);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (!dr8.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            label9.Text = dr8[0].ToString();
            dr8.Close();

            string sql9 = @"SELECT [daughter 1] FROM member WHERE id ='" + textBox1.Text + "'";
            SqlCommand cmd9 = new SqlCommand(sql9, conn1);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (!dr9.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            label11.Text = dr9[0].ToString();
            dr9.Close();

            

            string sql11 = @"SELECT sex FROM member WHERE id ='" + textBox1.Text + "'";
            SqlCommand cmd11 = new SqlCommand(sql11, conn1);
            SqlDataReader dr11 = cmd11.ExecuteReader();
            if (!dr11.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            flag= dr11[0].ToString();
            dr11.Close();

            if (flag == "男")
            {

                string sql10 = @"SELECT [daughter 1] FROM member WHERE id ='" + num + "'";
                SqlCommand cmd10 = new SqlCommand(sql10, conn1);
                SqlDataReader dr10 = cmd10.ExecuteReader();
                if (!dr10.Read())
                {
                    MessageBox.Show("该成员不存在！");
                }
                label13.Text ="妹妹 " +dr10[0].ToString();
                dr10.Close();
            }
            else
            {
                string sql12 = @"SELECT [son 1] FROM member WHERE id ='" + num + "'";
                SqlCommand cmd12 = new SqlCommand(sql12, conn1);
                SqlDataReader dr12 = cmd12.ExecuteReader();
                if (!dr12.Read())
                {
                    MessageBox.Show("该成员不存在！");
                }
                label13.Text = "弟弟 "+dr12[0].ToString();
                dr12.Close();
            }
        }
    }
}
