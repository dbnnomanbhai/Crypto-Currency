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
    public partial class Adminlogin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = " select * from   adminreg where  username= @username and  pw =@pw ";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@pw ", textBox2.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.HasRows == true)
            {
                AdminDashboard dash = new AdminDashboard();
                this.Hide();
                dash.ShowDialog();

            }
            else
            {
                MessageBox.Show(" not successful");
            }
            con.Close();
        }

      

        private void label6_Click(object sender, EventArgs e)
        {
           AdminRegistration dash = new AdminRegistration();
            this.Hide();

            dash.ShowDialog();

        }

         

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
