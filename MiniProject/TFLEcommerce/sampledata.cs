/*using MySql.Data.MySqlClient;
using System;

class DirectConnectivity
{
    static string connectionString = "Server=localhost;Port=3306;Database=sample;User=root;Password=root;";

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n----- Product Details Menu -----");
            Console.WriteLine("1. Create Table");
            Console.WriteLine("2. Insert Product");
            Console.WriteLine("3. Update Product Price");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Get All Products");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateTable();
                    break;

                case 2:
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());

                    InsertProduct(id, name, price);
                    break;

                case 3:
                    Console.Write("Enter ID to update: ");
                    int updateId = int.Parse(Console.ReadLine());

                    Console.Write("Enter New Price: ");
                    double newPrice = double.Parse(Console.ReadLine());

                    UpdateProduct(updateId, newPrice);
                    break;

                case 4:
                    Console.Write("Enter ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());

                    DeleteProduct(deleteId);
                    break;

                case 5:
                    GetAllProducts();
                    break;

                case 6:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 6);
    }

    static void CreateTable()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string createTableSql = @"
                    CREATE TABLE IF NOT EXISTS Product (
                        id INT PRIMARY KEY,
                        name VARCHAR(255) NOT NULL,
                        price DOUBLE NOT NULL
                    );";

                using (MySqlCommand cmd = new MySqlCommand(createTableSql, connection))
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table 'Product' created or already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating table: " + ex.Message);
            }
        }
    }

    static void InsertProduct(int id, string name, double price)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string insertSql = "INSERT INTO Product (id, name, price) VALUES (@id, @name, @price)";
                using (MySqlCommand cmd = new MySqlCommand(insertSql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Inserted {rowsAffected} row(s).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting product: " + ex.Message);
            }
        }
    }

    static void UpdateProduct(int id, double price)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string updateSql = "UPDATE Product SET price = @price WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(updateSql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@price", price);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected > 0 ? "Product updated." : "No matching product found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating product: " + ex.Message);
            }
        }
    }

    static void DeleteProduct(int id)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string deleteSql = "DELETE FROM Product WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(deleteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected > 0 ? "Product deleted." : "No product found with the given ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting product: " + ex.Message);
            }
        }
    }

    static void GetAllProducts()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string selectSql = "SELECT * FROM Product";
                using (MySqlCommand cmd = new MySqlCommand(selectSql, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n--- Product List ---");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Price: {reader["price"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching products: " + ex.Message);
            }
        }
    }
}
*/
