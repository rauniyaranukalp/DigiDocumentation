using Domain.Common;
using Domain.Tile;
using Persistence.RepositoryContract;
using Service.Contract;

namespace Service.Implementation
{
    public class TileService : ITileService
    {
        private readonly IRepositoryManager _repositoryManager;

        public TileService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<Response<bool>> AddTile(AddTileReq model)
        {
            return await _repositoryManager.TileRepository.AddTile(model);
        }
    }
}
