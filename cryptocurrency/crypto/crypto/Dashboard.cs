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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerView  cv = new CustomerView();
            this.Hide();
            cv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Viewbalance cv = new Viewbalance();
            this.Hide();
            cv.ShowDialog();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
             CryproTransaction cv = new CryproTransaction();
            this.Hide();
            cv.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CustomerView cv = new CustomerView ();

            //cv.ShowDialog();
            UpdateCustomer cv = new UpdateCustomer();
            this.Hide();
            cv.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             Deletcustomer cv = new Deletcustomer();
            this.Hide();
            cv.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Coin cv = new  Coin();
            this.Hide();
            cv.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Help cv = new Help();
            this.Hide();
            cv.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Viewbalance cv = new Viewbalance();
            this.Hide();
            cv.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView ();
            this.Hide();
            cv.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             Developer cv = new Developer();

            cv.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          Addmoney  cv = new Addmoney();
            this.Hide();
            cv.ShowDialog();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Withdraw cv = new Withdraw();
            this.Hide();
            cv.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Homepage cv = new Homepage();
            this.Hide();

            cv.ShowDialog();
        }
    }
}
