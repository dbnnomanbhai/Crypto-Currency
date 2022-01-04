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
    public partial class Withdraw : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Withdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wd = Int32.Parse(textBox2.Text);

            SqlConnection con = new SqlConnection(cs);
            //string query = "insert into customer values (@customerid,@deposit )";

            string query = "update transactions set balance=balance - '" + wd + "'  where customerid = @customerid ";



            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerid", textBox1.Text);
            cmd.Parameters.AddWithValue("@withdraw", wd);




            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("wihdraw success ");
                //Form1 cv = new Form1();

                //cv.ShowDialog();

            }
            else
            {
                MessageBox.Show("insufficient balance .....");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
             
            this.Hide();
            d.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
