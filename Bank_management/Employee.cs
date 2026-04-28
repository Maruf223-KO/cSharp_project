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

        public Employee(int userid,int employeeId,string name,string email,string position,string phone,double salary,string address,int branchId) : base(userid,name,phone,email,address)
        {
            this.EmployeeId = employeeId;
            this.Position = position;
            this.Salary = salary;
            this.BranchId = branchId;

        }

    }
}
