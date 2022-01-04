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
    public partial class Help : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text=="")
            {
                MessageBox.Show("Username ,CustomerId fields are empty", "  Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                SqlConnection con = new SqlConnection(cs);
                string query = "insert into   help values (@customerid,@username,@mail,@query)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@customerid", textBox1.Text);
                cmd.Parameters.AddWithValue("@username", textBox2.Text);
                cmd.Parameters.AddWithValue("@mail", textBox3.Text);
                cmd.Parameters.AddWithValue("@query", textBox4.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show(" Thank You  for contact us .");

                }
                else
                {
                    MessageBox.Show(" sorry ! we are not getting your information  .....");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard D = new Dashboard();
            this.Hide();
            D.ShowDialog();
            
        }
    }
}
