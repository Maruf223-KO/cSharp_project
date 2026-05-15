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
    public partial class EmployeeLoan : Form
    {
        string connection_string = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog = Bank; Integrated Security = True";
        string loanId = "";
        float requestedMoney = 0;
        string customerID;
        //DateTime date_Time = DateTime.Now();
        public EmployeeLoan()
        {
            InitializeComponent();
        }

        private void EmployeeLoan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);
            string select_query = "select * from Loan";
            SqlDataAdapter sda = new SqlDataAdapter(select_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridloanemployee.DataSource = dt;
        }

        private void datagridloanemployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridloanemployee.Rows[e.RowIndex];
            loanId = selectedRow.Cells[0].Value.ToString();
            requestedMoney = float.Parse(selectedRow.Cells[1].Value.ToString());
            customerID = selectedRow.Cells[5].Value.ToString();

           
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(connection_string);
                
            
              
                   
                    string update_status_query = "update Loan set Status='Approved' where LoanId = '" +this.loanId + "'";
            string update_money_query = "UPDATE Account SET Balance = Balance + " + this.requestedMoney + " WHERE CustomerId = (SELECT CustomerId FROM Loan WHERE LoanId='" + this.loanId + "')";
           // string insert_transaction_query = "insert into Transactions values ('(select AccoundId from Account where CustomerId='"+customerID+"')','NULL','" + requestedMoney+ "','COMPLETED','Loan','" + date_Time.ToString("yyyy-MM-dd HH:mm:ss") + "','Loan accepted')";
            SqlCommand sql3 = new SqlCommand(update_status_query, con);
                    SqlCommand sql4 = new SqlCommand(update_money_query, con);

                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        sql3.ExecuteNonQuery();
                        sql4.ExecuteNonQuery();
                MessageBox.Show("Updated sucessfully");

                    }
                    else
                    {
                        MessageBox.Show("Update is not sucessful");
                    }
                    con.Close();
                }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);




            string update_status_query = "update Loan set Status='Rejected' where LoanId = '" + this.loanId + "'";
           
            SqlCommand sql3 = new SqlCommand(update_status_query, con);
           

            con.Open();
            if (con.State == ConnectionState.Open)
            {
                sql3.ExecuteNonQuery();
                
            }
            else
            {
                MessageBox.Show("Update is not sucessful");
            }
            con.Close();
        }
    }
        }
    

