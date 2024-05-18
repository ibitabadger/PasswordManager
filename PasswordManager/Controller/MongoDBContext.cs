using MongoDB.Driver;
using PasswordManager.Model;


namespace PasswordManager.Controller
{
    public class MongoDBContext
    {
        private static readonly string connectionString = "mongodb://localhost:27017"; 
        private static readonly string databaseName = "PasswordHashing"; 
        private static readonly string collectionName = "Users"; 

        private static readonly IMongoClient client;
        private static readonly IMongoDatabase database;
        private static readonly IMongoCollection<User> collection; 

        static MongoDBContext()
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
            collection = database.GetCollection<User>(collectionName);
        }

        private MongoDBContext() { }

        public static IMongoCollection<User> GetCollection()
        {
            return collection;
        }
    }
}
