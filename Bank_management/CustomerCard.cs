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
    public partial class CustomerCard : Form
    {
        string connection_string = @"Data Source=DESKTOP-S9F74LP\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
        public CustomerCard()
        {
            InitializeComponent();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection_string);
            string cardId = IdGenerator.NewCardID(con);
            float amount = float.Parse("mam");
            //string insert_query = "insert into Card values('" + cardId + "','" + amount + "',5,'" + int.Parse(combobox_Duration.Text) + "','Pending',(select CustomerId from Customer where UserId='" + userId + "'))";
            string insert_query = "insert into Loan values()";
            SqlCommand cmd = new SqlCommand(insert_query, con);
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
    }
}
