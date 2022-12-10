using PhongHienCoop.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongHienCoop.models
{
    public  class Dashboard: dbConnection
    {
        private DateTime startDate; 
        private DateTime endDate;   
       

        public int Numberoforders { get; set; }

        public int Numberofagents { get; set;  }

        public int Numberofproducts {  get; set; }
        
        public List<KeyValuePair<String, int>> TopProductsList { get; set; }


        // private methods
        private int getnumberorders()
        {
          

            using (var connection = GetSqlConnection())
            {
                //int orders = 0;

                


                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;

                    // query orders 
                    String order_query = "select count(*) as order_id  from Orders";
                    command.CommandText = order_query;
                    Numberoforders = Convert.ToInt32(command.ExecuteScalar());

                    // query products 
                    String Product_query = "select count(*) as order_id  from Products";
                    command.CommandText = Product_query;
                    Numberofproducts = Convert.ToInt32(command.ExecuteScalar());


                    // query agents 
                    String Agents_query = "select count(*) as order_id  from Agents";
                    command.CommandText = Agents_query;
                    Numberofagents = Convert.ToInt32(command.ExecuteScalar());

                }
                
               
              
                var rows_affected = cmd.ExecuteReader();
                /*if (rows_affected.HasRows)
                {
                    while (rows_affected.Read())
                    {
                        orders = rows_affected.GetInt32(0);
                                         
                    }
                }*/

                return orders;
            }
    
    }

}
