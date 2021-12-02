﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Server.Database
{
    /// <summary>
    /// A class that allows you to query a database 
    /// </summary>
    class Repository
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// A method that allows you to register new user if login wasn't used yet
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <returns>true if user was registered successfully, false else</returns>
        public bool RegisterUser(string login, string password, string firstName, string lastName, DateTime birthday,
            string email, int phone)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
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


                SqlTransaction transaction = _connection.BeginTransaction("RegisterTransaction");
                try
                {
                    // Insert personal data
                    string queryInsertPersonalData =
                        "INSERT INTO PersonalData " +
                        $"VALUES ('{firstName}', '{lastName}', '{birthday.ToString("yyyy-MM-dd")}', {phone}, '{email}');";
                    command = new SqlCommand(queryInsertPersonalData, _connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    // Get id of new personal data
                    string queryGetPersonalDataId =
                        "SELECT MAX(Id) " +
                        "FROM PersonalData;";
                    command = new SqlCommand(queryGetPersonalDataId, _connection);
                    command.Transaction = transaction;
                    int personalDataId = (int) command.ExecuteScalar();

                    // Insert credentials
                    string queryInsertCredentials =
                        "INSERT INTO Credentials " +
                        $"VALUES ('{login}', '{password}', {personalDataId});";
                    command = new SqlCommand(queryInsertCredentials, _connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return true;
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

        /// <summary>
        /// A method that allows you to check if user entered correct credentials.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>PersonalDataId if user exist, -1 else</returns>
        public int Login(string login, string password)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string loginQuery = "SELECT COUNT(*) " +
                                    "FROM Credentials " +
                                    $"WHERE Login='{login}' AND Password='{password}';";
                SqlCommand command = new SqlCommand(loginQuery, _connection);
                int foundCredentials = (int)command.ExecuteScalar();
                if (foundCredentials < 1)
                    return -1;
                loginQuery = "SELECT PersonalDataId " +
                             "FROM Credentials " +
                             $"WHERE Login='{login}' AND Password='{password}';";
                command = new SqlCommand(loginQuery, _connection);
                int personalDataId = (int)command.ExecuteScalar();
                return personalDataId;
            }

        }
    }
}
