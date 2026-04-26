using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management
{
    class Employee : Person
    {

        public int EmployeeId
        {
            get;
            set;
        }

        public string Position
        {
            get;
            set;
        }
        public double Salary
        {
            set;
            get;
        }
        public int BranchId
        {
            get;
            set;

        }

        public Employee(string name,string email,string position,int phone,double salary,string address,int branchId) : base(name, email,address,phone)
        {
            this.Position = position;
            this.Salary = salary;
            this.BranchId = branchId;

        }

    }
}
