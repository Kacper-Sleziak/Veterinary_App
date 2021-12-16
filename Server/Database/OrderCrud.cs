using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Server.Database
{
    class OrderCrud
    {

        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        public string GetOrdersOfClient(int clientId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getClientOrders = "SELECT * " +
                                          "FROM Orders " +
                                          $"WHERE OwnerId = {clientId};";
                SqlDataAdapter adapter = new SqlDataAdapter(getClientOrders, _connection);
                DataTable table = new DataTable();
                try
                {
                    adapter.Fill(table);
                    string temp = JsonConvert.SerializeObject(table);
                    return temp;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    return "";
                }
            }
        }
    }
}
