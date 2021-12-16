using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Server.Database
{
    class FreeTermsCrud
    {
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        public bool AddFreeTerm(DateTime date, int employeeId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                //Default status = 0, false in sql
                int status = 0;
                
                _connection.Open();
                string queryInsertFreeTerm = "INSERT INTO FreeTerms " +
                                                $"VALUES ({date:yyyy-MM-dd-hh-mm-ss}, {employeeId}, {status});";
                SqlCommand command = new SqlCommand(queryInsertFreeTerm, _connection);
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

        public string GetFreeTerms(int VetId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getFreeTermQuery = "SELECT * " +
                                             "FROM FreeTerms " +
                                             $"WHERE EmployeeId = {VetId};";
                SqlDataAdapter adapter = new SqlDataAdapter(getFreeTermQuery, _connection);
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

        public bool UpdateFreeTerm(int id, int status)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateFreeTermQuery = "UPDATE FreeTerms " +
                                                $"SET Status = {status} " +
                                                $"WHERE Id = {id};"; 
                SqlCommand command = new SqlCommand(updateFreeTermQuery, _connection);
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

        public bool DeleteFreeTerm(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string deleteFreeTermQuery = "DELETE FreeTerms " +
                                             $"Where Id = {id};";
                SqlCommand command = new SqlCommand(deleteFreeTermQuery, _connection);
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
