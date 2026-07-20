using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class Program
{
    static string connectionString = "Server=(localdb)\\ProjectModels;Initial Catalog = dbTest1; Integrated Security = True; Connect Timeout = 30;";

    static void Main(string[] args)
    {
        WordAnalyser analyser = new WordAnalyser();
        analyser.AnalyseFile("words.txt");

        List<Word> analysedWords = analyser.AnalyseFile("words.txt");

        foreach (Word word in analysedWords)
        {
            Console.WriteLine(word.ToString());
            CreateTable(word);
        }
    }

    static void CreateTable(Word word) // creating SQL database
    {
        using (var connection = new SqlConnection(connectionString))
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

                        ";

            using (var command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }



            sql = @"INSERT INTO Words (Word, WordLength, DifficultyScore) OUTPUT INSERTED.WordID VALUES (@word, @length, @score)";
            int wordID;
                           
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@word", word.Text);
                command.Parameters.AddWithValue("@length", word.Length);
                command.Parameters.AddWithValue("@score", word.TotalScore);

                wordID = (int)command.ExecuteScalar(); // returns first column of the first row in the result (so wordID is accessed for each given command
            }


            sql = @"INSERT INTO WordLetters (WordID, Letter, Frequency) VALUES (@WordID, @Letter, @Frequency)";

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

            sql = @"INSERT INTO WordDifficulty (WordID, LengthScore, AlternatingScore, SameCharScore, RareCharScore, SameFingerScore, SameHandScore, TotalScore) 
                   VALUES (@WordID, @LengthScore, @AlternatingScore, @SameCharScore, @RareCharScore, @SameFingerScore, @SameHandScore, @TotalScore)";

            using (var command = new SqlCommand(sql, connection))
            {

                command.Parameters.AddWithValue("@WordID", wordID);
                command.Parameters.AddWithValue("@LengthScore", word.LengthScore);
                command.Parameters.AddWithValue("@AlternatingScore", (int)word.AlternatingScore);
                command.Parameters.AddWithValue("@SameCharScore", word.SameCharScore);
                command.Parameters.AddWithValue("@RareCharScore", word.RareCharScore);
                command.Parameters.AddWithValue("@SameFingerScore", word.SameFingerScore);
                command.Parameters.AddWithValue("@SameHandScore", word.SameHandScore);
                command.Parameters.AddWithValue("@TotalScore", word.TotalScore);

                command.ExecuteNonQuery();
            }


        }
    }
}

public enum Hand
{
    Left,
    Right
}

public enum Finger
{
    LeftPinky,
    LeftRing,
    LeftMiddle,
    LeftIndex,
    RightIndex,
    RightRing,
    RightMiddle,
    RightPinky
}

public static class FingerMapping
{
    public static Dictionary<char, Finger> Fingers { get; } = new Dictionary<char, Finger>()
    {
        {'q', Finger.LeftPinky },
        {'a', Finger.LeftPinky },
        {'z', Finger.LeftPinky },   

        {'s', Finger.LeftRing },
        {'w', Finger.LeftRing },
        {'x', Finger.LeftRing },

        {'d', Finger.LeftMiddle },
        {'e', Finger.LeftMiddle },
        {'c', Finger.LeftMiddle },

        {'f', Finger.LeftIndex },
        {'r', Finger.LeftIndex },
        {'v', Finger.LeftIndex },
        {'g', Finger.LeftIndex },
        {'t', Finger.LeftIndex },
        {'b', Finger.LeftIndex },

        {'j', Finger.RightIndex },
        {'u', Finger.RightIndex },
        {'m', Finger.RightIndex },
        {'h', Finger.RightIndex },
        {'y', Finger.RightIndex },
        {'n', Finger.RightIndex },

        {'k', Finger.RightMiddle },
        {'i', Finger.RightMiddle },

        {'l', Finger.RightRing },
        {'o', Finger.RightRing },

        {'p', Finger.RightPinky }
    };

    public static Hand GetHand(Finger Fingers)
    {
        return Fingers switch
        {
            Finger.LeftPinky or
            Finger.LeftRing or
            Finger.LeftMiddle or
            Finger.LeftIndex => Hand.Left,

            Finger.RightIndex or
            Finger.RightMiddle or
            Finger.RightRing or
            Finger.RightPinky => Hand.Right
        };
    }

    public static Dictionary<char, int> rareCharacters = new Dictionary<char, int>()
    {
        {'z', 6 },
        {'q', 5 },
        {'x', 5 },
        {'j', 3 },
        {'k', 2 },
        {'v', 2 }
    };
}

public class Word
{
    public string Text { get; set; }
    public int Length { get; set; }
    public Dictionary<char, int> LetterFrequency { get; set; }

    public float AlternatingHands { get; set; }

    public int LengthScore { get; set; }
    public float AlternatingScore { get; set; }
    public int SameCharScore { get; set; }
    public int RareCharScore { get; set; }
    public int SameFingerScore { get; set; }
    public int SameHandScore { get; set; }
    public int DifficultBigramsScore { get; set; }

    public double TotalScore =>
        LengthScore +
        (0.35 * AlternatingScore) +
        SameCharScore +
        SameFingerScore +
        RareCharScore;

    public override string ToString()
    {
        string output = "";

        output += $"Word: {Text}\n";
        output += $"Length: {Length}\n";

        output += $"Word Score: {(int)TotalScore}\n";
        output += "Letter Frequency:\n";

        foreach (var letter in LetterFrequency)
        {
            output += $"{letter.Key}: {letter.Value}\n";
        }

        return output;
    }
}


public class WordAnalyser
{
    public List<Word> AnalyseFile(string filePath)  // takes each word in file, puts each word into an array, then sends each word to get analysed (AnalyseWord)
    {
        string[] words = File.ReadAllLines(filePath);

        List<Word> analysedWords = new List<Word>();

        foreach (string wordText in words)
        {
            Word word = AnalyseWord(wordText);

            analysedWords.Add(word);
        }

        return analysedWords;
    }

    private Word AnalyseWord(string text) // for each word in file (one at a time given by words array), it calculates the text, length and frequency of letters as part of word object
    {
        Word word = new Word();

        word.Text = text;
        word.Length = text.Length;

        word.LetterFrequency = new Dictionary<char, int>();


        foreach (char c in text)
        {
            if (word.LetterFrequency.ContainsKey(c))
            {
                word.LetterFrequency[c]++;
            }
            else
            {
                word.LetterFrequency[c] = 1;
            }
        }

        // calculate finger scores
        for (int i = 0; i < word.Length - 1; i++)
        {
            char firstChar = word.Text[i];
            char secondChar = word.Text[i + 1];

            Finger finger1 = FingerMapping.Fingers[firstChar];
            Finger finger2 = FingerMapping.Fingers[secondChar];

            Hand hand1 = FingerMapping.GetHand(finger1);
            Hand hand2 = FingerMapping.GetHand(finger2);



            if (finger1 == finger2) // if fingers are the same (often difficult)
            {
                word.SameFingerScore += 2;
            }
            else if (firstChar == secondChar) // same letter (harder, as not expected)
            {
                word.SameCharScore += 3;
            }


            if (hand1 == hand2) // if hands are same (easier)
            {
                word.SameHandScore -= 1;
            }
            if (hand1 != hand2) // if hand is different each letter (alternating hands)
            {
                word.AlternatingHands += 1;
            }
            if (FingerMapping.rareCharacters.ContainsKey(firstChar))
            {
                word.RareCharScore += FingerMapping.rareCharacters[firstChar];
            }
        }
        if (word.Length >= 5)
        {
            word.LengthScore += Math.Min(word.Length * 2, 25);
        }
        else
        {
            word.LengthScore += 2;
        }

        float alternatingRatio = word.AlternatingHands / (word.Length - 1);
        word.AlternatingScore = (1 - alternatingRatio) * 15; // max score of +15

        return word;

    }
}