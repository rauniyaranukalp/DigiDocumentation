using Domain.Common;
using Domain.Tile;
using Domain.User;
using MongoDB.Driver;
using Persistence.RepositoryContract;

namespace Persistence.RepositoryImplementation
{
    public class TileRepository : ITileRepository
    {
        private readonly IMongoCollection<TileResModel> _tileCollection;

        public TileRepository(MongoDbConnection mongoDbConnection)
        {
            _tileCollection = mongoDbConnection.Database.GetCollection<TileResModel>("tiles");
        }
        public async Task<Response<List<TileResModel>>> GetTitle()
        {
            try
            {
                var filter = Builders<TileResModel>.Filter.Empty;
                var result = await _tileCollection.FindAsync(filter);
                var tiles = await result.ToListAsync();
                return new Response<List<TileResModel>>(tiles, "Successfully retrieved tiles.");
            }
            catch (Exception ex)
            {
                return new Response<List<TileResModel>>(null, "Failed to retrieve tiles.", false);
            }
        }
    }
}
