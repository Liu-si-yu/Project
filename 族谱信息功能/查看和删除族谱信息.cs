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
    public partial class 查看和删除族谱信息 : Form
    {
        public 查看和删除族谱信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textID1.Text;
            string connString = @"Data Source=DESKTOP-IM75SVJ; Initial Catalog = mybook; User ID = aa; Password = 123456";
            string sql = @"SELECT * FROM zupu WHERE id= '"+ textID1.Text +"'";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dr = new SqlDataAdapter(sql, connString);
            DataSet ds = new DataSet();
            dr.Fill(ds, "zupu");
            dataGridView1.DataSource = ds.Tables["zupu"];
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textID1.Text;
            string connString = @"Data Source=DESKTOP-IM75SVJ; Initial Catalog = mybook; User ID = aa; Password = 123456";
            
           
            string sql = @"DELETE  FROM zupu WHERE id= '" + textID1.Text + "'";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
            }
            catch (Exception msg)
            {
                MessageBox.Show("删除失败！！！" + msg.Message);
            } 
            SqlDataAdapter dr = new SqlDataAdapter(sql, connString);
            DataSet ds = new DataSet();
            dr.Fill(ds, "zupu");
            dataGridView1.DataSource = ds.Tables["zupu"];
            conn.Close();
        }
    }
}
