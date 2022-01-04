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
    public partial class Buycoin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Buycoin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cn = Int32.Parse(textBox2.Text);
            SqlConnection con = new SqlConnection(cs);
            //

            //string query = "update transactions set balance  = deposit - (coinprice * '" + cn + "') where customerid = @customerid ";

            string query = "update transactions set  coinvalue  = deposit - (coinprice * '" + cn + "') where customerid = @customerid ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerid", textBox1.Text);
            cmd.Parameters.AddWithValue("@coinprice", cn);


            string query2 = "update transactions set coinvalue  = coinprice * '" + cn + "' where customerid = @customerid ";

            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@customerid", textBox1.Text);
            cmd2.Parameters.AddWithValue("@coinprice", cn);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Purchase succesfull");
                

            }
            else
            {
                MessageBox.Show(" purchase unsucessfull  .....");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard D = new AdminDashboard();
            this.Hide();
            D.ShowDialog();
        
        }
    }
}
