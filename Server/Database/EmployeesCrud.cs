using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Server.Database
{
    class EmployeesCrud
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// A method that allows to add employee to database
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="personalDataId"></param>
        /// <returns>true if employee added successfully, false else</returns>
        public bool AddEmployee(string jobName, int personalDataId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string addEmployeeQuery = "INSERT INTO Employees " +
                                          $"VALUES ('{jobName}',{personalDataId});";
                SqlCommand command = new SqlCommand(addEmployeeQuery, _connection);
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
        /// A method that allow to read table employees
        /// </summary>
        /// <returns>employees table parsed to json string</returns>
        public string GetAllEmployees()
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getEmployeesQuery = "SELECT Employees.Id, Employees.JobName, PersonalData.FirstName, PersonalData.LastName, PersonalData.Email, PersonalData.Phone, PersonalData.Id " +
                                           "FROM Employees " +
                                           "JOIN PersonalData ON Employees.PersonalDataId = PersonalData.Id " +
                                           "WHERE Employees.JobName <> 'wlasciciel';";
                SqlDataAdapter adapter = new SqlDataAdapter(getEmployeesQuery, _connection);
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

        public string GetAllVets()
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getEmployeesQuery = "SELECT Employees.Id PersonalData.FirstName, PersonalData.LastName " +
                                           "FROM PersonalData " +
                                           "JOIN Employees ON Employees.PersonalDataId = PersonalData.Id " +
                                           "WHERE Employees.JobName = 'Weterynarz';";
                SqlDataAdapter adapter = new SqlDataAdapter(getEmployeesQuery, _connection);
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
        /// A method that allows to update employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jobName"></param>
        /// <param name="personalDataId"></param>
        /// <returns>true if updated successfully, false else</returns>
        public bool UpdateEmployee(int id, string jobName, int personalDataId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateEmployeeQuery = "UPDATE Employees " +
                                            $"SET JobName =  '{jobName}', " +
                                            $"PersonalDataId = {personalDataId} " +
                                            $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updateEmployeeQuery, _connection);
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
        /// A method that allows to delete employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if deleted successfully, false else</returns>
        public bool DeleteEmployee(int PersonalDataId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string deleteEmployeeQuery = "DELETE PersonalData " +
                                            $"Where Id = {PersonalDataId};";
                SqlCommand command = new SqlCommand(deleteEmployeeQuery, _connection);
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