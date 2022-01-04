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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();

            this.Hide();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminRegistration a = new AdminRegistration();
            this.Hide();
            a.ShowDialog();
        }

        private void Features_Click(object sender, EventArgs e)
        {
         sir a = new sir();
            this.Hide();
            a.ShowDialog();
        }
    }
}
