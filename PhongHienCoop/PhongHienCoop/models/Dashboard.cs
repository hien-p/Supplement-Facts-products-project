using PhongHienCoop.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongHienCoop.models
{
    public class Dashboard : dbConnection
    {
        
        public String TotalProfit { get; set; }
        public long TotalRevenue { get; set; }

        public int Numberoforders { get; set; }

        public int Numberofagents { get; set; }

        public int Numberofproducts { get; set; }

        public List<KeyValuePair<int, int>> TopProductsList { get; set; }


        // private methods
        private void getnumberorders()
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    // query orders 
                    String order_query = "select count(*) as order_id  from Orders";
                    command.CommandText = order_query;
                    Numberoforders = (int)command.ExecuteScalar();

                    // query products 
                    String Product_query = " select COUNT(product_id) from Products";
                    command.CommandText = Product_query;
                    Numberofproducts = (int)command.ExecuteScalar();


                    // query agents 
                    String Agents_query = "select count(agent_id) as agent_id  from Agents";
                    command.CommandText = Agents_query;
                    Numberofagents = (int)command.ExecuteScalar();

                }
            }

        }

        private void getorderanalysis()
        {
            
            TotalRevenue = 0;
            
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select product_id, SUM(CAST(price AS BIGINT)) * SUM(CAST(quantity AS BIGINT)) as revenue from [Orders] group by product_id order by product_id desc";


                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TotalRevenue += (long)reader[1];
                        }

                    }
                    reader.Close();
                }

                using (var command2 = new SqlCommand())
                {
                    command2.Connection = connection;
                    command2.CommandText = @"select sum(g.quantity*(w.price_out - w.price_in)) as profit  from Warehouse w, GoodsDeliveryNote g  where w.product_id = g.products_id";
                   
                    var reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        TotalProfit = reader[0].ToString();
                        break;
                    }


                }

            }
        }

        private void Top5product()
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @" select product_id, sum(quantity) 
                                        from [Orders] group by product_id order by product_id desc";

                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // TotalRevenue += (decimal)reader[0];
                            TopProductsList.Add(new KeyValuePair<int, int>((int)reader[0], (int)reader[1]));
                        }

                    }

                    reader.Close();
                }


            }


        }


        public void loaddata()
        {

            getnumberorders();
            getorderanalysis();
      
        }

    }

}
