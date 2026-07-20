using System;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static string connectionString = "Server=(localdb)\\ProjectModels;Initial Catalog = dbTest1; Integrated Security = True; Connect Timeout = 30;";

    static void Main(string[] args)
    {
        CreateTable();

        while (true)
        {
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. List Users");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Delete User");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    ListUsers();
                    break;
                case "3":
                    UpdateUser();
                    break;
                case "4":
                    DeleteUser();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void CreateTable()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='USERS' and xtype='U')
                           CREATE TABLE USERS (
                           UserID INT PRIMARY KEY IDENTITY(1,1),
                           Username VARCHAR(50) NOT NULL,
                           FirstName VARCHAR(50) NOT NULL,
                           Surname VARCHAR(50) NOT NULL);";
            using (var command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    static void AddUser()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter FirstName: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Surname: ");
        string surname = Console.ReadLine();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO USERS (Username, FirstName, Surname) VALUES (@Username, @FirstName, @Surname)";
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Surname", surname);
                command.ExecuteNonQuery();
            }
        }

        Console.WriteLine("User added successfully.\n");
    }

    static void ListUsers()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM USERS";
            using (var command = new SqlCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"UserID: {reader["UserID"]}, Username: {reader["Username"]}, FirstName: {reader["FirstName"]}, Surname: {reader["Surname"]}");
                    }
                }
            }
        }
        Console.WriteLine();
    }

    static void UpdateUser()
    {
        Console.Write("Enter UserID of the user to update: ");
        int userId = int.Parse(Console.ReadLine());

        Console.Write("Enter new Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter new FirstName: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter new Surname: ");
        string surname = Console.ReadLine();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE USERS SET Username = @Username, FirstName = @FirstName, Surname = @Surname WHERE UserID = @UserID";
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Surname", surname);
                command.ExecuteNonQuery();
            }
        }

        Console.WriteLine("User updated successfully.\n");
    }

    static void DeleteUser()
    {
        // TODO: Complete this section

        Console.Write("Enter UserID of the user to delete: ");
        int userId = int.Parse(Console.ReadLine());

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "DELETE FROM USERS WHERE UserID = @UserID";
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);
                command.ExecuteNonQuery();
            }
        }

        Console.WriteLine("User deleted successfully.\n");
    }
}


