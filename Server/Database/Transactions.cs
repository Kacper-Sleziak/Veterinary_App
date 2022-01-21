using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Server.Database
{
    /// <summary>
    /// A class that allows you to query a database 
    /// </summary>
    class Transactions
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
        public bool Register(string login, string password, string firstName, string lastName, DateTime birthday,
            string email, int phone)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                CredentialsCrud credentrals = new CredentialsCrud();
                PersonalDataCrud personalData = new PersonalDataCrud();
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
                        $"VALUES ('{firstName}', '{lastName}', '{birthday.ToString("yyyy-MM-dd")}', {phone}, '{email}', 0);";
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
        /// Overload for Register method allowing to register new Employee 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="jobName"></param>
        /// <returns>true if employee was registered successfully, false else</returns>
        public bool Register(string login, string password, string firstName, string lastName, DateTime birthday,
            string email, int phone, string jobName)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();

                string queryGetLogin =
                    "SELECT COUNT(*) " +
                    "FROM Credentials " +
                    $"WHERE Login = '{login}';";

                SqlCommand command = new SqlCommand(queryGetLogin, _connection);
                int foundLogin = (int)command.ExecuteScalar();

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
                        $"VALUES ('{firstName}', '{lastName}', '{birthday.ToString("yyyy-MM-dd")}', {phone}, '{email}', 0);";
                    command = new SqlCommand(queryInsertPersonalData, _connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    // Get id of new personal data
                    string queryGetPersonalDataId =
                        "SELECT MAX(Id) " +
                        "FROM PersonalData;";
                    command = new SqlCommand(queryGetPersonalDataId, _connection);
                    command.Transaction = transaction;
                    int personalDataId = (int)command.ExecuteScalar();

                    // Insert credentials
                    string queryInsertCredentials =
                        "INSERT INTO Credentials " +
                        $"VALUES ('{login}', '{password}', {personalDataId});";
                    command = new SqlCommand(queryInsertCredentials, _connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    // Insert Employee
                    string queryInsertEmployee =
                        "INSERT INTO Employees " +
                        $"VALUES ('{jobName}', '{personalDataId}');";
                    command = new SqlCommand(queryInsertEmployee, _connection);
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

        /// <summary>
        /// A method that allows you to check if user with given PersonalDataId is employee.
        /// </summary>
        /// <param name="personalDataId"></param>
        /// <returns>JobName if user is employee, "użytkownik" else</returns>
        public string IsEmployee(int personalDataId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string isEmployeeQuery = "SELECT COUNT(*) " +
                                         "FROM Employees " +
                                         $"WHERE PersonalDataId = {personalDataId};";
                SqlCommand command = new SqlCommand(isEmployeeQuery, _connection);
                int foundEmployee = (int) command.ExecuteScalar();
                if (foundEmployee < 1)
                    return "uzytkownik";
                isEmployeeQuery = "SELECT JobName " +
                                  "FROM Employees " +
                                  $"WHERE PersonalDataId='{personalDataId}';";
                command = new SqlCommand(isEmployeeQuery, _connection);
                string jobName = command.ExecuteScalar().ToString();
                return jobName;
            }
        }   

        public bool addNewVisit(int freeTermId, int visitTypeId, int animalId, int vetId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getVisitDuration = "SELECT Duration " +
                                          "FROM VisitTypes " +
                                          $"WHERE Id = {visitTypeId};";
                SqlCommand command = new SqlCommand(getVisitDuration, _connection);
                int duration = (int)command.ExecuteScalar();
                bool isFree = true;S
                for (int i = freeTermId; i < freeTermId + duration; i++)
                {
                    string checkAvailability  = "SELECT Status " +
                                                "FROM FreeTerms " +
                                                $"WHERE Id = {i};";
                    command = new SqlCommand(checkAvailability, _connection);
                    if (!(bool) command.ExecuteScalar())
                        isFree = false;
                }

                if (!isFree)
                    return false;

                SqlTransaction transaction = _connection.BeginTransaction("VisitTransaction");
                try
                {
                    for (int i = freeTermId; i < freeTermId + duration; i++)
                    {
                        string setAvailability = "Update FreeTerms " +
                                                 $"Set Status = {false}" +
                                                 $"WHERE Id = {i};";
                        command = new SqlCommand(setAvailability, _connection);
                        command.Transaction = transaction;
                        command.ExecuteNonQuery();
                    }
                    string getDate = "SELECT Date " + 
                                     "FROM FreeTerms " +
                                     $"WHERE Id = {freeTermId};";
                    command = new SqlCommand(getDate, _connection);
                    command.Transaction = transaction;
                    DateTime date = (DateTime) command.ExecuteScalar();

                    string addVisit = "INSERT INTO Visits " +
                                      $"VALUES ('{date:u}',{visitTypeId},{animalId}, {vetId});";
                    command = new SqlCommand(addVisit, _connection);
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

        public bool CancelVisit(int visitId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getVisitDuration = "SELECT vt.Duration " +
                                          "FROM VisitTypes vt " +
                                          "JOIN Visits v ON v.Id " +
                                          $"WHERE v.Id = {visitId};";

                SqlCommand command = new SqlCommand(getVisitDuration, _connection);
                int duration = (int)command.ExecuteScalar();


                string getVisitDate = "SELECT Date " +
                                      "FROM Visits " +
                                      $"WHERE Id = {visitId}";
                
                command = new SqlCommand(getVisitDate, _connection);

                DateTime visitStartDate = (DateTime)command.ExecuteScalar();
                DateTime visitEndDate = visitStartDate.AddMinutes((double)duration*1);

                SqlTransaction transaction = _connection.BeginTransaction("CanelVisitTransaction");

                try
                {
                    string updateFreeTerms = "UPDATE FreeTerms " +
                                             "SET Status = 0 " +
                                             $"WHERE Date >= {visitStartDate:u} and Date < {visitEndDate:u};";

                    command = new SqlCommand(updateFreeTerms, _connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    string deleteVisitQuery = "DELETE Visits " +
                                              $"Where Id = {visitId};";

                    command = new SqlCommand(deleteVisitQuery, _connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records were changed in database.");
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

        public bool Order(int ownerId, DateTime date, string city, int zipCode, string street, string delivery, string apartment, string status, List<int> productId, List<int> productAmount)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string createOrderQuery = "INSERT INTO Orders " +
                                          $"VALUES {ownerId}, {date}, '{city}', {zipCode}, '{street}, '{delivery}', '{apartment}', '{status}';";


                SqlTransaction transaction = _connection.BeginTransaction("Order");

                try
                {
                    SqlCommand command = new SqlCommand(createOrderQuery, _connection);
                    
                    int amountOfOrderedProducts = productId.Count;
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    string getOrderQuery = "SELECT OrderId " +
                                      "FROM Orders " +
                                      $"WHERE OwnerId = {ownerId} and Date = {date:u};";

                    command = new SqlCommand(getOrderQuery, _connection);
                    command.Transaction = transaction;
                    
                    int orderId = (int)command.ExecuteScalar();

                    for (var i = 0; i < amountOfOrderedProducts; i++)
                    {
                        string createOrderedProductQuery = "INSERT Into OrderedProducts " +
                                                           $"VALUES {productId[i]} {productAmount[i]} {orderId};";
                        
                        command = new SqlCommand(createOrderedProductQuery, _connection);
                        command.Transaction = transaction;
                        command.ExecuteNonQuery();

                        string getAmountOfProductQuery = "SELECT Amount " +
                                                    "FROM Products " +
                                                    $"WHERE id = {productId[i]};";
                        
                        command = new SqlCommand(getAmountOfProductQuery, _connection);
                        command.Transaction = transaction;
                        int amountOfProduct = (int) command.ExecuteScalar();
                        
                        amountOfProduct -= productAmount[i];

                        string updateProductsQuery = "UPDATE Products " +
                                                     $"SET Amount = {amountOfProduct} " + 
                                                     $"WHERE id = {productId[i]};";
                        
                        command = new SqlCommand(updateProductsQuery, _connection);
                        command.Transaction = transaction;
                        command.ExecuteNonQuery();

                        
                    }

                    Console.WriteLine("All records were changed in datanase");
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

        public void ReloadFreeTerms()
        {
            using (_connection)
            {
                _connection.Open();
                DateTime actualDate = DateTime.Now;

                String deleteFreeTermsQuery = "DELETE FreeTerms " +
                                              $"WHERE Date <= {actualDate:u}";
                SqlCommand command = new SqlCommand(deleteFreeTermsQuery, _connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                }
            }
        }
    }
}
