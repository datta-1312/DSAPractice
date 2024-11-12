using System.Data.SQLite;
public class ConnectToSQLite
{
    public static void Fetch()
    {
        string databasePath = "/Users/shrutinaik/MyDogs.db";
        string connectionString = $"Data Source={databasePath};Version=3;";

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))   
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection to SQLite database successful!");
                string query = "SELECT * FROM Dog";
                // Perform database operations here
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())   
                    {
                        while (reader.Read())   
                        {
                            // Do something with the data
                            Console.WriteLine($"Column 1: {reader["Name"]}, Column 2: {reader["Age"]}, Column 3: {reader["Weight"]}");
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error connecting to SQLite database: " + ex.Message);
            }
        }
    }
}