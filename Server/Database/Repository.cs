﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Server.Database
{
    /// <summary>
    /// A class that allows you to query a database 
    /// </summary>
    class Repository
    {
        // A variable that allows you to connect to database
        private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);
        
        /// <summary>
        /// A method that allows you to register new user if login wasn't used yet
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool RegisterUser(string login, string password, string firstName, string lastName, DateTime birthday, string email, int phone)
        {
            using (_connection)
            {
                _connection.Open();

                string queryGetLogin =
                    "SELECT COUNT(*) " +
                    "FROM Credentials " +
                    $"WHERE Login = '{login}';";

                SqlCommand command = new SqlCommand(queryGetLogin, _connection);
                int foundLogin = (int) command.ExecuteScalar();
                // If given login occur in database return false and end method
                if (foundLogin != 0)
                {
                    Console.WriteLine("Given login was taken.");
                    return false;
                }


                SqlTransaction transaction = _connection.BeginTransaction("SampleTransaction");
                try
                {
                    // Insert personal data
                    string queryInsertPersonalData =
                        "INSERT INTO PersonalData " +
                        $"VALUES ('{firstName}', '{lastName}', {birthday}, '{email}, {phone});";
                    command = new SqlCommand(queryInsertPersonalData, _connection);
                    command.ExecuteNonQuery();
                    // Get id of new personal data
                    string queryGetPersonalDataId =
                        "SELECT MAX(Id) " +
                        "FROM PersonalData;";
                    command = new SqlCommand(queryGetPersonalDataId, _connection);
                    int personalDataId = (int) command.ExecuteScalar();
                    // Insert credentials
                    string queryInsertCredentials =
                        "INSERT INTO Credentials " +
                        $"VALUES ('{login}', '{password}', {personalDataId});";
                    command = new SqlCommand(queryInsertCredentials, _connection);
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                        return false;
                    }
                }
            }
        }
    }
}