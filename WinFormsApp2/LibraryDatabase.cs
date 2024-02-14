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

    public static List<Book> getAllRecords()
    {
        return _database.GetCollection<Book>("Books").Find(_ => true).ToList();
    }

    public static Book getBookByISBN(string isbn)
    {
        return _database.GetCollection<Book>("Books").Find(book => book.ISBN == isbn).FirstOrDefault();
    }

    public static T getRecord<T>(string filter, string keyword, string collectionName)
    {
        // Filtering database collection to find the record
        var FILTER = Builders<T>.Filter.Eq(filter, keyword);
        // return filtered results
        return _database.GetCollection<T>(collectionName).Find(FILTER).FirstOrDefault();
    }
}
