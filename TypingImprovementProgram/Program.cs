using System.Diagnostics;
using TypingImprovementProgram.Algorithms.WordAnalysis;
using TypingImprovementProgram.Database;
using TypingImprovementProgram.Models;
using System.Runtime.InteropServices;
using TypingImprovementProgram.Forms;
using TypingImprovementProgram.Forms.SetupPages;
namespace TypingImprovementProgram
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(new BaselineTestForm());


            DatabaseManager database = new DatabaseManager();
            database.CreateTables();

            WordAnalyser analyser = new WordAnalyser();
            analyser.AnalyseFile("words.txt");

            List<Word> analysedWords = analyser.AnalyseFile("words.txt");

            foreach (Word word in analysedWords)
            {
                Debug.WriteLine(word.ToString()); 
                database.InsertIntoTables(word);
                
            }
        }
    }
}