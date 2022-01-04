using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace crypto
{
    public partial class Deletcustomer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Deletcustomer()
        {
            InitializeComponent();
        }

        

        private void Deletcustomer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "  select * from  customer ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            reset();
            con.Close();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "  select * from  customer where  customerid like  '" + textBox2.Text + "%' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void reset()
        {


            textBox1.Clear();
            textBox2.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           AdminDashboard D = new AdminDashboard();
            this.Hide();
            D.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "  delete from  transactions  where  tid=@tid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", textBox1.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Transaction id   Deleted succesfully");

            }
            else
            {
                MessageBox.Show(" Transaction not succesfully deleted /unsucessfull  .....");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }

