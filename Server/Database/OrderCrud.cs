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

        public bool UpdateOrder(int id, int ownerId, DateTime date, string city, int zipCode, string street, string delivery, string apartmentNumber,  string status )
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateOrderQuery = "UPDATE OrderedProducts " +
                                                   $"SET Owner =  {ownerId}, " +
                                                   $"Date = {date} " +
                                                   $"City= '{city}' " +
                                                   $"Street = '{street}' " +
                                                   $"Delivery = '{delivery}' " +
                                                   $"ApartmentNumber = {apartmentNumber} " +
                                                   $"Status = '{status}' " +
                                                   $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updateOrderQuery, _connection);
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    return false;
                }
            }
        }

        public string GetAllOrders()
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getOrdersQuery = "SELECT * " +
                                           "FROM Orders;";
                SqlDataAdapter adapter = new SqlDataAdapter(getOrdersQuery, _connection);
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
