using Domain.User;
using MongoDB.Driver;
using Persistence.RepositoryContract;

namespace Persistence.RepositoryImplementation
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<AddUserReq> _userCollection;

        public UserRepository(MongoDbConnection mongoDbConnection)
        {
            _userCollection = mongoDbConnection.Database.GetCollection<AddUserReq>("users");
        }

        public async Task<bool> AddUser(AddUserReq req) 
        {
            await _userCollection.InsertOneAsync(req);
            return true;
        }
    }
}
