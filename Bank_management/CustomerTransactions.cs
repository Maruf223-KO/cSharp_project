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
    public partial class CustomerTransactions : Form
    {
        string connection_string = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
        private string UserId
        {
            get;
            set;
        }
        public CustomerTransactions(string userId)
        {
            InitializeComponent();
            this.UserId = userId;
        }

        private void CustomerTransactions_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);
            string select_all_transaction = "select * from Transactions";
            SqlDataAdapter sda = new SqlDataAdapter(select_all_transaction, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);
            string select_all_transaction = "select * from Transactions where TransactionId like '%"+txt_search.Text+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(select_all_transaction, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboard cd = new CustomerDashboard(UserId);
            cd.Show();
        }
    }
}
