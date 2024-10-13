using Domain.Common;
using Domain.Tile;
using Domain.User;
using MongoDB.Driver;
using Persistence.RepositoryContract;

namespace Persistence.RepositoryImplementation
{
    public class TileRepository : ITileRepository
    {
        private readonly IMongoCollection<AddTileReq> _tileCollection;

        public TileRepository(MongoDbConnection mongoDbConnection)
        {
            _tileCollection = mongoDbConnection.Database.GetCollection<AddTileReq>("tiles");
        }
        public async Task<Response<bool>> AddTile(AddTileReq model)
        {
            try
            {
                var filter = Builders<AddTileReq>.Filter.Empty;
                CountOptions opts = new CountOptions() { Hint = "_id_" };
                var result = await _tileCollection.CountDocumentsAsync(filter, opts);
                AddTileReq user = new AddTileReq()
                {
                    Name = model.Name,
                    IsAdmin = model.IsAdmin,
                };
                await _tileCollection.InsertOneAsync(user);
                return new Response<bool>(true, "Successfull");
            }
            catch (Exception ex)
            {
                return new Response<bool>(false, "Failed", false);

            }
        }
    }
}
