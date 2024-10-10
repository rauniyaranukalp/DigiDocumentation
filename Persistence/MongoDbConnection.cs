using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Persistence
{
    public class MongoDbConnection
    {
        private readonly IConfiguration _configuration;
        private readonly IMongoDatabase mongoDatabase;

        public MongoDbConnection(IConfiguration configuration, IMongoDatabase mongoDatabase)
        {
            this._configuration = configuration;

            var connectionString = _configuration.GetConnectionString("dbConnection");
            var mongoUrl = MongoUrl.Create(connectionString);
            var mongoClient = new MongoClient(mongoUrl);
            mongoDatabase = mongoClient.GetDatabase(mongoUrl.DatabaseName);
        }

        public IMongoDatabase? Database => mongoDatabase;
    }
}
    