using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Server.Database
{
    class ProductsCrud
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// A method that allows to add product to database
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="price"></param>
        /// <returns>true if product added successfully, false else</returns>
        public bool AddProduct(string type, string name, int amount, float price)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string addProductQuery = "INSERT INTO Products " +
                                         $"VALUES ('{type}','{name}',{amount},'{price.ToString(System.Globalization.CultureInfo.InvariantCulture)}');";
                SqlCommand command = new SqlCommand(addProductQuery, _connection);
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

        /// <summary>
        /// A method that allow to read table products
        /// </summary>
        /// <returns>products table parsed to json string</returns>
        public string GetAllProducts()
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getProductsQuery = "SELECT * " +
                                          "FROM Products;";
                SqlDataAdapter adapter = new SqlDataAdapter(getProductsQuery, _connection);
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

        /// <summary>
        /// A method that allows to update product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="price"></param>
        /// <returns>true if updated successfully, false else</returns>
        public bool UpdateProduct(int id, string type, string name, int amount, float price)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateProductQuery = "UPDATE Products " +
                                            $"SET Type =  '{type}', " +
                                            $"Name = '{name}', " +
                                            $"Amount = {amount}, " +
                                            $"Price = {price.ToString(System.Globalization.CultureInfo.InvariantCulture)} " +
                                            $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updateProductQuery, _connection);
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

        /// <summary>
        /// A method that allows to delete product
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if deleted successfully, false else</returns>
        public bool DeleteProduct(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string deleteProductQuery = "DELETE Products " +
                                            $"Where Id = {id};";
                SqlCommand command = new SqlCommand(deleteProductQuery, _connection);
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
    }
}