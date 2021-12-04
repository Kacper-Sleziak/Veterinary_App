using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Server.Database
{
    class PersonalDataCrud
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// A method that allows to add personal data to database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <returns>true if personal data added successfully, false else</returns>
        public bool AddPersonalData(string firstName, string lastName, DateTime birthday,  int phone, string email)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string addPersonalDataQuery = "INSERT INTO PersonalData " +
                                              $"VALUES ('{firstName}', '{lastName}', '{birthday:yyyy-MM-dd}', {phone}, '{email}');";
                SqlCommand command = new SqlCommand(addPersonalDataQuery, _connection);
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
        /// A method that allow to read table personal data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>personal data of given person id parsed to json string</returns>
        public string GetPersonalData(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getPersonalDataQuery = "SELECT * " +
                                              "FROM PersonalData " +
                                              $"WHERE Id = {id};";
                SqlDataAdapter adapter = new SqlDataAdapter(getPersonalDataQuery, _connection);
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
        /// A method that allows to update personal data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <returns>true if updated successfully, false else</returns>
        public bool UpdatePersonalData(int id, string firstName, string lastName, DateTime birthday, int phone, string email)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updatePersonalDataQuery = "UPDATE PersonalData " +
                                            $"SET FirstName =  '{firstName}', " +
                                            $"LastName = '{lastName}', " +
                                            $"Birthday = '{birthday:yyyy-MM-dd}', " +
                                            $"Phone = {phone}, " +
                                            $"Email = '{email}' " +
                                            $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updatePersonalDataQuery, _connection);
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
                string deletePersonalDataQuery = "DELETE PersonalData " +
                                                 $"Where Id = {id};";
                SqlCommand command = new SqlCommand(deletePersonalDataQuery, _connection);
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
