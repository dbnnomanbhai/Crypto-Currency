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
    public partial class Addmoney : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Addmoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dp = Int32.Parse(textBox2.Text);

            SqlConnection con = new SqlConnection(cs);
        

        string query = "update transactions set balance=balance + '" + dp + "'  where customerid = @customerid ";

            //string query = "update transactions set deposit=balance + '" + dp + "'  where customerid = @customerid ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerid", textBox1.Text);
            cmd.Parameters.AddWithValue("@deposit", dp);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show(" Money Added  succesfully");
              

               

            }
            else
            {
                MessageBox.Show(" sorry !unsucessfull  .....");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard a = new Dashboard();
            a.Show();
            this.Hide();

        }

        private void Addmoney_Load(object sender, EventArgs e)
        {

        }
    }
}
