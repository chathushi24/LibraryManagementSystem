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

            //connecting the database with GUI
            //var database = new MongoClient("mongodb://localhost:27017").GetDatabase("LibraryDatabase");
            //var collections = database.GetCollection<Book>("Books");

            //Book book = new Book("2344", "ai mokada", "mage nama", "234-3432-23", "5", "2005", true);
            //collections.Add(book);
        }
    }
}