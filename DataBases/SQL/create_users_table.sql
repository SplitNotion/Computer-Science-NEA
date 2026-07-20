CREATE TABLE USERS (
    UserID INT PRIMARY KEY IDENTITY(1,1), -- IDENTITY(1,1) performs an auto increment feature, starting at 1 and incrementing by 1
    Username VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    Surname VARCHAR(50) NOT NULL
);
