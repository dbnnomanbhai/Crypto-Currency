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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminRegistration a = new AdminRegistration();
            a.ShowDialog();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            

            s.ShowDialog();
       

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.BlueViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        

        private void Welcome_Load(object sender, EventArgs e)
        {
         
        }

         

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
