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
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==  true){
                textBox2.UseSystemPasswordChar = false;


                }
            else
            {
                textBox2.UseSystemPasswordChar =  true;


            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Registration reg = new  Registration();
         //  reg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);

                string query = " select * from  customer where  username= @username and  pass =@pass ";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();



                if (dr.HasRows == true)
                {
                    Dashboard dash = new Dashboard();
                    this.Hide();
                    
                    dash.ShowDialog();

                }
                else
                {
                    MessageBox.Show(" not successful");
                }
                con.Close();
                


            }
            else
            {
                MessageBox.Show("  FILL IN THE FIELD");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Signup cv = new Signup();
            this.Hide();
            cv.ShowDialog();
        

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

