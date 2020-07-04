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
    public partial class cahxun1 : Form
    {
        public cahxun1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string connString = @"Data Source = LAPTOP-38KTM6R7; Initial Catalog = ZUPUDB; User ID = sa; Password = 123456";
            SqlConnection conn1 = new SqlConnection(connString);
            conn1.Open();
            string sql1 = @"SELECT * FROM member WHERE id ='"+textBox1.Text+"'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (!dr1.Read())
            {
                MessageBox.Show("该成员不存在！");
            }
            label12.Text = dr1[0].ToString();
            label13.Text = dr1[1].ToString();
            label14.Text = dr1[2].ToString();
            label15.Text = dr1[3].ToString();
            label16.Text = dr1[4].ToString();
            label17.Text = dr1[5].ToString();
            label18.Text = dr1[6].ToString();
            label19.Text = dr1[7].ToString();
            label20.Text = dr1[9].ToString();
            label23.Text = dr1[11].ToString();

            dr1.Close();


        }

     
    }
}
