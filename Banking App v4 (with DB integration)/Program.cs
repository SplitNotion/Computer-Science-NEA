//using Banking;

namespace BankingApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Instantiate the Transactions form
            Application.Run(new frmTransactions());

            // TODO: From here you should instantiate the login form.
            // From the login form you should open the transactions form.
        }
    }
}