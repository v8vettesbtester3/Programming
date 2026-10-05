namespace DB01_01
{
    using System;
    using Microsoft.Data.Sqlite;    // Import the SQLite namespace

    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Define the connection string. 
            // This will look for or create 'test1.db' in your project's output folder.
            string connectionString = "Data Source=test1.db";

            // 2. Open the connection wrapped in a 'using' statement for safe disposal
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Successfully connected to SQLite database.");

                // 3. Create a table
                string createTableSql = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Age INTEGER
                );";

                using (var command = new SqliteCommand(createTableSql, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Table 'Users' checked/created.");
                }

                // 4. Insert data using parameters to prevent SQL injection
                string insertSql = "INSERT INTO Users (Name, Age) VALUES ($name, $age);";
                using (var command = new SqliteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("$name", "Alice");
                    command.Parameters.AddWithValue("$age", 30);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Sample data inserted.");
                }

                // 5. Read data back from the database
                string selectSql = "SELECT Id, Name, Age FROM Users;";
                using (var command = new SqliteCommand(selectSql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nRetrieved Records:");
                        while (reader.Read())
                        {
                            var id = reader.GetInt32(0);
                            var name = reader.GetString(1);
                            var age = reader.GetInt32(2);

                            Console.WriteLine($"ID: {id} | Name: {name} | Age: {age}");
                        }
                    }
                }

                // 6. Update selected data
                string sqlCommand = "UPDATE Users set Name = 'Albert' where Name = 'Alice';";
                using (var command = new SqliteCommand(sqlCommand, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Data modified.");
                }


            } // Connection automatically closes here
        }
    }
}
