using System;
using System.ComponentModel;
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
        public string GetAnimalsOfOwner(string ownerID)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                string getAnimalsQuery = "SELECT * " +
                                          "FROM Animals " +
                                          $"Where OwnerID = '{ownerID}';";

                SqlDataAdapter adapter = new SqlDataAdapter(getAnimalsQuery, _connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                string temp = JsonConvert.SerializeObject(table);

                return temp;
            }
        }

        //Change data animal data by animal's id
        public void ChangeAnimalData(string newName, float newWeight, string newSpecies, int newOwnerId , int animalId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                
                string changeAnimalNameQuery = "UPDATE Animals " +
                                               $"SET Name =  '{newName}', "   +
                                               $"Weight = {newWeight}, " +
                                               $"Species = '{newSpecies}', " +
                                               $"OwnerId = {newOwnerId} " +
                                               $"Where Id =   {animalId};";
                _connection.Open();
                SqlCommand commandChangeAnimalName = new SqlCommand(changeAnimalNameQuery, _connection);
                commandChangeAnimalName.ExecuteNonQuery();

            }
        }

        //Delete animal from data base by animal's id
        public void DeleteAnimal(int animalId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                string deleteAnimalQuery = "DELETE FROM Animals " +
                                           $"WHERE Id = {animalId};";

                _connection.Open();
                SqlCommand deleteAnimalCommand = new SqlCommand(deleteAnimalQuery, _connection);
                deleteAnimalCommand.ExecuteNonQuery();
            }
        }

        //Add new animals to data base
        
        //Problem with using float typical float number as a parameter of weight for example 20.1,
        //Normal int passed as a weight is working correctly 
        public void AddNewAnimal(string name, string species, float weight, int ownerId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                string addAnimalQuery = "INSERT INTO Animals " +
                                        $"VALUES ('{name}', '{species}', {weight}, {ownerId});";

                _connection.Open();
                SqlCommand addAnimalCommand = new SqlCommand(addAnimalQuery, _connection);
                addAnimalCommand.ExecuteNonQuery();
            }
        }
    }
}
