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
    public partial class Loan : Form
    {
        string connection_string = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
        
        private string UserId
        {
            get;
            set;
        }
        public Loan(string id)
        {
            InitializeComponent();
            this.UserId = id;
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);
            string select_query = "select * from Loan";
            SqlDataAdapter sda = new SqlDataAdapter(select_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data_grid_loan.DataSource = dt;
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);
            string loanId = IdGenerator.NewLoanID(con);
            float amount = float.Parse(txt_Amount.Text);
            string insert_query = "insert into Loan values('" + loanId + "','" + amount + "',5,'" + int.Parse(combobox_Duration.Text) + "','Pending',(select CustomerId from Customer where UserId='" + UserId + "'))";
            
            //string insert_query = "insert into Loan values('" + loanId + "','" + amount + "',5,'" + combobox_Duration.Text + "',Pending,Mar123)";
            SqlCommand cmd = new SqlCommand(insert_query,con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Loan request submitted");
                    
                }
                else
                {
                    MessageBox.Show("Loan request failed");

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Database is closed");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_Amount.Text = "";
            this.combobox_Duration.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboard c2 = new CustomerDashboard(UserId);
            c2.Show();
        }
    }
}
