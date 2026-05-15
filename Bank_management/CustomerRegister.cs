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
    public partial class CustomerRegister : Form
    {
        string connectionString = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog = Bank; Integrated Security = True";

        private string _UserId;
        private string _customerId;


        DateTime dt = DateTime.Today;
        public CustomerRegister(string passedUserID )
        {
            InitializeComponent();
            this._UserId = passedUserID;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Name.Text = " ";
            txt_Address.Text = " ";
            txt_Email.Text = " ";
            txt_Phone.Text = " ";
            combox_Sex.Text = " ";
          
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionString);
            string insert_query ="insert into Customer values ('"+_customerId+"','"+txt_Name.Text+ "','" + txt_Phone.Text + "','" + txt_Email.Text+ "','" + combox_Sex.Text + "','" + txt_Address.Text+"','"+txt_Branch.Text+"','"+txt_userId.Text+"')";
            SqlCommand cmd = new SqlCommand(insert_query,con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sucessfully submitted.Please wait for to review your information");
                    
                    string accountId=IdGenerator.NewAccountID(con);
                    string insert_account_query = "insert into Account values('" + accountId + "',0,'" + dt + "',1,'" + 111 + "','" + _customerId + "')";
                    SqlCommand cmd1 = new SqlCommand(insert_account_query, con);
                    cmd1.ExecuteNonQuery();

                    btn_Clear_Click(sender,e);
                }
                else
                {
                    MessageBox.Show("Insertion not completed");

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Data base connection is closed");
            }
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            _customerId = IdGenerator.NewCustomerID(con);
            this.txt_userId.Text = _UserId;
            this.txt_userId.ReadOnly=true;
            this.txt_CustomerId.Text = _customerId;

        }



        private void CustomerRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ans = MessageBox.Show("Your user ID will be deleted","Confirm", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectionString);
                string delete_query = "delete from Login where UserId='" + txt_userId.Text + "'";
                SqlCommand cmd = new SqlCommand(delete_query, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Deletion completed");
                        
                    }
                    else
                    {
                        MessageBox.Show("Deletion is not completed");

                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Data base connection is closed");
                }
            }
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                this.label_warphone.Text = "Must be Number";
                this.label_warphone.ForeColor = Color.Red;
            }
            else
            {
                this.label_warphone.Text = "";
            }
            
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_Phone.Text.Length < 11)
            {
                this.label_warphone.Text = "Must be 11 number";
                this.label_warphone.ForeColor = Color.Red;
            }
        }
    }
}
