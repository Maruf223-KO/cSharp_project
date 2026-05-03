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
            string insert_query ="insert into Customer values ('"+txt_CustomerId.Text+"','"+txt_Name.Text+ "','" + txt_Phone.Text + "','" + txt_Email.Text+ "','" + combox_Sex.Text + "','" + txt_Address.Text+"','"+txt_Branch.Text+"','"+txt_userId.Text+"')";
            SqlCommand cmd = new SqlCommand(insert_query,con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Insertion completed");
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
            this.txt_userId.Text = _UserId;
            this.txt_userId.ReadOnly=true;
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

       
    }
}
