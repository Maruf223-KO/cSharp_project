using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_management
{
    class Customer : Person
    {
        public int Customerid { get; set; }

        public Customer(int userid, int customerid, string name, string phone, string email, string address, string position, double salary, int branchId) : base(userid, name, phone, email, address)
        {
            this.Customerid = customerid;
        }

    }
}
