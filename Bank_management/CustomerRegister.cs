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
        
        public CustomerRegister()
        {
            InitializeComponent();
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
    }
}
