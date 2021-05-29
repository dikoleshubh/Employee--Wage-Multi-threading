using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMultiThreading
{
   public class DBConnection
    {
        public SqlConnection GetConnection()
        {

            //Specifying the connection string from the sql server connection
            string connectionString = @"Data Source=LAPTOP-NAVJ6800\SQLEXPRESS;Initial Catalog=EmployeePayroll";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
