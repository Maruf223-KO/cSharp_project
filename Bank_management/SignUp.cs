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
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog = Bank; Integrated Security = True";
        
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.txt_UserId.Text = "";
            this.txt_Password.Text = "";
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string insert_query = "insert into Login values ('" + txt_UserId.Text + "','" + txt_Password.Text + "',3,0)";
            SqlCommand cmd = new SqlCommand(insert_query, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sign up completed");
                    new CustomerRegister().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to sign Up");

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Database is closed");
            }



        }

        private void txt_UserId_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string search_query = "select UserId from Login where UserId = '"+txt_UserId.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(search_query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count==1)
            {
                this.label_Status.ForeColor = Color.Red;
                this.label_Status.Text = "User Id is already taken";

                
               
            }
            else
            {
                this.label_Status.ForeColor = Color.Green;
                this.label_Status.Text = "User Id is avaliable";
               

            }

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (txt_Password.Text.Length < 5)
            {

                label_SignUp_password.Text = "Password must be 5 chartacter";
                label_SignUp_password.ForeColor = Color.Red;
                btn_Signup.Enabled = false;
            }
            else
            {
                label_SignUp_password.Text = "Length is perfect";
                label_SignUp_password.ForeColor = Color.Green;
                btn_Signup.Enabled = true;
            }
        }
    }
}
