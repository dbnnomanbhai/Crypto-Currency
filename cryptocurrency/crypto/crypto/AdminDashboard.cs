using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView();
            this.Hide();
            cv.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deletcustomer c = new Deletcustomer();
            this.Hide();
            c.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewTrans a = new AdminViewTrans();
            this.Hide();
            a.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AdminViewQuery a = new AdminViewQuery();
            this.Hide();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminAddCoin a = new AdminAddCoin();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUpdateProfile a = new AdminUpdateProfile();

            this.Hide();
            a.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
        Homepage a = new Homepage();

            this.Hide();
            a.ShowDialog();
        }
    }
}
