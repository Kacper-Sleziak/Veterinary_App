using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Server.Database
{
    class VisitsCrud
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        //Function add new visit to database
        public bool AddVisit(DateTime date, int visitTypeId, int animalId, int vetId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string addVisitQuery = "INSERT INTO Visits " +
                                          $"VALUES ({date}, {visitTypeId}, {animalId}, {vetId});";
                SqlCommand command = new SqlCommand(addVisitQuery, _connection);
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

        public string GetVisits()
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getVisitsQuery = "SELECT * " +
                                           "FROM Visits;";
                SqlDataAdapter adapter = new SqlDataAdapter(getVisitsQuery, _connection);
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

        public string GetVetVisits(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getVisitsQuery = "SELECT * " +
                                        "FROM Visits " +
                                        $"WHERE VetId = {id};";
                SqlDataAdapter adapter = new SqlDataAdapter(getVisitsQuery, _connection);
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

        public string GetAnimalVisits(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getVisitsQuery = "SELECT * " +
                                        "FROM Visits " +
                                        $"WHERE AnimalId = {id};";
                SqlDataAdapter adapter = new SqlDataAdapter(getVisitsQuery, _connection);
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

        public string GetOwnerVisits(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string getVisitsQuery = "SELECT Visits.* " +
                                        "FROM Visits " +
                                        "JOIN Animals ON Animals.Id = Visits.AnimalId " +
                                        "JOIN PersonalData ON PersonalData.Id = Animals.OwnerId " + 
                                        $"WHERE PersonalData.Id = {id};";
                SqlDataAdapter adapter = new SqlDataAdapter(getVisitsQuery, _connection);
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

        //Function update visit
        public bool UpdateVisit(int id, DateTime date, int visitTypeId, int animalId, int vetId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateVisitQuery = "UPDATE Visits " +
                                             $"SET Date =  {date}, " +
                                             $"VisitTypeId = {visitTypeId} " +
                                             $"AnimalId = {animalId}" +
                                             $"VetId = {vetId}" +
                                             $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updateVisitQuery, _connection);
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

        //Function delete visit from database
        public bool DeleteVisit(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string deleteVisitQuery = "DELETE Visits " +
                                          $"Where Id = {id};";
                SqlCommand command = new SqlCommand(deleteVisitQuery, _connection);
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
