using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Server.Database
{
    class CredentialsCrud
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// A method that allows to add credentials to database
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="personalDataId"></param>
        /// <returns>true if personal data added successfully, false else</returns>
        public bool AddCredentials(string login, string password, int personalDataId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string queryInsertCredentials = "INSERT INTO Credentials " +
                                                $"VALUES ('{login}', '{password}', {personalDataId});";
                SqlCommand command = new SqlCommand(queryInsertCredentials, _connection);
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
        /// A method that allow to read table credentials
        /// </summary>
        /// <param name="id"></param>
        /// <returns>personal data of given person id parsed to json string</returns>
        public string GetCredentials(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getCredentialsQuery = "SELECT * " +
                                              "FROM Credentials " +
                                              $"WHERE Id = {id};";
                SqlDataAdapter adapter = new SqlDataAdapter(getCredentialsQuery, _connection);
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
        /// A method that allows to update credentials
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="personalDataId"></param>
        /// <returns>true if updated successfully, false else</returns>
        public bool UpdateCredentials(int id, string login, string password, int personalDataId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateCredentialsQuery = "UPDATE PersonalData " +
                                            $"SET Login =  '{login}', " +
                                            $"Password = '{password}', " +
                                            $"PersonalDataId = '{personalDataId}' " +
                                            $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updateCredentialsQuery, _connection);
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
        /// A method that allows to delete personal data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if deleted successfully, false else</returns>
        public bool DeletePersonalData(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string deleteCredentialsQuery = "DELETE Credentials " +
                                                 $"Where Id = {id};";
                SqlCommand command = new SqlCommand(deleteCredentialsQuery, _connection);
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
