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
using System.Security.Cryptography;

namespace crypto
{
    public partial class CryproTransaction : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public CryproTransaction()
        {
            InitializeComponent();
        }
        string hash = "f0xle@rn";
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            byte[] data = UTF8Encoding.UTF8.GetBytes(textValu.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())

            {

                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })

                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textEncrypt.Text = Convert.ToBase64String(results, 0, results.Length);


                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into  crypt values (@customerid,@secret,@encrypted )";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerid", textBox1.Text);
            cmd.Parameters.AddWithValue("@secret", textValu.Text);
            cmd.Parameters.AddWithValue("@encrypted", textEncrypt.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("   Thank you for keeping it secret ");

            }
            else
            {
                MessageBox.Show("   sorry we are not getting your private code .....");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard D = new Dashboard();
            this.Hide();
            D.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {

                progressBar1.Value += 1;
                label5.Text = progressBar1.Value.ToString() + "%";

            }
            else

            {
                timer1.Stop();
                MessageBox.Show("Your Secret Transaction successfully completed");

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
