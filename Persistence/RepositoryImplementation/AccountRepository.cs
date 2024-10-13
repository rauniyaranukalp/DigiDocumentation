using Domain.Common;
using Domain.User;
using MongoDB.Driver;
using Persistence.RepositoryContract;

namespace Persistence.RepositoryImplementation
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMongoCollection<AddUserReq> _userCollection;

        public AccountRepository(MongoDbConnection mongoDbConnection)
        {
            _userCollection = mongoDbConnection.Database.GetCollection<AddUserReq>("users");
        }

        public async Task<Response<dynamic>> Login(string username, string password)
        {
            try
            {
                var user = await _userCollection.Find(u => u.username == username && u.password == password).FirstOrDefaultAsync();

                if (user != null)
                {
                    return new Response<dynamic>(user, "Login successful", true);
                }
                else
                {
                    return new Response<dynamic>(null, "Invalid username or password", false);
                }
            }
            catch (Exception ex)
            {
                return new Response<dynamic>(null, "Failed", false);
            }
        }

    }
}
