using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Algorithms.WordAnalysis;
using TypingImprovementProgram.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TypingImprovementProgram.Database
{
    internal class DatabaseManager
    {
        private SqlConnection GetConnection()
        {
            return new SqlConnection(DatabaseConnection.connectionString);
        }

        public Dictionary<string, int> BigramIDs { get; set; }

        public DatabaseManager()
        {
            BigramIDs = new Dictionary<string, int>();
        }

        #region InitalTableGenerationInsertion

        // creates all necessary SQL tables required for the program. Checks whether they already exist also.
        public void CreateTables()                                 
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string sql = @"
                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'Words'
                        )
                        BEGIN
                            CREATE TABLE Words
                            (
                                WordID INT PRIMARY KEY IDENTITY(1,1),
                                Word VARCHAR(50) NOT NULL,
                                WordLength INT NOT NULL,
                                DifficultyScore INT NOT NULL
                            );
                        END;


                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'WordLetters'
                        )
                        BEGIN
                            CREATE TABLE WordLetters
                            (
                                WordLetterID INT PRIMARY KEY IDENTITY(1,1),
                                WordID INT NOT NULL,
                                Letter CHAR(1) NOT NULL,
                                Frequency INT NOT NULL,
                                FOREIGN KEY (WordID) REFERENCES Words(WordID)
                            );
                        END;


                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'WordDifficulty'
                        )
                        BEGIN
                            CREATE TABLE WordDifficulty
                            (
                                WordID INT PRIMARY KEY,
                                LengthScore INT NOT NULL,
                                AlternatingScore INT NOT NULL,
                                SameCharScore INT NOT NULL,
                                RareCharScore INT NOT NULL,
                                SameFingerScore INT NOT NULL,
                                SameHandScore INT NOT NULL,
                                DistanceScore FLOAT NOT NULL,
                                TotalScore INT NOT NULL,
                                FOREIGN KEY (WordID) REFERENCES Words(WordID)
                            );
                        END;

                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'PossibleBigrams'
                        )
                        BEGIN
                            CREATE TABLE PossibleBigrams
                            (
                                BigramID INT PRIMARY KEY IDENTITY(1,1),
                                Bigram CHAR(2) UNIQUE NOT NULL,
                                BigramFrequency INT NOT NULL
                            );
                        END;

                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'WordBigrams'
                        )
                        BEGIN
                            CREATE TABLE WordBigrams
                            (
                                WordID INT,
                                BigramID INT,
                                
                                PRIMARY KEY (WordID, BigramID),
                                FOREIGN KEY (WordID) REFERENCES Words(WordID),
                                FOREIGN KEY (BigramID) REFERENCES PossibleBigrams(BigramID)
                            );
                        END;

                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'Users'
                        )
                        BEGIN
                            CREATE TABLE Users
                            (
                                UserID INT PRIMARY KEY IDENTITY(1,1),
                                Username VARCHAR(50) NOT NULL,
                                PasswordHash VARCHAR(50) NOT NULL,
                                BaselineCompleted BIT NOT NULL
                            );
                        END


                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'Tests'
                        )
                        BEGIN
                            CREATE TABLE Tests
                            (
                                TestID INT PRIMARY KEY IDENTITY(1,1),
                                UserID INT,
                                TestNote VARCHAR(30) NOT NULL,
                                TestDate DATETIME NOT NULL,
                                WPM INT,
                                Accuracy FLOAT NOT NULL,

                                FOREIGN KEY (UserID) REFERENCES Users(UserID)
                            );
                        END

                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'TestProblemLetters'
                        )
                        BEGIN
                            CREATE TABLE TestProblemLetters
                            (
                                TestProblemLetterID INT PRIMARY KEY IDENTITY(1,1),
                                TestID INT NOT NULL,
                                Letter CHAR(1) NOT NULL,
                                ErrorRate FLOAT NOT NULL,
                                Hesitation BIT NOT NULL,

                                FOREIGN KEY (TestID) REFERENCES Tests(TestID)
                            );
                        END

                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'TestProblemBigrams'
                        )
                        BEGIN
                            CREATE TABLE TestProblemBigrams
                            (
                                TestProblemBigramID INT PRIMARY KEY IDENTITY(1,1),
                                TestID INT NOT NULL,
                                Bigram VARCHAR(2) NOT NULL,
                                ErrorRate FLOAT NOT NULL,
                                Hesitation BIT NOT NULL,

                                FOREIGN KEY (TestID) REFERENCES Tests(TestID)
                            );
                        END
                        ";


                using (var command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertIntoTables(Word word)
        {
            int wordID;
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"INSERT INTO Words (Word, WordLength, DifficultyScore) OUTPUT INSERTED.WordID VALUES (@word, @length, @score)";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@word", word.Text);
                    command.Parameters.AddWithValue("@length", word.Length);
                    command.Parameters.AddWithValue("@score", word.Difficulty.TotalScore);

                    wordID = (int)command.ExecuteScalar(); // returns first column of the first row in the result (so wordID is accessed for each given command
                }
            }
            InsertIntoWordLetters(wordID, word);
            InsertIntoWordDifficulty(wordID, word.Difficulty);
            InsertIntoWordBigrams(wordID, word, BigramIDs);
        }



        private void InsertIntoWordLetters(int wordID, Word word)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"INSERT INTO WordLetters (WordID, Letter, Frequency) VALUES (@WordID, @Letter, @Frequency)";

                foreach (var letter in word.LetterFrequency)
                {
                    using (var command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@WordID", wordID);
                        command.Parameters.AddWithValue("@Letter", letter.Key);
                        command.Parameters.AddWithValue("@Frequency", letter.Value);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void InsertIntoWordDifficulty(int wordID, WordDifficulty difficulty)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string sql = @"INSERT INTO WordDifficulty (WordID, LengthScore, AlternatingScore, SameCharScore, RareCharScore, SameFingerScore, SameHandScore, DistanceScore, TotalScore) 
                   VALUES (@WordID, @LengthScore, @AlternatingScore, @SameCharScore, @RareCharScore, @SameFingerScore, @SameHandScore, @DistanceScore, @TotalScore)";

                using (var command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@WordID", wordID);
                    command.Parameters.AddWithValue("@LengthScore", difficulty.LengthScore);
                    command.Parameters.AddWithValue("@AlternatingScore", (int)difficulty.AlternatingScore);
                    command.Parameters.AddWithValue("@SameCharScore", difficulty.SameCharScore);
                    command.Parameters.AddWithValue("@RareCharScore", difficulty.RareCharScore);
                    command.Parameters.AddWithValue("@SameFingerScore", difficulty.SameFingerScore);
                    command.Parameters.AddWithValue("@SameHandScore", difficulty.SameHandScore);
                    command.Parameters.AddWithValue("@DistanceScore", difficulty.DistanceScore);
                    command.Parameters.AddWithValue("@TotalScore", difficulty.TotalScore);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertIntoWordBigrams(int wordID, Word word, Dictionary<string, int> bigramIDs)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"INSERT INTO WordBigrams (WordID, BigramID) VALUES (@WordID, @BigramID)";
                HashSet<string> insertedBigrams = new HashSet<string>();   // a list that doesn't store unique values

                for (int i = 0; i < word.Length - 1; i++)
                {
                    string bigram = word.Text.Substring(i, 2);


                    if (insertedBigrams.Contains(bigram))
                    {
                        continue;
                    }

                    insertedBigrams.Add(bigram);
                    int bigramID = bigramIDs[bigram];


                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@WordID", wordID);
                        command.Parameters.AddWithValue("@BigramID", bigramID);

                        command.ExecuteNonQuery();
                    }
                }
            }

        }

        public int InsertIntoPossibleBigrams(string bigram, int bigramFrequency)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"INSERT INTO PossibleBigrams (Bigram, BigramFrequency) OUTPUT INSERTED.BigramID VALUES (@Bigram, @BigramFrequency)";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Bigram", bigram);
                    command.Parameters.AddWithValue("@BigramFrequency", bigramFrequency);

                    return (int)command.ExecuteScalar();
                }
            }
        }

        #endregion


        // method which creates a new record/user account in the Users database, however if it already exists then it returns and error to
        public int InsertNewUserAccount(string username, string password)
        {
            int testID = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"SELECT Username FROM Users WHERE Username = @Username";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedUsername = (string)reader["Username"];
                            if (username == storedUsername)
                            {
                                return -1;
                            }
                        }
                    }
                }

                sql = @"INSERT INTO Users(Username, PasswordHash, BaselineCompleted) OUTPUT INSERTED.UserID VALUES (@Username, @PasswordHash, @BaselineCompleted)" ;

                using (var command = new SqlCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", password);
                    command.Parameters.AddWithValue("@BaselineCompleted", false);

                    testID = (int)command.ExecuteScalar();
                }
                return testID;
            }
        }

        public string ValidateLogin(string username, string password, out int userID, out bool baselineCompleted)
        {
            userID = 0;
            baselineCompleted = false;

            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"SELECT * FROM Users WHERE Username = @Username";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = (string)reader["PasswordHash"];

                            if (password == storedPassword)
                            {
                                userID = (int)reader["UserID"];
                                baselineCompleted = (bool)reader["baselineCompleted"];
                                return "Success";
                            }
                            else
                            {
                                return "Incorrect Password";
                            }
                        }
                        else
                        {
                            return "Username not found";
                        }
                    }
                }
            }
        }

        public int SaveTestResults(int userID, string testNote, int WPM, double accuracy, Dictionary<char, (double errorRate, bool hesitated)> problemLetters, Dictionary<string, (double errorRate, bool hesitated)> problemBigrams)
        {
            int testID = 0;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // creates a new test record in the Tests database and returns the TestID from that record, so then that ID can be used as the foreign key for the ProblemLetters and ProblemBigrams records of the same test
                        string sql = @"INSERT INTO Tests(UserID, TestNote, TestDate, WPM, Accuracy) OUTPUT INSERTED.TestID VALUES (@UserID, @TestNote, @TestDate, @WPM, @Accuracy)";

                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@UserID", userID);
                            command.Parameters.AddWithValue("@TestNote", testNote);
                            command.Parameters.AddWithValue("@TestDate", DateTime.Now);
                            command.Parameters.AddWithValue("@WPM", WPM);
                            command.Parameters.AddWithValue("@Accuracy", accuracy);

                            testID = (int)command.ExecuteScalar();
                        }

                        // creates a new record in the TestProblemLetters database which stores all the user's 'problem' letters for each test, so that it can be retrieved at a later date.
                        sql = @"INSERT INTO TestProblemLetters(TestID, Letter, ErrorRate, Hesitation) VALUES (@TestID, @Letter, @ErrorRate, @Hesitation)";
                        foreach (var item in problemLetters)
                        {
                            using (var command = new SqlCommand(sql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@TestID", testID);
                                command.Parameters.AddWithValue("@Letter", item.Key);
                                command.Parameters.AddWithValue("@ErrorRate", item.Value.errorRate);
                                command.Parameters.AddWithValue("@Hesitation", item.Value.hesitated);
                                
                                command.ExecuteNonQuery();
                            }
                        }

                        // creates a new record in the TestProblemBigrams database which stores all the user's 'problem' bigrams for each test, so that it can be retrieved at a later date.
                        sql = @"INSERT INTO TestProblemBigrams(TestID, Bigram, ErrorRate, Hesitation) VALUES (@TestID, @Bigram, @ErrorRate, @Hesitation)";
                        foreach (var item in problemBigrams)
                        {
                            using (var command = new SqlCommand(sql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@TestID", testID);
                                command.Parameters.AddWithValue("@Bigram", item.Key);
                                command.Parameters.AddWithValue("@ErrorRate", item.Value.errorRate);
                                command.Parameters.AddWithValue("@Hesitation", item.Value.hesitated);

                                command.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        return testID;
                    }

                    catch (Exception ex) 
                    {
                        transaction.Rollback();
                        MessageBox.Show("Data saving failed. Please contact the program developer, or stop trying to break the program...","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        throw;
                    }
                }


            }

            
        }
        public void CompletedBaselineTest(int userID)
        {
            using (var connection  = GetConnection())
            {
                connection.Open();
                string sql = @"UPDATE Users SET BaselineCompleted = @BaselineCompleted WHERE UserID = @UserID";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BaselineCompleted", true);
                    command.Parameters.AddWithValue("@UserID", userID);

                    command.ExecuteNonQuery();
                }
            }
        }

        #region Practice Test Generation
        public (Dictionary<char, (double, bool)> problemLetters, Dictionary<string, (double, bool)> problemBigrams) GetLatestUserLetterBigramProblems(int userID)
        {
            Dictionary<char, (double errorRate, bool hesitation)> problemLetters = new Dictionary<char, (double, bool)>();
            Dictionary<string, (double errorRate, bool hesitation)> problemBigrams = new Dictionary<string, (double, bool)>();

            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"SELECT TestID FROM Tests WHERE TestDate = (SELECT MAX(TestDate) FROM Tests WHERE UserID = @UserID)";
                int testID;

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    testID = (int)command.ExecuteScalar();
                }

                sql = @"SELECT Letter, ErrorRate, Hesitation FROM TestProblemLetters WHERE TestID = @TestID";

                using (var command = new SqlCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            char letter = Convert.ToChar(reader["Letter"].ToString());
                            double errorRate = (double)reader["ErrorRate"];
                            bool hesitation = (bool)reader["Hesitation"];

                            problemLetters.Add(letter, (errorRate, hesitation));
                        }
                    }  
                }

                sql = @"SELECT Bigram, ErrorRate, Hesitation FROM TestProblemBigrams WHERE TestID = @TestID";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bigram = (string)reader["Bigram"];
                            double errorRate = (double)reader["ErrorRate"];
                            bool hesitation = (bool)reader["Hesitation"];

                            problemBigrams.Add(bigram, (errorRate, hesitation));
                        }
                    }
                }
            }
            return (problemLetters, problemBigrams);
        }



        #endregion


    }
}