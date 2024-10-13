using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Persistence
{
    public class MongoDbConnection
    {
        private readonly IMongoDatabase mongoDatabase;

        public MongoDbConnection(IMongoClient mongoClient, IConfiguration configuration)
        {
            var databaseName = "TechDocumentationDB";
            mongoDatabase = mongoClient.GetDatabase(databaseName);
        }

        public IMongoDatabase Database => mongoDatabase;
    }
}
    