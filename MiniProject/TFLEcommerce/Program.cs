using MySql.Data.MySqlClient;
using System;
using System.Data;

class Directconnectivity
{
    static void Main()
    { 
     string connectionString = "Server=localhost;Port=3306;Database=sample;User=root;Password=root;";
      using(MySqlConnection connection = new MySqlConnection(connectionString))
      {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL!");
                CreateTable(connection);
                InsertUser(connection, "Shital Patil", "Shital@tfl.com");
                InsertUser(connection, "Sridhar Patil", "Sridhar@tfl.com");
                UpdateUserEmail(connection, "Shital Patil", "Update@tfl.com");
                DeleteUser(connection, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
            static void CreateTable(MySqlConnection connection)
            {
                string createTableSql = "CREATE TABLE IF NOT EXISTS users(" + "id INT AUTO_INCREMENT PRIMARY KEY," + "name VARCHAR(255) NOT NULL," + "email VARCHAR(255) NOT NULL)";

                using (MySqlCommand createTableCmd = new MySqlCommand(createTableSql, connection))
                {
                    createTableCmd.ExecuteNonQuery();
                }

            }
            static void InsertUser(MySqlConnection connection, string name,string email)
            {
              string insertSql = "INSERT INTO users (name, email) VALUES (@name, @email)";
                using (MySqlCommand cmd = new MySqlCommand(insertSql, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Inserted {rowsAffected} row(s) into the users table.");
                }

            }
            static void UpdateUserEmail(MySqlConnection connection, string name,string newEmail)
            {
                    
                    string updateSql = "UPDATE users SET email = @newEmail WHERE name = @name";
                using (MySqlCommand updateCmd = new MySqlCommand(updateSql, connection))
                {
                    updateCmd.Parameters.AddWithValue("@name", name);
                    updateCmd.Parameters.AddWithValue("@newEmail", newEmail);   
                    updateCmd.ExecuteNonQuery();
                    
                    }
            }
            static void DeleteUser(MySqlConnection connection,int id)
            {
                    string deleteSql = "DELETE FROM users WHERE id = @id";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteSql, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", id);
                        deleteCmd.ExecuteNonQuery();

                    }
            }
            try 
            {
                connection.Open();
                string strCmd = "SELECT * FROM users";
                using (MySqlCommand cmd = new MySqlCommand(strCmd, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"id: {reader["id"]}, name: {reader["name"]}, email: {reader["email"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
             finally
           {
            connection.Close();
           }
        }

    }
}