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
    public partial class AdminViewQuery : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminViewQuery()
        {
            InitializeComponent();
        }
        void BindView()
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "  select * from   help ";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            cmd.Fill(data);
            dataGridView1.DataSource = data;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard D = new AdminDashboard();
            this.Hide();
            D.ShowDialog();
            
        }
    }
}
