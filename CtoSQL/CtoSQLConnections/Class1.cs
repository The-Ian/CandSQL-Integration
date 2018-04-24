using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CtoSQLConnections
{
    class Class1
    {
        const string ConnString = @"Server=PL6\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True; User ID=AdvWorks2012;Password=1942";
        SqlConnection sqlConn;

        private bool dataConnect(string connectionString = "")
        {
            bool returnValue;

            if (connectionString.Length == 0)
                connectionString = ConnString;

            try
            {
                sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();

                returnValue = true;
            }

            catch (Exception ex)
            {
                returnValue = false;
                throw ex;
            }
            finally
            {
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }

            }

            return returnValue;
        }
    }

    
}
