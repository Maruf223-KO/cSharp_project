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
    public partial class CustomerWithdraw : Form
    {
        string connection_string = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
        
        private string UserId
        {
            get;
            set;
        }

        public CustomerWithdraw(string userId)
        {
            InitializeComponent();
            this.UserId = userId;
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            txt_amount.Text = btn_50.Text;
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            txt_amount.Text = btn_100.Text;
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            txt_amount.Text = btn_500.Text;
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            txt_amount.Text = btn_1000.Text;
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            float amount = float.Parse(txt_amount.Text);
            SqlConnection con = new SqlConnection(connection_string);
            string balance_query = "select Balance from Account where AccountId=(select AccountId from Account where CustomerId = (select CustomerId from Customer where UserId ='"+UserId+"'))" ;
            SqlDataAdapter sda = new SqlDataAdapter(balance_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            float accountBalance = float.Parse(dt.Rows[0][0].ToString());
            if (accountBalance < amount)
            {
                MessageBox.Show("Do not have sufficient balance");
            }
            else
            {
                accountBalance -= amount;
                string update_account_balance_query = "update Account set balance='" + accountBalance + "' where AccountId=(select AccountId from Account where CustomerId = (select CustomerId from Customer where UserId ='" + UserId + "'))";
                string insert_transaction_query = "insert into Transactions values((select AccountId from Account where CustomerId=(select CustomerId from Customer where UserId='" + UserId + "')),NULL,'" + amount + "','Completed','Withdraw',GETDATE(),'Personl reason')";
                SqlCommand sql3 = new SqlCommand(update_account_balance_query, con);
                SqlCommand sql4 = new SqlCommand(insert_transaction_query, con);
              

                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    sql3.ExecuteNonQuery();
                    sql4.ExecuteNonQuery();

                    
                }
                else
                {
                    MessageBox.Show("Update is not sucessful");
                }
                CustomerWithdraw_Load(sender, e);
                this.txt_amount.Text = "";
                con.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboard cd = new CustomerDashboard(UserId);
            cd.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_amount.Text = "";
        }

        private void CustomerWithdraw_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);
            string select_balance_query = "select Balance from Account where AccountId=(select AccountId from Customer where UserId='" + UserId + "' )";
            SqlDataAdapter sda = new SqlDataAdapter(select_balance_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            float balance = float.Parse(dt.Rows[0][0].ToString());
            this.label_show_balance.Text = balance.ToString();
        }
    }
}
