using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;

static class libraryDatabase
{
    static IMongoClient _client = new MongoClient();
    static IMongoDatabase _database = _client.GetDatabase("librarydb");

    // Method to insert any document into the database
    public static void insertRecord<T>(T record, string collection)
    {
        try
        {

            _database.GetCollection<T>(collection).InsertOne(record);
            MessageBox.Show("Record Added!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch
        {
            MessageBox.Show("Record already exits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
    public static void deleteRecord<T>(string id, string collection)
    {
        try
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            _database.GetCollection<T>(collection).DeleteOne(filter);
            MessageBox.Show("Record Deleted!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch
        {
            MessageBox.Show("Record can not delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    public static List<Book> getAllBookRecords()
    {
        return _database.GetCollection<Book>("Books").Find(_ => true).ToList();
    }

    public static List<T> getAllRecords<T>(string collection)
    {
        // Return all the objects from database, given collection
        return _database.GetCollection<T>(collection).Find(_ => true).ToList(); 
    }

    public static T getRecord<T>(string filter, string keyword, string collectionName)
    {
        // Filtering database collection to find the record
        var FILTER = Builders<T>.Filter.Eq(filter, keyword);
        // return filtered results
        return _database.GetCollection<T>(collectionName).Find(FILTER).FirstOrDefault();
    }

    public static void updateRecord<T>(string id, string collection, T update)
    {
        try
        {
            // Filter database to find the record to update
            var filter = Builders<T>.Filter.Eq("Id", id);
            
            // Replace the object with the given object in the particular table in the database
            _database.GetCollection<T>(collection).ReplaceOne(filter, update);

            // Display success message
            MessageBox.Show("Record Updated!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception e)
        {
            // Get error message and display error in a message box
            MessageBox.Show($"Update Failed!\n\n{e.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
