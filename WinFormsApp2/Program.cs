using MongoDB.Driver;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;


namespace WinFormsApp2
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
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }

        static void consoleApplication()
        {
            do
            {
                User user;
                Console.Clear();
                Console.WriteLine("Library Management System!");
                Console.WriteLine();
                Console.Write("\tUsername: ");
                string username = Console.ReadLine();
                Console.Write("\tPassword: ");
                string password = Console.ReadLine();
                Console.WriteLine();
               
                if ()
                {

                }


            }
            while (true);

        }
    }
}