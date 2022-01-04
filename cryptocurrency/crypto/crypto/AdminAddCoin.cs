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
    public partial class AdminAddCoin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminAddCoin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SqlConnection con = new SqlConnection(cs);


            string query = "insert into transactions (coinprice,coinname,customerid) values (@coinprice,@coinname,@customerid )";

             

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@coinprice", textBox1.Text);
            cmd.Parameters.AddWithValue("@coinname", textBox2.Text);
            cmd.Parameters.AddWithValue("@customerid", textBox3.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();


            if (a > 0)
            {
                //MessageBox.Show("   successfully coin added");
                 

            }
            else
            {
                MessageBox.Show(" not successful");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard D = new AdminDashboard();
            this.Hide();
            D.ShowDialog();

            
        }


       

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {

                progressBar1.Value += 1;
                label3.Text = progressBar1.Value.ToString() + "%";

            }
            else

            {
                timer1.Stop();
                MessageBox.Show("Your Coin Added successfully  ");

            }
        }

        private void AdminAddCoin_Load(object sender, EventArgs e)
        {
             
        }
    }
}
