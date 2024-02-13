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


    public  static List<Book> getAllRecords()
    {
        return _database.GetCollection<Book>("Books").Find(_=> true).ToList();
    }

    public static Book getBookById (string id)
    {
        return _database.GetCollection<Book>("Books").Find(book => book.Id == id).FirstOrDefault();
    }
}
