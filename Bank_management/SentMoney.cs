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
    public partial class SentMoney : Form
    {
        string connectionString= @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog = Bank; Integrated Security = True";

        DateTime date_Time = DateTime.Now;
        
        private string Userid
        {
            get;
            set;
        }
        public SentMoney(string id)
        {
            InitializeComponent();
            
            Userid = id;
        }

        private int txt_ReceiverAccount_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string search_query = "select AccountId from Account where AccountId = '" + txt_ReceiverAccount.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(search_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.label_AccountFind.ForeColor = Color.Green;
                this.label_AccountFind.Text = "Account exist";

                return 1;

            }
            else
            {
                this.label_AccountFind.ForeColor = Color.Red;
                this.label_AccountFind.Text = "NO account found";

                return 0;
            }
        }

        private void btn_Sent_Click(object sender, EventArgs e)
        {
            if (txt_ReceiverAccount_Leave(sender, e) == 0)
            {
                MessageBox.Show("Given account id is not found");
            }
            else
            {
                float balance = float.Parse(txt_Amount.Text);
                SqlConnection con = new SqlConnection(connectionString);
                string balance_query = "select Balance from Account where AccountId='" + txt_SenterAccount.Text + "' or AccountId='"+txt_ReceiverAccount.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(balance_query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                float senterMoney = float.Parse(dt.Rows[0][0].ToString());
                float receiverMoney = float.Parse(dt.Rows[1][0].ToString());
                if (senterMoney < balance)
                {
                    MessageBox.Show("Do not have sufficient balance");
                }
                else
                {
                    
                    receiverMoney += balance;
                    senterMoney -= balance;
                    string update_senter_query = "update Account set balance='"+senterMoney+"' where AccountId = '"+txt_SenterAccount.Text+"'";
                    string update_receiver_query = "update Account set balance='"+receiverMoney+"' where AccountId = '" + txt_ReceiverAccount.Text + "'";
                    string transactionId = IdGenerator.NewTransactionID(con);
                    string insert_transaction_query = "insert into Transactions values ('"+txt_SenterAccount.Text+"','"+txt_ReceiverAccount.Text+"','"+balance+"','COMPLETED','Transfer','"+date_Time.ToString("yyyy-MM-dd HH:mm:ss") +"','Fund transfer to account:"+txt_ReceiverAccount.Text+"')";
                    SqlCommand sql3 = new SqlCommand(update_senter_query,con);
                    SqlCommand sql4 = new SqlCommand(update_receiver_query,con);
                    SqlCommand sql5 = new SqlCommand(insert_transaction_query, con);
                    
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        sql3.ExecuteNonQuery();
                        sql4.ExecuteNonQuery();
                        sql5.ExecuteNonQuery();



                    }
                    else
                    {
                        MessageBox.Show("Update is not sucessful");
                    }
                    con.Close();
                }
                
                
            }
        }

        private void SentMoney_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string select_account_query = "select AccountId from Account where CustomerId= (select CustomerId from Customer where UserId='" + Userid + "')";
            SqlDataAdapter sda = new SqlDataAdapter(select_account_query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string accountId = dt.Rows[0][0].ToString();
            this.txt_SenterAccount.Text = accountId;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_ReceiverAccount.Text = "";
            this.txt_Amount.Text = "";
            this.label_AccountFind.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboard cd = new CustomerDashboard(Userid);
            cd.Show();
            
        }
    }
}
