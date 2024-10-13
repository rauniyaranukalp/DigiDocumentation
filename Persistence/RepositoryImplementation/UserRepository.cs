using Domain.Common;
using Domain.User;
using Humanizer;
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

        public async Task<Response<dynamic>> AddUser(AddUserReq req) 
        {

            try
            {
                var filter = Builders<AddUserReq>.Filter.Empty;
                CountOptions opts = new CountOptions() { Hint = "_id_" };
                var result = await _userCollection.CountDocumentsAsync(filter,opts);
                AddUserReq user = new AddUserReq()
                {
                    username = $"{req.firstName.ToLower()}{req.lastName.Titleize()}{result + 1}00",
                    password = req.password,
                    email = req.email,
                    firstName = req.firstName,
                    lastName = req.lastName,
                    role = req.role,
                    isActive = req.isActive
                };
                await _userCollection.InsertOneAsync(user);
                return new Response<dynamic>(null, "Successfull");
            }
            catch (Exception ex)
            {
                return new Response<dynamic>(null,"Failed",false);

            }
        }
    }
}
