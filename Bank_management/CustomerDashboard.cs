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
        private string UserID
        {
            get;
            set;
        }
        public int second = 5;
        public CustomerDashboard(string userId)
        {
            InitializeComponent();
            this.UserID = userId;
        }

        private void label_Balance_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string select_balance_query = "select Balance from Account where AccountId=(select AccountId from Customer where UserId='" + UserID + "')";
            SqlDataAdapter sda = new SqlDataAdapter(select_balance_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string balance = dt.Rows[0][0].ToString();
            this.label_Balance.Text = balance;
            timer1.Start();

        }

        private void btn_SentMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SentMoney("noton").Show();
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loan l1 = new Loan(UserID);

            l1.Show();
            
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerWithdraw cw = new CustomerWithdraw(UserID);
            cw.Show();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDeposit cd = new CustomerDeposit(UserID);
            cd.Show();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string select_name_query = "select name from Customer where UserId='" + UserID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(select_name_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string customerName = dt.Rows[0][0].ToString();
            this.label_customername.Text = customerName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            
            if (second <= 0)
            {
                timer1.Stop();
                second = 5;
                this.label_Balance.Text = "Click to see Balance";           
            }
        }

        private void btn_Transcation_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerTransactions ct = new CustomerTransactions(UserID);
            ct.Show();

        }
    }
}
