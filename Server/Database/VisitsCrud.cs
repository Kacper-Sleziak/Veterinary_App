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
        public bool DeleteEmployee(int id)
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
