using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_management
{
    public partial class CustomerDashboard : Form
    {
        string connectionString = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog = Bank; Integrated Security = True";
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void label_Balance_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string search_query = "";

        }
    }
}
