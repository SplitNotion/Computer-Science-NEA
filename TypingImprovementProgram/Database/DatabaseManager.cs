using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Algorithms.WordAnalysis;
using TypingImprovementProgram.Models;

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

        public void CreateTables()                                 // creates all necessary SQL tables required for the program. Checks whether they already exist.
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

                string sql = @"INSERT INTO WordDifficulty (WordID, LengthScore, AlternatingScore, SameCharScore, RareCharScore, SameFingerScore, SameHandScore, TotalScore) 
                   VALUES (@WordID, @LengthScore, @AlternatingScore, @SameCharScore, @RareCharScore, @SameFingerScore, @SameHandScore, @TotalScore)";

                using (var command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@WordID", wordID);
                    command.Parameters.AddWithValue("@LengthScore", difficulty.LengthScore);
                    command.Parameters.AddWithValue("@AlternatingScore", (int)difficulty.AlternatingScore);
                    command.Parameters.AddWithValue("@SameCharScore", difficulty.SameCharScore);
                    command.Parameters.AddWithValue("@RareCharScore", difficulty.RareCharScore);
                    command.Parameters.AddWithValue("@SameFingerScore", difficulty.SameFingerScore);
                    command.Parameters.AddWithValue("@SameHandScore", difficulty.SameHandScore);
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
    }
}
