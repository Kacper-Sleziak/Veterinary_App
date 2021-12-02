using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace Server.Database
{
    class AnimalsCrud
    {    // A variable that allows you to connect to database
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
        public void ChangeAnimalData(string newName, float newWeight, string newSpieces, int newOwnerId , string animalId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string changeAnimalNameQuery = "UPDATE Animals " +
                                               $"SET Name =   '{newName}' "   +
                                               $",Weight = '{newWeight}' " +
                                               $",Spiecies = '{newSpieces}" +
                                               $",OwnerId = '{newOwnerId}" +
                                               $"Where Id =   '{animalId}';";

                SqlCommand commandChangeAnimalName = new SqlCommand(changeAnimalNameQuery, _connection);
                commandChangeAnimalName.ExecuteNonQuery();

            }
        }
    }
}
