using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bank_management
{
    static class IdGenerator
    {
        private static string Generate(SqlConnection conn,string table,string column,string prefix,int start)
        {
            string search_query = "SELECT MAX(CAST(REPLACE(" + column + ",'" + prefix + "','') AS INT)) FROM " + table;
            SqlDataAdapter sda = new SqlDataAdapter(search_query,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0]==DBNull.Value)
            {
                return prefix+"1000";
                
            }
            string lastId = dt.Rows[0][0].ToString();
            int lastNum = int.Parse(lastId);
            return prefix + (lastNum + 1);

        }
        public static string NewAccountID(SqlConnection conn)
        {
            return Generate(conn, "Account", "AccountId", "ACC", 1000);
        }
       

        // Customer ID → CUST2000, CUST2001 ...
        public static string NewCustomerID(SqlConnection conn)
        {
            return Generate(conn, "Customer", "CustomerId", "CUST", 2000);
        }
           

        // Transaction ID → TXN3000, TXN3001 ...
        public static string NewTransactionID(SqlConnection conn)
        {
            return Generate(conn, "Transactions", "TransactionId", "TXN", 3000);
        }
            

        // Loan ID → LOAN4000, LOAN4001 ...
        public static string NewLoanID(SqlConnection conn)
        {
           return Generate(conn, "Loan", "LoanId", "LOAN", 4000);
        }
            

        // Employee ID → EMP5000, EMP5001 ...
        public static string NewEmployeeID(SqlConnection conn)
        {
            return Generate(conn, "Employee", "EmployeeId", "EMP", 5000);
        }
            

        // Card ID → CARD6000, CARD6001 ...
        public static string NewCardID(SqlConnection conn)
        {
            return Generate(conn, "Card", "CardId", "CARD", 6000);
        }
           

    }
}
