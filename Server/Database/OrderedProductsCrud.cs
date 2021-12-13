namespace Server.Database
{
    class OrderedProductsCrud
    {
        // A variable that allows you to connect to database
        private SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        //Function add new product to data base
        public bool AddOrderedProduct(int productId, int amount, int orderId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string addOrderedProductQuery = "INSERT INTO OrderedProducts " +
                                                $"VALUES ({productId}, {amount}, {orderId});";
                SqlCommand command = new SqlCommand(addOrderedProductQuery, _connection);
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

        //Function update ordered product
        public bool UpdateOrderedProduct(int id, int productId, int amount, int orderId)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string updateOrderedProductQuery = "UPDATE OrderedProducts " +
                                             $"SET ProductId =  {productId}, " +
                                             $"Amount = {amount} " +
                                             $"OrderId = {orderId}" +
                                             $"WHERE Id = {id};";
                SqlCommand command = new SqlCommand(updateOrderedProductQuery, _connection);
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


        //Function delete ordered Product
        public bool DeleteOrderedProduct(int id)
        {
            using (_connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                _connection.Open();
                string deleteOrderedProduct = "DELETE OrderedProducts " +
                                              $"Where Id = {id};";
                SqlCommand command = new SqlCommand(deleteOrderedProduct, _connection);
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
