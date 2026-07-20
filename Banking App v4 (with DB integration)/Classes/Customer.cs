using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Classes
{
    // Transaction class
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public BankAccount CurrentAccount { get; set; }

        // Constructor
        public Customer(int customerId, string firstname, string surname, string username, string password)
        {
            CustomerId = customerId;
            FirstName = firstname;
            Surname = surname;
            Username = username;
            Password = password;
        }

        // Constructor
        public Customer(int customerId)
        {
            CustomerId = customerId;

            // Get the customer details
            GetCustomerDetails();

            // Get the customer's bank account
            // (here, we assume that they only have one bank account)
            CurrentAccount = new BankAccount(this);

            // Get the customer's transactions
            GetTransactions();
        }

        // Gets customer details from the database
        public void GetCustomerDetails()
        {

            using (var connection = new SqlConnection(GlobalConstants.connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM CUSTOMERS WHERE CustomerID = @CustomerID";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Debug.WriteLine($"CustomerID: {reader["CustomerID"]}, Username: {reader["Username"]}, FirstName: {reader["FirstName"]}, Surname: {reader["Surname"]}, Password: {reader["Password"]}");
                            // We only expect one record to be returned here.
                            // Set the object properties using the data returned.
                            FirstName = (string)reader["FirstName"];
                            Surname = (string)reader["Surname"];
                            Username = (string)reader["Username"];
                            Password = (string)reader["Password"];
                        }
                    }
                }
            }

            Debug.WriteLine("Customer successfully retrieved.\n");
        }

        // Updates customer details in the database
        public void UpdateCustomerDetails()
        {

            // TODO: 

            Debug.WriteLine("Customer successfully updated.\n");
        }

        // Gets the transactions from the database
        public void GetTransactions()
        {

            using (var connection = new SqlConnection(GlobalConstants.connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM TRANSACTIONS WHERE CustomerID = @CustomerID";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Debug.WriteLine($"TransactionID: {reader["TransactionID"]}, CustomerID: {reader["CustomerID"]}, Amount: {reader["Amount"]}, Notes: {reader["Notes"]}");
                            // Create a transaction object and append it to the transaction list held in memory
                            Transaction transaction = new Transaction((int)reader["CustomerID"], Convert.ToDecimal(reader["Amount"]), (DateTime)reader["DateTime"], (string)reader["Notes"]);
                            CurrentAccount.AppendToTransactionList(transaction);
                        }
                    }
                }
            }

            Debug.WriteLine("Transactions successfully retrieved.\n");
        }
    }
}
