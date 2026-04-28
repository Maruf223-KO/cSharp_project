using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_management
{
    public partial class CustomerRegister : Form
    {
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
            
        }
    }
}
