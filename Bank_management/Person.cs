using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management
{
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public Person(string name,string email,int phone)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

    }
}
