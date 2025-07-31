using MySql.Data.MySqlClient;
using System;
using System.Data;

class DirectConnectivity
{
     static string connectionString = "Server = localhost; Port = 3306; Database = sample; User = root; Password = root ";

    static void Main()
    {


        int choice;

        do
        {
            Console.WriteLine("-----Product Details-----");
            Console.WriteLine("1. CreateTable");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. GetAll");
           // Console.WriteLine("6. getById");
            Console.WriteLine("6. Exit");
            Console.Write("enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("invalid choice");
                continue;
            }
            switch (choice)
            {
                case 1: CreateTable();
                    break;

                case 2:
                    Console.Write("Enter id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter price: ");
                    double price = double.Parse(Console.ReadLine());
                    InsertProduct(id, name, price);
                    break;

                case 3:
                    Console.Write("Enter id to update: ");
                    int pid = int.Parse(Console.ReadLine());
                    Console.Write("Enter New price: ");
                    double nprice = double.Parse(Console.ReadLine());
                    UpdateProduct(pid, nprice);
                    break;

                case 4:
                    Console.Write("Enter ID to delete: ");
                    int del_id = int.Parse(Console.ReadLine());
                    DeleteProduct(del_id);
                    break;

                case 5:
                    GetAllProducts();
                    break;
                
                case 6:
                    Console.WriteLine("Exiting...");
                    break;

                /*case 6:
                    GetById();
                    break; */

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
                string CreateTableSql = @"CREATE TABLE IF NOT EXISTS Products (
                                            id INT AUTO_INCREMENT PRIMARY KEY,
                                            name VARCHAR(255) NOT NULL,
                                            price double NOT NULL
                                         );";
                using (MySqlCommand cmd = new MySqlCommand(CreateTableSql, connection))
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table created..........");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error creating : " + ex.Message);
            }

            finally
            {
                connection.Close();
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
                string InsertProductSql = "INSERT INTO Products (id, name, price) VALUES (@id, @name, @price)";
                using (MySqlCommand InsertCommand = new MySqlCommand(InsertProductSql, connection))
                {
                    InsertCommand.Parameters.AddWithValue("@id", id);
                    InsertCommand.Parameters.AddWithValue("@name", name);
                    InsertCommand.Parameters.AddWithValue("@price", price);
                    int RowsAffected = InsertCommand.ExecuteNonQuery();
                    Console.WriteLine($"inserted {RowsAffected} row(s).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting user: " + ex.Message);
            }
            finally
            {
                connection.Close();
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
                string UpdateProductSql = "UPDATE Products SET price = @price WHERE id = @id";
                using (MySqlCommand UpdateCommand = new MySqlCommand(UpdateProductSql, connection))
                {
                    UpdateCommand.Parameters.AddWithValue("@id", id);
                    UpdateCommand.Parameters.AddWithValue("@price", price);
                    int rowsAffected = UpdateCommand.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected > 0 ? "Update successful." : "No matching product found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating product: " + ex.Message);
            }
            finally
            {
                connection.Close();
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
                string DeleteProductSql = "DELETE FROM Products WHERE id = @id";
                using (MySqlCommand DeleteCommand = new MySqlCommand(DeleteProductSql, connection))
                {
                    DeleteCommand.Parameters.AddWithValue("@id", id);
                    int rowsAffected = DeleteCommand.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected > 0 ? "product deleted." : "No product found with given ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting product: " + ex.Message);
            }
            finally
            {
                connection.Close();
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
                string selectSql = "SELECT * FROM Products";
                using (MySqlCommand cmd = new MySqlCommand(selectSql, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n--- Products ---");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, price: {reader["price"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching Products: " + ex.Message);
            }
        }
    }
}