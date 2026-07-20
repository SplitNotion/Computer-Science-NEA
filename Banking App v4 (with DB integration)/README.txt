Version with solution to connecting with a database:

- Inheritance used, e.g. BankAccount (parent) -> CurrentAccount (child)
- Polymorphism/overriding used, e.g. MakeWithdrawal())
- Encapsulation is used in the classes (i.e. data and methods contained in a class)
- 1-to-many is modelled in the classes (one customer to many bank accounts)
- Add transaction to database works
- Retrieving transactions from database works
- Skeleton code included for Login page but this is not complete
- To take this app further, an ACCOUNTS table could be created to allow different bank accounts to be stored for a single customer (current, savings, etc.)

When using this code for the first time:

- Create the database (e.g. dbBanking1)
- Run the two SQL scripts to create the CUSTOMERS and TRANSACTIONS tables
- Run the SQL script to create two CUSTOMER records 
- Update the connection string in GlobalConstants.cs (i.e. use the correct SQL Server instance and database name)