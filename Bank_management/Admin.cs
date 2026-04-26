using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management
{
    class Admin : Person
    {
        public int Adminid { get; set; }
        public Admin(int userid,int adminid,string name,string phone,string email,string address) : base(userid, name, phone, email, address)
        {
            this.Adminid = adminid;
        }

    }
}
