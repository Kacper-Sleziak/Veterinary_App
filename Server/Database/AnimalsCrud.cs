using System;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace Server.Database
{
    class AnimalsCrud
    {    
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);
        
        //Get animals by id of owner's personal data
        public string GetAnimalsOfOwner(int ownerID)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                string getAnimalsQuery = "SELECT * " +
                                          "FROM Animals " +
                                          $"Where OwnerID = {ownerID};";

                SqlDataAdapter adapter = new SqlDataAdapter(getAnimalsQuery, _connection);
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

        //Change data animal data by animal's id
        public bool ChangeAnimalData(int animalId, string newName, string newSpecies, float newWeight ,int newOwnerId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                
                string changeAnimalNameQuery = "UPDATE Animals " +
                                               $"SET Name =  '{newName}', "   +
                                               $"Species = '{newSpecies}', " +
                                               $"Weight = {newWeight.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                                               $"OwnerId = {newOwnerId} " +
                                               $"Where Id =   {animalId};";
                _connection.Open();
                SqlCommand commandChangeAnimalName = new SqlCommand(changeAnimalNameQuery, _connection);
                
                try
                {
                    commandChangeAnimalName.ExecuteNonQuery();
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

        //Delete animal from data base by animal's id
        public bool DeleteAnimal(int animalId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                string deleteAnimalQuery = "DELETE FROM Animals " +
                                           $"WHERE Id = {animalId};";

                _connection.Open();
                SqlCommand deleteAnimalCommand = new SqlCommand(deleteAnimalQuery, _connection);

                try
                {
                    deleteAnimalCommand.ExecuteNonQuery();
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

        //Add new animals to data base
        
        //Problem with using float typical float number as a parameter of weight for example 20.1,
        //Normal int passed as a weight is working correctly 
        public bool AddNewAnimal(string name, string species, float weight, int ownerId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                string addAnimalQuery = "INSERT INTO Animals " +
                                        $"VALUES ('{name}', '{species}', {weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {ownerId});";

                _connection.Open();
                SqlCommand addAnimalCommand = new SqlCommand(addAnimalQuery, _connection);

                try
                {
                    addAnimalCommand.ExecuteNonQuery();
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
