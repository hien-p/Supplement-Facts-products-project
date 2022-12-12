using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongHienCoop.db
{
     public abstract class dbConnection
    {
        private readonly string connectionString;

        public dbConnection()
        {
            connectionString = @"server=PREMIUM-131\SQLEXPRESS;database=PhongHienCoop;integrated security=true;";
        }

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
