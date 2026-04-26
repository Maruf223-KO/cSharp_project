using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management
{
    class Person
    {

        public int Userid { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }

        public Person(int userid,string name,string phone, string email,string address)
        {
            this.Userid = userid;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            
        }

    }
}
