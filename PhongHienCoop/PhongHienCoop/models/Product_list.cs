using PhongHienCoop.db;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace PhongHienCoop.models
{
    public class Product_list : dbConnection
    {


        public List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();

        public Dictionary<string, string> column;

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string agentsname { get; set; }
        public string phone { get; set; }


        private void deleviry_info()
        {

            using (var connection = GetSqlConnection())
            {
               connection.Open();
               using (var command = new SqlCommand())
                {
                    command.Connection= connection;

                    String query = "select * from orders";
                    command.CommandText = query;

                    var rows_affected = command.ExecuteReader();
                    while (rows_affected.Read())
                    {
                        column = new Dictionary<string, string>();
                        column["order_id"] = rows_affected["order_id"].ToString();
                        column["order_date"] = rows_affected["order_date"].ToString();

                        
                        rows.Add(column);
                    }
                }
                connection.Close();
            }


        }



        public DataTable orders()
        {
            DataTable data = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    String query = "select * from orders";
                    command.CommandText = query;
                    SqlDataAdapter sqldat = new SqlDataAdapter(query, connection);
                    sqldat.Fill(data);
                }


            }
                return data;
        }


        public DataTable info_name(String Id)
        {
            DataTable data2 = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                string bookDetails = String.Format("select * from Products where Products.product_id = {0}", Id);
                SqlDataAdapter da = new SqlDataAdapter(bookDetails, connection);
                da.Fill(data2);
                
            }
            
            return data2;
        
        
        }

        public DataTable info_name_agent(String Id)
        {
            DataTable data2 = new DataTable();
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                string bookDetails = String.Format("select * from Agents  where Agents.agent_id = {0}", Id);
                SqlDataAdapter da = new SqlDataAdapter(bookDetails, connection);
                da.Fill(data2);

            }

            return data2;


        }

        public void loaddata()
        {
            deleviry_info();
        }


    }
}
