using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Server.Database
{
    class VisitTypesCrud
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// A method that allows to add visit type to database
        /// </summary>
        /// <param name="type"></param>
        /// <param name="duration"></param>
        /// <param name="price"></param>
        /// <returns>true if visit type added successfully, false else</returns>
        public bool AddVisitType(string type, int duration, float price)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string addVisitTypeQuery = "INSERT INTO VisitTypes " +
                                          $"VALUES ('{type}',{duration},{price.ToString(System.Globalization.CultureInfo.InvariantCulture)});";
                SqlCommand command = new SqlCommand(addVisitTypeQuery, _connection);
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
        /// A method that allow to read table visitTypes
        /// </summary>
        /// <returns>visitTypes table parsed to json string</returns>
        public string GetAllVisitTypes()
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getVisitTypesQuery = "SELECT * " +
                                            "FROM VisitTypes;";
                SqlDataAdapter adapter = new SqlDataAdapter(getVisitTypesQuery, _connection);
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
        /// A method that allows to update visitType
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="duration"></param>
        /// <param name="price"></param>
        /// <returns>true if updated successfully, false else</returns>
        public bool UpdateVisitType(int id, string type, int duration, float price)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateVisitTypeQuery = "UPDATE VisitTypes " +
                                            $"SET Type =  '{type}', " +
                                            $"Duration = {duration}, " +
                                            $"Price = {price.ToString(System.Globalization.CultureInfo.InvariantCulture)} " +
                                            $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updateVisitTypeQuery, _connection);
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
        /// A method that allows to delete visitType
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if deleted successfully, false else</returns>
        public bool DeleteVisitType(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string deleteVisitTypeQuery = "DELETE VisitTypes " +
                                              $"Where Id = {id};";
                SqlCommand command = new SqlCommand(deleteVisitTypeQuery, _connection);
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
