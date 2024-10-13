using Domain.Common;
using Domain.Tile;

namespace Persistence.RepositoryContract
{
    public interface ITileRepository
    {
        Task<Response<bool>> AddTile(AddTileReq model);
    }
}
