﻿using System;
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
    public partial class UpdateCustomer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public UpdateCustomer()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = " update  customer set customerid=@customerid,username=@username,pass=@pass,confirmpass=@confirmpass where customerid=@customerid ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerid", textBox1.Text);

            cmd.Parameters.AddWithValue("@username", txtUsername.Text);

            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            cmd.Parameters.AddWithValue("@confirmpass", txtComPassword.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("data Updated succesfully");

            }
            else
            {
                MessageBox.Show("data  not Updated  succesfully/unsucessfull  .....");
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard D = new Dashboard();
            this.Hide();
            D.ShowDialog();
      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
