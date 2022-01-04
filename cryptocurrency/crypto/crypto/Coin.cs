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
    public partial class Coin : Form
    {
        public Coin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
           
            int i = int.Parse(aAmount.Text);

            if (aFromCombo1.SelectedItem == "Bitcoin" && aToCombo2.SelectedItem == "Ether")
            {
                double conver = i * 12.300;
                aDisplay.Text = "Converted Amount  : " + conver + "\t    Ether";
            }


            if (aFromCombo1.SelectedItem == "Ether" && aToCombo2.SelectedItem == "Bitcoin")
            {
                double conver = i * 0.810;
                aDisplay.Text = "Converted Amount : " + conver + "\t  Bitcoin";
            }

            if (aFromCombo1.SelectedItem == "Bitcoin" && aToCombo2.SelectedItem == " Litecoin")
            {
                double conver = i * 37226;
                aDisplay.Text = "Converted Amount : " + conver + "\t  Litecoin";
            }

            if (aFromCombo1.SelectedItem == "Litecoin" && aToCombo2.SelectedItem == "Bitcoin")
            {
                double conver = i * 0.22;
                aDisplay.Text = "Converted Amount   : " + conver + "\t  Bitcoin";

            }

            if (aFromCombo1.SelectedItem == "Ether" && aToCombo2.SelectedItem == "Litecoin")
            {
                double conver = i * 0.26;
                aDisplay.Text = "Converted  Amount  : " + conver + "\t  Litecoin";
            }
            if (aFromCombo1.SelectedItem == " Litecoin" && aToCombo2.SelectedItem == "Ether")
            {
                double conver = i * 3026;
                aDisplay.Text = "Converted Amount  : " + conver + "\t    Ether";
            }

        }

        private void Coin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard D = new Dashboard();
            this.Hide();
            D.ShowDialog();
        }
    }
}
